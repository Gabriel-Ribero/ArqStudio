using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArqStudio.Repository;
using ArqStudio.Model;
using ArqStudio.DataTransferObject.Login;

namespace ArqStudio.View.Avaliação
{
    public partial class frmAvaliacao : Form
    {

        public int IdAvaliacao;
        Avaliacao altera = new Avaliacao();
        Usuario us = new Usuario();
        internal Usuario Us { get => us; set => us = value; }

        private AvaliacaoRep Rep = new AvaliacaoRep();

        public frmAvaliacao()
        {
            InitializeComponent();
        }


        private void frmAvaliacao_Load(object sender, EventArgs e)
        {
            CarregaComboProfissional();
            if(IdAvaliacao > 0)
            {
                CarregaAvaliacao();
            }
        }


        #region "Eventos"

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_avaliar_Click(object sender, EventArgs e)
        {
            if (Valida())
                return;

            var Valid = false;
            Objeto c = Rep.getCliente(Us.IdUsuario);
            Avaliacao a = new Avaliacao();
            if (IdAvaliacao > 0)
            {
                a.IdAvaliacao = IdAvaliacao;
            }
            a.IdCliente = c.Id;
            a.IdProfissional = int.Parse(cbProfissional.SelectedValue.ToString());
            a.Descricao = rtxt_descricao.Text;
            a.Nota = int.Parse(spinNota.Value.ToString());

            if (IdAvaliacao == 0)
            {
                Valid = Rep.adiciona(a);
            }
            else
            {
                Valid = Rep.altera(a);
            }


            if (Valid)
            {
                MessageBox.Show("Dados gravados com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao gravar os dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            frmAvaliacaoPesquisa fap = new frmAvaliacaoPesquisa();
            fap.Us = Us;
            fap.ShowDialog();
        }

        #endregion


        #region "Loads / Valida"

        private void CarregaAvaliacao()
        {
            altera = Rep.getAvaliacao(IdAvaliacao);

            cbProfissional.SelectedValue = altera.IdProfissional;
            rtxt_descricao.Text = altera.Descricao;
            spinNota.Value = altera.Nota;
        }

        private void CarregaComboProfissional()
        {
            cbProfissional.DataSource = Rep.getProfissional();
            cbProfissional.ValueMember = "Id";
            cbProfissional.DisplayMember = "Nome";
        }

        private bool Valida()
        {
            if (cbProfissional.DataSource == null)
            {
                MessageBox.Show("é necessário ter um profissional cadastrado. Entre em contato com o profissional.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (rtxt_descricao.Text == "")
            {
                MessageBox.Show("Informe uma descrição da avaliação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        #endregion
    }
}
