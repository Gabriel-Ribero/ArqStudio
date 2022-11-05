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
        frmAvaliacao Ava = new frmAvaliacao();
        frmLogin Login = new frmLogin();
        RAvaliacao ra = new RAvaliacao();
        Objeto ob = new Objeto();
        int idCliente;
        int idProfissional;
        string descricao;
        int nota;

        private void CarregaComboCliente()
        {
            cmb_pesquisa.DataSource = ra.GetCliente(idCliente);
            cmb_pesquisa.ValueMember = "Id";
            cmb_pesquisa.DisplayMember = "Name";
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
        //Continuar...

        private void btn_avaliar_Click(object sender, EventArgs e)
        {
            Ava.idCliente = idCliente;
            Ava.idProfissional = idProfissional;
            Ava.descricao = descricao;
            Ava.nota = nota;

            //ra.adiciona(Ava);
            MessageBox.Show("Registro incluido com sucesso!!!");
        }
    }
}
