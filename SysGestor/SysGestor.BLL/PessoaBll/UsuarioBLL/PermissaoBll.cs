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
    public class PermissaoBll
    {
        PermissaoDal _permissaoDal;

        public PermissaoBll()
        {
            _permissaoDal = new PermissaoDal();
        }

        public void Inserir(PermissaoDto permissaoDto)
        {
            AssertionConcern.AssertArgumentNotEmpty(permissaoDto.Descricao, Errors.EmptyDescription);

            _permissaoDal.Inserir(permissaoDto);
        }

        public void Alterar(PermissaoDto permissaoDto)
        {
            AssertionConcern.AssertArgumentNotEmpty(permissaoDto.Descricao, Errors.EmptyDescription);

            _permissaoDal.Alterar(permissaoDto);
        }

        public PermissaoDto GetPermissaoById(int idPermissao)
        {
            AssertionConcern.AssertArgumentNotNull(idPermissao, Errors.InvalidId);

            return _permissaoDal.GetPermissaoById(idPermissao);
        }

        public List<PermissaoDto> FindAll()
        {
            return _permissaoDal.FindAll().ToList();
        }

        public void Remove(int idPermissao)
        {
            AssertionConcern.AssertArgumentNotNull(idPermissao, Errors.InvalidId);

            _permissaoDal.Remove(idPermissao);
        }

        public void RemoveMass(int[] idPermissao)
        {
            AssertionConcern.AssertArgumentArrayIntNull(idPermissao, Errors.InvalidId);

            _permissaoDal.RemoveMass(idPermissao);
        }
    }
}
