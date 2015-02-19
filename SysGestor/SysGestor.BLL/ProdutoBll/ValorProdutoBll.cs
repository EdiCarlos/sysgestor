using SysGestor.DAL.ProdutoDal;
using SysGestor.DTO.Produto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.ProdutoBll
{
    public class ValorProdutoBll
    {
        ValorProdutoDto _valorProdutoDto;
        ValorProdutoDal _valorProdutoDal;

        public ValorProdutoBll()
        {
            _valorProdutoDto = new ValorProdutoDto();
            _valorProdutoDal = new ValorProdutoDal();
        }

        public void Inserir(ValorProdutoDto valorProdutoDto)
        {
            AssertionConcern.AssertArgumentNotNull(valorProdutoDto.ProdutoDto.Id, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotNull(valorProdutoDto.ValorCompra, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(valorProdutoDto.ValorVenda, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(valorProdutoDto.Margem, Errors.InvalidValue);

            _valorProdutoDal.Inserir(valorProdutoDto);
        }

        public void Alterar(ValorProdutoDto valorProdutoDto)
        {
            AssertionConcern.AssertArgumentNotNull(valorProdutoDto.ProdutoDto.Id, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotNull(valorProdutoDto.ValorCompra, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(valorProdutoDto.ValorVenda, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(valorProdutoDto.Margem, Errors.InvalidValue);

            _valorProdutoDal.Alterar(valorProdutoDto);
        }

        public ValorProdutoDto GetValorProdutoById(int IdProduto)
        {
            AssertionConcern.AssertArgumentNotNull(IdProduto, Errors.InvalidId);

            return _valorProdutoDal.GetValorProdutoById(IdProduto);
        }
    }
}
