using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace flexnit
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void pbxUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void pbxSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Focus();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtSenha_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.PasswordChar -= '*';
                txtSenha.Text = "Senha";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show("Aqui é o login!!!");
            if(txtUsername.Text == "admin")
            {
                frmMenuAdmin formAdmin = new frmMenuAdmin();
                this.Hide();
                formAdmin.ShowDialog();
            }
            else if (!String.IsNullOrWhiteSpace(txtUsername.Text) && txtUsername.Text != "admin")
            {
                frmMenuUser formMenuUsuario = new frmMenuUser();
                this.Hide();
                formMenuUsuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Insira um usuário!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Activate();
            this.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("Aqui é o cadastro!!!");
            frmCadastro formCadastro = new frmCadastro();
            this.Hide();
            formCadastro.ShowDialog();
            this.Activate();
            this.Show();
        }

    }
}
