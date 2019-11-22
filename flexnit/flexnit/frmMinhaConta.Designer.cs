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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblContaUsername = new System.Windows.Forms.Label();
            this.lblContaEmail = new System.Windows.Forms.Label();
            this.lblContaNome = new System.Windows.Forms.Label();
            this.lblContaEstado = new System.Windows.Forms.Label();
            this.lblContaFilmes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtContaNome = new System.Windows.Forms.TextBox();
            this.txtContaUsername = new System.Windows.Forms.TextBox();
            this.txtContaEstado = new System.Windows.Forms.TextBox();
            this.txtContaEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::flexnit.Properties.Resources.login_icon_png;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(92, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 156);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblContaUsername
            // 
            this.lblContaUsername.AutoSize = true;
            this.lblContaUsername.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblContaUsername.Location = new System.Drawing.Point(21, 264);
            this.lblContaUsername.Name = "lblContaUsername";
            this.lblContaUsername.Size = new System.Drawing.Size(93, 22);
            this.lblContaUsername.TabIndex = 1;
            this.lblContaUsername.Text = "Username:";
            // 
            // lblContaEmail
            // 
            this.lblContaEmail.AutoSize = true;
            this.lblContaEmail.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblContaEmail.Location = new System.Drawing.Point(21, 318);
            this.lblContaEmail.Name = "lblContaEmail";
            this.lblContaEmail.Size = new System.Drawing.Size(55, 22);
            this.lblContaEmail.TabIndex = 2;
            this.lblContaEmail.Text = "Email:";
            // 
            // lblContaNome
            // 
            this.lblContaNome.AutoSize = true;
            this.lblContaNome.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblContaNome.Location = new System.Drawing.Point(21, 211);
            this.lblContaNome.Name = "lblContaNome";
            this.lblContaNome.Size = new System.Drawing.Size(60, 22);
            this.lblContaNome.TabIndex = 3;
            this.lblContaNome.Text = "Nome:";
            // 
            // lblContaEstado
            // 
            this.lblContaEstado.AutoSize = true;
            this.lblContaEstado.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblContaEstado.Location = new System.Drawing.Point(21, 365);
            this.lblContaEstado.Name = "lblContaEstado";
            this.lblContaEstado.Size = new System.Drawing.Size(66, 22);
            this.lblContaEstado.TabIndex = 4;
            this.lblContaEstado.Text = "Estado:";
            // 
            // lblContaFilmes
            // 
            this.lblContaFilmes.AutoSize = true;
            this.lblContaFilmes.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblContaFilmes.Location = new System.Drawing.Point(334, 24);
            this.lblContaFilmes.Name = "lblContaFilmes";
            this.lblContaFilmes.Size = new System.Drawing.Size(141, 22);
            this.lblContaFilmes.TabIndex = 5;
            this.lblContaFilmes.Text = "Filmes assistidos:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(450, 389);
            this.dataGridView1.TabIndex = 6;
            // 
            // txtContaNome
            // 
            this.txtContaNome.Enabled = false;
            this.txtContaNome.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.txtContaNome.Location = new System.Drawing.Point(120, 211);
            this.txtContaNome.Name = "txtContaNome";
            this.txtContaNome.Size = new System.Drawing.Size(189, 25);
            this.txtContaNome.TabIndex = 7;
            // 
            // txtContaUsername
            // 
            this.txtContaUsername.Enabled = false;
            this.txtContaUsername.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.txtContaUsername.Location = new System.Drawing.Point(120, 264);
            this.txtContaUsername.Name = "txtContaUsername";
            this.txtContaUsername.Size = new System.Drawing.Size(189, 25);
            this.txtContaUsername.TabIndex = 8;
            // 
            // txtContaEstado
            // 
            this.txtContaEstado.Enabled = false;
            this.txtContaEstado.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.txtContaEstado.Location = new System.Drawing.Point(120, 365);
            this.txtContaEstado.Name = "txtContaEstado";
            this.txtContaEstado.Size = new System.Drawing.Size(110, 25);
            this.txtContaEstado.TabIndex = 9;
            // 
            // txtContaEmail
            // 
            this.txtContaEmail.Enabled = false;
            this.txtContaEmail.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.txtContaEmail.Location = new System.Drawing.Point(120, 318);
            this.txtContaEmail.Name = "txtContaEmail";
            this.txtContaEmail.Size = new System.Drawing.Size(189, 25);
            this.txtContaEmail.TabIndex = 10;
            // 
            // frmMinhaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContaEmail);
            this.Controls.Add(this.txtContaEstado);
            this.Controls.Add(this.txtContaUsername);
            this.Controls.Add(this.txtContaNome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblContaFilmes);
            this.Controls.Add(this.lblContaEstado);
            this.Controls.Add(this.lblContaNome);
            this.Controls.Add(this.lblContaEmail);
            this.Controls.Add(this.lblContaUsername);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "frmMinhaConta";
            this.Text = "frmMinhaConta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContaUsername;
        private System.Windows.Forms.Label lblContaEmail;
        private System.Windows.Forms.Label lblContaNome;
        private System.Windows.Forms.Label lblContaEstado;
        private System.Windows.Forms.Label lblContaFilmes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtContaNome;
        private System.Windows.Forms.TextBox txtContaUsername;
        private System.Windows.Forms.TextBox txtContaEstado;
        private System.Windows.Forms.TextBox txtContaEmail;
    }
}