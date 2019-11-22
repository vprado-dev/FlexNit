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
    public partial class frmMinhaConta : Form
    {
        public frmMinhaConta(string username)
        {
            InitializeComponent();
            ClassControl.desconectar();
            txtContaUsername.Text = username;
            buscaSQL(username);
        }
        
        private string buscaSQL(string username)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Parameters.AddWithValue("@username", txtContaUsername.Text);
            string sqlConta;
            try
            {
                ClassControl.conectar();
                sqlConta = "SELECT nome_cliente, email_cliente, estado_cliente FROM cliente WHERE username_cliente = @username";
                cmd.CommandText = sqlConta;
                cmd.Connection = ClassControl.cn;
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                txtContaNome.Text = dr[0].ToString();
                txtContaEmail.Text = dr[1].ToString();
                txtContaEstado.Text = dr[2].ToString();
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                ClassControl.desconectar();
            }
            return sqlConta;
        }
    }
}
