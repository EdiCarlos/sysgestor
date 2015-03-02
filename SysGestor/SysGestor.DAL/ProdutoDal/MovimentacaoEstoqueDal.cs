using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.Produto;
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
                comando.CommandText = "INSERT INTO movestoque(idproduto, codigointerno, documento, qtd, data, operacao, observacao, idusuario, idunidmedida) " +
                                      "VALUES (@IdProduto, @CodigoInterno, @Documento, @Qtd, @Data, @Operacao, @Observacao, @IdUsuario, @IdUnidMedida)";

                comando.Parameters.AddWithValue("@IdProduto", movimentacaoEstoqueDto.ProdutoDto.Id);
                comando.Parameters.AddWithValue("@CodigoInterno", movimentacaoEstoqueDto.ProdutoDto.IdInterno);
                comando.Parameters.AddWithValue("@Documento", movimentacaoEstoqueDto.Documento);
                comando.Parameters.AddWithValue("@Qtd", movimentacaoEstoqueDto.Quantidade);
                comando.Parameters.AddWithValue("@Data", DateTime.Now);
                comando.Parameters.AddWithValue("@Operacao", movimentacaoEstoqueDto.Operacao);
                comando.Parameters.AddWithValue("@Observacao", movimentacaoEstoqueDto.Observacao);
                comando.Parameters.AddWithValue("@IdUsuario", movimentacaoEstoqueDto.UsuarioDto.IdUsuario);
                comando.Parameters.AddWithValue("@IdUnidMedida", movimentacaoEstoqueDto.UnidadeDto.IdUnidMedida);
               
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
                comando.CommandText = "UPDATE movestoque SET idproduto = @IdProduto , codigointerno = @CodigoInterno, documento = @Documento, qtd = @Qtd, operacao = @Operacao, observacao = @Observacao, idusuario = @Observacao " +
                                      "WHERE idproduto = @IdProduto";

                comando.Parameters.AddWithValue("@IdProduto", movimentacaoEstoqueDto.ProdutoDto.Id);
                comando.Parameters.AddWithValue("@CodigoInterno", movimentacaoEstoqueDto.ProdutoDto.IdInterno);
                comando.Parameters.AddWithValue("@Documento", movimentacaoEstoqueDto.Documento);
                comando.Parameters.AddWithValue("@Qtd", movimentacaoEstoqueDto.Quantidade);
                comando.Parameters.AddWithValue("@Operacao", movimentacaoEstoqueDto.Operacao);
                comando.Parameters.AddWithValue("@Observacao", movimentacaoEstoqueDto.Observacao);
                comando.Parameters.AddWithValue("@IdUsuario", movimentacaoEstoqueDto.UsuarioDto.IdUsuario);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }
               
    }
}
