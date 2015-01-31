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
    public class ContatoDal
    {
        public void Inserir(ContatoDto contatoDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO contato (telfixo, telcel, telcomercial, email, idpessoa) " +
                                      "VALUES (@TelFixo, @TelCel, @TelComercial, @Email, @IdPessoa)";

                comando.Parameters.AddWithValue("@TelFixo", contatoDto.TelFixo);
                comando.Parameters.AddWithValue("@TelCel", contatoDto.TelCel);
                comando.Parameters.AddWithValue("@TelComercial", contatoDto.TelComercial);
                comando.Parameters.AddWithValue("@Email", contatoDto.Email);
                comando.Parameters.AddWithValue("@IdPessoa", contatoDto.PessoaDto.Id);

                Conexao.Crud(comando);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao inserir dados. " + ex.Message);
            }
        }

        public void Alterar(ContatoDto contatoDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE contato SET telfixo = @TelFixo, telcel = @TelCel, " +
                                      "telcomercial = @TelComercial, email = @Email " +
                                      "WHERE idpessoa = @IdPessoa";

                comando.Parameters.AddWithValue("@TelFixo", contatoDto.TelFixo);
                comando.Parameters.AddWithValue("@TelCel", contatoDto.TelCel);
                comando.Parameters.AddWithValue("@TelComercial", contatoDto.TelComercial);
                comando.Parameters.AddWithValue("@Email", contatoDto.Email);
                comando.Parameters.AddWithValue("@IdPessoa", contatoDto.PessoaDto.Id);

                Conexao.Crud(comando);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao inserir dados. " + ex.Message);
            }
        }

        public ContatoDto GetContato(int id )
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT  idcontato, telfixo, telcel, telcomercial, email, idpessoa " +
                                      "FROM contato " +
                                      "WHERE idpessoa = @IdPessoa";

                comando.Parameters.AddWithValue("@IdPessoa",id);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var contato = new ContatoDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        contato.Id = (int)dr["idcontato"];
                        contato.TelFixo = (string)dr["telfixo"];
                        contato.TelCel = (string)dr["telcel"];
                        contato.TelComercial = (string)dr["telcomercial"];
                        contato.Email = (string)dr["email"];
                        contato.PessoaDto.Id = (int)dr["idpessoa"];
                    }
                }
                else
                {
                    contato = null;
                }
                return contato;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar dados. " + ex.Message);
            }
        }
    }
}
