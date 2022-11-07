namespace ArqStudio.View.Avaliação
{
    partial class frmAvaliacaoPesquisa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_pesquisa = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_pesquisa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_pesquisa);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.lbl_pesquisa);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btn_apagar);
            this.groupBox1.Location = new System.Drawing.Point(29, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 312);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualização:";
            // 
            // cmb_pesquisa
            // 
            this.cmb_pesquisa.FormattingEnabled = true;
            this.cmb_pesquisa.Location = new System.Drawing.Point(113, 24);
            this.cmb_pesquisa.Name = "cmb_pesquisa";
            this.cmb_pesquisa.Size = new System.Drawing.Size(263, 21);
            this.cmb_pesquisa.TabIndex = 4;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(248, 50);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(128, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Pesquisar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // lbl_pesquisa
            // 
            this.lbl_pesquisa.AutoSize = true;
            this.lbl_pesquisa.Location = new System.Drawing.Point(6, 27);
            this.lbl_pesquisa.Name = "lbl_pesquisa";
            this.lbl_pesquisa.Size = new System.Drawing.Size(101, 13);
            this.lbl_pesquisa.TabIndex = 1;
            this.lbl_pesquisa.Text = "Selecione o Cliente:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(9, 275);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(128, 23);
            this.btn_apagar.TabIndex = 6;
            this.btn_apagar.Text = "Apagar Avaliação";
            this.btn_apagar.UseVisualStyleBackColor = true;
            // 
            // frmAvaliacaoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAvaliacaoPesquisa";
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.frmAvaliacaoPesquisa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_pesquisa;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_pesquisa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_apagar;
    }
}