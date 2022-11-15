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

namespace ArqStudio.View.Pergunta
{
    public partial class FormVisualizacaoFormulario : Form
    {
        private List<Formulario> ListaFormularios = new List<Formulario>();
        private FormularioRep Rep = new FormularioRep();
        private Usuario us;
        internal Usuario Us { get => us; set => us = value; }

        public FormVisualizacaoFormulario()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmIncluirFormulario frm = new frmIncluirFormulario();
            frm.Us = Us;
            frm.ShowDialog();
            CarregaGrid(us.IdUsuario);
            frm.Dispose();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarregaGrid(int id)
        {
            gridPerguntas.DataSource = Rep.getPerguntas(id).ToList();
        }

        private void FormVisualizacaoPergunta_Load(object sender, EventArgs e)
        {
            CarregaGrid(us.IdUsuario);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmIncluirFormulario frm = new frmIncluirFormulario();
            frm.Us = Us;
            frm.idFormulario = int.Parse(gridPerguntas.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
            CarregaGrid(us.IdUsuario);
            frm.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var Valid = false;
            Valid = Rep.excluir(int.Parse(gridPerguntas.CurrentRow.Cells[0].Value.ToString()));
            CarregaGrid(us.IdUsuario);

            if (Valid)
            {
                MessageBox.Show("Formulario deletado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridPerguntas.DataSource = Rep.getPerguntas(us.IdUsuario);
                return;
            }
            else
            {
                MessageBox.Show("Erro ao deletar o formulario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
