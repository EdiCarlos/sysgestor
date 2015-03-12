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
    public class PermissaoDal
    {
        public void Inserir(PermissaoDto permissaoDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO permissao(descricao) " +
                                      "VALUES (@Descricao)";

                comando.Parameters.AddWithValue("@Descricao", permissaoDto.Descricao);
             
                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
            }
        }

        public void Alterar(PermissaoDto permissaoDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE permissao SET descricao = @Descricao, ativo = @Ativo " +
                                      "WHERE idPermissao = @IdPermissao";

                comando.Parameters.AddWithValue("@IdPermissao", permissaoDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public PermissaoDto GetPermissaoById(int idPermissao)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idpermissao, descricao, ativo" +
                                      "FROM permissao " +
                                      "WHERE idpermissao = @IdPermissao";

                comando.Parameters.AddWithValue("@IdPermissao", idPermissao);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var permissao = new PermissaoDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        permissao.Id = (int)dr["idpermissao"];
                        permissao.Descricao = (string)dr["descricao"];
                        permissao.Ativo = (int)dr["ativo"];
                    }
                }
                else
                {
                    permissao = null;
                }
                return permissao;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public List<PermissaoDto> FindAll()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idpermissao, descricao, ativo" +
                                      "FROM permissao " +
                                      "WHERE ativo = 0 ";

                MySqlDataReader dr = Conexao.Buscar(comando);

                var lista = new List<PermissaoDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var permissao = new PermissaoDto();

                        permissao.Id = (int)dr["idpermissao"];
                        permissao.Descricao = (string)dr["descricao"];
                        permissao.Ativo = (int)dr["ativo"];

                        lista.Add(permissao);
                    }
                }
                else
                {
                    lista = null;
                }
                return lista.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public void Remove(int idPermissao)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE permissao SET ativo = 1 WHERE idpermissao = @IdPermissao";

                comando.Parameters.AddWithValue("@IdPermissao", idPermissao);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public void RemoveMass(int[] idPermissao)
        {
            try
            {
                for (int i = 0; i < idPermissao.Length; i++)
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE permissao SET ativo = 1 WHERE idpermissao = @IdPermissao";

                    comando.Parameters.AddWithValue("@IdPermissao", idPermissao);
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
