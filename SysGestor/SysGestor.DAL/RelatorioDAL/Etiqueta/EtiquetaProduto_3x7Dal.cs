using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.RelatorioDto.Etiqueta;
using SysGestor.RESOURCE.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DAL.RelatorioDAL.Etiqueta
{
    public class EtiquetaProduto_3x7Dal
    {
        public EtiquetaProduto_3x7Collection FindAll(string searchType, object filter)
        {
            string pesquisa = "";

            if (searchType == "Descricao" && filter != "")
                pesquisa = "WHERE descricao LIKE '%" + filter + "%'";

            if (searchType == "Codigo" && filter != "")
                pesquisa = "WHERE idproduto LIKE '%" + filter + "%'";

            if (searchType == "CodigoBarra" && filter != "")
                pesquisa = "WHERE codigointerno LIKE '%" + filter + "%'";

            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * " +
                                      "FROM vwetiqueta " + pesquisa;

                MySqlDataReader dr = Conexao.Buscar(comando);

                var lista = new EtiquetaProduto_3x7Collection();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var etiqueta = new EtiquetaProduto_3x7Dto();

                        etiqueta.Id = Convert.ToInt32(System.Convert.IsDBNull(dr["idproduto"]) ? null : dr["idproduto"]);
                        etiqueta.CodigoBarra = Convert.ToString(System.Convert.IsDBNull(dr["codigointerno"]) ? null : dr["codigointerno"]);
                        etiqueta.Descricao = Convert.ToString(System.Convert.IsDBNull(dr["descricao"]) ? null : dr["descricao"]);
                        etiqueta.PrecoVista = Convert.ToDouble(System.Convert.IsDBNull(dr["valorvenda"]) ? null : dr["valorvenda"]);
                        etiqueta.PrecoPrazo = Convert.ToDouble(System.Convert.IsDBNull(dr["valorprazo"]) ? null : dr["valorprazo"]);
                        etiqueta.PrecoCartao = Convert.ToDouble(System.Convert.IsDBNull(dr["valorcartao"]) ? null : dr["valorcartao"]);
                        etiqueta.IdEmpresa = Convert.ToInt32(System.Convert.IsDBNull(dr["idempresa"]) ? null : dr["idempresa"]);
                        etiqueta.Empresa = Convert.ToString(System.Convert.IsDBNull(dr["nomefantasia"]) ? null : dr["nomefantasia"]);

                        lista.Add(etiqueta);
                    }
                }
                else
                {
                    lista = null;
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }
    }
}
