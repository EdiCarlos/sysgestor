using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.PessoaDto;
using SysGestor.DTO.PessoaDto.ClienteDto;
using System;
using System.Data;

namespace SysGestor.DAL.PessoaDal
{
    public class PessoaDal
    {
        public void Inserir(PessoaDto pessoaDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO pessoa (nome, tipopessoa, cpfcnpj, rgie, datanascimento, datacadastro, observacao) " +
                                      "VALUES (@Nome, @TipoPessoa, @CpfCnpj, @RgIe, @DataNascimento, @DataCadastro, @Observacao)";

                comando.Parameters.AddWithValue("@Nome", pessoaDto.Nome);
                comando.Parameters.AddWithValue("@TipoPessoa", pessoaDto.TipoPessoa);
                comando.Parameters.AddWithValue("@CpfCnpj", pessoaDto.CpfCnpj);
                comando.Parameters.AddWithValue("@RgIe", pessoaDto.RgIe);
                comando.Parameters.AddWithValue("@DataNascimento", pessoaDto.DataNascimento);
                comando.Parameters.AddWithValue("@DataCadastro", pessoaDto.DataCadastro);
                comando.Parameters.AddWithValue("@Observacao", pessoaDto.Observacao);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir dados. " + ex.Message);
            }
        }

        public void Alterar(PessoaDto pessoaDto, int idPessoa)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE pessoa SET nome = @Nome, tipopessoa = @TipoPessoa, cpfcnpj = @CpfCnpj, rgie = @RgIe, " + 
                                                         "datanascimento = @DataNascimento, observacao = @Observacao " +
                                                         "WHERE idpessoa = @IdPessoa";

                comando.Parameters.AddWithValue("@Nome", pessoaDto.Nome);
                comando.Parameters.AddWithValue("@TipoPessoa", pessoaDto.TipoPessoa);
                comando.Parameters.AddWithValue("@CpfCnpj", pessoaDto.CpfCnpj);
                comando.Parameters.AddWithValue("@RgIe", pessoaDto.RgIe);
                comando.Parameters.AddWithValue("@DataNascimento", pessoaDto.DataNascimento);
                comando.Parameters.AddWithValue("@Observacao", pessoaDto.Observacao);
                comando.Parameters.AddWithValue("@IdPessoa", idPessoa);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar dados. " + ex.Message);
            }
        }

        public int GetIdPessoa()
        {
            int idPessoa = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idpessoa "
                                    + "FROM pessoa ORDER BY idpessoa DESC LIMIT 1";
                MySqlDataReader dr = Conexao.Buscar(comando);

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        idPessoa = (int)dr["idpessoa"];                     
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar dados. " + ex.Message);
            }
            return idPessoa;
        }

    }
}
