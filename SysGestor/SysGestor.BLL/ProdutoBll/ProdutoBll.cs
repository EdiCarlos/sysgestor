using SysGestor.DAL.ProdutoDal;
using SysGestor.DTO.ProdutoDto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System.Collections.Generic;

namespace SysGestor.BLL.ProdutoBll
{
    public class ProdutoBll
    {
        ProdutoDal _produtoDal;
        ProdutoDto _produtoDto;

        public ProdutoBll()
        {
            _produtoDal = new ProdutoDal();
            _produtoDto = new ProdutoDto();
        }

        public void Inserir(ProdutoDto produtoDto)
        {
            AssertionConcern.AssertArgumentNotNull(produtoDto.IdInterno, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotNull(produtoDto.Descricao, Errors.EmptyDescription);
            AssertionConcern.AssertArgumentNotNull(produtoDto.CategoriaDto.Id, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(produtoDto.GradeDto.Id, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(produtoDto.FornecedorDto.Id, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotEquals(produtoDto.Descricao,
                                                 GetEqualsProduto(produtoDto.Descricao),
                                                 Errors.EqualsValue);

            _produtoDal.Inserir(produtoDto);
        }

        public void Alterar(ProdutoDto produtoDto)
        {
            AssertionConcern.AssertArgumentNotNull(produtoDto.IdInterno, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotNull(produtoDto.Descricao, Errors.EmptyDescription);
            AssertionConcern.AssertArgumentNotNull(produtoDto.CategoriaDto.Id, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(produtoDto.GradeDto.Id, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(produtoDto.FornecedorDto.Id, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotEquals(produtoDto.Descricao,
                                                GetEqualsProduto(produtoDto.Descricao),
                                                Errors.EqualsValue);

            _produtoDal.Alterar(produtoDto);
        }

        public void Remove(int idProduto)
        {
            AssertionConcern.AssertArgumentNotNull(idProduto, Errors.InvalidId);

            _produtoDal.Remove(idProduto);
        }

        public void RemoveMass(int[] idProduto)
        {
            AssertionConcern.AssertArgumentNotNull(idProduto, Errors.InvalidId);

            _produtoDal.RemoveMass(idProduto);
        }

        public ProdutoDto GetProdutoById(int idProduto)
        {
            AssertionConcern.AssertArgumentNotNull(idProduto, Errors.InvalidId);

            return _produtoDal.GetProdutoById(idProduto);
        }

        public string GetEqualsProduto(string descricao)
        {
            return _produtoDal.GetEqualsProduto(descricao);
        }

        public IList<ProdutoDto> FindAllByDescricaoCategoriaIdInterno(string descricao, string categoria, string idInterno)
        {
            return _produtoDal.FindAllByDescricaoCategoriaIdInterno(descricao, categoria, idInterno);
        }
    }
}
