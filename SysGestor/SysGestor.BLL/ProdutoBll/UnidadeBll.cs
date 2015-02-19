using SysGestor.DAL.ProdutoDal;
using SysGestor.DTO.Produto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System.Collections.Generic;
using System.Linq;

namespace SysGestor.BLL.ProdutoBll
{
    public class UnidadeBll
    {
        UnidadeDal _unidadeDal;

        public UnidadeBll()
        {
            _unidadeDal = new UnidadeDal();
        }

        private void Inserir(UnidadeDto unidadeDto)
        {
            AssertionConcern.AssertArgumentNotEmpty(unidadeDto.Descricao, Errors.EmptyDescription);
            AssertionConcern.AssertArgumentNotEquals(unidadeDto.Descricao,
                                                GetEqualsUnidade(unidadeDto.Descricao),
                                                Errors.EqualsValue);

            _unidadeDal.Inserir(unidadeDto);
        }

        private void Alterar(UnidadeDto unidadeDto)
        {
            AssertionConcern.AssertArgumentNotEmpty(unidadeDto.Descricao, Errors.EmptyDescription);
            AssertionConcern.AssertArgumentNotEquals(unidadeDto.Descricao,
                                                GetEqualsUnidade(unidadeDto.Descricao),
                                                Errors.EqualsValue);

            _unidadeDal.Alterar(unidadeDto);
        }

        public void Salvar(UnidadeDto unidadeDto)
        {
            if (unidadeDto.IdUnidMedida == null || unidadeDto.IdUnidMedida == 0) Inserir(unidadeDto);
            else Alterar(unidadeDto);
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

            if (lista != null) return lista;
            else return null;
        }
              
        public int GetIdListaUnidade(string unidade)
        {
            int id = 0;

            if (!string.IsNullOrEmpty(unidade))
            {
                var listaUnidade = new List<UnidadeDto>();

                listaUnidade = FindAll();

                if(listaUnidade != null)
                {
                    var p = from x in listaUnidade where x.Descricao == unidade select x.IdUnidMedida; //consulta linq

                    id = p.FirstOrDefault();
                }              
            }
           return id;
        }
    }
}
