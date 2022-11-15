using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArqStudio.Interface;
using ArqStudio.Repository;
using ArqStudio.Model;
using ArqStudio.DataTransferObject.Avaliação;

namespace ArqStudio.View.Avaliação
{
    public partial class frmAvaliacaoPesquisa : Form
    {

        Usuario us = new Usuario();
        internal Usuario Us { get => us; set => us = value; }
        AvaliacaoRep Rep = new AvaliacaoRep();
        Objeto o = new Objeto();
        List<DtoGridAvaliacao> ListaAvaliacao = new List<DtoGridAvaliacao>();
        List<DtoGridAvalicaoProfissional> ListaAvaliacaoProfissional = new List<DtoGridAvalicaoProfissional>();

        public frmAvaliacaoPesquisa()
        {
            InitializeComponent();
        }


        private void frmAvaliacaoPesquisa_Load(object sender, EventArgs e)
        {  
            if(Us.Adm == 1)
            {
                CarregaGrid();
                btnIncluir.Visible = false;
                btnAlterar.Visible = false;
                btnExcluir.Visible = false;
            }
            else
            {
                o = Rep.getCliente(Us.IdUsuario);
                gridAvaliacao.DataSource = Rep.getListaAvaliacao(o.Id);
            }
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmAvaliacao frm = new frmAvaliacao();
            frm.Us = Us;
            frm.ShowDialog();
            frm.Dispose();
            gridAvaliacao.DataSource = Rep.getListaAvaliacao(o.Id);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAvaliacao frm = new frmAvaliacao();
            frm.Us = Us;
            frm.IdAvaliacao = int.Parse(gridAvaliacao.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
            frm.Dispose();
            gridAvaliacao.DataSource = Rep.getListaAvaliacao(o.Id);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var Valid = false;

            Valid = Rep.deleta(int.Parse(gridAvaliacao.CurrentRow.Cells[0].Value.ToString()));

            if(Valid)
            {
                MessageBox.Show("Avaliação deletada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridAvaliacao.DataSource = Rep.getListaAvaliacao(o.Id);
                return;
            }
            else
            {
                MessageBox.Show("Erro ao deletar a avaliação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }


        #region "Loads"

        private void CarregaGrid()
        {
            ListaAvaliacaoProfissional = Rep.getListaAvaliacaoProfissional();
            gridAvaliacao.DataSource = ListaAvaliacaoProfissional.ToList();
        }

        #endregion

    }
}
