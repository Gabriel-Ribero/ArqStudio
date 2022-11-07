using ArqStudio.View.Avaliação;
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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvaliacao fa = new frmAvaliacao();
            fa.ShowDialog();
        }
    }
}
