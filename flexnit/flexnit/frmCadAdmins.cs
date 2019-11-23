using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;
using Npgsql;
namespace flexnit
{
    public partial class frmCadAdmins : Form
    {
        public frmCadAdmins()
        {
            InitializeComponent();
        }

        private void btnCadCadastrarAdmin_Click(object sender, EventArgs e)
        {
            ClassControl.conectar();
            if(txtCadPwdAdmin.Text == txtCadConfirmPwdAdmin.Text)
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Parameters.AddWithValue("@NomeAdmin", txtCadNomeAdmin.Text);
                cmd.Parameters.AddWithValue("@UserAdmin", txtCadUsernameAdmin.Text);
                cmd.Parameters.AddWithValue("@EmailAdmin", txtCadEmailAdmin.Text);
                cmd.Parameters.AddWithValue("@PwdAdmin", txtCadPwdAdmin.Text);
                try
                {
                    string sql = "SELECT * FROM admin WHERE user_admin=@UserAdmin OR email_admin=@EmailAdmin";
                    cmd.CommandText = sql;
                    cmd.Connection = ClassControl.cn;
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    bool AdminAlreadyExists = dr.HasRows;
                    if (AdminAlreadyExists)
                    {
                        MessageBox.Show("Username ou Email Já cadastrados no sistema!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dr.Close();
                        sql = "INSERT INTO admin(nome_admin, user_admin, email_admin, senha_admin) " +
                        "VALUES (@NomeAdmin,@UserAdmin,@EmailAdmin,@PwdAdmin)";
                        try
                        {
                            cmd.CommandText = sql;
                            cmd.Connection = ClassControl.cn;
                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {

                                MessageBox.Show("Administrador Cadastrado com sucesso!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (NpgsqlException ex)
                        {
                            throw new ApplicationException(ex.Message);
                        }

                    }
                    
                }catch(NpgsqlException ex)
                {
                    throw new ApplicationException(ex.Message);
                }
                finally
                {
                    ClassControl.desconectar();
                }
                
            }
            else
            {
                MessageBox.Show("Senhas não conferem", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblCadSairAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxCadSairAdmin_Click(object sender, EventArgs e)
        {
            lblCadSairAdmin_Click(sender, e);
        }
    }
}
