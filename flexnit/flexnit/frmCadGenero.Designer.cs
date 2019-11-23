namespace flexnit
{
    partial class frmCadGenero
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCadastrarGen = new System.Windows.Forms.Button();
            this.txtGenFilme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Noto Sans Cond", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(41, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(399, 65);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cadastro de Gênero";
            // 
            // btnCadastrarGen
            // 
            this.btnCadastrarGen.Location = new System.Drawing.Point(385, 200);
            this.btnCadastrarGen.Name = "btnCadastrarGen";
            this.btnCadastrarGen.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarGen.TabIndex = 2;
            this.btnCadastrarGen.Text = "Cadastrar";
            this.btnCadastrarGen.UseVisualStyleBackColor = true;
            this.btnCadastrarGen.Click += new System.EventHandler(this.btnCadastrarGen_Click);
            // 
            // txtGenFilme
            // 
            this.txtGenFilme.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.txtGenFilme.Location = new System.Drawing.Point(198, 123);
            this.txtGenFilme.Name = "txtGenFilme";
            this.txtGenFilme.Size = new System.Drawing.Size(262, 25);
            this.txtGenFilme.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(18, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o novo gênero:";
            // 
            // frmCadGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(472, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenFilme);
            this.Controls.Add(this.btnCadastrarGen);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCadGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadGenero";
            this.Load += new System.EventHandler(this.frmCadGenero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCadastrarGen;
        private System.Windows.Forms.TextBox txtGenFilme;
        private System.Windows.Forms.Label label1;
    }
}