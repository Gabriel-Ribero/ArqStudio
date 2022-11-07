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

namespace ArqStudio.View.Avaliação
{
    public partial class frmAvaliacaoPesquisa : MetroFramework.Forms.MetroForm
    {
        public frmAvaliacaoPesquisa()
        {
            InitializeComponent();
        }
        Usuario us = new Usuario();
        AvaliacaoRep ra = new AvaliacaoRep();
        LoginRep lg = new LoginRep();
        public int idAvaliacao;
        private int idCliente;

        internal Usuario Us { get => us; set => us = value; }

        private void CarregaComboCliente()
        {
            cmb_pesquisa.DataSource = ra.GetCliente(idCliente);
            cmb_pesquisa.ValueMember = "Id";
            cmb_pesquisa.DisplayMember = "Nome";
        }

        private void CarregaGrid(int id)
        {
            dataGridView1.DataSource = ra.GetAvaliacao(id);
        }

        private void cmb_pesquisa_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregaGrid((int)cmb_pesquisa.SelectedValue);
        }

        private void frmAvaliacaoPesquisa_Load(object sender, EventArgs e)
        {
            
            if(Us.IdUsuario == 1)
            {
                CarregaComboCliente();
                CarregaGrid(int.Parse(cmb_pesquisa.SelectedValue.ToString()));
            }
            else
            {
                //CarregaGrid()
                cmb_pesquisa.Visible = false;
                lbl_pesquisa.Visible = false;
                btn_apagar.Visible = false;
            }
            CarregaGrid(int.Parse(cmb_pesquisa.SelectedValue.ToString()));
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ra.Get(int.Parse(cmb_pesquisa.Text));
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idAvaliacao = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Close();
        }
        private void cmb_pesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCliente = int.Parse(((Cliente)cmb_pesquisa.SelectedItem).IdCliente.ToString());
            dataGridView1.DataSource = ra.Get(idCliente).Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.RowHeadersVisible = false;
        }
    }
}
