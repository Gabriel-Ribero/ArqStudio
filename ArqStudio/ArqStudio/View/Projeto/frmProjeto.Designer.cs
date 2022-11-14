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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imgProjeto = new System.Windows.Forms.PictureBox();
            this.lblNomeProjeto = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgProjeto)).BeginInit();
            this.SuspendLayout();
            // 
            // imgProjeto
            // 
            this.imgProjeto.Location = new System.Drawing.Point(270, 77);
            this.imgProjeto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgProjeto.Name = "imgProjeto";
            this.imgProjeto.Size = new System.Drawing.Size(771, 466);
            this.imgProjeto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProjeto.TabIndex = 13;
            this.imgProjeto.TabStop = false;
            // 
            // lblNomeProjeto
            // 
            this.lblNomeProjeto.AutoSize = true;
            this.lblNomeProjeto.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProjeto.Location = new System.Drawing.Point(33, 21);
            this.lblNomeProjeto.Name = "lblNomeProjeto";
            this.lblNomeProjeto.Size = new System.Drawing.Size(230, 38);
            this.lblNomeProjeto.TabIndex = 14;
            this.lblNomeProjeto.Text = "Nome do Projeto";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(36, 561);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(87, 23);
            this.lblDescricao.TabIndex = 15;
            this.lblDescricao.Text = "Descrição:";
            // 
            // frmProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1302, 711);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNomeProjeto);
            this.Controls.Add(this.imgProjeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProjeto";
            ((System.ComponentModel.ISupportInitialize)(this.imgProjeto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox imgProjeto;
        private System.Windows.Forms.Label lblNomeProjeto;
        private System.Windows.Forms.Label lblDescricao;
    }
}