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
    public partial class frmCadFilmes : Form
    {
        public frmCadFilmes()
        {
            InitializeComponent();
        }

        private void btnCadCadastrarFilme_Click(object sender, EventArgs e)
        {
            ClassControl.conectar();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Parameters.AddWithValue("@NomeFilme", txtNomeFilme.Text);
            cmd.Parameters.AddWithValue("@DescricaoFilme", txtDescricaoFilme.Text);
            cmd.Parameters.AddWithValue("@AnoFilme", Convert.ToInt32(mskAnoFilme.Text));
            cmd.Parameters.AddWithValue("@GenFilme", cmbGeneroFilme.SelectedItem);
            cmd.Connection = ClassControl.cn;
            try
            {
                
                string sql = "SELECT * FROM filmes WHERE titulo_filme = @NomeFilme";
                cmd.CommandText = sql;
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Filme já cadastrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dr.Close();
                    NpgsqlDataReader dr2;
                    string sql2 = "SELECT id_genero FROM genero WHERE nome_gen = @GenFilme";
                    cmd.CommandText = sql2;
                    dr2 = cmd.ExecuteReader();
                    if (dr2.Read())
                    {
                        int id_gen = Convert.ToInt32(dr2["id_genero"]);
                        cmd.Parameters.AddWithValue("@idGenFilme", id_gen);
                    }
                    dr2.Close();
                    sql = "INSERT INTO filmes(titulo_filme,descricao_filme, ano_filme, id_genero)" +
                        " VALUES(@NomeFilme, @DescricaoFilme, @AnoFilme, @idGenFilme)";
                    cmd.CommandText = sql;
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Filme adicionado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
        }

        private void frmCadFilmes_Load(object sender, EventArgs e)
        {
            ClassControl.conectar();
            string sql = "SELECT COUNT(*) FROM genero";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, ClassControl.cn);
            sql = "SELECT nome_gen FROM genero";
            cmd.CommandText = sql;
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                cmbGeneroFilme.Items.Add("---");
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                       cmbGeneroFilme.Items.Add(dr.GetString(i));

                    }
                }
            }
            dr.Close();
            //MessageBox.Show(count.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
