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
using ArqStudio.DataTransferObject.Projeto;

namespace ArqStudio.View.Projeto
{
    public partial class frmProjeto : Form
    {
        private FormularioRep Rep = new FormularioRep();
        private Usuario us;
        List<DtoGridProjetoProfissional> ListaProjeto = new List<DtoGridProjetoProfissional>();
        internal Usuario Us { get => us; set => us = value; }
        public frmProjeto()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            if (us.Adm == 1)
            {
                btnVisualizar.Visible = false;
                btnFinalizarProjeto.Visible = true;
                ListaProjeto = Rep.getListaFormularioProfissional();
                gridFormularios.DataSource = ListaProjeto.ToList();
            }
            else
            {
                btnVisualizar.Visible = true;
                btnFinalizarProjeto.Visible = false;
                gridFormularios.DataSource = Rep.getPerguntas(us.IdUsuario).ToList();
            }
        }

        private void btnFinalizarProjeto_Click(object sender, EventArgs e)
        {
            frmFinalizaProjeto frm = new frmFinalizaProjeto();
            frm.Us = Us;
            frm.idProjeto = int.Parse(gridFormularios.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
            CarregaGrid();
            frm.Dispose();
        }

        private void frmProjeto_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmFinalizaProjeto frm = new frmFinalizaProjeto();
            frm.Us = Us;
            frm.idProjeto = int.Parse(gridFormularios.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
            CarregaGrid();
            frm.Dispose();
        }
    }
}
