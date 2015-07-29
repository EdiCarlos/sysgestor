using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.PessoaDTO.UsuarioDTO;
using SysGestor.RESOURCE.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SysGestor.DAL.PessoaDal.UsuarioDAL
{
    public class UsuarioDal
    {
        public void Inserir(UsuarioDto usuarioDto, int idPessoa)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO usuario(login, senha, idpessoa) " +
                                      "VALUES (@Login, @Senha, @IdPessoa)";

                comando.Parameters.AddWithValue("@Login", usuarioDto.Login);
                comando.Parameters.AddWithValue("@Senha", usuarioDto.Senha);
                comando.Parameters.AddWithValue("@IdPessoa", idPessoa);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
            }
        }

        public void Alterar(UsuarioDto usuarioDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE usuario SET login = @Login, senha = @Senha " +
                                      "WHERE idusuario = @IdUsuario";

                comando.Parameters.AddWithValue("@Login", usuarioDto.Login);
                comando.Parameters.AddWithValue("@Senha", usuarioDto.Senha);
                comando.Parameters.AddWithValue("@IdUsuario", usuarioDto.IdUsuario);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public UsuarioDto GetUsuarioById(int idUsuario)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.idpessoa, A.nome, A.cpfcnpj, A.rgie, A.datanascimento, A.datacadastro, A.ativo, A.observacao, B.idusuario, B.login, B.senha " +
                                      "FROM pessoa A " +
                                      "INNER JOIN usuario B ON A.idpessoa = B.idpessoa "
                                    + "WHERE B.idusuario = @IdUsuario";

                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var usuario = new UsuarioDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        usuario.Id = Convert.ToInt32(Convert.IsDBNull(dr["idpessoa"]) ? null : dr["idpessoa"]);
                        usuario.Nome = Convert.ToString(Convert.IsDBNull(dr["nome"]) ? null : dr["nome"]);
                        usuario.CpfCnpj = Convert.ToString(Convert.IsDBNull(dr["cpfcnpj"]) ? null : dr["cpfcnpj"]);
                        usuario.RgIe = Convert.ToString(Convert.IsDBNull(dr["rgie"]) ? null : dr["rgie"]);
                        usuario.DataNascimento = Convert.ToDateTime(Convert.IsDBNull(dr["datanascimento"]) ? null : dr["datanascimento"]);
                        usuario.DataCadastro = Convert.ToDateTime(Convert.IsDBNull(dr["datacadastro"]) ? null : dr["datacadastro"]);
                        usuario.Ativo = Convert.ToInt32(Convert.IsDBNull(dr["ativo"]) ? null : dr["ativo"]);
                        usuario.Observacao = Convert.ToString(Convert.IsDBNull(dr["observacao"]) ? null : dr["observacao"]);
                        usuario.IdUsuario = Convert.ToInt32(Convert.IsDBNull(dr["idusuario"]) ? null : dr["idusuario"]);
                        usuario.Login = Convert.ToString(Convert.IsDBNull(dr["login"]) ? null : dr["login"]);
                        usuario.Senha = Convert.ToString(Convert.IsDBNull(dr["senha"]) ? null : dr["senha"]); 
                    }
                }
                else
                {
                    usuario = null;
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public List<UsuarioDto> FindAll()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.idpessoa, A.nome, A.cpfcnpj, A.rgie, A.datanascimento, A.datacadastro, A.ativo, A.observacao, B.idusuario, B.login, B.senha " +
                                      "FROM pessoa A " +
                                      "INNER JOIN usuario B ON A.idpessoa = B.idpessoa " +
                                      "WHERE A.ativo = 0 ";

                MySqlDataReader dr = Conexao.Buscar(comando);

                var listaUsuario = new List<UsuarioDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var usuario = new UsuarioDto();

                        usuario.Id = Convert.ToInt32(Convert.IsDBNull(dr["idpessoa"]) ? null : dr["idpessoa"]);
                        usuario.Nome = Convert.ToString(Convert.IsDBNull(dr["nome"]) ? null : dr["nome"]);
                        usuario.CpfCnpj = Convert.ToString(Convert.IsDBNull(dr["cpfcnpj"]) ? null : dr["cpfcnpj"]);
                        usuario.RgIe = Convert.ToString(Convert.IsDBNull(dr["rgie"]) ? null : dr["rgie"]);
                        usuario.DataNascimento = Convert.ToDateTime(Convert.IsDBNull(dr["datanascimento"]) ? null : dr["datanascimento"]);
                        usuario.DataCadastro = Convert.ToDateTime(Convert.IsDBNull(dr["datacadastro"]) ? null : dr["datacadastro"]); 
                        usuario.Ativo = Convert.ToInt32(Convert.IsDBNull(dr["ativo"]) ? null : dr["ativo"]); 
                        usuario.Observacao = Convert.ToString(Convert.IsDBNull(dr["observacao"]) ? null : dr["observacao"]);
                        usuario.IdUsuario = Convert.ToInt32(Convert.IsDBNull(dr["idusuario"]) ? null : dr["idusuario"]);
                        usuario.Login = Convert.ToString(Convert.IsDBNull(dr["login"]) ? null : dr["login"]);
                        usuario.Senha = Convert.ToString(Convert.IsDBNull(dr["senha"]) ? null : dr["senha"]); 

                        listaUsuario.Add(usuario);

                    }
                }
               
                return listaUsuario.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public void Remove(int idUsuario)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE pessoa SET ativo = 1 WHERE idPessoa = (SELECT idpessoa FROM usuario WHERE idusuario = @IdUsuario)";

                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public void RemoveMass(int[] idUsuario)
        {
            try
            {
                for (int i = 0; i < idUsuario.Length; i++)
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE pessoa SET ativo = 1 WHERE idPessoa = (SELECT idpessoa FROM usuario WHERE idusuario = @IdUsuario)";

                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario[i]);
                    Conexao.Crud(comando);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }
    }
}
