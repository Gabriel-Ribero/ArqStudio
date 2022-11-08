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

        public frmMenu()
        {
            InitializeComponent();
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
    }
}
