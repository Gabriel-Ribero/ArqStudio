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
    public partial class frmIncluirFormulario :  Form
    {
        List<Endereco> ListaEndereco = new List<Endereco>();
        FormularioRep Rep = new FormularioRep();
        private Usuario us;
        internal Usuario Us { get => us; set => us = value; }



        public frmIncluirFormulario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Formulario f = new Formulario();
            f.QuantPessoasHabitam = int.Parse(spinNumeroPessoasVive.Value.ToString());
            f.PessoasDeficientes = int.Parse(spinNumPessoaDeficiente.Value.ToString());
            f.DescricaoDeficientes = txtDescricaoDeficiente.Text;
            f.AnimaisEstimacao = int.Parse(spinNumeroAnimais.Value.ToString());
            f.DescricaoAnimais = txtDescricaoAnimais.Text;
            f.PessoasTrabalhaEmCasa = int.Parse(spinNumeroPessoasViveTrabalham.Value.ToString());
            f.EstiloArquitetonico = txtTipoArquitetonico.Text;
            f.Status = "Pendente";
            f.IdEndereco = int.Parse(cbEnderecoProjeto.SelectedValue.ToString());
            f.IdUsuario = Us.IdUsuario;

            var Valida = false;
            Valida = Rep.incluir(f);

            if (Valida)
            {
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            else
            {
                MessageBox.Show("Dados não inseridos! Erro.");
            }
        }

        private void frmIncluirFormulario_Load(object sender, EventArgs e)
        {
            CarregaEndereco();
        }

        private void CarregaEndereco()
        {
            ListaEndereco = Rep.getEndereco(Us.IdUsuario);

            cbEnderecoProjeto.ValueMember = "IdEndereco";
            cbEnderecoProjeto.DisplayMember = "Rua";
            cbEnderecoProjeto.DataSource = ListaEndereco.ToList();
        }
    }
}
