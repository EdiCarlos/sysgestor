using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.PessoaDto.UsuarioDTO;
using SysGestor.RESOURCE.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DAL.PessoaDal.UsuarioDAL
{
    public class PermissaoUsuarioDal
    {
        public void Inserir(PermissaoUsuarioDto permissaoUsuarioDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO permissaousuario(idusuario, idpermissao) " +
                                      "VALUES (@IdUsuario, @IdPermissao)";

                comando.Parameters.AddWithValue("@IdUsuario", permissaoUsuarioDto.UsuarioDto.IdUsuario);
                comando.Parameters.AddWithValue("@IdPermissao", permissaoUsuarioDto.PermissaoDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
            }
        }      
    }
}
