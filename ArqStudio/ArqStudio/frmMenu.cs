using ArqStudio.DataTransferObject.Login;
using ArqStudio.Model;
using ArqStudio.Repository;
using ArqStudio.View.Avaliação;
using ArqStudio.View.Login;
using ArqStudio.View.Pergunta;
using ArqStudio.View.Projeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArqStudio
{
    public partial class frmMenu : Form
    {
        private Usuario us;
        internal Usuario Us { get => us; set => us = value; }

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private LoginRep Rep = new LoginRep();

        public frmMenu()
        {
            InitializeComponent();
            random = new Random();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (us.Adm == 0)
            {
                DtoLoginClienteProfissional c = Rep.getCliente(us.IdUsuario);
                lblNome.Text = "Bem vindo " + c.Cliente.Nome;
            }
            else
            {
                DtoLoginClienteProfissional p = Rep.getProfissional(us.IdUsuario);
                lblNome.Text = "Bem vindo " + p.Profissional.Nome;
                btn_perguntas.Visible = false;
            }
        }

        private Color SelecionaCorTema()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string cor = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(cor);
        }

        private void BotaoAtivo(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    BotaoDesativado();
                    Color cor = SelecionaCorTema();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = cor;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void BotaoDesativado()
        {
            foreach(Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(46, 139, 87);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            BotaoAtivo(sender);
            frmPerfil frm = new frmPerfil();
            frm.Us = Us;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btn_projeto_Click(object sender, EventArgs e)
        {
            BotaoAtivo(sender);
            frmProjeto frm = new frmProjeto();
            frm.Us = Us;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btn_avaliacao_Click(object sender, EventArgs e)
        {
            BotaoAtivo(sender);
            frmAvaliacaoPesquisa frm = new frmAvaliacaoPesquisa();
            frm.Us = Us;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btn_perguntas_Click(object sender, EventArgs e)
        {
            BotaoAtivo(sender);
            FormVisualizacaoFormulario frm = new FormVisualizacaoFormulario();
            frm.Us = Us;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            BotaoAtivo(sender);
            Close();
        }

    }
}
