﻿using System;
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
        AvaliacaoRep ra = new AvaliacaoRep();
        LoginRep lr = new LoginRep();
        Objeto ob = new Objeto();
        public int idAvaliacao;
        public int idCliente;
        public int idProfissional;
        public string descricao;
        public int nota;

        private void CarregaComboProfissional()
        {
            cmb_profissional.DataSource = ra.GetProfissional(idProfissional);
            cmb_profissional.ValueMember = "Id";
            cmb_profissional.DisplayMember = "Nome";
        }

        private void frmAvaliacao_Load(object sender, EventArgs e)
        {
            CarregaComboProfissional();
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

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            ra.altera(Ava);
            MessageBox.Show("Registro alterado com sucesso!!!");
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
