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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_perguntas = new System.Windows.Forms.Button();
            this.btn_avaliacao = new System.Windows.Forms.Button();
            this.btn_projeto = new System.Windows.Forms.Button();
            this.btn_perfil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_avaliacao);
            this.panel1.Controls.Add(this.btn_projeto);
            this.panel1.Controls.Add(this.btn_perguntas);
            this.panel1.Controls.Add(this.btn_perfil);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(27, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 635);
            this.panel1.TabIndex = 6;
            // 
            // btn_sair
            // 
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Image = global::ArqStudio.Properties.Resources.icons8_sair_32__1_1;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.Location = new System.Drawing.Point(0, 434);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_sair.Size = new System.Drawing.Size(267, 74);
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
            this.btn_perguntas.Location = new System.Drawing.Point(0, 212);
            this.btn_perguntas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_perguntas.Name = "btn_perguntas";
            this.btn_perguntas.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_perguntas.Size = new System.Drawing.Size(267, 74);
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
            this.btn_avaliacao.Location = new System.Drawing.Point(0, 360);
            this.btn_avaliacao.Margin = new System.Windows.Forms.Padding(4);
            this.btn_avaliacao.Name = "btn_avaliacao";
            this.btn_avaliacao.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_avaliacao.Size = new System.Drawing.Size(267, 74);
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
            this.btn_projeto.Location = new System.Drawing.Point(0, 286);
            this.btn_projeto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_projeto.Name = "btn_projeto";
            this.btn_projeto.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_projeto.Size = new System.Drawing.Size(267, 74);
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
            this.btn_perfil.Location = new System.Drawing.Point(0, 138);
            this.btn_perfil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_perfil.Size = new System.Drawing.Size(267, 74);
            this.btn_perfil.TabIndex = 7;
            this.btn_perfil.Text = " Perfil";
            this.btn_perfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_perfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_perfil.UseVisualStyleBackColor = false;
            this.btn_perfil.Click += new System.EventHandler(this.btn_perfil_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 138);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ArqStudio.Properties.Resources.WhatsApp_Image_2022_11_07_at_19_24_23;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(18, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 54);
            this.lblNome.TabIndex = 7;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1445, 734);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_perfil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_perguntas;
        private System.Windows.Forms.Button btn_avaliacao;
        private System.Windows.Forms.Button btn_projeto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNome;
    }
}

