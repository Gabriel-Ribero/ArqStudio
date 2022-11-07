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
    public partial class frmRecuperaSenha : MetroFramework.Forms.MetroForm
    {

        LoginRep Rep = new LoginRep();
        public bool Adm;

        public frmRecuperaSenha()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var Valid = false;
            if (Valida()) return;

            Valid = Rep.updateSenha(txtNovaSenha.Text, txtCPF.Text, Adm);

            if (Valid)
            {
                MessageBox.Show("Senha alterada com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao alterar a senha.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool Valida()
        {
            if (txtNovaSenha.Text == "")
            {
                MessageBox.Show("Informe a Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtConfirmSenha.Text == "")
            {
                MessageBox.Show("Informe a Confirmação da Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtNovaSenha.Text != txtConfirmSenha.Text)
            {
                MessageBox.Show("As Senhas não estão iguais.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }
    }
}
