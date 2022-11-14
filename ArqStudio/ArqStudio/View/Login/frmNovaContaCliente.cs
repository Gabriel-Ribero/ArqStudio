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
    public partial class frmNovaContaCliente : Form
    {

        #region "Atributos"

        private DtoLoginClienteProfissional cpl = new DtoLoginClienteProfissional();
        List<DtoGridEndereco> gridEndereco = new List<DtoGridEndereco>();
        private LoginRep Rep = new LoginRep();
        public bool Adm;

        #endregion


        public frmNovaContaCliente()
        {
            InitializeComponent();
        }

        private void frmNovaContaCliente_Load(object sender, EventArgs e)
        {
            if (Adm)
            {
                lblRG.Text = "CAU:";
                txtRG.Mask = "";
                lblDataNasc.Visible = false;
                dtDataNascimento.Visible = false;
                lblDDD.Visible = false;
                txtDDD.Visible = false;
                lblTelefone.Visible = false;
                txtTelefone.Visible = false;
                lblProfissao.Visible = false;
                txtProfissao.Visible = false;
                groupBox2.Visible = false;
                gridEnd.Visible = false;
            }
        }


        #region "Eventos"

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            var Valid = false;

            if (!Adm)
            {
                if (ValidaCadastro(true)) return;

                cpl.Usuario.Email = txtEmail.Text;
                cpl.Usuario.Senha = txtSenha.Text;
                cpl.Usuario.Adm = 0;
                cpl.Cliente.Nome = txtNome.Text;
                cpl.Cliente.SobreNome = txtSobreNome.Text;
                cpl.Cliente.RG = txtRG.Text;
                cpl.Cliente.CPF = txtCPF.Text;
                cpl.Cliente.DataNasc = dtDataNascimento.Value.Date;
                cpl.Cliente.DDD = txtDDD.Text;
                cpl.Cliente.Telefone = txtTelefone.Text;
                cpl.Cliente.Profissao = txtProfissao.Text;
                Valid = Rep.incluir(cpl);
            }
            else
            {
                if (ValidaCadastro(false)) return;

                cpl.Usuario.Email = txtEmail.Text;
                cpl.Usuario.Senha = txtSenha.Text;
                cpl.Usuario.Adm = 1;
                cpl.Profissional.Nome = txtNome.Text;
                cpl.Profissional.SobreNome = txtSobreNome.Text;
                cpl.Profissional.CAU = txtRG.Text;
                cpl.Profissional.CPF = txtCPF.Text;
                Valid = Rep.incluir(cpl);
            }

            if (Valid)
            {
                MessageBox.Show("Dados inseridos com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao inserir os dados.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            if (ValidaEndereco()) return;

            Endereco ed = new Endereco();
            ed.Rua = txtRua.Text;
            ed.Numero = int.Parse(txtNumero.Text);
            ed.Bairro = txtBairro.Text;
            ed.Loteamento = txtLoteamento.Text;
            ed.Quadra = txtQuadra.Text;
            ed.Lote = txtLote.Text;
            ed.Cidade = txtCidade.Text;
            ed.Estado = txtEstado.Text;
            ed.EnderecoProjeto = chkEndProjeto.Checked ? 'S' : 'N';
            cpl.ListaEndereco.Add(ed);

            DtoGridEndereco grid = new DtoGridEndereco();
            grid.Id = gridEndereco.Count + 1;
            grid.Rua = txtRua.Text;
            grid.Bairro = txtBairro.Text;
            grid.Numero = txtNumero.Text;
            grid.Cidade = txtCidade.Text;
            grid.Estado = txtEstado.Text;
            gridEndereco.Add(grid);
            gridEnd.DataSource = gridEndereco.ToList();


            ed = new Endereco();
            txtRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtLoteamento.Text = "";
            txtQuadra.Text = "";
            txtLote.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
        }

        #endregion


        #region "Validações"

        private bool ValidaEndereco()
        {
            if (txtRua.Text == "")
            {
                MessageBox.Show("Informe a Rua.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtNumero.Text == "")
            {
                MessageBox.Show("Informe o Número.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtBairro.Text == "")
            {
                MessageBox.Show("Informe o Bairro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtLoteamento.Text == "")
            {
                MessageBox.Show("Informe o Loteamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtQuadra.Text == "")
            {
                MessageBox.Show("Informe a Quadra.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtLote.Text == "")
            {
                MessageBox.Show("Informe o Lote.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtCidade.Text == "")
            {
                MessageBox.Show("Informe a Cidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtEstado.Text == "")
            {
                MessageBox.Show("Informe o Estado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private bool ValidaCadastro(bool cliente)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtSobreNome.Text == "")
            {
                MessageBox.Show("Informe o Sobre Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtRG.Text == "")
            {
                MessageBox.Show("Informe o RG.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtCPF.Text == "")
            {
                MessageBox.Show("Informe o CPF.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (cliente)
            {
                if (txtDDD.Text == "")
                {
                    MessageBox.Show("Informe o DDD.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }

                if (txtTelefone.Text == "")
                {
                    MessageBox.Show("Informe o Telefone.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }

                if (txtProfissao.Text == "")
                {
                    MessageBox.Show("Informe o Profissão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Informe o E-mail.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtSenha.Text == "")
            {
                MessageBox.Show("Informe a Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtConfirSenha.Text == "")
            {
                MessageBox.Show("Informe a Confirmação da Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtSenha.Text != txtConfirSenha.Text)
            {
                MessageBox.Show("As Senhas não estão iguais.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }


        #endregion
    }
}
