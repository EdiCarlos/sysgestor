﻿using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.ProdutoDto;
using SysGestor.RESOURCE.Resources;
using System;
using System.Collections.Generic;
using System.Data;

namespace SysGestor.DAL.ProdutoDal
{
    public class ProdutoDal
    {
        public void Inserir(ProdutoDto produtoDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO produto(referencia, codigointerno, descricao, estoqueminimo, localizacaofisica, idcategoria, idgrade, idfornecedor) " +
                                      "VALUES (@Referencia, @CodigoInterno, @Descricao, @EstoqueMinimo, @LocalizacaoFisica, @IdCategoria, @IdGrade, @IdFornecedor)";

                comando.Parameters.AddWithValue("@Referencia", produtoDto.Referencia);
                comando.Parameters.AddWithValue("@CodigoInterno", produtoDto.IdInterno);
                comando.Parameters.AddWithValue("@Descricao", produtoDto.Descricao);
                comando.Parameters.AddWithValue("@EstoqueMinimo", produtoDto.EstoqueMinimo);
                comando.Parameters.AddWithValue("@LocalizacaoFisica", produtoDto.LocalizacaoFisica);
                comando.Parameters.AddWithValue("@IdCategoria", produtoDto.CategoriaDto.Id);
                comando.Parameters.AddWithValue("@IdGrade", produtoDto.GradeDto.Id);
                comando.Parameters.AddWithValue("@IdFornecedor", produtoDto.FornecedorDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
            }
        }

        public void Alterar(ProdutoDto produtoDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE produto SET referencia = @Referencia, codigointerno = @CodigoInterno, descricao = @Descricao, estoqueminimo = @EstoqueMinimo, " +  
                                      "localizacaofisica = @LocalizacaoFisica, idcategoria = @IdCategoria, idgrade = @IdGrade, idfornecedor = @IdFornecedor " +
                                      "WHERE idproduto = @IdProduto";

                comando.Parameters.AddWithValue("@Referencia", produtoDto.Referencia);
                comando.Parameters.AddWithValue("@CodigoInterno", produtoDto.IdInterno);
                comando.Parameters.AddWithValue("@Descricao", produtoDto.Descricao);
                comando.Parameters.AddWithValue("@EstoqueMinimo", produtoDto.EstoqueMinimo);
                comando.Parameters.AddWithValue("@LocalizacaoFisica", produtoDto.LocalizacaoFisica);
                comando.Parameters.AddWithValue("@IdCategoria", produtoDto.CategoriaDto.Id);
                comando.Parameters.AddWithValue("@IdGrade", produtoDto.GradeDto.Id);
                comando.Parameters.AddWithValue("@IdFornecedor", produtoDto.FornecedorDto.Id);
                comando.Parameters.AddWithValue("@IdProduto", produtoDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public void Remove(int idProduto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE produto SET ativo = 1 WHERE idproduto = @IdProduto";

                comando.Parameters.AddWithValue("@IdProduto", idProduto);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public void RemoveMass(int[] idProduto)
        {
            try
            {
                for (int i = 0; i < idProduto.Length; i++)
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE produto SET ativo = 1 WHERE idproduto = @IdProduto";

                    comando.Parameters.AddWithValue("@IdProduto", idProduto[i]);

                    Conexao.Crud(comando);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public ProdutoDto GetProdutoById(int idProduto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idproduto, referencia, codigointerno, descricao, estoqueminimo, " + 
                                       "localizacaofisica, idcategoria, idgrade, idfornecedor, ativo " +
                                       "FROM produto WHERE idproduto = @IdProduto";

                comando.Parameters.AddWithValue("@IdProduto", idProduto);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var produto = new ProdutoDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        produto.Id = (int)dr["idproduto"];
                        produto.Referencia = (string)dr["referencia"];
                        produto.IdInterno = (string)dr["codigointerno"];
                        produto.Descricao = (string)dr["descricao"];
                        produto.EstoqueMinimo = (decimal)dr["estoqueminimo"];
                        produto.LocalizacaoFisica = (string)dr["localizacaofisica"];
                        produto.CategoriaDto.Id = (int)dr["idcategoria"];
                        produto.GradeDto.Id = (int)dr["idgrade"];
                        produto.FornecedorDto.Id = (int)dr["idfornecedor"];
                        produto.Ativo = (int)dr["ativo"];
                    }
                }
                else
                {
                    produto = null;
                }
                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public string GetEqualsProduto(string descricao)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT descricao FROM produto WHERE descricao = @Descricao";

                comando.Parameters.AddWithValue("@Descricao", descricao);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var produto = "";

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        produto = (string)dr["descricao"];
                    }
                }
                else
                {
                    produto = null;
                }
                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public IList<ProdutoDto> FindAllByDescricaoCategoriaIdInterno(string descricao, string categoria, string idInterno)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.idproduto, A.referencia, A.codigointerno, A.descricao, A.estoqueminimo, " + 
                                      "A.localizacaofisica, A.idcategoria, A.idgrade, A.idfornecedor, A.ativo, B.descricao, C.descricao, D.nome " +
                                      "FROM produto A " + 
                                      "INNER JOIN categoria B ON A.idcategoria = B.idcategoria " +
                                      "INNER JOIN grade C ON A.idgrade = B.idgrade " +
                                      "INNER JOIN fornecedor D  ON A.idfornecedor = D.idfornecedor " +
                                      "WHERE A.ativo = 0";
               
                MySqlDataReader dr = Conexao.Buscar(comando);

                var listaProduto = new List<ProdutoDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var produto = new ProdutoDto();

                        produto.Id = (int)dr["idproduto"];
                        produto.Referencia = (string)dr["referencia"];
                        produto.IdInterno = (string)dr["codigointerno"];
                        produto.Descricao = (string)dr["descricao"];
                        produto.EstoqueMinimo = (decimal)dr["estoqueminimo"];
                        produto.LocalizacaoFisica = (string)dr["localizacaofisica"];
                        produto.CategoriaDto.Id = (int)dr["idcategoria"];
                        produto.GradeDto.Id = (int)dr["idgrade"];
                        produto.FornecedorDto.Id = (int)dr["idfornecedor"];
                        produto.Ativo = (int)dr["ativo"];
                        produto.CategoriaDto.Descricao = (string)dr["descricao"];
                        produto.GradeDto.Descricao = (string)dr["descricao"];
                        produto.FornecedorDto.Nome = (string)dr["nome"];

                        listaProduto.Add(produto);
                    }
                }
                else
                {
                    listaProduto = null;
                }
                return listaProduto;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }
    }
}
