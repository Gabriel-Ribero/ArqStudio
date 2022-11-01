using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArqStudio.View.Login
{
    public partial class frmNovaContaCliente : MetroFramework.Forms.MetroForm
    {
        public frmNovaContaCliente()
        {
            InitializeComponent();
        }


        #region "Eventos"

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
