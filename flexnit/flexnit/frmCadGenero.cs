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
    public partial class frmCadGenero : Form
    {
        public frmCadGenero()
        {
            InitializeComponent();
        }

        private void frmCadGenero_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarGen_Click(object sender, EventArgs e)
        {
            ClassControl.conectar();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Parameters.AddWithValue("@GenFilme", txtGenFilme.Text);
            cmd.Connection = ClassControl.cn;
            try
            {
                string sql = "SELECT * FROM genero WHERE nome_gen = @GenFilme";
                cmd.CommandText = sql;
                NpgsqlDataReader dr = cmd.ExecuteReader();
                bool GenRegistred = dr.HasRows;
                if (GenRegistred)
                {
                    MessageBox.Show("Genero já cadastrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        dr.Close();
                        sql = "INSERT INTO genero(nome_gen) VALUES(@GenFilme)";
                        cmd.CommandText = sql;
                        int Registrou = cmd.ExecuteNonQuery();
                        if (Registrou > 0)
                        {
                            MessageBox.Show("Genero cadastrado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }catch(NpgsqlException ex)
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
    }
}
