using ArqStudio.DataTransferObject.Login;
using ArqStudio.Model;
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
    public partial class frmPerfil : Form
    {

        #region "Atributos"

        LoginRep Rep = new LoginRep();
        private Usuario us;

        #endregion


        #region "Propriedade"

        internal Usuario Us { get => us; set => us = value; }

        #endregion


        public frmPerfil()
        {
            InitializeComponent();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            DtoLoginClienteProfissional lcp = new DtoLoginClienteProfissional();
            if (Us.Adm == 0)
            {
                lcp = Rep.getCliente(Us.IdUsuario);
                txtNome.Text = lcp.Cliente.Nome;
                txtSobreNome.Text = lcp.Cliente.SobreNome;
                txtRG.Text = lcp.Cliente.RG;
                txtCPF.Text = lcp.Cliente.CPF;
                dtDataNasc.Value = lcp.Cliente.DataNasc;
                txtDDD.Text = lcp.Cliente.DDD;
                txtTelefone.Text = lcp.Cliente.Telefone;
                txtProfissao.Text = lcp.Cliente.Profissao;
            }
            else
            {
                lcp = Rep.getProfissional(Us.IdUsuario);
                txtNome.Text = lcp.Profissional.Nome;
                txtSobreNome.Text = lcp.Profissional.SobreNome;
                txtRG.Text = lcp.Profissional.CAU;
                txtCPF.Text = lcp.Profissional.CPF;
                lblRG.Text = "CAU";
                lblDataNasc.Visible = false;
                dtDataNasc.Visible = false;
                lblDDD.Visible = false;
                txtDDD.Visible = false;
                lblTelefone.Visible = false;
                txtTelefone.Visible = false;
                lblProfissao.Visible = false;
                txtProfissao.Visible = false;
            }
            
        }


        #region "Eventos"

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var Valid = false;
            DtoLoginClienteProfissional lcp = new DtoLoginClienteProfissional();
            if (Us.Adm == 0)
            {
                lcp.Cliente.Nome = txtNome.Text;
                lcp.Cliente.SobreNome = txtSobreNome.Text;
                lcp.Cliente.RG = txtRG.Text;
                lcp.Cliente.CPF = txtCPF.Text;
                lcp.Cliente.DataNasc = dtDataNasc.Value;
                lcp.Cliente.DDD = txtDDD.Text;
                lcp.Cliente.Telefone = txtTelefone.Text;
                lcp.Cliente.Profissao = txtProfissao.Text;
                lcp.Usuario.Adm = Us.Adm;
                lcp.Usuario.IdUsuario = Us.IdUsuario;
                Valid = Rep.update(lcp);
                if (Valid)
                {
                    MessageBox.Show("Dados alterados com sucesso.", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Erro ao alterar os dados", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                lcp.Profissional.Nome = txtNome.Text;
                lcp.Profissional.SobreNome = txtSobreNome.Text;
                lcp.Profissional.CAU = txtRG.Text;
                lcp.Profissional.CPF = txtCPF.Text;
                lcp.Usuario.Adm = Us.Adm;
                lcp.Usuario.IdUsuario = Us.IdUsuario;
                Valid = Rep.update(lcp);
                if (Valid)
                {
                    MessageBox.Show("Dados alterados com sucesso.", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Erro ao alterar os dados", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        #endregion
    }
}
