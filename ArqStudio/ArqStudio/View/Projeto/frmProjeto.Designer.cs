namespace ArqStudio.View.Projeto
{
    partial class frmProjeto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjeto));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFinalizarProjeto = new System.Windows.Forms.Button();
            this.gridFormularios = new System.Windows.Forms.DataGridView();
            this.btn_sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormularios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulários em Aberto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnFinalizarProjeto);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnFinalizarProjeto
            // 
            this.btnFinalizarProjeto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFinalizarProjeto.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarProjeto.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarProjeto.Location = new System.Drawing.Point(11, 15);
            this.btnFinalizarProjeto.Name = "btnFinalizarProjeto";
            this.btnFinalizarProjeto.Size = new System.Drawing.Size(127, 29);
            this.btnFinalizarProjeto.TabIndex = 0;
            this.btnFinalizarProjeto.Text = "Finalizar Projeto";
            this.btnFinalizarProjeto.UseVisualStyleBackColor = false;
            this.btnFinalizarProjeto.Click += new System.EventHandler(this.btnFinalizarProjeto_Click);
            // 
            // gridFormularios
            // 
            this.gridFormularios.BackgroundColor = System.Drawing.Color.White;
            this.gridFormularios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFormularios.GridColor = System.Drawing.Color.White;
            this.gridFormularios.Location = new System.Drawing.Point(12, 128);
            this.gridFormularios.Name = "gridFormularios";
            this.gridFormularios.RowHeadersWidth = 51;
            this.gridFormularios.RowTemplate.Height = 24;
            this.gridFormularios.Size = new System.Drawing.Size(1077, 410);
            this.gridFormularios.TabIndex = 2;
            // 
            // btn_sair
            // 
            this.btn_sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sair.BackgroundImage")));
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sair.Location = new System.Drawing.Point(1066, 9);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(23, 23);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // frmProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1101, 550);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.gridFormularios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProjeto";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFormularios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFinalizarProjeto;
        private System.Windows.Forms.DataGridView gridFormularios;
        private System.Windows.Forms.Button btn_sair;
    }
}