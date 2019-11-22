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
    }
}
