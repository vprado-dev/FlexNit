namespace flexnit
{
    partial class frmMinhaConta
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
            this.pbxFotoConta = new System.Windows.Forms.PictureBox();
            this.lblContaUsername = new System.Windows.Forms.Label();
            this.lblContaNome = new System.Windows.Forms.Label();
            this.lblContaEstado = new System.Windows.Forms.Label();
            this.lblContaEmail = new System.Windows.Forms.Label();
            this.lblContaFilmes = new System.Windows.Forms.Label();
            this.dgvFilmes = new System.Windows.Forms.DataGridView();
            this.txtContaUsername = new System.Windows.Forms.TextBox();
            this.txtContaEmail = new System.Windows.Forms.TextBox();
            this.txtContaNome = new System.Windows.Forms.TextBox();
            this.txtContaEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxFotoConta
            // 
            this.pbxFotoConta.BackgroundImage = global::flexnit.Properties.Resources.login_icon_png;
            this.pbxFotoConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxFotoConta.Location = new System.Drawing.Point(121, 12);
            this.pbxFotoConta.Name = "pbxFotoConta";
            this.pbxFotoConta.Size = new System.Drawing.Size(143, 138);
            this.pbxFotoConta.TabIndex = 0;
            this.pbxFotoConta.TabStop = false;
            // 
            // lblContaUsername
            // 
            this.lblContaUsername.AutoSize = true;
            this.lblContaUsername.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblContaUsername.Location = new System.Drawing.Point(37, 180);
            this.lblContaUsername.Name = "lblContaUsername";
            this.lblContaUsername.Size = new System.Drawing.Size(93, 22);
            this.lblContaUsername.TabIndex = 1;
            this.lblContaUsername.Text = "Username:";
            // 
            // lblContaNome
            // 
            this.lblContaNome.AutoSize = true;
            this.lblContaNome.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblContaNome.Location = new System.Drawing.Point(37, 294);
            this.lblContaNome.Name = "lblContaNome";
            this.lblContaNome.Size = new System.Drawing.Size(60, 22);
            this.lblContaNome.TabIndex = 2;
            this.lblContaNome.Text = "Nome:";
            // 
            // lblContaEstado
            // 
            this.lblContaEstado.AutoSize = true;
            this.lblContaEstado.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblContaEstado.Location = new System.Drawing.Point(37, 353);
            this.lblContaEstado.Name = "lblContaEstado";
            this.lblContaEstado.Size = new System.Drawing.Size(70, 22);
            this.lblContaEstado.TabIndex = 3;
            this.lblContaEstado.Text = "Estado: ";
            // 
            // lblContaEmail
            // 
            this.lblContaEmail.AutoSize = true;
            this.lblContaEmail.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblContaEmail.Location = new System.Drawing.Point(37, 240);
            this.lblContaEmail.Name = "lblContaEmail";
            this.lblContaEmail.Size = new System.Drawing.Size(55, 22);
            this.lblContaEmail.TabIndex = 4;
            this.lblContaEmail.Text = "Email:";
            // 
            // lblContaFilmes
            // 
            this.lblContaFilmes.AutoSize = true;
            this.lblContaFilmes.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblContaFilmes.Location = new System.Drawing.Point(381, 40);
            this.lblContaFilmes.Name = "lblContaFilmes";
            this.lblContaFilmes.Size = new System.Drawing.Size(141, 22);
            this.lblContaFilmes.TabIndex = 5;
            this.lblContaFilmes.Text = "Filmes assistidos:";
            // 
            // dgvFilmes
            // 
            this.dgvFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmes.Location = new System.Drawing.Point(385, 65);
            this.dgvFilmes.Name = "dgvFilmes";
            this.dgvFilmes.Size = new System.Drawing.Size(352, 330);
            this.dgvFilmes.TabIndex = 6;
            // 
            // txtContaUsername
            // 
            this.txtContaUsername.Enabled = false;
            this.txtContaUsername.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.txtContaUsername.Location = new System.Drawing.Point(137, 180);
            this.txtContaUsername.Name = "txtContaUsername";
            this.txtContaUsername.Size = new System.Drawing.Size(202, 25);
            this.txtContaUsername.TabIndex = 7;
            this.txtContaUsername.Text = "nome do usuário";
            // 
            // txtContaEmail
            // 
            this.txtContaEmail.Enabled = false;
            this.txtContaEmail.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.txtContaEmail.Location = new System.Drawing.Point(137, 237);
            this.txtContaEmail.Name = "txtContaEmail";
            this.txtContaEmail.Size = new System.Drawing.Size(202, 25);
            this.txtContaEmail.TabIndex = 8;
            this.txtContaEmail.Text = "user@gmail.com";
            // 
            // txtContaNome
            // 
            this.txtContaNome.Enabled = false;
            this.txtContaNome.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.txtContaNome.Location = new System.Drawing.Point(137, 294);
            this.txtContaNome.Name = "txtContaNome";
            this.txtContaNome.Size = new System.Drawing.Size(202, 25);
            this.txtContaNome.TabIndex = 9;
            this.txtContaNome.Text = "Usuário da Silva";
            // 
            // txtContaEstado
            // 
            this.txtContaEstado.Enabled = false;
            this.txtContaEstado.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.txtContaEstado.Location = new System.Drawing.Point(137, 350);
            this.txtContaEstado.Name = "txtContaEstado";
            this.txtContaEstado.Size = new System.Drawing.Size(88, 25);
            this.txtContaEstado.TabIndex = 10;
            this.txtContaEstado.Text = "SP";
            // 
            // frmMinhaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(756, 407);
            this.Controls.Add(this.txtContaEstado);
            this.Controls.Add(this.txtContaNome);
            this.Controls.Add(this.txtContaEmail);
            this.Controls.Add(this.txtContaUsername);
            this.Controls.Add(this.dgvFilmes);
            this.Controls.Add(this.lblContaFilmes);
            this.Controls.Add(this.lblContaEmail);
            this.Controls.Add(this.lblContaEstado);
            this.Controls.Add(this.lblContaNome);
            this.Controls.Add(this.lblContaUsername);
            this.Controls.Add(this.pbxFotoConta);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMinhaConta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhes da Minha Conta";
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxFotoConta;
        private System.Windows.Forms.Label lblContaUsername;
        private System.Windows.Forms.Label lblContaNome;
        private System.Windows.Forms.Label lblContaEstado;
        private System.Windows.Forms.Label lblContaEmail;
        private System.Windows.Forms.Label lblContaFilmes;
        private System.Windows.Forms.DataGridView dgvFilmes;
        private System.Windows.Forms.TextBox txtContaUsername;
        private System.Windows.Forms.TextBox txtContaEmail;
        private System.Windows.Forms.TextBox txtContaNome;
        private System.Windows.Forms.TextBox txtContaEstado;
    }
}