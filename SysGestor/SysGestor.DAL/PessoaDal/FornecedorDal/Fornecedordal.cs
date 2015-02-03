using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.PessoaDto.FornecedorDto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DAL.PessoaDal.FornecedorDal
{
    public class FornecedorDal
    {
        public void Inserir(FornecedorDto fornecedorDto, int idPessoa)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO fornecedor(idpessoa) " +
                                      "VALUES (@IdPessoa)";

                comando.Parameters.AddWithValue("@IdPessoa", idPessoa);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir dados. " + ex.Message);
            }
        }

        public void Alterar(FornecedorDto fornecedorDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE fornecedor SET  " +
                                      "WHERE idpessoa = @IdPessoa";

                comando.Parameters.AddWithValue("@IdPessoa", fornecedorDto.PessoaDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar dados. " + ex.Message);
            }
        }

        public FornecedorDto GetFornecedor(int idFornecedor)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.idpessoa, A.nome, A.tipopessoa, A.cpfcnpj, A.rgie, A.datanascimento, A.datacadastro, A.ativo, A.observacao, B.idfornecedor " +
                                      "FROM pessoa A " +
                                      "INNER JOIN fornecedor B ON A.idpessoa = B.idpessoa "
                                    + "WHERE B.idfornecedor = @IdFornrcedor";
                comando.Parameters.AddWithValue("@IdFornrcedor", idFornecedor);
                MySqlDataReader dr = Conexao.Buscar(comando);

                var fornecedor = new FornecedorDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        fornecedor.PessoaDto.Id = (int)dr["idpessoa"];
                        fornecedor.Nome = (string)dr["nome"];
                        fornecedor.TipoPessoa = (string)dr["tipopessoa"];
                        fornecedor.CpfCnpj = (string)dr["cpfcnpj"];
                        fornecedor.RgIe = (string)dr["rgie"];
                        fornecedor.DataNascimento = (DateTime)dr["datanascimento"];
                        fornecedor.DataCadastro = (DateTime)dr["datacadastro"];
                        fornecedor.Ativo = (int)dr["ativo"];
                        fornecedor.Observacao = (string)dr["observacao"];
                        fornecedor.IdFornecedor = (int)dr["idfornecedor"];
                    }
                }
                else
                {
                    fornecedor = null;
                }
                return fornecedor;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar dados. " + ex.Message);
            }
        }

        public IList<FornecedorDto> FindAll()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT A.idpessoa, A.nome, A.tipopessoa, A.cpfcnpj, A.rgie, A.datanascimento, A.datacadastro, A.ativo, A.observacao, B.idfornecedor " +
                                      "FROM pessoa A " +
                                      "INNER JOIN fornecedor B ON A.idpessoa = B.idpessoa " +
                                      "WHERE A.ativo = 0 ";

                MySqlDataReader dr = Conexao.Buscar(comando);

                var listaFornecedor = new List<FornecedorDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var fornecedor = new FornecedorDto();

                        fornecedor.Id = (int)dr["idpessoa"];
                        fornecedor.Nome = (string)dr["nome"];
                        fornecedor.TipoPessoa = (string)dr["tipopessoa"];
                        fornecedor.CpfCnpj = (string)dr["cpfcnpj"];
                        fornecedor.RgIe = (string)dr["rgie"];
                        fornecedor.DataNascimento = (DateTime)dr["datanascimento"];
                        fornecedor.DataCadastro = (DateTime)dr["datacadastro"];
                        fornecedor.Ativo = (int)dr["ativo"];
                        fornecedor.Observacao = (string)dr["observacao"];
                        fornecedor.IdFornecedor = (int)dr["idfornecedor"];

                        listaFornecedor.Add(fornecedor);

                    }
                }
                else
                {
                    listaFornecedor = null;
                }
                return listaFornecedor;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar dados. " + ex.Message);
            }
        }

        public void Remove(int idFornecedor)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE pessoa SET ativo = 1 WHERE idPessoa = (SELECT idpessoa FROM fornecedor WHERE idfornecedor = @IdFornecedor)";

                comando.Parameters.AddWithValue("@IdFornecedor", idFornecedor);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir dados. " + ex.Message);
            }
        }

        public void RemoveMass(int[] idFornecedor)
        {
            try
            {
                for (int i = 0; i < idFornecedor.Length; i++)
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE pessoa SET ativo = 1 WHERE idPessoa = (SELECT idpessoa FROM fornecedor WHERE idfornecedor = @IdFornecedor)";

                    comando.Parameters.AddWithValue("@IdFornecedor", idFornecedor[i]);

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
