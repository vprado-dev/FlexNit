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
    public partial class frmMenuAdmin : Form
    {
        frmCadFilmes FormCadFilme = new frmCadFilmes();
        frmCadGenero FormCadGenero = new frmCadGenero();
        frmCadAdmins FormCadAdmin = new frmCadAdmins();
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void frmMenuAdmin_Load(object sender, EventArgs e)
        {

            carregaFilmes();
            carregaClientes();
        }
        private void carregaClientes()
        {
            string sql = "SELECT c.nome_cliente,c.email_cliente,c.username_cliente, c.estado_cliente FROM cliente AS c";
            DataTable dt = new DataTable();

            dt = ClassControl.selecionarDataTable(sql);

            dtgClientes.DataSource = dt;
        }
        private void carregaFilmes()
        {
            try
            {
                string sql;

                sql = "SELECT f.titulo_filme, f.descricao_filme, f.ano_filme, g.nome_gen FROM" +
                    " filmes AS f, genero AS g WHERE f.id_genero = g.id_genero";

                DataTable dt = new DataTable();

                dt = ClassControl.selecionarDataTable(sql);

                dtgFilmes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o comando!" +
                                "\n\nMais informações:" + ex.Message,
                           "FlexNit",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            }
        }
        private void frmMenuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnCadGen_Click(object sender, EventArgs e)
        {
            FormCadGenero.ShowDialog();

        }

        private void btnCadAdmin_Click(object sender, EventArgs e)
        {
            FormCadAdmin.ShowDialog();

        }
        private void btnCadProd_Click(object sender, EventArgs e)
        {
            FormCadFilme.ShowDialog();
            this.Activate();
            this.Show();
        }
    }
}
