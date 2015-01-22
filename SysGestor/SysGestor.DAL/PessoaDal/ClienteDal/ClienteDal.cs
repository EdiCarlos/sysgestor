using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.PessoaDto.ClienteDto;
using System;
using System.Collections.Generic;
using System.Data;

namespace SysGestor.DAL.PessoaDal.ClienteDal
{
    public class ClienteDal
    {

        public void Inserir(int idPessoa)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO cliente(idpessoa) " +
                                      "VALUES (@IdPessoa)";

                comando.Parameters.AddWithValue("@IdPessoa", idPessoa);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir dados. " + ex.Message);
            }
        }

        public IList<ClienteDto> FindById(int idCliente)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.idpessoa, A.nome, A.tipopessoa, A.cpfcnpj, A.rgie, A.datanascimento, A.datacadastro, A.ativo, A.observacao, B.idcliente " +
                                      "FROM pessoa A " +
                                      "INNER JOIN cliente B ON A.idpessoa = B.idpessoa "
                                    + "WHERE B.idcliente = @IdCliente";
                comando.Parameters.AddWithValue("@IdCliente", idCliente);
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

        public IList<ClienteDto> FindAll()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.idpessoa, A.nome, A.tipopessoa, A.cpfcnpj, A.rgie, A.datanascimento, A.datacadastro, A.ativo, A.observacao, B.idcliente " +
                                      "FROM pessoa A " +
                                      "INNER JOIN cliente B ON A.idpessoa = B.idpessoa ";
           
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

        public void Remove(int idCliente)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE pessoa SET ativo = 1 WHERE idPessoa = (SELECT idcliente FROM cliente WHERE idcliente = @IdCliente)";

                comando.Parameters.AddWithValue("@IdCliente", idCliente);

                Conexao.Crud(comando);
               
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir dados. " + ex.Message);
            }
        }

        public void RemoveMass(int [] idCliente)
        {
            try
            {
                for (int i = 0; i < idCliente.Length; i++)
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE pessoa SET ativo = 1 WHERE idPessoa = (SELECT idcliente FROM cliente WHERE idcliente = @IdCliente)";

                    comando.Parameters.AddWithValue("@IdCliente", idCliente[i]);

                    Conexao.Crud(comando); 
                }              
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir dados. " + ex.Message);
            }
        }
    }
}
