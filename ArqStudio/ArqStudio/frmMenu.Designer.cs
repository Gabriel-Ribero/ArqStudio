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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_avaliacao = new System.Windows.Forms.Button();
            this.btn_projeto = new System.Windows.Forms.Button();
            this.btn_perguntas = new System.Windows.Forms.Button();
            this.btn_perfil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 516);
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
            // btn_avaliacao
            // 
            this.btn_avaliacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_avaliacao.FlatAppearance.BorderSize = 0;
            this.btn_avaliacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_avaliacao.ForeColor = System.Drawing.Color.White;
            this.btn_avaliacao.Image = global::ArqStudio.Properties.Resources.icons8_reequilibrar_o_portfólio_321;
            this.btn_avaliacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_avaliacao.Location = new System.Drawing.Point(0, 292);
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
            this.btn_projeto.Location = new System.Drawing.Point(0, 232);
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
            // btn_perguntas
            // 
            this.btn_perguntas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_perguntas.FlatAppearance.BorderSize = 0;
            this.btn_perguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perguntas.ForeColor = System.Drawing.Color.White;
            this.btn_perguntas.Image = global::ArqStudio.Properties.Resources.icons8_perguntas_321;
            this.btn_perguntas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_perguntas.Location = new System.Drawing.Point(0, 172);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 112);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Arq Studio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(14, 13);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 45);
            this.lblNome.TabIndex = 7;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1084, 596);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 20);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
    }
}

