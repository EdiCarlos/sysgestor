using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.VendaDto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DAL.VendaDal
{
    public class PedidoDal
    {
        //public void Inserir(PedidoDto pedidoDto)
        //{
        //    try
        //    {
        //        MySqlCommand comando = new MySqlCommand();
        //        comando.CommandType = CommandType.Text;
        //        comando.CommandText = "INSERT INTO produto(referencia, codigointerno, descricao, marca, estoqueminimo, localizacaofisica, observacao, idcategoria, idgrade, idunidmedida, idfornecedor) " +
        //                              "VALUES (@Referencia, @CodigoInterno, @Descricao, @Marca, @EstoqueMinimo, @LocalizacaoFisica, @Observacao, @IdCategoria, @IdGrade, @IdUnidMedida, @IdFornecedor)";

        //        comando.Parameters.AddWithValue("@Referencia", pedidoDto.Referencia);
        //        comando.Parameters.AddWithValue("@CodigoInterno", pedidoDto.IdInterno);
        //        comando.Parameters.AddWithValue("@Descricao", pedidoDto.Descricao);
        //        comando.Parameters.AddWithValue("@Marca", pedidoDto.Marca);
        //        comando.Parameters.AddWithValue("@EstoqueMinimo", pedidoDto.EstoqueMinimo);
        //        comando.Parameters.AddWithValue("@LocalizacaoFisica", pedidoDto.LocalizacaoFisica);
        //        comando.Parameters.AddWithValue("@Observacao", pedidoDto.Observacao);
        //        comando.Parameters.AddWithValue("@IdCategoria", pedidoDto.CategoriaDto.Id);
        //        comando.Parameters.AddWithValue("@IdGrade", pedidoDto.GradeDto.Id);
        //        comando.Parameters.AddWithValue("@IdUnidMedida", pedidoDto.UnidadeDto.IdUnidMedida);
        //        comando.Parameters.AddWithValue("@IdFornecedor", pedidoDto.FornecedorDto.Id);

        //        Conexao.Crud(comando);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
        //    }
        //}

        //public void Alterar(pedidoDto pedidoDto)
        //{
        //    try
        //    {
        //        MySqlCommand comando = new MySqlCommand();
        //        comando.CommandType = CommandType.Text;
        //        comando.CommandText = "UPDATE produto SET referencia = @Referencia, codigointerno = @CodigoInterno, descricao = @Descricao, marca = @Marca, estoqueminimo = @EstoqueMinimo, " +
        //                              "localizacaofisica = @LocalizacaoFisica, observacao = @Observacao, idcategoria = @IdCategoria, idgrade = @IdGrade, idfornecedor = @IdFornecedor " +
        //                              "WHERE idproduto = @IdProduto AND codigointerno = @CodigoInterno";

        //        comando.Parameters.AddWithValue("@Referencia", pedidoDto.Referencia);
        //        comando.Parameters.AddWithValue("@Descricao", pedidoDto.Descricao);
        //        comando.Parameters.AddWithValue("@Marca", pedidoDto.Marca);
        //        comando.Parameters.AddWithValue("@EstoqueMinimo", pedidoDto.EstoqueMinimo);
        //        comando.Parameters.AddWithValue("@LocalizacaoFisica", pedidoDto.LocalizacaoFisica);
        //        comando.Parameters.AddWithValue("@Observacao", pedidoDto.Observacao);
        //        comando.Parameters.AddWithValue("@IdCategoria", pedidoDto.CategoriaDto.Id);
        //        comando.Parameters.AddWithValue("@IdGrade", pedidoDto.GradeDto.Id);
        //        comando.Parameters.AddWithValue("@IdUnidMedida", pedidoDto.UnidadeDto.IdUnidMedida);
        //        comando.Parameters.AddWithValue("@IdFornecedor", pedidoDto.FornecedorDto.Id);
        //        comando.Parameters.AddWithValue("@CodigoInterno", pedidoDto.IdInterno);
        //        comando.Parameters.AddWithValue("@IdProduto", pedidoDto.Id);

        //        Conexao.Crud(comando);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
        //    }
        //}

        //public void Remove(int idProduto)
        //{
        //    try
        //    {
        //        MySqlCommand comando = new MySqlCommand();
        //        comando.CommandType = CommandType.Text;
        //        comando.CommandText = "UPDATE produto SET ativo = 1 WHERE idproduto = @IdProduto";

        //        comando.Parameters.AddWithValue("@IdProduto", idProduto);

        //        Conexao.Crud(comando);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
        //    }
        //}

        //public List<pedidoDto> FindAllByDescricaoCategoriaIdInterno()
        //{
        //    try
        //    {
        //        MySqlCommand comando = new MySqlCommand();
        //        comando.CommandType = CommandType.Text;
        //        comando.CommandText = "SELECT A.idproduto, A.referencia, A.codigointerno, A.descricao, A.marca, A.estoque, A.estoqueminimo, " +
        //                              "A.localizacaofisica, A.observacao, A.idcategoria, A.idgrade, A.idunidmedida, A.idfornecedor, " +
        //                              "A.ativo, B.descricao, C.descricao, E.descricao, " +
        //                              "(select nome from pessoa where idpessoa = (select idpessoa  from fornecedor where idfornecedor = D.idfornecedor)) as nome " +
        //                              "FROM produto A " +
        //                              "INNER JOIN categoria B ON A.idcategoria = B.idcategoria " +
        //                              "INNER JOIN grade C ON A.idgrade = C.idgrade " +
        //                              "INNER JOIN unidmedida E ON A.idgrade = E.idunidmedida " +
        //                              "INNER JOIN fornecedor D  ON A.idfornecedor = D.idfornecedor " +
        //                              "WHERE A.ativo = 0";

        //        MySqlDataReader dr = Conexao.Buscar(comando);

        //        var listaProduto = new List<pedidoDto>();

        //        if (dr.HasRows)
        //        {
        //            while (dr.Read())
        //            {
        //                var produto = new pedidoDto();

        //                produto.Id = (int)dr["idproduto"];
        //                produto.Referencia = (string)dr["referencia"];
        //                produto.IdInterno = (string)dr["codigointerno"];
        //                produto.Descricao = (string)dr["descricao"];
        //                produto.Marca = (string)dr["marca"];
        //                produto.Estoque = Convert.ToDecimal(System.Convert.IsDBNull(dr["estoque"]) ? null : dr["estoque"]);
        //                produto.EstoqueMinimo = (decimal)dr["estoqueminimo"];
        //                produto.LocalizacaoFisica = (string)dr["localizacaofisica"];
        //                produto.Observacao = (string)dr["observacao"];
        //                produto.CategoriaDto.Id = (int)dr["idcategoria"];
        //                produto.GradeDto.Id = (int)dr["idgrade"];
        //                produto.UnidadeDto.IdUnidMedida = (int)dr["idunidmedida"];
        //                produto.FornecedorDto.Id = (int)dr["idfornecedor"];
        //                produto.Ativo = (int)dr["ativo"];
        //                produto.CategoriaDto.Descricao = (string)dr["descricao"];
        //                produto.GradeDto.Descricao = (string)dr["descricao"];
        //                produto.UnidadeDto.Descricao = (string)dr["descricao"];
        //                produto.FornecedorDto.Nome = (string)dr["nome"];

        //                listaProduto.Add(produto);
        //            }
        //        }
        //        else
        //        {
        //            listaProduto = null;
        //        }
        //        return listaProduto;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
        //    }
        //}
    }
}
