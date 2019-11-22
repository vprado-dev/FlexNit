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
            this.tbcCatalogo = new System.Windows.Forms.TabControl();
            this.tabTodos = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPesquisaGen = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmbGeneros = new System.Windows.Forms.ComboBox();
            this.lblSelecGen = new System.Windows.Forms.Label();
            this.tabAno = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txtSelecAno = new System.Windows.Forms.MaskedTextBox();
            this.lblSelecAno = new System.Windows.Forms.Label();
            this.tbcCatalogo.SuspendLayout();
            this.tabTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPesquisaGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabAno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCatalogo
            // 
            this.tbcCatalogo.Controls.Add(this.tabTodos);
            this.tbcCatalogo.Controls.Add(this.tabPesquisaGen);
            this.tbcCatalogo.Controls.Add(this.tabAno);
            this.tbcCatalogo.Location = new System.Drawing.Point(12, 12);
            this.tbcCatalogo.Name = "tbcCatalogo";
            this.tbcCatalogo.SelectedIndex = 0;
            this.tbcCatalogo.Size = new System.Drawing.Size(637, 374);
            this.tbcCatalogo.TabIndex = 0;
            // 
            // tabTodos
            // 
            this.tabTodos.Controls.Add(this.dataGridView1);
            this.tabTodos.Location = new System.Drawing.Point(4, 22);
            this.tabTodos.Name = "tabTodos";
            this.tabTodos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodos.Size = new System.Drawing.Size(629, 348);
            this.tabTodos.TabIndex = 0;
            this.tabTodos.Text = "Todos os filmes";
            this.tabTodos.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(616, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPesquisaGen
            // 
            this.tabPesquisaGen.Controls.Add(this.dataGridView2);
            this.tabPesquisaGen.Controls.Add(this.cmbGeneros);
            this.tabPesquisaGen.Controls.Add(this.lblSelecGen);
            this.tabPesquisaGen.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisaGen.Name = "tabPesquisaGen";
            this.tabPesquisaGen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisaGen.Size = new System.Drawing.Size(629, 348);
            this.tabPesquisaGen.TabIndex = 1;
            this.tabPesquisaGen.Text = "Pesquisa por gênero";
            this.tabPesquisaGen.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(616, 273);
            this.dataGridView2.TabIndex = 2;
            // 
            // cmbGeneros
            // 
            this.cmbGeneros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneros.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.cmbGeneros.FormattingEnabled = true;
            this.cmbGeneros.Location = new System.Drawing.Point(292, 23);
            this.cmbGeneros.Name = "cmbGeneros";
            this.cmbGeneros.Size = new System.Drawing.Size(175, 26);
            this.cmbGeneros.TabIndex = 1;
            // 
            // lblSelecGen
            // 
            this.lblSelecGen.AutoSize = true;
            this.lblSelecGen.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.lblSelecGen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelecGen.Location = new System.Drawing.Point(142, 24);
            this.lblSelecGen.Name = "lblSelecGen";
            this.lblSelecGen.Size = new System.Drawing.Size(144, 20);
            this.lblSelecGen.TabIndex = 0;
            this.lblSelecGen.Text = "Selecione o gênero:";
            // 
            // tabAno
            // 
            this.tabAno.Controls.Add(this.dataGridView3);
            this.tabAno.Controls.Add(this.txtSelecAno);
            this.tabAno.Controls.Add(this.lblSelecAno);
            this.tabAno.Location = new System.Drawing.Point(4, 22);
            this.tabAno.Name = "tabAno";
            this.tabAno.Padding = new System.Windows.Forms.Padding(3);
            this.tabAno.Size = new System.Drawing.Size(629, 348);
            this.tabAno.TabIndex = 2;
            this.tabAno.Text = "Pesquisa por ano";
            this.tabAno.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 69);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(616, 273);
            this.dataGridView3.TabIndex = 3;
            // 
            // txtSelecAno
            // 
            this.txtSelecAno.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.txtSelecAno.Location = new System.Drawing.Point(333, 24);
            this.txtSelecAno.Mask = "9999";
            this.txtSelecAno.Name = "txtSelecAno";
            this.txtSelecAno.Size = new System.Drawing.Size(49, 25);
            this.txtSelecAno.TabIndex = 2;
            this.txtSelecAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSelecAno.Click += new System.EventHandler(this.txtSelecAno_Click);
            // 
            // lblSelecAno
            // 
            this.lblSelecAno.AutoSize = true;
            this.lblSelecAno.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.lblSelecAno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelecAno.Location = new System.Drawing.Point(230, 25);
            this.lblSelecAno.Name = "lblSelecAno";
            this.lblSelecAno.Size = new System.Drawing.Size(97, 20);
            this.lblSelecAno.TabIndex = 1;
            this.lblSelecAno.Text = "Digite o ano:";
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(661, 398);
            this.Controls.Add(this.tbcCatalogo);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "frmCatalogo";
            this.Text = "frmCatalogo";
            this.tbcCatalogo.ResumeLayout(false);
            this.tabTodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPesquisaGen.ResumeLayout(false);
            this.tabPesquisaGen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabAno.ResumeLayout(false);
            this.tabAno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCatalogo;
        private System.Windows.Forms.TabPage tabTodos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPesquisaGen;
        private System.Windows.Forms.ComboBox cmbGeneros;
        private System.Windows.Forms.Label lblSelecGen;
        private System.Windows.Forms.TabPage tabAno;
        private System.Windows.Forms.MaskedTextBox txtSelecAno;
        private System.Windows.Forms.Label lblSelecAno;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}