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
            if (txtLoginUsername.Text == "Username")
            {
                txtLoginUsername.Text = "";
            }
            else
                txtLoginUsername.SelectAll();
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
            if(txtLoginSenha.Text == "Senha")
            {
                txtLoginSenha.Text = "";
                txtLoginSenha.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Parameters.AddWithValue("@EmailOrUser", txtLoginUsername.Text);
            cmd.Parameters.AddWithValue("@LoginPwd", txtLoginSenha.Text);
            
            try
            {
                ClassControl.conectar();
                string sqlLogin = "SELECT * FROM admin " +
                    "WHERE (email_admin =  @EmailOrUser OR user_admin = @EmailOrUser) AND senha_admin = @LoginPwd";
                cmd.CommandText = sqlLogin;
                cmd.Connection = ClassControl.cn;
                NpgsqlDataReader dr = cmd.ExecuteReader();
                bool IsAdmin = dr.HasRows;
                if (IsAdmin)
                {
                    ClassControl.desconectar();
                    this.Hide();
                    frmMenuAdmin formAdmin = new frmMenuAdmin();
                    formAdmin.Show();
                }
                else
                {
                    dr.Close();
                    sqlLogin = "SELECT * FROM cliente " +
                    "WHERE (email_cliente = @EmailOrUser OR username_cliente = @EmailOrUser) AND senha_cliente = @LoginPwd";
                    cmd.CommandText = sqlLogin;
                    cmd.Connection = ClassControl.cn;
                    dr = cmd.ExecuteReader();
                    bool logged = dr.HasRows;
                    if (logged)
                    {
                        ClassControl.desconectar();
                        MessageBox.Show("Login efetuado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frmMenuUser formMenuUsuario = new frmMenuUser(txtLoginUsername.Text);
                        formMenuUsuario.ShowDialog();
                        this.Activate();
                        this.Show();
                    }
                    else
                    {
                        if (txtLoginUsername.Text != "admin" && txtLoginSenha.Text != "admin")
                            MessageBox.Show("Credencias erradas ou usuário inesistente", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClassControl.desconectar();
                    }
                }
               
            }
            catch(NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }


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

        private void pbxFundo_Click(object sender, EventArgs e)
        {

        }
    }
}
