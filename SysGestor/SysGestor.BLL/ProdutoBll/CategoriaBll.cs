using SysGestor.DAL.ProdutoDal;
using SysGestor.DTO.ProdutoDto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SysGestor.BLL.ProdutoBll
{
    public class CategoriaBll
    {
        CategoriaDal _categoriaDal;

        public CategoriaBll()
        {
            _categoriaDal = new CategoriaDal();
        }

        public void Inserir(CategoriaDto categoriaDto)
        {
            AssertionConcern.AssertArgumentNotEmpty(categoriaDto.Descricao, Errors.EmptyDescription);
            AssertionConcern.AssertArgumentNotEquals(categoriaDto.Descricao,
                                                 GetEqualsCategoria(categoriaDto.Descricao),
                                                 Errors.EqualsValue);

            _categoriaDal.Inserir(categoriaDto);
        }

        public void Alterar(CategoriaDto categoriaDto)
        {
            AssertionConcern.AssertArgumentNotEmpty(categoriaDto.Descricao, Errors.EmptyDescription);
            AssertionConcern.AssertArgumentNotEquals(categoriaDto.Descricao,
                                                  GetEqualsCategoria(categoriaDto.Descricao), 
                                                  Errors.EqualsValue);

            _categoriaDal.Alterar(categoriaDto);
        }

        public void Remove(int idCategoria)
        {
            AssertionConcern.AssertArgumentNotNull(idCategoria, Errors.InvalidId);

            _categoriaDal.Remove(idCategoria);
        }

        public void RemoveMass(int[] idCategoria)
        {
            AssertionConcern.AssertArgumentNotNull(idCategoria, Errors.InvalidId);

            _categoriaDal.RemoveMass(idCategoria);
        }

        public CategoriaDto GetCategoria(int idCategoria)
        {
            AssertionConcern.AssertArgumentNotNull(idCategoria, Errors.InvalidId);

            return _categoriaDal.GetCategoria(idCategoria);
        }

        public string GetEqualsCategoria(string descricao)
        {
            return _categoriaDal.GetEqualsCategoria(descricao);
        }

        public List<CategoriaDto> FindAll(string searchValue, object filter)
        {
            var categorias = new List<CategoriaDto>();

            categorias = _categoriaDal.FindAll().ToList();

            if (searchValue == "Descricao" && filter != "")
                return categorias.Where(x => x.Descricao.Contains(Convert.ToString(filter))).ToList();

            if (searchValue == "Id" && filter != "")
                return categorias.Where(x => x.Id == Convert.ToInt32(filter)).ToList();

            return categorias;
        }
    }
}
