namespace ArqStudio
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProjeto = new System.Windows.Forms.ToolStripMenuItem();
            this.perguntasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaliaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPerfil,
            this.btnProjeto,
            this.avaliaçãoToolStripMenuItem,
            this.perguntasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(20, 60);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(781, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnPerfil
            // 
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(46, 20);
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnProjeto
            // 
            this.btnProjeto.Name = "btnProjeto";
            this.btnProjeto.Size = new System.Drawing.Size(57, 20);
            this.btnProjeto.Text = "Projeto";
            // 
            // perguntasToolStripMenuItem
            // 
            this.perguntasToolStripMenuItem.Name = "perguntasToolStripMenuItem";
            this.perguntasToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.perguntasToolStripMenuItem.Text = "Perguntas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // avaliaçãoToolStripMenuItem
            // 
            this.avaliaçãoToolStripMenuItem.Name = "avaliaçãoToolStripMenuItem";
            this.avaliaçãoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.avaliaçãoToolStripMenuItem.Text = "Avaliação";
            this.avaliaçãoToolStripMenuItem.Click += new System.EventHandler(this.avaliaçãoToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 464);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnPerfil;
        private System.Windows.Forms.ToolStripMenuItem btnProjeto;
        private System.Windows.Forms.ToolStripMenuItem perguntasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaliaçãoToolStripMenuItem;
    }
}

