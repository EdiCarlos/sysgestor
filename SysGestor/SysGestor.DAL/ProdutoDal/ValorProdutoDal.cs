﻿using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.Produto;
using SysGestor.DTO.Produto.ProdutoGridDto;
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
                comando.CommandText = "INSERT INTO valorproduto(idproduto, valorcompra, valorvenda, margem, comissao, valorprazo, valorcartao, margemprazo, margemcartao) " +
                              "VALUES (@IdProduto, @ValorCompra, @ValorVenda, @Margem, @Comissao, @ValorPrazo, @ValorCartao, @MargemPrazo, @MargemCartao)";

                comando.Parameters.AddWithValue("@IdProduto", valorProdutoDto.ProdutoDto.Id);
                comando.Parameters.AddWithValue("@ValorCompra", valorProdutoDto.ValorCompra);
                comando.Parameters.AddWithValue("@ValorVenda", valorProdutoDto.ValorVenda);
                comando.Parameters.AddWithValue("@Margem", valorProdutoDto.Margem);
                comando.Parameters.AddWithValue("@Comissao", valorProdutoDto.Comissao);
                comando.Parameters.AddWithValue("@ValorPrazo", valorProdutoDto.ValorPrazo);
                comando.Parameters.AddWithValue("@ValorCartao", valorProdutoDto.ValorCartao);
                comando.Parameters.AddWithValue("@MargemPrazo", valorProdutoDto.MargemPrazo);
                comando.Parameters.AddWithValue("@MargemCartao", valorProdutoDto.MargemCartao);

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
                                      "margem = @Margem, comissao = @Comissao, valorprazo = @ValorPrazo, valorcartao = @ValorCartao, " +
                                      "margemprazo = @MargemPrazo, margemcartao = @MargemCartao " +
                                      "WHERE idproduto = @IdProduto";

                comando.Parameters.AddWithValue("@ValorCompra", valorProdutoDto.ValorCompra);
                comando.Parameters.AddWithValue("@ValorVenda", valorProdutoDto.ValorVenda);
                comando.Parameters.AddWithValue("@Margem", valorProdutoDto.Margem);
                comando.Parameters.AddWithValue("@Comissao", valorProdutoDto.Comissao);
                comando.Parameters.AddWithValue("@ValorPrazo", valorProdutoDto.ValorPrazo);
                comando.Parameters.AddWithValue("@ValorCartao", valorProdutoDto.ValorCartao);
                comando.Parameters.AddWithValue("@MargemPrazo", valorProdutoDto.MargemPrazo);
                comando.Parameters.AddWithValue("@MargemCartao", valorProdutoDto.MargemCartao);
                comando.Parameters.AddWithValue("@IdProduto", valorProdutoDto.ProdutoDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public ValorProdutoDto GetValorProdutoById(int IdProduto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idvalorprod, valorcompra, valorvenda, margem, comissao, valorprazo, valorcartao, margemprazo, margemcartao " +
                                      " FROM valorproduto " +
                                      " WHERE idproduto = @IdProduto ";

                comando.Parameters.AddWithValue("@IdProduto", IdProduto);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var valorProduto = new ValorProdutoDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        valorProduto.Id = Convert.ToInt32(Convert.IsDBNull(dr["idvalorprod"]) ? null : dr["idvalorprod"]);
                        valorProduto.ValorCompra = Convert.ToDouble(Convert.IsDBNull(dr["valorcompra"]) ? null : dr["valorcompra"]);
                        valorProduto.ValorVenda = Convert.ToDouble(Convert.IsDBNull(dr["valorvenda"]) ? null : dr["valorvenda"]);
                        valorProduto.Margem = Convert.ToDecimal(Convert.IsDBNull(dr["margem"]) ? null : dr["margem"]);
                        valorProduto.Comissao = Convert.ToDecimal(Convert.IsDBNull(dr["comissao"]) ? null : dr["comissao"]);
                        valorProduto.ValorPrazo = Convert.ToDouble(Convert.IsDBNull(dr["valorprazo"]) ? null : dr["valorprazo"]);
                        valorProduto.ValorCartao = Convert.ToDouble(Convert.IsDBNull(dr["valorcartao"]) ? null : dr["valorcartao"]);
                        valorProduto.MargemPrazo = Convert.ToDecimal(Convert.IsDBNull(dr["margemprazo"]) ? null : dr["margemprazo"]);
                        valorProduto.MargemCartao = Convert.ToDecimal(Convert.IsDBNull(dr["margemcartao"]) ? null : dr["margemcartao"]);
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
                comando.CommandText = "SELECT A.idvalorprod, A.valorcompra, A.valorvenda, A.margem, A.comissao, A.valorprazo, " + 
                                      "A.valorcartao, A.margemprazo, A.margemcartao, B.idproduto, B.descricao " +
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
                        valorProdutoGrid.MargemPrazo = (decimal)dr["margemprazo"];
                        valorProdutoGrid.MargemCartao = (decimal)dr["margemcartao"];
                        valorProdutoGrid.ValorPrazo = (double)dr["valorprazo"];
                        valorProdutoGrid.ValorCartao = (double)dr["valorcartao"];
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
