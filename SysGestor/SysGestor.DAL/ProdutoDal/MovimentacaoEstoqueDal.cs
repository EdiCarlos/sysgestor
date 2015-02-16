using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.ProdutoDto;
using SysGestor.RESOURCE.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DAL.ProdutoDal
{
    public class MovimentacaoEstoqueDal
    {
        public void Inserir(MovimentacaoEstoqueDto movimentacaoEstoqueDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO movestoque(iddocumento, qtd, valorcompra, data, observacao, idproduto, idinterno) " +
                                      "VALUES (@IdDocumento, @Qtd, @ValorCompra, @Data, @Observacao, @IdProduto, @IdInterno)";

                comando.Parameters.AddWithValue("@IdDocumento", movimentacaoEstoqueDto.IdDocumento);
                comando.Parameters.AddWithValue("@Qtd", movimentacaoEstoqueDto.Quantidade);
                comando.Parameters.AddWithValue("@ValorCompra", movimentacaoEstoqueDto.ValorCompra);
                comando.Parameters.AddWithValue("@Data", DateTime.Now);
                comando.Parameters.AddWithValue("@Observacao", movimentacaoEstoqueDto.Observacao);
                comando.Parameters.AddWithValue("@IdProduto", movimentacaoEstoqueDto.ProdutoDto.Id);
                comando.Parameters.AddWithValue("@IdInterno", movimentacaoEstoqueDto.ProdutoDto.IdInterno);
               
                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
            }
        }

        public void Alterar(MovimentacaoEstoqueDto movimentacaoEstoqueDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE movestoque SET iddocumento = @IdDocumento, qtd = @Qtd, valorcompra = @ValorCompra, observacao = @Observacao " +
                                      "WHERE idmovestoque = @IdMovEstoque";

                comando.Parameters.AddWithValue("@IdDocumento", movimentacaoEstoqueDto.IdDocumento);
                comando.Parameters.AddWithValue("@Qtd", movimentacaoEstoqueDto.Quantidade);
                comando.Parameters.AddWithValue("@ValorCompra", movimentacaoEstoqueDto.ValorCompra);
                comando.Parameters.AddWithValue("@Observacao", movimentacaoEstoqueDto.Observacao);
                comando.Parameters.AddWithValue("@IdMovEstoque", movimentacaoEstoqueDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public void Remove(int idMovEstoque)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "DELETE FROM movestoque WHERE idmovestoque = @IdMovEstoque";

                comando.Parameters.AddWithValue("@IdMovEstoque", idMovEstoque);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public List<MovimentacaoEstoqueDto> FindAllFilter(string searchType, object filter)
        {
            string pesquisa = "";

            if (searchType == "Documento" && filter != "")
                pesquisa = "WHERE A.iddocumento LIKE '%" + filter + "%'";

            if (searchType == "Produto" && filter != "")
                pesquisa = "WHERE B.descricao LIKE '%" + filter + "%'";

            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.idmovestoque, A.iddocumento, A.qtd, A.valorcompra, A.data, A.observacao, B.descricao as produto " +
                                      "FROM movestoque A " +
                                      "INNER JOIN produto B ON A.idproduto = B.idproduto " + pesquisa;

                MySqlDataReader dr = Conexao.Buscar(comando);

                var lista = new List<MovimentacaoEstoqueDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var movEstoque = new MovimentacaoEstoqueDto();

                        movEstoque.Id = (int)dr["idmovestoque"];
                        movEstoque.IdDocumento = (string)dr["iddocumento"];
                        movEstoque.Quantidade = Convert.ToDecimal(Convert.IsDBNull(dr["qtd"]) ? null : dr["qtd"]);
                        movEstoque.ValorCompra = Convert.ToDouble(Convert.IsDBNull(dr["valorcompra"]) ? null : dr["valorcompra"]);
                        movEstoque.Data = Convert.ToDateTime(Convert.IsDBNull(dr["data"]) ? null : dr["data"]);
                        movEstoque.Observacao = (string)dr["observacao"];
                        movEstoque.DescProduto = (string)dr["produto"];
                        
                        lista.Add(movEstoque);
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
