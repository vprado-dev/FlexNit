namespace flexnit
{
    partial class frmCatalogo
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
            this.tabFilmes = new System.Windows.Forms.TabControl();
            this.tpTodosFilmes = new System.Windows.Forms.TabPage();
            this.dtgTodosFilmes = new System.Windows.Forms.DataGridView();
            this.tpPesquisaGenero = new System.Windows.Forms.TabPage();
            this.lblSelecGen = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.dtgGenero = new System.Windows.Forms.DataGridView();
            this.tpPesquisaAno = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mtxtDigitAno = new System.Windows.Forms.MaskedTextBox();
            this.lblDigitAno = new System.Windows.Forms.Label();
            this.tabFilmes.SuspendLayout();
            this.tpTodosFilmes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTodosFilmes)).BeginInit();
            this.tpPesquisaGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGenero)).BeginInit();
            this.tpPesquisaAno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFilmes
            // 
            this.tabFilmes.Controls.Add(this.tpTodosFilmes);
            this.tabFilmes.Controls.Add(this.tpPesquisaGenero);
            this.tabFilmes.Controls.Add(this.tpPesquisaAno);
            this.tabFilmes.Location = new System.Drawing.Point(13, 13);
            this.tabFilmes.Name = "tabFilmes";
            this.tabFilmes.SelectedIndex = 0;
            this.tabFilmes.Size = new System.Drawing.Size(613, 425);
            this.tabFilmes.TabIndex = 0;
            // 
            // tpTodosFilmes
            // 
            this.tpTodosFilmes.Controls.Add(this.dtgTodosFilmes);
            this.tpTodosFilmes.Location = new System.Drawing.Point(4, 22);
            this.tpTodosFilmes.Name = "tpTodosFilmes";
            this.tpTodosFilmes.Padding = new System.Windows.Forms.Padding(3);
            this.tpTodosFilmes.Size = new System.Drawing.Size(605, 399);
            this.tpTodosFilmes.TabIndex = 0;
            this.tpTodosFilmes.Text = "Todos os filmes";
            this.tpTodosFilmes.UseVisualStyleBackColor = true;
            // 
            // dtgTodosFilmes
            // 
            this.dtgTodosFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTodosFilmes.Location = new System.Drawing.Point(7, 7);
            this.dtgTodosFilmes.Name = "dtgTodosFilmes";
            this.dtgTodosFilmes.Size = new System.Drawing.Size(595, 386);
            this.dtgTodosFilmes.TabIndex = 0;
            // 
            // tpPesquisaGenero
            // 
            this.tpPesquisaGenero.Controls.Add(this.lblSelecGen);
            this.tpPesquisaGenero.Controls.Add(this.cmbGenero);
            this.tpPesquisaGenero.Controls.Add(this.dtgGenero);
            this.tpPesquisaGenero.Location = new System.Drawing.Point(4, 22);
            this.tpPesquisaGenero.Name = "tpPesquisaGenero";
            this.tpPesquisaGenero.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisaGenero.Size = new System.Drawing.Size(605, 399);
            this.tpPesquisaGenero.TabIndex = 1;
            this.tpPesquisaGenero.Text = "Pesquisa por gênero";
            this.tpPesquisaGenero.UseVisualStyleBackColor = true;
            // 
            // lblSelecGen
            // 
            this.lblSelecGen.AutoSize = true;
            this.lblSelecGen.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.lblSelecGen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelecGen.Location = new System.Drawing.Point(126, 29);
            this.lblSelecGen.Name = "lblSelecGen";
            this.lblSelecGen.Size = new System.Drawing.Size(144, 20);
            this.lblSelecGen.TabIndex = 3;
            this.lblSelecGen.Text = "Selecione o gênero:";
            // 
            // cmbGenero
            // 
            this.cmbGenero.Font = new System.Drawing.Font("Noto Sans Cond", 9.749999F);
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(276, 28);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(202, 26);
            this.cmbGenero.TabIndex = 2;
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.cmbGenero_SelectedIndexChanged);
            // 
            // dtgGenero
            // 
            this.dtgGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGenero.Location = new System.Drawing.Point(5, 77);
            this.dtgGenero.Name = "dtgGenero";
            this.dtgGenero.Size = new System.Drawing.Size(595, 315);
            this.dtgGenero.TabIndex = 1;
            // 
            // tpPesquisaAno
            // 
            this.tpPesquisaAno.Controls.Add(this.dataGridView1);
            this.tpPesquisaAno.Controls.Add(this.mtxtDigitAno);
            this.tpPesquisaAno.Controls.Add(this.lblDigitAno);
            this.tpPesquisaAno.Location = new System.Drawing.Point(4, 22);
            this.tpPesquisaAno.Name = "tpPesquisaAno";
            this.tpPesquisaAno.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisaAno.Size = new System.Drawing.Size(605, 399);
            this.tpPesquisaAno.TabIndex = 2;
            this.tpPesquisaAno.Text = "Pesquisa por ano";
            this.tpPesquisaAno.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 320);
            this.dataGridView1.TabIndex = 6;
            // 
            // mtxtDigitAno
            // 
            this.mtxtDigitAno.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.mtxtDigitAno.Location = new System.Drawing.Point(323, 28);
            this.mtxtDigitAno.Mask = "9999";
            this.mtxtDigitAno.Name = "mtxtDigitAno";
            this.mtxtDigitAno.Size = new System.Drawing.Size(46, 25);
            this.mtxtDigitAno.TabIndex = 5;
            this.mtxtDigitAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDigitAno.Click += new System.EventHandler(this.mtxtDigitAno_Click);
            this.mtxtDigitAno.Leave += new System.EventHandler(this.mtxtDigitAno_Leave);
            // 
            // lblDigitAno
            // 
            this.lblDigitAno.AutoSize = true;
            this.lblDigitAno.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.lblDigitAno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDigitAno.Location = new System.Drawing.Point(220, 29);
            this.lblDigitAno.Name = "lblDigitAno";
            this.lblDigitAno.Size = new System.Drawing.Size(97, 20);
            this.lblDigitAno.TabIndex = 4;
            this.lblDigitAno.Text = "Digite o ano:";
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.tabFilmes);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCatalogo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catálogo de Filmes";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            this.tabFilmes.ResumeLayout(false);
            this.tpTodosFilmes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTodosFilmes)).EndInit();
            this.tpPesquisaGenero.ResumeLayout(false);
            this.tpPesquisaGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGenero)).EndInit();
            this.tpPesquisaAno.ResumeLayout(false);
            this.tpPesquisaAno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFilmes;
        private System.Windows.Forms.TabPage tpTodosFilmes;
        private System.Windows.Forms.TabPage tpPesquisaGenero;
        private System.Windows.Forms.DataGridView dtgTodosFilmes;
        private System.Windows.Forms.Label lblSelecGen;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.DataGridView dtgGenero;
        private System.Windows.Forms.TabPage tpPesquisaAno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mtxtDigitAno;
        private System.Windows.Forms.Label lblDigitAno;
    }
}