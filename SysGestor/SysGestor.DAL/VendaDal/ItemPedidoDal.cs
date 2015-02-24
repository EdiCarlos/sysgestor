using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.VendaDto;
using SysGestor.RESOURCE.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DAL.PedidoDal
{
    public class ItemPedidoDal
    {
        public void InserirItemPedido(ItemPedidoDto itemPedidoDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO itempedido(qtd, desconto, idproduto, codigointerno, idpedido) " +
                                      "VALUES (@Qtd, @Desconto, @IdProduto, @CodigoInterno, @IdPedido)";

                comando.Parameters.AddWithValue("@Qtd", itemPedidoDto.Quantidade);
                comando.Parameters.AddWithValue("@Desconto", itemPedidoDto.Desconto);
                comando.Parameters.AddWithValue("@IdProduto", itemPedidoDto.ProdutoDto.Id);
                comando.Parameters.AddWithValue("@CodigoInterno", itemPedidoDto.ProdutoDto.IdInterno);
                comando.Parameters.AddWithValue("@IdPedido", itemPedidoDto.PedidoDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
            }
        }

        //public void AlterarPedido(itemPedidoDto itemPedidoDto)
        //{
        //    try
        //    {
        //        MySqlCommand comando = new MySqlCommand();
        //        comando.CommandType = CommandType.Text;
        //        comando.CommandText = "UPDATE pedido SET status = @Status, tipo = @Tipo, idusuario = @IdUsuario " +
        //                              "WHERE idpedido = @IdPedido";

        //        comando.Parameters.AddWithValue("@Status", itemPedidoDto.Status);
        //        comando.Parameters.AddWithValue("@Tipo", itemPedidoDto.Tipo);
        //        comando.Parameters.AddWithValue("@IdUsuario", itemPedidoDto.UsuarioDto.Id);
        //        comando.Parameters.AddWithValue("@IdPedido", itemPedidoDto.Id);

        //        Conexao.Crud(comando);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
        //    }
        //}

        public void Remove(int idPedido)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "DELETE FROM itempedido WHERE idpedido = @IdPedido";

                comando.Parameters.AddWithValue("@IdPedido", idPedido);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public List<ItemPedidoGridDto> GetItensPedidoById(int idPedido)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.iditempedido, B.codigointerno, B.descricao, A.qtd, C.descricao as unidade, D.valorvenda, (D.valorvenda * A.qtd) as total " +
                                      "FROM itempedido A " +
                                      "INNER JOIN produto B ON A.idproduto = B.idproduto " +
                                      "INNER JOIN unidmedida C ON B.idunidmedida = C.idunidmedida " +
                                      "INNER JOIN valorproduto D ON B.idproduto = D.idproduto " +
                                      "WHERE A.idpedido = @IdPedido";

                comando.Parameters.AddWithValue("@IdPedido", idPedido);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var listaPedido = new List<ItemPedidoGridDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var pedido = new ItemPedidoGridDto();

                        pedido.Id = Convert.ToInt32(System.Convert.IsDBNull(dr["iditempedido"]) ? null : dr["iditempedido"]);
                        pedido.IdInterno = Convert.ToString(System.Convert.IsDBNull(dr["codigointerno"]) ? null : dr["codigointerno"]);
                        pedido.Descricao = Convert.ToString(System.Convert.IsDBNull(dr["descricao"]) ? null : dr["descricao"]);
                        pedido.Quantidade = Convert.ToDecimal(System.Convert.IsDBNull(dr["qtd"]) ? null : dr["qtd"]);
                        pedido.Unidade = Convert.ToString(System.Convert.IsDBNull(dr["unidade"]) ? null : dr["unidade"]);
                        pedido.ValorUnitario = Convert.ToDouble(System.Convert.IsDBNull(dr["valorvenda"]) ? null : dr["valorvenda"]);
                        pedido.SubTotal = Convert.ToDouble(System.Convert.IsDBNull(dr["total"]) ? null : dr["total"]);

                        listaPedido.Add(pedido);
                    }
                }
                else
                {
                    listaPedido = null;
                }
                return listaPedido;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public void CancelaItemPedido(int idItemPedido)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "DELETE FROM itempedido WHERE  iditempedido = @IdItemPedido";

                comando.Parameters.AddWithValue("@IdItemPedido", idItemPedido);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public void AlteraItemPedido(int idItemPedido, decimal qtd)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE itempedido SET qtd = @Qtd WHERE  iditempedido = @IdItemPedido";

                comando.Parameters.AddWithValue("@Qtd", qtd);
                comando.Parameters.AddWithValue("@IdItemPedido", idItemPedido);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public CancelaItemDto GetItemCancelar(int idPedido, string idInterno)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.iditempedido, A.idpedido, A.qtd, A.codigointerno, A.idproduto, (select nome from pessoa where idpessoa = (select idpessoa  from cliente where idcliente = B.idcliente)) as nome, C.descricao " +
                                      "FROM itempedido A " +
                                      "INNER JOIN pedido B ON A.idpedido = B.idpedido " +
                                      "INNER JOIN produto C ON A.idproduto = C.idproduto " +
                                      "WHERE A.idpedido = @IdPedido AND A.codigointerno = @IdInterno ORDER BY A.qtd DESC LIMIT 1";

                comando.Parameters.AddWithValue("@IdPedido", idPedido);
                comando.Parameters.AddWithValue("@IdInterno", idInterno);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var item = new CancelaItemDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        item.IdItemPedido = Convert.ToInt32(System.Convert.IsDBNull(dr["iditempedido"]) ? null : dr["iditempedido"]);
                        item.IdPedido = Convert.ToInt32(System.Convert.IsDBNull(dr["idpedido"]) ? null : dr["idpedido"]);
                        item.Quantidade = Convert.ToDecimal(System.Convert.IsDBNull(dr["qtd"]) ? null : dr["qtd"]);
                        item.IdInterno = Convert.ToString(System.Convert.IsDBNull(dr["codigointerno"]) ? null : dr["codigointerno"]);
                        item.IdProduto = Convert.ToInt32(System.Convert.IsDBNull(dr["idproduto"]) ? null : dr["idproduto"]);
                        item.Cliente = Convert.ToString(System.Convert.IsDBNull(dr["nome"]) ? null : dr["nome"]);
                        item.Produto = Convert.ToString(System.Convert.IsDBNull(dr["descricao"]) ? null : dr["descricao"]);
                    }
                }
                else
                {
                    item = null;
                }
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }
        
    }
}
