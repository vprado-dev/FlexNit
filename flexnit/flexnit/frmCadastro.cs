using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flexnit
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void pbxNome_Click(object sender, EventArgs e)
        {
            txtCadNome.Focus();
        }

        private void txtCadNome_Enter(object sender, EventArgs e)
        {
            if (txtCadNome.Text == "Nome")
                txtCadNome.Text = "";
        }

        private void txtCadNome_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCadNome.Text))
            {
                txtCadNome.Text = "Nome";
            }
        }

        private void pbxUsername_Click(object sender, EventArgs e)
        {
            txtCadUsername.Focus();
        }

        private void txtCadUsername_Enter(object sender, EventArgs e)
        {
            if(txtCadUsername.Text == "Username")
                txtCadUsername.Text = "";
        }

        private void txtCadUsername_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCadUsername.Text))
            {
                txtCadUsername.Text = "Username";
            }
        }

        private void pbxEmail_Click(object sender, EventArgs e)
        {
            txtCadEmail.Focus();
        }

        private void txtCadEmail_Enter(object sender, EventArgs e)
        {
            if (txtCadEmail.Text == "Email")
                txtCadEmail.Text = "";
        }

        private void txtCadEmail_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCadEmail.Text))
            {
                txtCadEmail.Text = "Email";
            }
            else if(!txtCadEmail.Text.Contains("@") || !txtCadEmail.Text.Contains("."))
            {
                MessageBox.Show("Email inválido! Já conferiu o '@' ou o '.' ?", "Erro - Email");
            }
        }

        private void pbxSenha_Click(object sender, EventArgs e)
        {
            txtCadPwd.Focus();
        }

        private void txtCadPwd_Enter(object sender, EventArgs e)
        {
            if (txtCadPwd.Text == "Password")
            {
                txtCadPwd.Text = "";
                txtCadPwd.PasswordChar = '*';
            }
        }

        private void txtCadPwd_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCadPwd.Text))
            {
                txtCadPwd.Text = "Password";
                txtCadPwd.PasswordChar -= '*';
            }
        }

        private void pbxConfirmaSenha_Click(object sender, EventArgs e)
        {
            txtCadConfirmPwd.Focus();
        }

        private void txtCadConfirmPwd_Enter(object sender, EventArgs e)
        {
            if(txtCadConfirmPwd.Text == "Confirm Password")
            {
                txtCadConfirmPwd.Text = "";
                txtCadConfirmPwd.PasswordChar = '*';
            }
        }

        private void txtCadConfirmPwd_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCadConfirmPwd.Text))
            {
                txtCadConfirmPwd.Text = "Confirm Password";
                txtCadConfirmPwd.PasswordChar -= '*';
            }
        }
    }
}
