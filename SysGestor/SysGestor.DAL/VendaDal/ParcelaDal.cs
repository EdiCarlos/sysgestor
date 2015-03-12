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

namespace SysGestor.DAL.VendaDal
{
    public class ParcelaDal
    {
        public void InserirParcela(ParcelaDto parcelaDto, int qtdParcela)
        {
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO parcela(numparcela, idpedido, datavenc, valorparc, juro, qtdparc) " +
                                      "VALUES (@NumParcela, @IdPedido, @DataVenc, @ValorParc, @Juro, @QtdParc)";

                comando.Parameters.AddWithValue("@NumParcela", parcelaDto.NumParcela);
                comando.Parameters.AddWithValue("@IdPedido", parcelaDto.PedidoDto.Id);
                comando.Parameters.AddWithValue("@DataVenc", parcelaDto.DataVencimento);
                comando.Parameters.AddWithValue("@ValorParc", parcelaDto.ValorParcela);
                comando.Parameters.AddWithValue("@Juro", parcelaDto.Juro);
                comando.Parameters.AddWithValue("@QtdParc", parcelaDto.QtdParcela);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
            }
        }

        public void AlterarParcela(ParcelaDto parcelaDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE parcela SET datapag = @DataPag, valorpago = @ValorPago, desconto = @Desconto, juro =  @Juro, " +
                                      "situacao = @Situacao " +
                                      "WHERE idparcela = @IdParcela AND idpedido = @IdPedido";

                comando.Parameters.AddWithValue("@DataPag", parcelaDto.DataPagamento);
                comando.Parameters.AddWithValue("@ValorPago", parcelaDto.ValorPago);
                comando.Parameters.AddWithValue("@Desconto", parcelaDto.Desconto);
                comando.Parameters.AddWithValue("@Juro", parcelaDto.Juro);
                comando.Parameters.AddWithValue("@Situacao", parcelaDto.Situacao);
                comando.Parameters.AddWithValue("@IdParcela", parcelaDto.IdParcela);
                comando.Parameters.AddWithValue("@IdPedido", parcelaDto.PedidoDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public ParcelaCollection GetCrediarioByIdCliente(int idCliente)
        {
            try
            {
                MySqlCommand comando2 = new MySqlCommand();
                comando2.CommandType = CommandType.Text;
                comando2.CommandText = "SELECT * FROM vwcrediario " +
                                      "WHERE idcliente = @IdCliente AND situacao = 'A'";

                comando2.Parameters.AddWithValue("@IdCliente", idCliente);

                MySqlDataReader dr = Conexao.Buscar(comando2);

                var lista = new ParcelaCollection();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var parcela = new ParcelaDto();

                        parcela.IdParcela = (int)dr["idparcela"];
                        parcela.NumParcela = (int)dr["numparcela"];
                        parcela.PedidoDto.Id = (int)dr["idpedido"];
                        parcela.DataVencimento = (DateTime)dr["datavenc"];
                        parcela.ValorParcela = (double)dr["valorparc"];
                        parcela.ValorPago = (double)dr["valorpago"];
                        parcela.Restante = (double)dr["restante"];
                        parcela.QtdParcela = (int)dr["qtdparc"];
                        parcela.Historico = string.Format("{0} - Ped. {1} - Parc. {2} de {3}", dr["datapedido"], dr["idpedido"], dr["numparcela"], dr["qtdparc"]);

                        lista.Add(parcela);
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
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message.ToString());
            }
        }

        public ParcelaDto GetParcelaById(int idParcela)
        {
            try
            {
                MySqlCommand comando2 = new MySqlCommand();
                comando2.CommandType = CommandType.Text;
                comando2.CommandText = "SELECT * FROM vwcrediario " +
                                      "WHERE idparcela = @IdParcela AND situacao = 'A'";

                comando2.Parameters.AddWithValue("@IdParcela", idParcela);

                MySqlDataReader dr = Conexao.Buscar(comando2);

                var parcela = new ParcelaDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       

                        parcela.IdParcela = (int)dr["idparcela"];
                        parcela.NumParcela = (int)dr["numparcela"];
                        parcela.PedidoDto.Id = (int)dr["idpedido"];
                        parcela.DataVencimento = (DateTime)dr["datavenc"];
                        parcela.ValorParcela = (double)dr["valorparc"];
                        parcela.ValorPago = (double)dr["valorpago"];
                        parcela.Restante = (double)dr["restante"];
                        parcela.QtdParcela = (int)dr["qtdparc"];
                    }
                }
                else
                {
                    parcela = null;
                }
                return parcela;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message.ToString());
            }
        }
    }
}
