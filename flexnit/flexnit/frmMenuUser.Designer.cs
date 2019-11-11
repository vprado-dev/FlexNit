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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuUser));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssNomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssAux = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssAux2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLogout = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSaida = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
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
            // lblSaida
            // 
            this.lblSaida.BackColor = System.Drawing.Color.RosyBrown;
            this.lblSaida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSaida.Location = new System.Drawing.Point(754, 9);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(34, 23);
            this.lblSaida.TabIndex = 1;
            this.lblSaida.Text = "X";
            this.lblSaida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaida.Click += new System.EventHandler(this.lblSaida_Click);
            this.lblSaida.MouseEnter += new System.EventHandler(this.lblSaida_MouseEnter);
            this.lblSaida.MouseLeave += new System.EventHandler(this.lblSaida_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(106, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver dados cadastrados";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(457, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "Confirmar escolha";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // frmMenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSaida);
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
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}