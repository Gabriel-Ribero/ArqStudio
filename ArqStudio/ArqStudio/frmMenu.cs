using ArqStudio.Model;
using ArqStudio.View.Avaliação;
using ArqStudio.View.Login;
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
    public partial class frmMenu : MetroFramework.Forms.MetroForm
    {
        private Usuario us;
        internal Usuario Us { get => us; set => us = value; }

        private Button currentButton;
        private Random random;
        private int tempIndex;

        public frmMenu()
        {
            InitializeComponent();
            random = new Random();
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
                    painelTitulo.BackColor = cor;
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


        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmPerfil frm = new frmPerfil();
            frm.Us = Us;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void avaliaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Us.IdUsuario == 1)
            {
                frmAvaliacaoPesquisa fap = new frmAvaliacaoPesquisa();
                fap.ShowDialog();
            }
            else
            {
                frmAvaliacao fa = new frmAvaliacao();
                fa.ShowDialog();
            }
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            BotaoAtivo(sender);
        }

        private void btn_projeto_Click(object sender, EventArgs e)
        {
            BotaoAtivo(sender);
        }

        private void btn_avaliacao_Click(object sender, EventArgs e)
        {
            BotaoAtivo(sender);
        }

        private void btn_perguntas_Click(object sender, EventArgs e)
        {
            BotaoAtivo(sender);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            BotaoAtivo(sender);
        }
    }
}
