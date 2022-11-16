using ArqStudio.Model;
using ArqStudio.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArqStudio.View.Projeto;
using System.Data.SqlClient;

namespace ArqStudio.View.Projeto
{
    public partial class frmFinalizaProjeto : Form
    {
        ProjetoRep Rep = new ProjetoRep();
        private Usuario us;
        public int idProjeto;
        Bitmap bmp;
        List<Bitmap> listBmp = new List<Bitmap>();
        internal Usuario Us { get => us; set => us = value; }
        public frmFinalizaProjeto()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
            idProjeto = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            idProjeto = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Projetos p = new Projetos();
            //MemoryStream memory = new MemoryStream();

            //bmp.Save(memory, ImageFormat.Bmp);

            //byte[] arrayFoto = memory.ToArray();

            p.Descricao = txtDescricao.Text;
            p.NomeProjeto = txtNomeProjeto.Text;
            p.DataInicio = dtDataInicial.Value;
            p.DataConclusao = dtDataFinal.Value;
            p.IdFormulario = idProjeto;

            var Valida = false;
            Valida = Rep.incluir(p);

            if (Valida)
            {
                MessageBox.Show("Projeto finalizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro na finalização do Projeto.");
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            ofdIncluir.Title = "Selecionar Foto";
            ofdIncluir.Filter = "Imagem|*.png|*.jpg";
            if (ofdIncluir.ShowDialog() == DialogResult.OK)
            {
                string foto = ofdIncluir.FileName;
                bmp = new Bitmap(foto);

                pbImagem.Image = bmp;
            }
        }

        private void frmFinalizaProjeto_Load(object sender, EventArgs e)
        {
            Projetos p = new Projetos();
            p = Rep.getProjeto(idProjeto);
            if (p.IdProjeto == 0)
            {
                if (us.Adm == 0)
                {
                    MessageBox.Show("Este Projeto ainda está em andamento!");
                    Close();
                }
            }
            else
            {
                dtDataInicial.Value = p.DataInicio;
                dtDataFinal.Value = p.DataConclusao;
                txtNomeProjeto.Text = p.NomeProjeto;
                txtDescricao.Text = p.Descricao;

                if (us.Adm == 0)
                {
                    dtDataInicial.Enabled = false;
                    dtDataFinal.Enabled = false;
                    txtNomeProjeto.ReadOnly = true;
                    txtDescricao.ReadOnly = true;
                }
            }
        }
    }
}
