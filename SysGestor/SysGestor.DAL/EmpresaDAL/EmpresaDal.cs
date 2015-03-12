using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.EmpresaDTO;
using SysGestor.RESOURCE.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SysGestor.DAL.EmpresaDAL
{
    public class EmpresaDal
    {
        public void InserirEmpresa(EmpresaDto empresaDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO empresa(nomefantasia, logo, idpessoa) " +
                                      "VALUES (@NomeFantasia,@Logo, @IdPessoa)";

                comando.Parameters.AddWithValue("@NomeFantasia", empresaDto.NomeFantasia);
                comando.Parameters.AddWithValue("@Logo", empresaDto.Logo);
                comando.Parameters.AddWithValue("@IdPessoa", empresaDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
            }
        }

        public void AlterarEmpresa(EmpresaDto empresaDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE empresa SET nomefantasia = @NomeFantasia, logo = @Logo " +
                                      "WHERE idempresa =  @IdEmpresa";

                comando.Parameters.AddWithValue("@NomeFantasia", empresaDto.NomeFantasia);
                comando.Parameters.AddWithValue("@Logo", empresaDto.Logo);
                comando.Parameters.AddWithValue("@IdEmpresa", empresaDto.IdEmpresa);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public EmpresaDto GetEmpresaById(int idEmpresa)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * " +
                                      "FROM vwempresa " + 
                                      "WHERE idempresa = @IdEmpresa";

                comando.Parameters.AddWithValue("@IdEmpresa", idEmpresa);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var empresa = new EmpresaDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {


                        empresa.IdEmpresa = Convert.ToInt32(System.Convert.IsDBNull(dr["idempresa"]) ? null : dr["idempresa"]);
                        empresa.Id = Convert.ToInt32(System.Convert.IsDBNull(dr["idpessoa"]) ? null : dr["idpessoa"]);
                        empresa.NomeFantasia = Convert.ToString(System.Convert.IsDBNull(dr["nomefantasia"]) ? null : dr["nomefantasia"]);
                        empresa.Nome = Convert.ToString(System.Convert.IsDBNull(dr["nome"]) ? null : dr["nome"]);
                        empresa.CpfCnpj = Convert.ToString(System.Convert.IsDBNull(dr["cpfcnpj"]) ? null : dr["cpfcnpj"]);
                        empresa.RgIe = Convert.ToString(System.Convert.IsDBNull(dr["rgie"]) ? null : dr["rgie"]);
                        empresa.Logo = Convert.ToString(System.Convert.IsDBNull(dr["logo"]) ? null : dr["logo"]);
                        empresa.RgIe = Convert.ToString(System.Convert.IsDBNull(dr["rgie"]) ? null : dr["rgie"]);
                        empresa.EnderecoDto.Logradouro = Convert.ToString(System.Convert.IsDBNull(dr["logradouro"]) ? null : dr["logradouro"]);
                        empresa.EnderecoDto.Numero = Convert.ToString(System.Convert.IsDBNull(dr["numero"]) ? null : dr["numero"]);
                        empresa.EnderecoDto.Complemento = Convert.ToString(System.Convert.IsDBNull(dr["complemento"]) ? null : dr["complemento"]);
                        empresa.EnderecoDto.Bairro = Convert.ToString(System.Convert.IsDBNull(dr["bairro"]) ? null : dr["bairro"]);
                        empresa.EnderecoDto.Cep = Convert.ToString(System.Convert.IsDBNull(dr["cep"]) ? null : dr["cep"]);
                        empresa.EnderecoDto.CidadeDto.Cidade = Convert.ToString(System.Convert.IsDBNull(dr["cidade"]) ? null : dr["cidade"]);
                        empresa.EnderecoDto.CidadeDto.Uf = Convert.ToString(System.Convert.IsDBNull(dr["uf"]) ? null : dr["uf"]);
                        empresa.ContatoDto.TelFixo = Convert.ToString(System.Convert.IsDBNull(dr["telfixo"]) ? null : dr["telfixo"]);
                        empresa.ContatoDto.TelCel = Convert.ToString(System.Convert.IsDBNull(dr["telcel"]) ? null : dr["telcel"]);
                        empresa.ContatoDto.TelComercial = Convert.ToString(System.Convert.IsDBNull(dr["telcomercial"]) ? null : dr["telcomercial"]);
                        empresa.ContatoDto.Email = Convert.ToString(System.Convert.IsDBNull(dr["email"]) ? null : dr["email"]);
                    }
                }
                else
                {
                    empresa = null;
                }
                return empresa;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public EmpresaCollection FindAll()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * " +
                                      "FROM vwempresa ";

                MySqlDataReader dr = Conexao.Buscar(comando);

                var empresas = new EmpresaCollection();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var empresa = new EmpresaDto();

                        empresa.IdEmpresa = Convert.ToInt32(System.Convert.IsDBNull(dr["idempresa"]) ? null : dr["idempresa"]);
                        empresa.Id = Convert.ToInt32(System.Convert.IsDBNull(dr["idpessoa"]) ? null : dr["idpessoa"]);
                        empresa.NomeFantasia = Convert.ToString(System.Convert.IsDBNull(dr["nomefantasia"]) ? null : dr["nomefantasia"]);
                        empresa.Nome = Convert.ToString(System.Convert.IsDBNull(dr["nome"]) ? null : dr["nome"]);
                        empresa.CpfCnpj = Convert.ToString(System.Convert.IsDBNull(dr["cpfcnpj"]) ? null : dr["cpfcnpj"]);
                        empresa.RgIe = Convert.ToString(System.Convert.IsDBNull(dr["rgie"]) ? null : dr["rgie"]);
                        empresa.Logo = Convert.ToString(System.Convert.IsDBNull(dr["logo"]) ? null : dr["logo"]);
                        empresa.RgIe = Convert.ToString(System.Convert.IsDBNull(dr["rgie"]) ? null : dr["rgie"]);
                        empresa.EnderecoDto.Logradouro = Convert.ToString(System.Convert.IsDBNull(dr["logradouro"]) ? null : dr["logradouro"]);
                        empresa.EnderecoDto.Numero = Convert.ToString(System.Convert.IsDBNull(dr["numero"]) ? null : dr["numero"]);
                        empresa.EnderecoDto.Complemento = Convert.ToString(System.Convert.IsDBNull(dr["complemento"]) ? null : dr["complemento"]);
                        empresa.EnderecoDto.Bairro = Convert.ToString(System.Convert.IsDBNull(dr["bairro"]) ? null : dr["bairro"]);
                        empresa.EnderecoDto.Cep = Convert.ToString(System.Convert.IsDBNull(dr["cep"]) ? null : dr["cep"]);
                        empresa.EnderecoDto.CidadeDto.Cidade = Convert.ToString(System.Convert.IsDBNull(dr["cidade"]) ? null : dr["cidade"]);
                        empresa.EnderecoDto.CidadeDto.Uf = Convert.ToString(System.Convert.IsDBNull(dr["uf"]) ? null : dr["uf"]);
                        empresa.ContatoDto.TelFixo = Convert.ToString(System.Convert.IsDBNull(dr["telfixo"]) ? null : dr["telfixo"]);
                        empresa.ContatoDto.TelCel = Convert.ToString(System.Convert.IsDBNull(dr["telcel"]) ? null : dr["telcel"]);
                        empresa.ContatoDto.TelComercial = Convert.ToString(System.Convert.IsDBNull(dr["telcomercial"]) ? null : dr["telcomercial"]);
                        empresa.ContatoDto.Email = Convert.ToString(System.Convert.IsDBNull(dr["email"]) ? null : dr["email"]);

                        empresas.Add(empresa);
                    }
                }
                else
                {
                    empresas = null;
                }
                return empresas;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public EmpresaCollection FindAll(string searchType, object filter)
        {
            string pesquisa = "";

            if (searchType == "Nome" && filter != "")
                pesquisa = "WHERE nome LIKE '%" + filter + "%'";

            if (searchType == "CpfCnpj" && filter != "")

                pesquisa = "WHERE cpfcnpj LIKE '%" + filter + "%'";
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * " +
                                      "FROM vwempresa " + pesquisa;

                MySqlDataReader dr = Conexao.Buscar(comando);

                var empresas = new EmpresaCollection();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var empresa = new EmpresaDto();

                        empresa.IdEmpresa = Convert.ToInt32(System.Convert.IsDBNull(dr["idempresa"]) ? null : dr["idempresa"]);
                        empresa.Id = Convert.ToInt32(System.Convert.IsDBNull(dr["idpessoa"]) ? null : dr["idpessoa"]);
                        empresa.NomeFantasia = Convert.ToString(System.Convert.IsDBNull(dr["nomefantasia"]) ? null : dr["nomefantasia"]);
                        empresa.Nome = Convert.ToString(System.Convert.IsDBNull(dr["nome"]) ? null : dr["nome"]);
                        empresa.CpfCnpj = Convert.ToString(System.Convert.IsDBNull(dr["cpfcnpj"]) ? null : dr["cpfcnpj"]);
                        empresa.RgIe = Convert.ToString(System.Convert.IsDBNull(dr["rgie"]) ? null : dr["rgie"]);
                        empresa.Logo = Convert.ToString(System.Convert.IsDBNull(dr["logo"]) ? null : dr["logo"]);
                        empresa.RgIe = Convert.ToString(System.Convert.IsDBNull(dr["rgie"]) ? null : dr["rgie"]);
                        empresa.EnderecoDto.Logradouro = Convert.ToString(System.Convert.IsDBNull(dr["logradouro"]) ? null : dr["logradouro"]);
                        empresa.EnderecoDto.Numero = Convert.ToString(System.Convert.IsDBNull(dr["numero"]) ? null : dr["numero"]);
                        empresa.EnderecoDto.Complemento = Convert.ToString(System.Convert.IsDBNull(dr["complemento"]) ? null : dr["complemento"]);
                        empresa.EnderecoDto.Bairro = Convert.ToString(System.Convert.IsDBNull(dr["bairro"]) ? null : dr["bairro"]);
                        empresa.EnderecoDto.Cep = Convert.ToString(System.Convert.IsDBNull(dr["cep"]) ? null : dr["cep"]);
                        empresa.EnderecoDto.CidadeDto.Cidade = Convert.ToString(System.Convert.IsDBNull(dr["cidade"]) ? null : dr["cidade"]);
                        empresa.EnderecoDto.CidadeDto.Uf = Convert.ToString(System.Convert.IsDBNull(dr["uf"]) ? null : dr["uf"]);
                        empresa.ContatoDto.TelFixo = Convert.ToString(System.Convert.IsDBNull(dr["telfixo"]) ? null : dr["telfixo"]);
                        empresa.ContatoDto.TelCel = Convert.ToString(System.Convert.IsDBNull(dr["telcel"]) ? null : dr["telcel"]);
                        empresa.ContatoDto.TelComercial = Convert.ToString(System.Convert.IsDBNull(dr["telcomercial"]) ? null : dr["telcomercial"]);
                        empresa.ContatoDto.Email = Convert.ToString(System.Convert.IsDBNull(dr["email"]) ? null : dr["email"]);

                        empresas.Add(empresa);
                    }
                }
                else
                {
                    empresas = null;
                }
                return empresas;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public void Remove(int idEmpresa)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "DELETE FROM empresa WHERE  idempresa = @IdEmpresa";

                comando.Parameters.AddWithValue("@IdEmpresa", idEmpresa);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public void RemoveMass(int[] idEmpresa)
        {
            try
            {
                for (int i = 0; i < idEmpresa.Length; i++)
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "DELETE FROM empresa WHERE  idempresa = @IdEmpresa";

                    comando.Parameters.AddWithValue("@IdEmpresa", idEmpresa[i]);

                    Conexao.Crud(comando);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }
    }
}
