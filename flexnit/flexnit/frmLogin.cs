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
using flexnitClassControl;

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
            txtLoginUsername.Focus();
        }

        private void pbxSenha_Click(object sender, EventArgs e)
        {
            txtLoginSenha.Focus();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtLoginUsername.Text))
            {
                txtLoginUsername.Text = "Username";
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtLoginUsername.Text = "";
        }

        private void txtSenha_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtLoginSenha.Text))
            {
                txtLoginSenha.PasswordChar -= '*';
                txtLoginSenha.Text = "Senha";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtLoginSenha.Text = "";
            txtLoginSenha.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string sqlLogin = "SELECT clientes(email_cliente, username_cliente, senha_cliente) WHERE login = @nomeUsuario";            //   MessageBox.Show("Aqui é o login!!!");
            frmMenuAdmin formAdmin = new frmMenuAdmin();
            this.Hide();
            formAdmin.ShowDialog();
=======
            //   MessageBox.Show("Aqui é o login!!!");
            if(txtLoginUsername.Text == "admin")
            {
                frmMenuAdmin formAdmin = new frmMenuAdmin();
                this.Hide();
                formAdmin.ShowDialog();
            }
            else if (!String.IsNullOrWhiteSpace(txtLoginUsername.Text) && txtLoginUsername.Text != "admin")
            {
                frmMenuUser formMenuUsuario = new frmMenuUser(txtLoginUsername.Text);
                this.Hide();
                formMenuUsuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Insira um usuário!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
>>>>>>> master
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente sair?", "Saindo?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
