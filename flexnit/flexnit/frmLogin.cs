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
using Controle;
using Npgsql;


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
            frmMenuUser formMenuUsuario = new frmMenuUser(txtLoginUsername.Text);

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Parameters.AddWithValue("@EmailOrUser", txtLoginUsername.Text);
            cmd.Parameters.AddWithValue("@LoginPwd", txtLoginSenha.Text);
            try
            {
                ClassControl.conectar();
                string sqlLogin = "SELECT * FROM cliente " +
                "WHERE (email_cliente = @EmailOrUser OR username_cliente = @EmailOrUser) AND senha_cliente = @LoginPwd";
                cmd.CommandText = sqlLogin;
                cmd.Connection = ClassControl.cn;
                NpgsqlDataReader dr = cmd.ExecuteReader();
                bool logged = dr.HasRows;
                if (logged)
                {
                    MessageBox.Show("Login efetuado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    formMenuUsuario.Show();
                }
                else
                {
                    MessageBox.Show("Credencias erradas ou usuário inesistente","Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch(NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                ClassControl.desconectar();
            }

            /*  MessageBox.Show("Aqui é o login!!!");
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
            this.Activate();
            this.Show();
             */


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
