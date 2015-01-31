using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.PessoaDto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DAL.PessoaDal
{
    public class EnderecoDal
    {
        public void Inserir(EnderecoDto enderecoDto, int idPessoa)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO endereco (logradouro, numero, complemento, cep, bairro, idpessoa, idcidade) " +
                                      "VALUES (@Logradouro, @Numero, @Complemento, @Cep, @Bairro, @IdPessoa, @IdCidade)";

                comando.Parameters.AddWithValue("@Logradouro", enderecoDto.Logradouro);
                comando.Parameters.AddWithValue("@Numero", enderecoDto.Numero);
                comando.Parameters.AddWithValue("@Complemento", enderecoDto.Complemento);
                comando.Parameters.AddWithValue("@Cep", enderecoDto.Cep);
                comando.Parameters.AddWithValue("@Bairro", enderecoDto.Bairro);
                comando.Parameters.AddWithValue("@IdPessoa", idPessoa);
                comando.Parameters.AddWithValue("@IdCidade", enderecoDto.CidadeDto.Id);

                Conexao.Crud(comando);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao inserir dados. " + ex.Message);
            }
        }

        public void Alterar(EnderecoDto enderecoDto) 
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE endereco SET logradouro = @Logradouro, numero = @Numero, " +
                                      "complemento = @Complemento, cep = @Cep, bairro = @Bairro, idcidade = @IdCidade " +
                                      "WHERE idpessoa = @IdPessoa";

                comando.Parameters.AddWithValue("@Logradouro", enderecoDto.Logradouro);
                comando.Parameters.AddWithValue("@Numero", enderecoDto.Numero);
                comando.Parameters.AddWithValue("@Complemento", enderecoDto.Complemento);
                comando.Parameters.AddWithValue("@Cep", enderecoDto.Cep);
                comando.Parameters.AddWithValue("@Bairro", enderecoDto.Bairro);
                comando.Parameters.AddWithValue("@IdCidade", enderecoDto.CidadeDto.Id);
                comando.Parameters.AddWithValue("@IdPessoa", enderecoDto.PessoaDto.Id);

                Conexao.Crud(comando);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao alterar dados. " + ex.Message);
            }
        }

        public IList<EnderecoDto> FindById(int idPessoa)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT  idendereco, logradouro, numero, complemento, cep, bairro " +
                                      "FROM endereco " +
                                      "WHERE idpessoa = @IdPessoa";

                comando.Parameters.AddWithValue("@IdPessoa", idPessoa);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var listaEndereco = new List<EnderecoDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var endereco = new EnderecoDto();

                        endereco.Id = (int)dr["idendereco"];
                        endereco.Logradouro = (string)dr["logradouro"];
                        endereco.Numero = (string)dr["numero"];
                        endereco.Complemento = (string)dr["complemento"];
                        endereco.Cep = (string)dr["cep"];
                        endereco.Bairro = (string)dr["bairro"];

                        listaEndereco.Add(endereco);

                    }
                }
                else
                {
                    listaEndereco = null;
                }
                return listaEndereco;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar dados. " + ex.Message);
            }
        }

        public EnderecoDto GetEndereco(int id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idendereco, logradouro, numero, complemento, cep, bairro, idcidade, idpessoa  " +
                                      "FROM endereco " +
                                      "WHERE idpessoa = @IdPessoa";

                comando.Parameters.AddWithValue("@IdPessoa", id);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var endereco = new EnderecoDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        endereco.Id = (int)dr["idendereco"];
                        endereco.Logradouro = (string)dr["logradouro"];
                        endereco.Numero = (string)dr["numero"];
                        endereco.Complemento = (string)dr["complemento"];
                        endereco.Cep = (string)dr["cep"];
                        endereco.Bairro = (string)dr["bairro"];
                        endereco.CidadeDto.Id = (int)dr["idcidade"];
                        endereco.PessoaDto.Id = (int)dr["idpessoa"];
                    }
                }
                else
                {
                    endereco = null;
                }
                return endereco;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar dados. " + ex.Message);
            }
        }
    }
}
