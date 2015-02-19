using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.Produto;
using SysGestor.RESOURCE.Resources;
using System;
using System.Collections.Generic;
using System.Data;

namespace SysGestor.DAL.ProdutoDal
{
    public class UnidadeDal
    {
        public void Inserir(UnidadeDto unidadeDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO unidmedida(descricao) " +
                                      "VALUES (@Descricao)";

                comando.Parameters.AddWithValue("@Descricao", unidadeDto.Descricao);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
            }
        }

        public void Alterar(UnidadeDto unidadeDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE unidmedida SET descricao = @Descricao WHERE idunidmedida = @IdUnidMedida ";

                comando.Parameters.AddWithValue("@Descricao", unidadeDto.Descricao);
                comando.Parameters.AddWithValue("@IdUnidMedida", unidadeDto.IdUnidMedida);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public void Remove(int id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE unidmedida SET ativo = 1 WHERE idunidmedida = @IdUnidMedida";

                comando.Parameters.AddWithValue("@IdUnidMedida", id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public string GetEqualsUnidade(string descricao)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT descricao FROM unidmedida WHERE descricao = @Descricao";

                comando.Parameters.AddWithValue("@Descricao", descricao);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var unidade = "";

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        unidade = (string)dr["descricao"];
                    }
                }
                else
                {
                    unidade = null;
                }
                return unidade;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public List<UnidadeDto> FindAll()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idunidmedida, descricao, ativo FROM unidmedida WHERE ativo = 0";

                MySqlDataReader dr = Conexao.Buscar(comando);

                var listaUnidade = new List<UnidadeDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var unidade = new UnidadeDto();

                        unidade.IdUnidMedida = (int)dr["idunidmedida"];
                        unidade.Descricao = (string)dr["descricao"];
                        unidade.Ativo = (int)dr["ativo"];

                        listaUnidade.Add(unidade);
                    }
                }
                else
                {
                    listaUnidade = null;
                }
                return listaUnidade;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

      
    }
}
