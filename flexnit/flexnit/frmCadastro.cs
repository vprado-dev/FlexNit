using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Controle;

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
            ClassControl.conectar();
            if (txtCadPwd.Text == txtCadConfirmPwd.Text)
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Parameters.AddWithValue("@NameUser", txtCadNome.Text);
                cmd.Parameters.AddWithValue("@Username", txtCadUsername.Text);
                cmd.Parameters.AddWithValue("@email", txtCadEmail.Text);
                cmd.Parameters.AddWithValue("@UserLivingState", cmbCadEstado.SelectedItem);
                cmd.Parameters.AddWithValue("@userpwd", txtCadConfirmPwd.Text);
                try
                {
                    string sql = "SELECT * FROM cliente WHERE email_cliente = @email OR username_cliente = @Username";
                    cmd.CommandText = sql;
                    cmd.Connection = ClassControl.cn;
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    bool Selected = dr.HasRows;
                    
                    if (Selected)
                    {
                        MessageBox.Show("Username ou Email já em uso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        
                        try
                        {
                            dr.Close();
                            sql = "INSERT INTO CLIENTE(nome_cliente, email_cliente, username_cliente, estado_cliente, senha_cliente)" +
                            " VALUES(@NameUser, @email, @Username, @UserLivingState, @userpwd)";

                            cmd.CommandText = sql;
                            cmd.Connection = ClassControl.cn;
                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Cadastro realizado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch(NpgsqlException ex)
                        {
                            throw new ApplicationException(ex.Message);
                        }
                    }

                }
                catch (NpgsqlException sqlError)
                {
                    throw new ApplicationException(sqlError.Message);
                }
                finally
                {
                    ClassControl.desconectar();
                }


            }
            else
            {
                MessageBox.Show("As senhas não conferem", "Senhas não conferem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void pbxCadNome_Click(object sender, EventArgs e)
        {
            txtCadNome.Focus();
        }

        private void txtCadNome_Enter(object sender, EventArgs e)
        {
            if (txtCadNome.Text == "Nome")
                txtCadNome.Text = "";
            else
                txtCadNome.SelectAll();
        }

        private void txtCadNome_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCadNome.Text))
                txtCadNome.Text = "Nome";
        }

        private void pbxCadUsername_Click(object sender, EventArgs e)
        {
            txtCadUsername.Focus();
        }

        private void txtCadUsername_Enter(object sender, EventArgs e)
        {
            if (txtCadUsername.Text == "Username")
                txtCadUsername.Text = "";
            else
                txtCadUsername.SelectAll();
        }

        private void txtCadUsername_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCadUsername.Text))
                txtCadUsername.Text = "Username";
        }

        private void pbxCadEmail_Click(object sender, EventArgs e)
        {
            txtCadEmail.Focus();
        }

        private void txtCadEmail_Enter(object sender, EventArgs e)
        {
            if (txtCadEmail.Text == "Email")
                txtCadEmail.Text = "";
            else
                txtCadEmail.SelectAll();
        }

        private void txtCadEmail_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCadEmail.Text))
                txtCadEmail.Text = "Email";
        }

        private void pbxCadEstado_Click(object sender, EventArgs e)
        {
            cmbCadEstado.Focus();
        }

        private void pbxCadPassword_Click(object sender, EventArgs e)
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
            else
                txtCadPwd.SelectAll();
        }

        private void txtCadPwd_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCadPwd.Text))
            {
                txtCadPwd.PasswordChar -= '*';
                txtCadPwd.Text = "Password";
            }
            else
                txtCadPwd.SelectAll();
        }

        private void pbxCadConfirmPassword_Click(object sender, EventArgs e)
        {
            txtCadEmail.Focus();
        }

        private void txtCadConfirmPwd_Enter(object sender, EventArgs e)
        {
            if (txtCadConfirmPwd.Text == "Confirm Password")
            {
                txtCadConfirmPwd.Text = "";
                txtCadConfirmPwd.PasswordChar = '*';
            }
            else
                txtCadConfirmPwd.SelectAll();
        }

        private void txtCadConfirmPwd_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCadConfirmPwd.Text))
            {
                txtCadConfirmPwd.PasswordChar -= '*';
                txtCadConfirmPwd.Text = "Confirm Password";
            }
        }

        private void lblCadSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxCadSair_Click(object sender, EventArgs e)
        {
            lblCadSair_Click(sender, e);
        }
    }
}
