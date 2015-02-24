using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.AuthenticationDTO;
using SysGestor.RESOURCE.Resources;
using System;
using System.Data;

namespace SysGestor.DAL.AuthenticationDAL
{
    public class AuthenticationDal
    {
        public void GetByUsuario(string usuario)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idusuario, login" +
                                      "FROM usuario " +
                                      "WHERE login = @Login";

                comando.Parameters.AddWithValue("@Login", usuario);

                MySqlDataReader dr = Conexao.Buscar(comando);

                if (dr.HasRows)
                {                  
                    while (dr.Read())
                    {
                        AuthenticationDto.Id = Convert.ToInt32(Convert.IsDBNull(dr["idusuario"]) ? null : dr["idusuario"]);
                        AuthenticationDto.Usuario = Convert.ToString(Convert.IsDBNull(dr["login"]) ? null : dr["login"]);
                    }
                }              
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public void Authentication(string usuario, string senha)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idusuario, login " +
                                      "FROM usuario " +
                                      "WHERE login = @Login AND senha = @Senha";

                comando.Parameters.AddWithValue("@Login", usuario);
                comando.Parameters.AddWithValue("@Senha", senha);

                MySqlDataReader dr = Conexao.Buscar(comando);

                if (dr.HasRows)
                {
                    AuthenticationDto.Autenticado = true;
                    while (dr.Read())
                    {
                        AuthenticationDto.Id = Convert.ToInt32(Convert.IsDBNull(dr["idusuario"]) ? null : dr["idusuario"]);
                        AuthenticationDto.Usuario = Convert.ToString(Convert.IsDBNull(dr["login"]) ? null : dr["login"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }
    }
}
