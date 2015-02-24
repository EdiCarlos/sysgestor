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

namespace SysGestor.DAL.PedidoDAL
{
    public class PedidoDal
    {
        public void InserirPedido(PedidoDto pedidoDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO pedido(datapedido, status, tipo, idusuario, idcliente) " +
                                      "VALUES (@DataPedido, @Status, @Tipo, @IdUsuario, @IdCliente)";

                comando.Parameters.AddWithValue("@DataPedido", DateTime.Now);
                comando.Parameters.AddWithValue("@Status", pedidoDto.Status);
                comando.Parameters.AddWithValue("@Tipo", pedidoDto.Tipo);
                comando.Parameters.AddWithValue("@IdUsuario", pedidoDto.UsuarioDto.IdUsuario);
                comando.Parameters.AddWithValue("@IdCliente", pedidoDto.ClienteDto.IdCliente);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
            }
        }

        public void AlterarPedido(PedidoDto pedidoDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE pedido SET status = @Status, tipo = @Tipo, idusuario = @IdUsuario " +
                                      "WHERE idpedido = @IdPedido";

                comando.Parameters.AddWithValue("@Status", pedidoDto.Status);
                comando.Parameters.AddWithValue("@Tipo", pedidoDto.Tipo);
                comando.Parameters.AddWithValue("@IdUsuario", pedidoDto.UsuarioDto.Id);
                comando.Parameters.AddWithValue("@IdPedido", pedidoDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public void FecharPedido(PedidoDto pedidoDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE pedido SET status = @Status, tipo = @Tipo, idusuario = @IdUsuario " +
                                      "WHERE idpedido = @IdPedido";

                comando.Parameters.AddWithValue("@Status", pedidoDto.Status);
                comando.Parameters.AddWithValue("@Tipo", pedidoDto.Tipo);
                comando.Parameters.AddWithValue("@IdUsuario", pedidoDto.UsuarioDto.Id);
                comando.Parameters.AddWithValue("@IdPedido", pedidoDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public void Remove(int idPedido)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "DELETE FROM pedido WHERE  idpedido = @IdPedido";

                comando.Parameters.AddWithValue("@IdPedido", idPedido);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public int GetIdPedido()
        {
            int idPedido = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idpedido "
                                    + "FROM pedido ORDER BY idpedido DESC LIMIT 1";
                MySqlDataReader dr = Conexao.Buscar(comando);

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        idPedido = (int)dr["idpedido"];
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
            return idPedido;
        }

        public int GetIdClientePedido(int idPedido)
        {
            int idCliente = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idcliente "
                                    + "FROM pedido WHERE idpedido = @IdPedido";

                comando.Parameters.AddWithValue("@IdPedido", idPedido);

                MySqlDataReader dr = Conexao.Buscar(comando);

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        idCliente = (int)dr["idcliente"];
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
            return idCliente;
        }

        public List<PedidoDto> FindAll()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idpedido, datapedido, status, tipo, idusuario, idcliente " +
                                      "FROM pedido ";

                MySqlDataReader dr = Conexao.Buscar(comando);

                var listaPedido = new List<PedidoDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var pedido = new PedidoDto();

                        pedido.Id = Convert.ToInt32(System.Convert.IsDBNull(dr["idpedido"]) ? null : dr["idpedido"]);
                        pedido.DataPedido = Convert.ToDateTime(System.Convert.IsDBNull(dr["datapedido"]) ? null : dr["datapedido"]);
                        pedido.Status = Convert.ToInt32(System.Convert.IsDBNull(dr["status"]) ? null : dr["status"]);
                        pedido.Tipo = Convert.ToString(System.Convert.IsDBNull(dr["tipo"]) ? null : dr["tipo"]);
                        pedido.UsuarioDto.Id = Convert.ToInt32(System.Convert.IsDBNull(dr["idusuario"]) ? null : dr["idusuario"]);
                        pedido.ClienteDto.Id = Convert.ToInt32(System.Convert.IsDBNull(dr["idcliente"]) ? null : dr["idcliente"]);

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
    }
}
