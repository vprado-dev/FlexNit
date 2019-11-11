using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace flexnitClassControl
{
    public static class ClassControl
    {
        //String com os dados de conexão do banco de dados do trabalho
        static string strConnection = "Server = localhost; " +
        "Database = flexnit; Port=5432;" +
        "User ID= postgres; password = postgres;";

        public static NpgsqlConnection cn; //Declarando objeto da classe NpgsqlConnection

        public static void connect()//Func conecta ao banco
        {
            if (cn == null)
                cn = new NpgsqlConnection();
            try
            {
                if(cn.State != System.Data.ConnectionState.Open)
                {
                    cn.ConnectionString = strConnection;
                    cn.Open();
                }
            }
            catch (NpgsqlException exsql)
            {
                throw new ApplicationException(exsql.Message);
            }
        }

        public static void disconnect()//Func. desconcta do banco
        {
            cn.Close(); //Fecha conexão com o banco
            cn.Dispose(); //Libera os recursos utilizados
            cn = null; //seta cn como null para entrar no if da função conexão
        }

        public static void executeQr(string sqlQr)//Func. executa os comandos sql enviados pelo código
        //Essa func. serve para executar uma query no banco (Sem retornos)
        //Tais com: INSERT - UPDATE - DELETE
        {
            try
            {
                connect();
                NpgsqlCommand cmd = new NpgsqlCommand(sqlQr, cn);
                cmd.ExecuteNonQuery();

            }
            catch(NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                disconnect();
            }
        }
    }
}
