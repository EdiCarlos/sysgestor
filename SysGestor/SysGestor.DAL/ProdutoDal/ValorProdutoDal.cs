using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.ProdutoDto;
using SysGestor.DTO.ProdutoDto.ProdutoGridDto;
using SysGestor.RESOURCE.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DAL.ProdutoDal
{
    public class ValorProdutoDal
    {
        public void Inserir(ValorProdutoDto valorProdutoDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "INSERT INTO valorproduto(idproduto, valorcompra, valorvenda, margem, comissao) " +
                                      "VALUES (@IdProduto, @ValorCompra, @ValorVenda, @Margem, @Comissao)";

                        comando.Parameters.AddWithValue("@IdProduto", valorProdutoDto.ProdutoDto.Id);
                        comando.Parameters.AddWithValue("@ValorCompra", valorProdutoDto.ValorCompra);
                        comando.Parameters.AddWithValue("@ValorVenda", valorProdutoDto.ValorVenda);
                        comando.Parameters.AddWithValue("@Margem", valorProdutoDto.Margem);
                        comando.Parameters.AddWithValue("@Comissao", valorProdutoDto.Comissao);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
            }
        }

        public void Alterar(ValorProdutoDto valorProdutoDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE valorproduto SET valorcompra = @ValorCompra, valorvenda = @ValorVenda, " + 
                                      "margem = @Margem, comissao = @Comissao " +
                                      "WHERE idproduto = @IdProduto";

                comando.Parameters.AddWithValue("@ValorCompra", valorProdutoDto.ValorCompra);
                comando.Parameters.AddWithValue("@ValorVenda", valorProdutoDto.ValorVenda);
                comando.Parameters.AddWithValue("@Margem", valorProdutoDto.Margem);
                comando.Parameters.AddWithValue("@Margem", valorProdutoDto.Comissao);
                comando.Parameters.AddWithValue("@IdProduto", valorProdutoDto.ProdutoDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public ValorProdutoDto GetValorProdutoById(int idValorProduto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idvalorprod, valorcompra, valorvenda, margem, comissao " +
                                      " FROM valorproduto " +
                                      " WHERE idvalorprod = @IdValorProd ";

                comando.Parameters.AddWithValue("@IdValorProd", idValorProduto);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var valorProduto = new ValorProdutoDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        valorProduto.Id = (int)dr["idvalorprod"];
                        valorProduto.ValorCompra = (double)dr["valorcompra"];
                        valorProduto.ValorVenda = (double)dr["valorvenda"];
                        valorProduto.Comissao = (decimal)dr["comissao"];
                    }
                }
                else
                {
                    valorProduto = null;
                }
                return valorProduto;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public List<ValorProdutoGridDto> FindAll()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.idvalorprod, A.valorcompra, A.valorvenda, A.margem, A.comissao, B.idproduto, B.descricao " + 
                                      "FROM valorproduto A " +
                                      "INNER JOIN produto B ON A.idvalorprod = B.idvalorproduto " +
                                      "WHERE B.ativo = 0 ";

                MySqlDataReader dr = Conexao.Buscar(comando);

                var listaValorProduto = new List<ValorProdutoGridDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var valorProdutoGrid = new ValorProdutoGridDto();
                      
                        valorProdutoGrid.Id = (int)dr["idvalorprod"];
                        valorProdutoGrid.ValorCompra = (double)dr["valorcompra"];
                        valorProdutoGrid.ValorVenda = (double)dr["valorvenda"];
                        valorProdutoGrid.Margem = (decimal)dr["margem"];
                        valorProdutoGrid.Comissao = (decimal)dr["comissao"];
                        valorProdutoGrid.Id = (int)dr["idproduto"];
                        valorProdutoGrid.DescricaoProduto = (string)dr["descricao"];

                        listaValorProduto.Add(valorProdutoGrid);
                    }
                }
                else
                {
                    listaValorProduto = null;
                }
                return listaValorProduto;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }
    }
}
