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
        public frmMinhaConta()
        {
            InitializeComponent();
        }
        
        private void completaSQL()
        {
            ClassControl.conectar();
            try
            {
                string sql = "SELECT c.nome_cliente,c.email_cliente,c.username_cliente, c.estado_cliente FROM cliente AS c";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = ClassControl.cn;
                NpgsqlDataReader dr_myAccount = cmd.ExecuteReader();
                if (dr_myAccount.Read())
                {
                    txtContaNome.Text = dr_myAccount[0].ToString();
                    txtContaEmail.Text = dr_myAccount[1].ToString();
                    txtContaUsername.Text = dr_myAccount[2].ToString();
                    txtContaEstado.Text = dr_myAccount[3].ToString();
                }
            }
            catch(NpgsqlException Ex)
            {
                throw new ApplicationException(Ex.Message);
            }
            finally
            {
                ClassControl.desconectar();
            }
            
            
        }
        /*private void carregaHist()
        {
            string sql = "SELECT h.nome_filme, h.username_cliente, FROM filmes_assistidos AS h, filmes AS f, cliente AS c WHERE h.id_cliente = c.id_cliente AND h.id_filme = f.id_filme ";
            DataTable dt = new DataTable();

            dt = ClassControl.selecionarDataTable(sql);

            dtgHist.DataSource = dt;
        }*/
        private void frmMinhaConta_Load(object sender, EventArgs e)
        {
            completaSQL();
            //carregaHist();
        }
    }
}
