namespace flexnit
{
    partial class frmMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdmin));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgFilmes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.btnCadAdmin = new System.Windows.Forms.Button();
            this.btnCadGen = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFilmes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Noto Sans Cond", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Administração";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 338);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgFilmes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filmes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgFilmes
            // 
            this.dtgFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFilmes.Location = new System.Drawing.Point(7, 7);
            this.dtgFilmes.Name = "dtgFilmes";
            this.dtgFilmes.Size = new System.Drawing.Size(561, 299);
            this.dtgFilmes.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgClientes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(7, 7);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.Size = new System.Drawing.Size(561, 302);
            this.dtgClientes.TabIndex = 0;
            // 
            // btnCadProd
            // 
            this.btnCadProd.Location = new System.Drawing.Point(477, 415);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(118, 23);
            this.btnCadProd.TabIndex = 2;
            this.btnCadProd.Text = "Cadastrar Filmes";
            this.btnCadProd.UseVisualStyleBackColor = true;
            // 
            // btnCadAdmin
            // 
            this.btnCadAdmin.Location = new System.Drawing.Point(353, 415);
            this.btnCadAdmin.Name = "btnCadAdmin";
            this.btnCadAdmin.Size = new System.Drawing.Size(118, 23);
            this.btnCadAdmin.TabIndex = 3;
            this.btnCadAdmin.Text = "Cadastrar Admins";
            this.btnCadAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCadGen
            // 
            this.btnCadGen.Location = new System.Drawing.Point(223, 415);
            this.btnCadGen.Name = "btnCadGen";
            this.btnCadGen.Size = new System.Drawing.Size(118, 23);
            this.btnCadGen.TabIndex = 4;
            this.btnCadGen.Text = "Cadastrar Gêneros";
            this.btnCadGen.UseVisualStyleBackColor = true;
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.btnCadGen);
            this.Controls.Add(this.btnCadAdmin);
            this.Controls.Add(this.btnCadProd);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuAdmin";
            this.Text = "Administração";
            this.Load += new System.EventHandler(this.frmMenuAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFilmes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgFilmes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.Button btnCadAdmin;
        private System.Windows.Forms.Button btnCadGen;
    }
}