namespace ArqStudio.View.Avaliação
{
    partial class frmAvaliacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvaliacao));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.spinNota = new System.Windows.Forms.NumericUpDown();
            this.cbProfissional = new System.Windows.Forms.ComboBox();
            this.rtxt_descricao = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_avaliar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNota)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.Location = new System.Drawing.Point(253, 292);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.spinNota);
            this.groupBox2.Controls.Add(this.cbProfissional);
            this.groupBox2.Controls.Add(this.rtxt_descricao);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_avaliar);
            this.groupBox2.Location = new System.Drawing.Point(21, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(557, 337);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // spinNota
            // 
            this.spinNota.Location = new System.Drawing.Point(69, 257);
            this.spinNota.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinNota.Name = "spinNota";
            this.spinNota.Size = new System.Drawing.Size(40, 22);
            this.spinNota.TabIndex = 16;
            // 
            // cbProfissional
            // 
            this.cbProfissional.FormattingEnabled = true;
            this.cbProfissional.Location = new System.Drawing.Point(194, 16);
            this.cbProfissional.Margin = new System.Windows.Forms.Padding(4);
            this.cbProfissional.Name = "cbProfissional";
            this.cbProfissional.Size = new System.Drawing.Size(329, 24);
            this.cbProfissional.TabIndex = 14;
            // 
            // rtxt_descricao
            // 
            this.rtxt_descricao.Location = new System.Drawing.Point(13, 93);
            this.rtxt_descricao.Margin = new System.Windows.Forms.Padding(4);
            this.rtxt_descricao.Name = "rtxt_descricao";
            this.rtxt_descricao.Size = new System.Drawing.Size(516, 142);
            this.rtxt_descricao.TabIndex = 12;
            this.rtxt_descricao.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do Profissional:";
            // 
            // btn_avaliar
            // 
            this.btn_avaliar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_avaliar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_avaliar.Location = new System.Drawing.Point(394, 292);
            this.btn_avaliar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_avaliar.Name = "btn_avaliar";
            this.btn_avaliar.Size = new System.Drawing.Size(135, 28);
            this.btn_avaliar.TabIndex = 4;
            this.btn_avaliar.Text = "Avaliar";
            this.btn_avaliar.UseVisualStyleBackColor = true;
            this.btn_avaliar.Click += new System.EventHandler(this.btn_avaliar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sair.BackgroundImage")));
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sair.Location = new System.Drawing.Point(564, 9);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(23, 23);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 54);
            this.label5.TabIndex = 5;
            this.label5.Text = "Inclusão Avaliação";
            // 
            // frmAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 427);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAvaliacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliação";
            this.Load += new System.EventHandler(this.frmAvaliacao_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_avaliar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RichTextBox rtxt_descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProfissional;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown spinNota;
    }
}