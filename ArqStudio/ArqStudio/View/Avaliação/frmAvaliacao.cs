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

namespace ArqStudio.View.Avaliação
{
    public partial class frmAvaliacao : MetroFramework.Forms.MetroForm
    {
        public frmAvaliacao()
        {
            InitializeComponent();
        }
        Avaliacao Ava = new Avaliacao();
        frmLogin Login = new frmLogin();
        RAvaliacao ra = new RAvaliacao();
        Objeto ob = new Objeto();
        public int idAvaliacao;
        public int idCliente;
        public int idProfissional;
        public string descricao;
        public int nota;

        private void CarregaComboCliente()
        {
            cmb_pesquisa.DataSource = ra.GetCliente(idCliente);
            cmb_pesquisa.ValueMember = "Id";
            cmb_pesquisa.DisplayMember = "Nome";
        }

        private void CarregaComboProfissional()
        {
            cmb_profissional.DataSource = ra.GetProfissional(idProfissional);
            cmb_profissional.ValueMember = "Id";
            cmb_profissional.DisplayMember = "Nome";
        }

        private void CarregaGrid(int id)
        {
            dataGridView1.DataSource = ra.GetAvaliacao(id);
        }

        private void frmAvaliacao_Load(object sender, EventArgs e)
        {
            CarregaComboCliente();
            CarregaGrid(int.Parse(cmb_pesquisa.SelectedValue.ToString()));
        }

        private void cmb_pesquisa_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregaGrid((int)cmb_pesquisa.SelectedValue);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Necessário uma flag para a tela de inserir e alterar

        private void btn_avaliar_Click(object sender, EventArgs e)
        {
            Ava.IdCliente = idCliente;
            Ava.IdUsuario = idProfissional;
            Ava.Descricao = rtxt_descricao.Text;
            Ava.Nota = int.Parse(txt_nota.Text);

            ra.adiciona(Ava);
            MessageBox.Show("Registro incluido com sucesso!!!");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ra.Get(int.Parse(cmb_pesquisa.Text));
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idAvaliacao = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            if(idAvaliacao != 0)
            {
                Ava = ra.GetAvaliacao(idAvaliacao);
                ob = ra.GetCliente(Ava.IdCliente);
                txt_cliente.Text = ob.Nome;
                ob = ra.GetProfissional(Ava.IdUsuario);
                cmb_profissional.Text = ob.Nome;
                rtxt_descricao.Text = Ava.Descricao;
                txt_nota.Text = Ava.Nota.ToString(); ;
            }
        }

        private void cmb_pesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCliente = int.Parse(((Cliente)cmb_pesquisa.SelectedItem).IdCliente.ToString());
            dataGridView1.DataSource = ra.Get(idCliente).Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            ra.altera(Ava);
            MessageBox.Show("Registro alterado com sucesso!!!");
        }
    }
}
