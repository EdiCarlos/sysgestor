using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SysGestor.DAL.Repositorio
{
    public class Conexao
    {
        public static MySqlConnection Conectar()
        {
            var conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["CNS1"].ConnectionString);
            if (conexao.State != ConnectionState.Open)          
            conexao.Open();
            return conexao;
        }

        public static void Crud(MySqlCommand cm)
        {
            var con = Conectar();
            cm.Connection = con;
            cm.ExecuteNonQuery();
            con.Close();
        }

        public static MySqlDataReader Buscar(MySqlCommand cm)
        {
            var con = Conectar();
            cm.Connection = con;
            var dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }


        public static object Selecionar(MySqlCommand cm)
        {
            var con = Conectar();
            cm.Connection = con;
            var valor = cm.ExecuteScalar();
            return valor;
        }
    }
}
