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
            this.avaliaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perguntasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.painelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_perguntas = new System.Windows.Forms.Button();
            this.btn_avaliacao = new System.Windows.Forms.Button();
            this.btn_projeto = new System.Windows.Forms.Button();
            this.btn_perfil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.painelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip2.BackColor = System.Drawing.Color.SeaGreen;
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
            this.menuStrip2.Size = new System.Drawing.Size(1044, 24);
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
            // avaliaçãoToolStripMenuItem
            // 
            this.avaliaçãoToolStripMenuItem.Name = "avaliaçãoToolStripMenuItem";
            this.avaliaçãoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.avaliaçãoToolStripMenuItem.Text = "Avaliação";
            this.avaliaçãoToolStripMenuItem.Click += new System.EventHandler(this.avaliaçãoToolStripMenuItem_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_perguntas);
            this.panel1.Controls.Add(this.btn_avaliacao);
            this.panel1.Controls.Add(this.btn_projeto);
            this.panel1.Controls.Add(this.btn_perfil);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 492);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 112);
            this.panel2.TabIndex = 7;
            // 
            // painelTitulo
            // 
            this.painelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.painelTitulo.Controls.Add(this.label1);
            this.painelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelTitulo.Location = new System.Drawing.Point(220, 84);
            this.painelTitulo.Name = "painelTitulo";
            this.painelTitulo.Size = new System.Drawing.Size(844, 80);
            this.painelTitulo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(390, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOME";
            // 
            // btn_sair
            // 
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Image = global::ArqStudio.Properties.Resources.icons8_sair_32__1_1;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.Location = new System.Drawing.Point(0, 352);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_sair.Size = new System.Drawing.Size(200, 60);
            this.btn_sair.TabIndex = 11;
            this.btn_sair.Text = " Sair";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_perguntas
            // 
            this.btn_perguntas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_perguntas.FlatAppearance.BorderSize = 0;
            this.btn_perguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perguntas.ForeColor = System.Drawing.Color.White;
            this.btn_perguntas.Image = global::ArqStudio.Properties.Resources.icons8_perguntas_321;
            this.btn_perguntas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_perguntas.Location = new System.Drawing.Point(0, 292);
            this.btn_perguntas.Name = "btn_perguntas";
            this.btn_perguntas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_perguntas.Size = new System.Drawing.Size(200, 60);
            this.btn_perguntas.TabIndex = 10;
            this.btn_perguntas.Text = " Perguntas";
            this.btn_perguntas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_perguntas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_perguntas.UseVisualStyleBackColor = true;
            this.btn_perguntas.Click += new System.EventHandler(this.btn_perguntas_Click);
            // 
            // btn_avaliacao
            // 
            this.btn_avaliacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_avaliacao.FlatAppearance.BorderSize = 0;
            this.btn_avaliacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_avaliacao.ForeColor = System.Drawing.Color.White;
            this.btn_avaliacao.Image = global::ArqStudio.Properties.Resources.icons8_reequilibrar_o_portfólio_321;
            this.btn_avaliacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_avaliacao.Location = new System.Drawing.Point(0, 232);
            this.btn_avaliacao.Name = "btn_avaliacao";
            this.btn_avaliacao.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_avaliacao.Size = new System.Drawing.Size(200, 60);
            this.btn_avaliacao.TabIndex = 9;
            this.btn_avaliacao.Text = " Avaliação";
            this.btn_avaliacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_avaliacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_avaliacao.UseVisualStyleBackColor = true;
            this.btn_avaliacao.Click += new System.EventHandler(this.btn_avaliacao_Click);
            // 
            // btn_projeto
            // 
            this.btn_projeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_projeto.FlatAppearance.BorderSize = 0;
            this.btn_projeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_projeto.ForeColor = System.Drawing.Color.White;
            this.btn_projeto.Image = global::ArqStudio.Properties.Resources.icons8_não_testado_321;
            this.btn_projeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_projeto.Location = new System.Drawing.Point(0, 172);
            this.btn_projeto.Name = "btn_projeto";
            this.btn_projeto.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_projeto.Size = new System.Drawing.Size(200, 60);
            this.btn_projeto.TabIndex = 8;
            this.btn_projeto.Text = " Projeto";
            this.btn_projeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_projeto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_projeto.UseVisualStyleBackColor = true;
            this.btn_projeto.Click += new System.EventHandler(this.btn_projeto_Click);
            // 
            // btn_perfil
            // 
            this.btn_perfil.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_perfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_perfil.FlatAppearance.BorderSize = 0;
            this.btn_perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perfil.ForeColor = System.Drawing.Color.White;
            this.btn_perfil.Image = global::ArqStudio.Properties.Resources.icons8_usuário_homem_com_círculo_321;
            this.btn_perfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_perfil.Location = new System.Drawing.Point(0, 112);
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_perfil.Size = new System.Drawing.Size(200, 60);
            this.btn_perfil.TabIndex = 7;
            this.btn_perfil.Text = " Perfil";
            this.btn_perfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_perfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_perfil.UseVisualStyleBackColor = false;
            this.btn_perfil.Click += new System.EventHandler(this.btn_perfil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArqStudio.Properties.Resources.WhatsApp_Image_2022_11_07_at_19_24_23;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 596);
            this.Controls.Add(this.painelTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.painelTitulo.ResumeLayout(false);
            this.painelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_perfil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_perguntas;
        private System.Windows.Forms.Button btn_avaliacao;
        private System.Windows.Forms.Button btn_projeto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel painelTitulo;
        private System.Windows.Forms.Label label1;
    }
}

