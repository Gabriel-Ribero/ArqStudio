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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_pesquisa = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_pesquisa = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_profissional = new System.Windows.Forms.ComboBox();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.rtxt_descricao = new System.Windows.Forms.RichTextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_avaliar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_pesquisa);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.lbl_pesquisa);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btn_alterar);
            this.groupBox1.Controls.Add(this.btn_apagar);
            this.groupBox1.Location = new System.Drawing.Point(34, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 312);
            this.groupBox1.TabIndex = 1;
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
            this.cmb_pesquisa.SelectedIndexChanged += new System.EventHandler(this.cmb_pesquisa_SelectedIndexChanged);
            this.cmb_pesquisa.SelectedValueChanged += new System.EventHandler(this.cmb_pesquisa_SelectedValueChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(248, 50);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(128, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Pesquisar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
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
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(6, 275);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(128, 23);
            this.btn_alterar.TabIndex = 5;
            this.btn_alterar.Text = "Alterar Avaliação";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(140, 275);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(128, 23);
            this.btn_apagar.TabIndex = 6;
            this.btn_apagar.Text = "Apagar Avaliação";
            this.btn_apagar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_profissional);
            this.groupBox2.Controls.Add(this.txt_nota);
            this.groupBox2.Controls.Add(this.rtxt_descricao);
            this.groupBox2.Controls.Add(this.txt_cliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_avaliar);
            this.groupBox2.Location = new System.Drawing.Point(34, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 303);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Avaliar Profissional";
            // 
            // cmb_profissional
            // 
            this.cmb_profissional.FormattingEnabled = true;
            this.cmb_profissional.Location = new System.Drawing.Point(121, 56);
            this.cmb_profissional.Name = "cmb_profissional";
            this.cmb_profissional.Size = new System.Drawing.Size(276, 21);
            this.cmb_profissional.TabIndex = 14;
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(45, 229);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(49, 20);
            this.txt_nota.TabIndex = 13;
            // 
            // rtxt_descricao
            // 
            this.rtxt_descricao.Location = new System.Drawing.Point(9, 103);
            this.rtxt_descricao.Name = "rtxt_descricao";
            this.rtxt_descricao.Size = new System.Drawing.Size(388, 116);
            this.rtxt_descricao.TabIndex = 12;
            this.rtxt_descricao.Text = "";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(100, 28);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(297, 20);
            this.txt_cliente.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do Profissional:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do Cliente:";
            // 
            // btn_avaliar
            // 
            this.btn_avaliar.Location = new System.Drawing.Point(9, 265);
            this.btn_avaliar.Name = "btn_avaliar";
            this.btn_avaliar.Size = new System.Drawing.Size(128, 23);
            this.btn_avaliar.TabIndex = 4;
            this.btn_avaliar.Text = "Avaliar";
            this.btn_avaliar.UseVisualStyleBackColor = true;
            this.btn_avaliar.Click += new System.EventHandler(this.btn_avaliar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(649, 699);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(128, 23);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frmAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 732);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAvaliacao";
            this.Text = "Avaliação";
            this.Load += new System.EventHandler(this.frmAvaliacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_pesquisa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_avaliar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ComboBox cmb_pesquisa;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.RichTextBox rtxt_descricao;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_profissional;
    }
}