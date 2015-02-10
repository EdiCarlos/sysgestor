using SysGestor.DAL.ProdutoDal;
using SysGestor.DTO.ProdutoDto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System.Collections.Generic;

namespace SysGestor.BLL.ProdutoBll
{
    public class UnidadeBll
    {
        UnidadeDal _unidadeDal;

        public UnidadeBll()
        {
            _unidadeDal = new UnidadeDal();
        }
        public void Inserir(UnidadeDto unidadeDto)
        {
            AssertionConcern.AssertArgumentNotNull(unidadeDto.Descricao, Errors.EmptyDescription);
            AssertionConcern.AssertArgumentNotEquals(unidadeDto.Descricao,
                                                GetEqualsUnidade(unidadeDto.Descricao),
                                                Errors.EqualsValue);

            _unidadeDal.Inserir(unidadeDto);
        }

        public string GetEqualsUnidade(string descricao)
        {
            return _unidadeDal.GetEqualsUnidade(descricao);
        }

        public void Remove(int id)
        {
            AssertionConcern.AssertArgumentNotNull(id, Errors.InvalidId);

            _unidadeDal.Remove(id);
        }

        public List<UnidadeDto> FindAll()
        {
            var lista = new List<UnidadeDto>();

            lista = null;

            lista = _unidadeDal.FindAll();

            if (lista.Count > 0)
            {
                return lista;
            }
            else
            {
                return null;
            }
        }
    }
}
