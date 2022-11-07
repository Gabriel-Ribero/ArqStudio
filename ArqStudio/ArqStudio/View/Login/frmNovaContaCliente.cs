using ArqStudio.DataTransferObject.Login;
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
    public partial class frmNovaContaCliente : MetroFramework.Forms.MetroForm
    {
        private DtoLoginClienteProfissional cpl;

        public frmNovaContaCliente()
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
            cpl = new DtoLoginClienteProfissional();
            cpl.Usuario.Email = txtEmail.Text;
            cpl.Usuario.Senha = txtSenha.Text;
            cpl.Cliente.Nome = txtNome.Text;
            cpl.Cliente.SobreNome = txtSobreNome.Text;
            cpl.Cliente.RG = txtRG.Text;
            cpl.Cliente.CPF = txtCPF.Text;
            cpl.Cliente.DataNasc = dtDataNascimento.Value.Date;
            cpl.Cliente.DDD = txtDDD.Text;
            cpl.Cliente.Telefone = txtTelefone.Text;
            cpl.Cliente.Profissao = txtProfissao.Text;

        }

        #endregion

    }
}
