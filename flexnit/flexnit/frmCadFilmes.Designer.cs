namespace flexnit
{
    partial class frmCadFilmes
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
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.pbxNomeFilme = new System.Windows.Forms.PictureBox();
            this.txtDescricaoFilme = new System.Windows.Forms.TextBox();
            this.pbxDescricaoFilme = new System.Windows.Forms.PictureBox();
            this.pbxAnoFilme = new System.Windows.Forms.PictureBox();
            this.pbxGeneroFilme = new System.Windows.Forms.PictureBox();
            this.cmbGeneroFilme = new System.Windows.Forms.ComboBox();
            this.mskAnoFilme = new System.Windows.Forms.MaskedTextBox();
            this.lblAnoFilme = new System.Windows.Forms.Label();
            this.lblCadSairFilme = new System.Windows.Forms.Label();
            this.pbxCadSairFilme = new System.Windows.Forms.PictureBox();
            this.btnCadCadastrarFilme = new System.Windows.Forms.Button();
            this.lblCadastrarFilme = new System.Windows.Forms.Label();
            this.pbxCadastrarFilme = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNomeFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDescricaoFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnoFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGeneroFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadSairFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Noto Sans Cond", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(385, 65);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cadastro de Filmes";
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNomeFilme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeFilme.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFilme.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNomeFilme.Location = new System.Drawing.Point(33, 103);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(329, 21);
            this.txtNomeFilme.TabIndex = 4;
            this.txtNomeFilme.Text = "Nome";
            // 
            // pbxNomeFilme
            // 
            this.pbxNomeFilme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxNomeFilme.BackgroundImage = global::flexnit.Properties.Resources.caixa_login2;
            this.pbxNomeFilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxNomeFilme.Location = new System.Drawing.Point(22, 91);
            this.pbxNomeFilme.Name = "pbxNomeFilme";
            this.pbxNomeFilme.Size = new System.Drawing.Size(352, 46);
            this.pbxNomeFilme.TabIndex = 5;
            this.pbxNomeFilme.TabStop = false;
            // 
            // txtDescricaoFilme
            // 
            this.txtDescricaoFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDescricaoFilme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricaoFilme.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoFilme.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDescricaoFilme.Location = new System.Drawing.Point(33, 161);
            this.txtDescricaoFilme.Multiline = true;
            this.txtDescricaoFilme.Name = "txtDescricaoFilme";
            this.txtDescricaoFilme.Size = new System.Drawing.Size(329, 172);
            this.txtDescricaoFilme.TabIndex = 6;
            this.txtDescricaoFilme.Text = "Descrição";
            // 
            // pbxDescricaoFilme
            // 
            this.pbxDescricaoFilme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxDescricaoFilme.BackgroundImage = global::flexnit.Properties.Resources.caixa_login2;
            this.pbxDescricaoFilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxDescricaoFilme.Location = new System.Drawing.Point(22, 151);
            this.pbxDescricaoFilme.Name = "pbxDescricaoFilme";
            this.pbxDescricaoFilme.Size = new System.Drawing.Size(352, 200);
            this.pbxDescricaoFilme.TabIndex = 7;
            this.pbxDescricaoFilme.TabStop = false;
            // 
            // pbxAnoFilme
            // 
            this.pbxAnoFilme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxAnoFilme.BackgroundImage = global::flexnit.Properties.Resources.caixa_login2;
            this.pbxAnoFilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxAnoFilme.Location = new System.Drawing.Point(22, 367);
            this.pbxAnoFilme.Name = "pbxAnoFilme";
            this.pbxAnoFilme.Size = new System.Drawing.Size(352, 46);
            this.pbxAnoFilme.TabIndex = 9;
            this.pbxAnoFilme.TabStop = false;
            // 
            // pbxGeneroFilme
            // 
            this.pbxGeneroFilme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxGeneroFilme.BackgroundImage = global::flexnit.Properties.Resources.caixa_login2;
            this.pbxGeneroFilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxGeneroFilme.Location = new System.Drawing.Point(22, 432);
            this.pbxGeneroFilme.Name = "pbxGeneroFilme";
            this.pbxGeneroFilme.Size = new System.Drawing.Size(352, 46);
            this.pbxGeneroFilme.TabIndex = 11;
            this.pbxGeneroFilme.TabStop = false;
            // 
            // cmbGeneroFilme
            // 
            this.cmbGeneroFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbGeneroFilme.FormattingEnabled = true;
            this.cmbGeneroFilme.Location = new System.Drawing.Point(33, 445);
            this.cmbGeneroFilme.Name = "cmbGeneroFilme";
            this.cmbGeneroFilme.Size = new System.Drawing.Size(329, 21);
            this.cmbGeneroFilme.TabIndex = 12;
            // 
            // mskAnoFilme
            // 
            this.mskAnoFilme.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.mskAnoFilme.Location = new System.Drawing.Point(201, 377);
            this.mskAnoFilme.Mask = "9999";
            this.mskAnoFilme.Name = "mskAnoFilme";
            this.mskAnoFilme.Size = new System.Drawing.Size(76, 25);
            this.mskAnoFilme.TabIndex = 13;
            this.mskAnoFilme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAnoFilme
            // 
            this.lblAnoFilme.AutoSize = true;
            this.lblAnoFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblAnoFilme.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblAnoFilme.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAnoFilme.Location = new System.Drawing.Point(40, 380);
            this.lblAnoFilme.Name = "lblAnoFilme";
            this.lblAnoFilme.Size = new System.Drawing.Size(106, 22);
            this.lblAnoFilme.TabIndex = 14;
            this.lblAnoFilme.Text = "Digite o ano:";
            // 
            // lblCadSairFilme
            // 
            this.lblCadSairFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.lblCadSairFilme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadSairFilme.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadSairFilme.ForeColor = System.Drawing.Color.Black;
            this.lblCadSairFilme.Location = new System.Drawing.Point(263, 499);
            this.lblCadSairFilme.Name = "lblCadSairFilme";
            this.lblCadSairFilme.Size = new System.Drawing.Size(99, 37);
            this.lblCadSairFilme.TabIndex = 35;
            this.lblCadSairFilme.Text = "Sair";
            this.lblCadSairFilme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCadSairFilme.Click += new System.EventHandler(this.btnCadCadastrarFilme_Click);
            // 
            // pbxCadSairFilme
            // 
            this.pbxCadSairFilme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxCadSairFilme.BackgroundImage = global::flexnit.Properties.Resources.button_vermelho;
            this.pbxCadSairFilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCadSairFilme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCadSairFilme.Location = new System.Drawing.Point(210, 496);
            this.pbxCadSairFilme.Name = "pbxCadSairFilme";
            this.pbxCadSairFilme.Size = new System.Drawing.Size(202, 40);
            this.pbxCadSairFilme.TabIndex = 34;
            this.pbxCadSairFilme.TabStop = false;
            this.pbxCadSairFilme.Click += new System.EventHandler(this.btnCadCadastrarFilme_Click);
            // 
            // btnCadCadastrarFilme
            // 
            this.btnCadCadastrarFilme.Location = new System.Drawing.Point(171, 542);
            this.btnCadCadastrarFilme.Name = "btnCadCadastrarFilme";
            this.btnCadCadastrarFilme.Size = new System.Drawing.Size(75, 23);
            this.btnCadCadastrarFilme.TabIndex = 31;
            this.btnCadCadastrarFilme.Text = "Cadastrar";
            this.btnCadCadastrarFilme.UseVisualStyleBackColor = true;
            this.btnCadCadastrarFilme.Visible = false;
            this.btnCadCadastrarFilme.Click += new System.EventHandler(this.btnCadCadastrarFilme_Click);
            // 
            // lblCadastrarFilme
            // 
            this.lblCadastrarFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.lblCadastrarFilme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadastrarFilme.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarFilme.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarFilme.Location = new System.Drawing.Point(53, 498);
            this.lblCadastrarFilme.Name = "lblCadastrarFilme";
            this.lblCadastrarFilme.Size = new System.Drawing.Size(109, 37);
            this.lblCadastrarFilme.TabIndex = 33;
            this.lblCadastrarFilme.Text = "Cadastrar";
            this.lblCadastrarFilme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCadastrarFilme.Click += new System.EventHandler(this.btnCadCadastrarFilme_Click);
            // 
            // pbxCadastrarFilme
            // 
            this.pbxCadastrarFilme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxCadastrarFilme.BackgroundImage = global::flexnit.Properties.Resources.button_vermelho;
            this.pbxCadastrarFilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCadastrarFilme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCadastrarFilme.Location = new System.Drawing.Point(0, 496);
            this.pbxCadastrarFilme.Name = "pbxCadastrarFilme";
            this.pbxCadastrarFilme.Size = new System.Drawing.Size(211, 40);
            this.pbxCadastrarFilme.TabIndex = 32;
            this.pbxCadastrarFilme.TabStop = false;
            this.pbxCadastrarFilme.Click += new System.EventHandler(this.btnCadCadastrarFilme_Click);
            // 
            // frmCadFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(403, 561);
            this.Controls.Add(this.lblCadSairFilme);
            this.Controls.Add(this.pbxCadSairFilme);
            this.Controls.Add(this.btnCadCadastrarFilme);
            this.Controls.Add(this.lblCadastrarFilme);
            this.Controls.Add(this.pbxCadastrarFilme);
            this.Controls.Add(this.lblAnoFilme);
            this.Controls.Add(this.mskAnoFilme);
            this.Controls.Add(this.cmbGeneroFilme);
            this.Controls.Add(this.pbxGeneroFilme);
            this.Controls.Add(this.pbxAnoFilme);
            this.Controls.Add(this.txtDescricaoFilme);
            this.Controls.Add(this.pbxDescricaoFilme);
            this.Controls.Add(this.txtNomeFilme);
            this.Controls.Add(this.pbxNomeFilme);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCadFilmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadProd";
            this.Load += new System.EventHandler(this.frmCadFilmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNomeFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDescricaoFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnoFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGeneroFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadSairFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarFilme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNomeFilme;
        private System.Windows.Forms.PictureBox pbxNomeFilme;
        private System.Windows.Forms.TextBox txtDescricaoFilme;
        private System.Windows.Forms.PictureBox pbxDescricaoFilme;
        private System.Windows.Forms.PictureBox pbxAnoFilme;
        private System.Windows.Forms.PictureBox pbxGeneroFilme;
        private System.Windows.Forms.ComboBox cmbGeneroFilme;
        private System.Windows.Forms.MaskedTextBox mskAnoFilme;
        private System.Windows.Forms.Label lblAnoFilme;
        private System.Windows.Forms.Label lblCadSairFilme;
        private System.Windows.Forms.PictureBox pbxCadSairFilme;
        private System.Windows.Forms.Button btnCadCadastrarFilme;
        private System.Windows.Forms.Label lblCadastrarFilme;
        private System.Windows.Forms.PictureBox pbxCadastrarFilme;
    }
}