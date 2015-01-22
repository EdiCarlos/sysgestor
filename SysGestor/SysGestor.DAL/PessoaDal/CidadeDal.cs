using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.PessoaDto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DAL.PessoaDal
{
    public class CidadeDal
    {
        public IList<CidadeDto> Find()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT  idcidade, cidade, uf " +
                                      "FROM cidades ";

                MySqlDataReader dr = Conexao.Buscar(comando);

                var lista = new List<CidadeDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var cidade = new CidadeDto();

                        cidade.Id = (int)dr["idcidade"];
                        cidade.Cidade = (string)dr["cidade"];
                        cidade.Uf = (string)dr["uf"];
                      
                        lista.Add(cidade);

                    }
                }
                else
                {
                    lista = null;
                }
                return lista;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao buscar dados. " + ex.Message);
            }
        }

        public IList<CidadeDto> FindUf()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT DISTINCT uf " +
                                      "FROM cidades ";

                MySqlDataReader dr = Conexao.Buscar(comando);

                var lista = new List<CidadeDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var cidade = new CidadeDto();

                        cidade.Uf = (string)dr["uf"];

                        lista.Add(cidade);

                    }
                }
                else
                {
                    lista = null;
                }
                return lista;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao buscar dados. " + ex.Message);
            }
        }

        public IList<CidadeDto> FindCidade(string uf)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idcidade, cidade " +
                                      "FROM cidades WHERE uf = @Uf";

                comando.Parameters.AddWithValue("@Uf", uf);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var lista = new List<CidadeDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var cidade = new CidadeDto();

                        cidade.Id = (int)dr["idcidade"];
                        cidade.Cidade = (string)dr["cidade"];

                        lista.Add(cidade);

                    }
                }
                else
                {
                    lista = null;
                }
                return lista;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao buscar dados. " + ex.Message);
            }
        }

    }
}
