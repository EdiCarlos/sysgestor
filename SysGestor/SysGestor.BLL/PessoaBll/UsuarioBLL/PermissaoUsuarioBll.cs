using SysGestor.DAL.PessoaDal.UsuarioDAL;
using SysGestor.DTO.PessoaDTO.UsuarioDTO;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.PessoaBll.UsuarioBLL
{
    public class PermissaoUsuarioBll
    {
        PermissaoUsuarioDal _permissaoUsuarioDal;

        public PermissaoUsuarioBll()
        {
            _permissaoUsuarioDal = new PermissaoUsuarioDal();
        }

        public void Inserir(PermissaoUsuarioDto permissaoUsuarioDto)
        {
            AssertionConcern.AssertArgumentNotNull(permissaoUsuarioDto.PermissaoDto.Id, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotNull(permissaoUsuarioDto.UsuarioDto.IdUsuario, Errors.InvalidId);

            _permissaoUsuarioDal.Inserir(permissaoUsuarioDto);
        }
    }
}
