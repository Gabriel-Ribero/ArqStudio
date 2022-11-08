using ArqStudio.Model;
using ArqStudio.Repository;
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

namespace ArqStudio.View
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {

        private bool Adm = false;
        LoginRep Rep = new LoginRep();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            frmNovaContaCliente frm = new frmNovaContaCliente();
            frm.Adm = Adm;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperaSenha frm = new frmRecuperaSenha();
            frm.Adm = Adm;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Usuario u = Rep.getUsuario(txtEmailUsuario.Text, txtSenha.Text);
            if(u.IdUsuario != 0)
            {
                frmMenu frm = new frmMenu();
                frm.Us = u;
                frm.ShowDialog();
                frm.Dispose();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!Adm)
            {
                Adm = true;
                MessageBox.Show("Modo Admin ativado.", "Modo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Adm = false;
                MessageBox.Show("Modo Admin desativado.", "Modo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
