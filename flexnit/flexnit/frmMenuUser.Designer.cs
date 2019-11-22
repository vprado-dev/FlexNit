namespace flexnit
{
    partial class frmMenuUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuUser));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssNomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssAux = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssAux2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLogout = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblXis = new System.Windows.Forms.Label();
            this.btnDadosCadastrados = new System.Windows.Forms.Button();
            this.btnTodas = new System.Windows.Forms.Button();
            this.gpbFilmes = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.picFlexnit = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.minhaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoCompletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.gpbFilmes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlexnit)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssNomeUsuario,
            this.tssAux,
            this.tssMensagem,
            this.tssAux2,
            this.tssLogout});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssNomeUsuario
            // 
            this.tssNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.tssNomeUsuario.Name = "tssNomeUsuario";
            this.tssNomeUsuario.Size = new System.Drawing.Size(29, 17);
            this.tssNomeUsuario.Text = "user";
            // 
            // tssAux
            // 
            this.tssAux.Name = "tssAux";
            this.tssAux.Size = new System.Drawing.Size(297, 17);
            this.tssAux.Spring = true;
            this.tssAux.Text = "|";
            // 
            // tssMensagem
            // 
            this.tssMensagem.Name = "tssMensagem";
            this.tssMensagem.Size = new System.Drawing.Size(117, 17);
            this.tssMensagem.Text = "Olá! Seja bem-vindo!";
            // 
            // tssAux2
            // 
            this.tssAux2.Name = "tssAux2";
            this.tssAux2.Size = new System.Drawing.Size(297, 17);
            this.tssAux2.Spring = true;
            this.tssAux2.Text = "|";
            // 
            // tssLogout
            // 
            this.tssLogout.Name = "tssLogout";
            this.tssLogout.Size = new System.Drawing.Size(45, 17);
            this.tssLogout.Text = "Logout";
            this.tssLogout.Click += new System.EventHandler(this.tssLogout_Click);
            // 
            // lblXis
            // 
            this.lblXis.BackColor = System.Drawing.Color.RosyBrown;
            this.lblXis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblXis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblXis.Location = new System.Drawing.Point(754, 9);
            this.lblXis.Name = "lblXis";
            this.lblXis.Size = new System.Drawing.Size(34, 23);
            this.lblXis.TabIndex = 1;
            this.lblXis.Text = "X";
            this.lblXis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblXis.Click += new System.EventHandler(this.lblSaida_Click);
            this.lblXis.MouseEnter += new System.EventHandler(this.lblSaida_MouseEnter);
            this.lblXis.MouseLeave += new System.EventHandler(this.lblSaida_MouseLeave);
            // 
            // btnDadosCadastrados
            // 
            this.btnDadosCadastrados.BackColor = System.Drawing.Color.Firebrick;
            this.btnDadosCadastrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDadosCadastrados.FlatAppearance.BorderSize = 0;
            this.btnDadosCadastrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosCadastrados.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDadosCadastrados.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDadosCadastrados.Location = new System.Drawing.Point(23, 356);
            this.btnDadosCadastrados.Name = "btnDadosCadastrados";
            this.btnDadosCadastrados.Size = new System.Drawing.Size(205, 42);
            this.btnDadosCadastrados.TabIndex = 2;
            this.btnDadosCadastrados.Text = "Minha conta";
            this.btnDadosCadastrados.UseVisualStyleBackColor = false;
            this.btnDadosCadastrados.Click += new System.EventHandler(this.btnDadosCadastrados_Click);
            // 
            // btnTodas
            // 
            this.btnTodas.BackColor = System.Drawing.Color.Firebrick;
            this.btnTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodas.FlatAppearance.BorderSize = 0;
            this.btnTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodas.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnTodas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTodas.Location = new System.Drawing.Point(422, 356);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(356, 42);
            this.btnTodas.TabIndex = 5;
            this.btnTodas.Text = "Catálogo completo";
            this.btnTodas.UseVisualStyleBackColor = false;
            this.btnTodas.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // gpbFilmes
            // 
            this.gpbFilmes.Controls.Add(this.pictureBox1);
            this.gpbFilmes.Controls.Add(this.pic4);
            this.gpbFilmes.Controls.Add(this.pic3);
            this.gpbFilmes.Controls.Add(this.pic2);
            this.gpbFilmes.Controls.Add(this.pic1);
            this.gpbFilmes.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.gpbFilmes.ForeColor = System.Drawing.Color.White;
            this.gpbFilmes.Location = new System.Drawing.Point(12, 86);
            this.gpbFilmes.Name = "gpbFilmes";
            this.gpbFilmes.Size = new System.Drawing.Size(776, 249);
            this.gpbFilmes.TabIndex = 6;
            this.gpbFilmes.TabStop = false;
            this.gpbFilmes.Text = "Filmes em destaque:  ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(619, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 211);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic4.BackgroundImage")));
            this.pic4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic4.Location = new System.Drawing.Point(467, 27);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(147, 211);
            this.pic4.TabIndex = 3;
            this.pic4.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic3.BackgroundImage")));
            this.pic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic3.Location = new System.Drawing.Point(315, 27);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(147, 211);
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic2.BackgroundImage")));
            this.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic2.Location = new System.Drawing.Point(163, 27);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(147, 211);
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic1.BackgroundImage")));
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic1.Location = new System.Drawing.Point(11, 27);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(147, 211);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // picFlexnit
            // 
            this.picFlexnit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFlexnit.BackgroundImage")));
            this.picFlexnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFlexnit.Location = new System.Drawing.Point(306, 10);
            this.picFlexnit.Name = "picFlexnit";
            this.picFlexnit.Size = new System.Drawing.Size(216, 59);
            this.picFlexnit.TabIndex = 7;
            this.picFlexnit.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhaContaToolStripMenuItem,
            this.catálogoCompletoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 70);
            // 
            // minhaContaToolStripMenuItem
            // 
            this.minhaContaToolStripMenuItem.Name = "minhaContaToolStripMenuItem";
            this.minhaContaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minhaContaToolStripMenuItem.Text = "Minha conta";
            this.minhaContaToolStripMenuItem.Click += new System.EventHandler(this.btnDadosCadastrados_Click);
            // 
            // catálogoCompletoToolStripMenuItem
            // 
            this.catálogoCompletoToolStripMenuItem.Name = "catálogoCompletoToolStripMenuItem";
            this.catálogoCompletoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.catálogoCompletoToolStripMenuItem.Text = "Catálogo completo";
            this.catálogoCompletoToolStripMenuItem.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.lblSaida_Click);
            // 
            // frmMenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.picFlexnit);
            this.Controls.Add(this.gpbFilmes);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.btnDadosCadastrados);
            this.Controls.Add(this.lblXis);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuUser";
            this.Load += new System.EventHandler(this.frmMenuUser_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gpbFilmes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlexnit)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssNomeUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tssAux;
        private System.Windows.Forms.ToolStripStatusLabel tssMensagem;
        private System.Windows.Forms.ToolStripStatusLabel tssAux2;
        private System.Windows.Forms.ToolStripStatusLabel tssLogout;
        private System.Windows.Forms.Label lblXis;
        private System.Windows.Forms.Button btnDadosCadastrados;
        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.GroupBox gpbFilmes;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picFlexnit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem minhaContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoCompletoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}