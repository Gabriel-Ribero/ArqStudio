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
    public partial class frmAvaliacao : MetroFramework.Forms.MetroForm
    {
        public frmAvaliacao()
        {
            InitializeComponent();
        }
        Usuario us = new Usuario();
        Cliente cliente = new Cliente();
        Avaliacao Ava = new Avaliacao();
        frmLogin Login = new frmLogin();
        AvaliacaoRep ra = new AvaliacaoRep();
        LoginRep Rep = new LoginRep();
        Objeto ob = new Objeto();
        public int idAvaliacao;
        public int idCliente;
        public int idProfissional;
        public string descricao;
        public int nota;

        DtoLoginClienteProfissional lcp = new DtoLoginClienteProfissional();

        internal Usuario Us { get => us; set => us = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }

        private void CarregaComboProfissional()
        {
            cmb_profissional.DataSource = ra.GetProfissional();
            cmb_profissional.ValueMember = "Id";
            cmb_profissional.DisplayMember = "Nome";
        }

        private void frmAvaliacao_Load(object sender, EventArgs e)
        {
            lcp = Rep.getCliente(Us.IdUsuario);
            txt_cliente.Text = lcp.Cliente.Nome;
            txt_cliente.ReadOnly = true;
            CarregaComboProfissional();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Necessário uma flag para a tela de inserir e alterar

        private void btn_avaliar_Click(object sender, EventArgs e)
        {
            Ava.IdCliente = lcp.Cliente.IdCliente;
            Ava.IdUsuario = lcp.Profissional.IdProfissional;
            Ava.Descricao = rtxt_descricao.Text;
            Ava.Nota = int.Parse(txt_nota.Text);

            ra.adiciona(Ava);
            MessageBox.Show("Registro incluido com sucesso!!!");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            ra.altera(Ava);
            MessageBox.Show("Registro alterado com sucesso!!!");
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            frmAvaliacaoPesquisa fap = new frmAvaliacaoPesquisa();
            fap.Us = Us;
            fap.ShowDialog();
        }

        //private void btn_localizar_Click(object sender, EventArgs e)
        //{
        //    frmAvaliacaoPesquisa fap = new frmAvaliacaoPesquisa();
        //    fap.ShowDialog();
        //    int codigo = fap.idAvaliacao;
        //    if (codigo != 0)
        //    {
        //        Ava = ra.GetAvaliacao(codigo);
        //        Login = lr.GetCliente(IdCliente);
        //        txt_cliente.Text = Login.Nome;
        //        v = rv.GetVacina(f.IdVacina);
        //        cmbVacina.Text = v.NomeVacina;
        //        dateTimePicker1.Text = f.DataFicha;
        //    }
        //}
    }
}
