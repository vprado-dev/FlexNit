namespace flexnit
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pbxSenha = new System.Windows.Forms.PictureBox();
            this.pbxUsername = new System.Windows.Forms.PictureBox();
            this.pbxLogin = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbxFundo = new System.Windows.Forms.PictureBox();
            this.pbxCadastrar = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtUsername.Location = new System.Drawing.Point(74, 211);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(329, 21);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSenha.Location = new System.Drawing.Point(74, 264);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(329, 21);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenha_Validating);
            // 
            // pbxSenha
            // 
            this.pbxSenha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxSenha.BackgroundImage = global::flexnit.Properties.Resources.caixa_login2;
            this.pbxSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSenha.Location = new System.Drawing.Point(63, 251);
            this.pbxSenha.Name = "pbxSenha";
            this.pbxSenha.Size = new System.Drawing.Size(352, 46);
            this.pbxSenha.TabIndex = 4;
            this.pbxSenha.TabStop = false;
            this.pbxSenha.Click += new System.EventHandler(this.pbxSenha_Click);
            // 
            // pbxUsername
            // 
            this.pbxUsername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxUsername.BackgroundImage = global::flexnit.Properties.Resources.caixa_login2;
            this.pbxUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUsername.Location = new System.Drawing.Point(63, 199);
            this.pbxUsername.Name = "pbxUsername";
            this.pbxUsername.Size = new System.Drawing.Size(352, 46);
            this.pbxUsername.TabIndex = 3;
            this.pbxUsername.TabStop = false;
            this.pbxUsername.Click += new System.EventHandler(this.pbxUsername_Click);
            // 
            // pbxLogin
            // 
            this.pbxLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxLogin.Image = global::flexnit.Properties.Resources.login_icon_png;
            this.pbxLogin.Location = new System.Drawing.Point(163, 24);
            this.pbxLogin.Name = "pbxLogin";
            this.pbxLogin.Size = new System.Drawing.Size(152, 156);
            this.pbxLogin.TabIndex = 2;
            this.pbxLogin.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::flexnit.Properties.Resources.npreto;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(426, 384);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 66);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pbxFundo
            // 
            this.pbxFundo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxFundo.BackgroundImage")));
            this.pbxFundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxFundo.Location = new System.Drawing.Point(-236, 0);
            this.pbxFundo.Name = "pbxFundo";
            this.pbxFundo.Size = new System.Drawing.Size(837, 464);
            this.pbxFundo.TabIndex = 0;
            this.pbxFundo.TabStop = false;
            // 
            // pbxCadastrar
            // 
            this.pbxCadastrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbxCadastrar.BackgroundImage = global::flexnit.Properties.Resources.button_vermelho;
            this.pbxCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCadastrar.Location = new System.Drawing.Point(74, 314);
            this.pbxCadastrar.Name = "pbxCadastrar";
            this.pbxCadastrar.Size = new System.Drawing.Size(157, 40);
            this.pbxCadastrar.TabIndex = 6;
            this.pbxCadastrar.TabStop = false;
            this.pbxCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(271, 316);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(109, 37);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.lblCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadastrar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrar.Location = new System.Drawing.Point(97, 316);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(109, 37);
            this.lblCadastrar.TabIndex = 8;
            this.lblCadastrar.Text = "Cadastrar";
            this.lblCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BackgroundImage = global::flexnit.Properties.Resources.button_vermelho;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(246, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 40);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logarToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // logarToolStripMenuItem
            // 
            this.logarToolStripMenuItem.Name = "logarToolStripMenuItem";
            this.logarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.logarToolStripMenuItem.Text = "Login";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(287, 370);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(115, 370);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Visible = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.pbxCadastrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pbxSenha);
            this.Controls.Add(this.pbxUsername);
            this.Controls.Add(this.pbxLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbxFundo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbxFundo;
        private System.Windows.Forms.PictureBox pbxLogin;
        private System.Windows.Forms.PictureBox pbxUsername;
        private System.Windows.Forms.PictureBox pbxSenha;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pbxCadastrar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

