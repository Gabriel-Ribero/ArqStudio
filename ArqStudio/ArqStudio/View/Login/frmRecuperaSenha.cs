using ArqStudio.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArqStudio.View.Login
{
    public partial class frmRecuperaSenha : Form
    {

        #region "Atributo"

        LoginRep Rep = new LoginRep();
        public bool Adm;

        #endregion


        public frmRecuperaSenha()
        {
            InitializeComponent();
        }


        #region "Eventos"

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var Valid = false;
            if (Valida()) return;

            string cpf = txtCPF.Text.Replace(",", "-");

            Valid = Rep.updateSenha(txtNovaSenha.Text, cpf, Adm);

            if (Valid)
            {
                MessageBox.Show("Senha alterada com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao alterar a senha.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion


        #region "Validação"

        private bool Valida()
        {
            if (txtNovaSenha.Text == "")
            {
                MessageBox.Show("Informe a Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtSenha.Text == "")
            {
                MessageBox.Show("Informe a Confirmação da Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtNovaSenha.Text != txtSenha.Text)
            {
                MessageBox.Show("As Senhas não estão iguais.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        #endregion
    }
}
