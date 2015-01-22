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
        public IList<CidadeDto> FindById()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT  idcidade, cidade, uf " +
                                      "FROM cidade ";

                MySqlDataReader dr = Conexao.Buscar(comando);

                var listaCidade = new List<CidadeDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var cidade = new CidadeDto();

                        cidade.Id = (int)dr["idcidade"];
                        cidade.Cidade = (string)dr["cidade"];
                        cidade.Uf = (string)dr["uf"];
                      
                        listaCidade.Add(cidade);

                    }
                }
                else
                {
                    listaCidade = null;
                }
                return listaCidade;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao buscar dados. " + ex.Message);
            }
        }
    }
}
