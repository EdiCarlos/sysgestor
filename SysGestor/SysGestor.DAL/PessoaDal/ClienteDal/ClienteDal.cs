using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.PessoaDTO.ClienteDto;
using SysGestor.RESOURCE.Resources;
using System;
using System.Collections.Generic;
using System.Data;

namespace SysGestor.DAL.PessoaDal.ClienteDal
{
    public class ClienteDal
    {

        public void Inserir(ClienteDto clienteDto, int idPessoa)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO cliente(limitecredito, idpessoa) " +
                                      "VALUES (@LimiteCredito, @IdPessoa)";

                comando.Parameters.AddWithValue("@IdPessoa", idPessoa);
                comando.Parameters.AddWithValue("@LimiteCredito", clienteDto.LimiteCredito);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir dados. " + ex.Message);
            }
        }

        public void Alterar(ClienteDto clienteDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE cliente SET limitecredito = @LimiteCredito " +
                                      "WHERE idpessoa = @IdPessoa";

                comando.Parameters.AddWithValue("@IdPessoa", clienteDto.PessoaDto.Id);
                comando.Parameters.AddWithValue("@LimiteCredito", clienteDto.LimiteCredito);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar dados. " + ex.Message);
            }
        }

        public ClienteDto GetCliente(int idCliente)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.idpessoa, A.nome, A.tipopessoa, A.cpfcnpj, A.rgie, A.datanascimento, A.datacadastro, A.ativo, A.observacao, B.idcliente, B.limitecredito " +
                                      "FROM pessoa A " +
                                      "INNER JOIN cliente B ON A.idpessoa = B.idpessoa "
                                    + "WHERE B.idcliente = @IdCliente";
                comando.Parameters.AddWithValue("@IdCliente", idCliente);
                MySqlDataReader dr = Conexao.Buscar(comando);

                var cliente = new ClienteDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cliente.PessoaDto.Id = (int)dr["idpessoa"];
                        cliente.Nome = (string)dr["nome"];
                        cliente.TipoPessoa = (string)dr["tipopessoa"];
                        cliente.CpfCnpj = (string)dr["cpfcnpj"];
                        cliente.RgIe = (string)dr["rgie"];
                        cliente.DataNascimento = (DateTime)dr["datanascimento"];
                        cliente.DataCadastro = (DateTime)dr["datacadastro"];
                        cliente.Ativo = (int)dr["ativo"];
                        cliente.Observacao = (string)dr["observacao"];
                        cliente.IdCliente = (int)dr["idcliente"];
                        cliente.LimiteCredito = (double)dr["limitecredito"];
                    }
                }
                else
                {
                    cliente = null;
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar dados. " + ex.Message);
            }
        }

        public IList<ClienteDto> FindAll()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.idpessoa, A.nome, A.tipopessoa, A.cpfcnpj, A.rgie, A.datanascimento, A.datacadastro, A.ativo, A.observacao, B.idcliente " +
                                      "FROM pessoa A " +
                                      "INNER JOIN cliente B ON A.idpessoa = B.idpessoa " +
                                      "WHERE A.ativo = 0";

                MySqlDataReader dr = Conexao.Buscar(comando);

                var listaCliente = new List<ClienteDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var cliente = new ClienteDto();

                        cliente.Id = (int)dr["idpessoa"];
                        cliente.Nome = (string)dr["nome"];
                        cliente.TipoPessoa = (string)dr["tipopessoa"];
                        cliente.CpfCnpj = (string)dr["cpfcnpj"];
                        cliente.RgIe = (string)dr["rgie"];
                        cliente.DataNascimento = (DateTime)dr["datanascimento"];
                        cliente.DataCadastro = (DateTime)dr["datacadastro"];
                        cliente.Ativo = (int)dr["ativo"];
                        cliente.Observacao = (string)dr["observacao"];
                        cliente.IdCliente = (int)dr["idcliente"];

                        listaCliente.Add(cliente);

                    }
                }
                else
                {
                    listaCliente = null;
                }
                return listaCliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar dados. " + ex.Message);
            }
        }

        public ClienteDto GetClienteByNome(string nome)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.idpessoa, A.nome, A.tipopessoa, A.cpfcnpj, A.rgie, A.datanascimento, A.datacadastro, A.ativo, A.observacao, B.idcliente, B.limitecredito " +
                                      "FROM pessoa A " +
                                      "INNER JOIN cliente B ON A.idpessoa = B.idpessoa "
                                    + "WHERE A.nome = @Nome ";

                comando.Parameters.AddWithValue("@Nome", nome);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var cliente = new ClienteDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cliente.PessoaDto.Id = (int)dr["idpessoa"];
                        cliente.Nome = (string)dr["nome"];
                        cliente.TipoPessoa = (string)dr["tipopessoa"];
                        cliente.CpfCnpj = (string)dr["cpfcnpj"];
                        cliente.RgIe = (string)dr["rgie"];
                        cliente.DataNascimento = (DateTime)dr["datanascimento"];
                        cliente.DataCadastro = (DateTime)dr["datacadastro"];
                        cliente.Ativo = (int)dr["ativo"];
                        cliente.Observacao = (string)dr["observacao"];
                        cliente.IdCliente = (int)dr["idcliente"];
                        cliente.LimiteCredito = (double)dr["limitecredito"];
                    }
                }
                else
                {
                    cliente = null;
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message.ToString());
            }
        }

        public ClienteDto GetClienteByCpfCnpj(string cpfCnpj)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.idpessoa, A.nome, A.tipopessoa, A.cpfcnpj, A.rgie, A.datanascimento, A.datacadastro, A.ativo, A.observacao, B.idcliente, B.limitecredito " +
                                      "FROM pessoa A " +
                                      "INNER JOIN cliente B ON A.idpessoa = B.idpessoa "
                                    + "WHERE A.cpfcnpj = @CpfCnpj ";

                comando.Parameters.AddWithValue("@CpfCnpj", cpfCnpj);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var cliente = new ClienteDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cliente.PessoaDto.Id = (int)dr["idpessoa"];
                        cliente.Nome = (string)dr["nome"];
                        cliente.TipoPessoa = (string)dr["tipopessoa"];
                        cliente.CpfCnpj = (string)dr["cpfcnpj"];
                        cliente.RgIe = (string)dr["rgie"];
                        cliente.DataNascimento = (DateTime)dr["datanascimento"];
                        cliente.DataCadastro = (DateTime)dr["datacadastro"];
                        cliente.Ativo = (int)dr["ativo"];
                        cliente.Observacao = (string)dr["observacao"];
                        cliente.IdCliente = (int)dr["idcliente"];
                        cliente.LimiteCredito = (double)dr["limitecredito"];
                    }
                }
                else
                {
                    cliente = null;
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message.ToString());
            }
        }

        public void Remove(int idCliente)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE pessoa SET ativo = 1 WHERE idPessoa = (SELECT idpessoa FROM cliente WHERE idcliente = @IdCliente)";

                comando.Parameters.AddWithValue("@IdCliente", idCliente);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir dados. " + ex.Message);
            }
        }

        public void RemoveMass(int[] idCliente)
        {
            try
            {
                for (int i = 0; i < idCliente.Length; i++)
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE pessoa SET ativo = 1 WHERE idPessoa = (SELECT idpessoa FROM cliente WHERE idcliente = @IdCliente)";

                    comando.Parameters.AddWithValue("@IdCliente", idCliente[i]);

                    Conexao.Crud(comando);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir dados. " + ex.Message);
            }
        }

        public double GetDebitoByIdCLiente(int idCliente)
        {
            double valor = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT SUM(A.valorparc) FROM parcela A " +
                                      "JOIN pedido B ON A.idpedido = B.idpedido " +
                                      "JOIN cliente C ON B.idcliente = C.idcliente " +
                                      "WHERE A.valorpago = 0 AND C.idcliente = @IdCliente";

                comando.Parameters.AddWithValue("@IdCliente", idCliente);

                valor = Convert.ToDouble(Conexao.Selecionar(comando));

                return valor;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message.ToString());
            }
        }
    }
}
