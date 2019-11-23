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
    public partial class frmCatalogo : Form
    {
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            carregaFilmes();
            CarregaComboBoxGen();
        }
        private void txtSelecAno_Click(object sender, EventArgs e)
        {
            txtSelecAno.SelectAll();
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

        private void CarregaComboBoxGen()
        {
            ClassControl.conectar();
            string sql = "SELECT COUNT(*) FROM genero";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, ClassControl.cn);
            sql = "SELECT nome_gen FROM genero";
            cmd.CommandText = sql;
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                cmbGeneros.Items.Add("---");
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        cmbGeneros.Items.Add(dr.GetString(i));

                    }
                }
            }
            dr.Close();
        }
        private void cmbGeneros_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(cmbGeneros.SelectedItem.ToString()))
            {
                try
                {
                    
                    string sql;
                    int gen = cmbGeneros.SelectedIndex;
                    sql = "SELECT f.titulo_filme, f.descricao_filme, f.ano_filme, g.nome_gen FROM filmes AS f, genero AS g WHERE f.id_genero = g.id_genero AND g.id_genero = " + gen;


                    DataTable dt = new DataTable();

                    dt = ClassControl.selecionarDataTable(sql);

                    dtgFilmesGen.DataSource = dt;
                }
                catch (Exception ex)
                {
                    /*MessageBox.Show("Ocorreu um erro ao processar o comando!" +
                                    "\n\nMais informações:" + ex.Message,
                               "FlexNit",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);*/
                    throw new ApplicationException(ex.Message);

                }
            }
        }

        private void txtSelecAno_Validating(object sender, CancelEventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtSelecAno.Text) && txtSelecAno.Text != "____")
            {
                try
                {

                    string sql;
                    double ano = Convert.ToDouble(txtSelecAno.Text);
                    sql = "SELECT f.titulo_filme, f.descricao_filme, f.ano_filme, g.nome_gen FROM filmes AS f, genero AS g WHERE f.id_genero = g.id_genero AND f.ano_filme = " + ano;


                    DataTable dt = new DataTable();

                    dt = ClassControl.selecionarDataTable(sql);

                    dtgFilmesAno.DataSource = dt;
                }
                catch (Exception ex)
                {
                    /*MessageBox.Show("Ocorreu um erro ao processar o comando!" +
                                    "\n\nMais informações:" + ex.Message,
                               "FlexNit",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);*/
                    throw new ApplicationException(ex.Message);

                }
            }

        }
    }
}
