using SysGestor.DAL.ProdutoDal;
using SysGestor.DTO.Produto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.ProdutoBLL
{
    public class MovimentacaoEstoqueBll
    {
        MovimentacaoEstoqueDal _movEstoqueDal;
        ProdutoBll _produtoBll;

        public MovimentacaoEstoqueBll()
        {
            _movEstoqueDal = new MovimentacaoEstoqueDal();
            _produtoBll = new ProdutoBll();
        }

        public void Inserir(MovimentacaoEstoqueDto movimentacaoEstoqueDto)
        {
            AssertionConcern.AssertArgumentDecimalNull(movimentacaoEstoqueDto.Quantidade, Errors.InvalidValue);
            AssertionConcern.AssertArgumentIntNull(movimentacaoEstoqueDto.ProdutoDto.Id, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotEmpty(movimentacaoEstoqueDto.ProdutoDto.IdInterno, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotEmpty(movimentacaoEstoqueDto.Operacao, Errors.InvalidOrNullOperation);
       
            _movEstoqueDal.Inserir(movimentacaoEstoqueDto);
        }

        public void Alterar(MovimentacaoEstoqueDto movimentacaoEstoqueDto)
        {
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.ProdutoDto.Id, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotEmpty(movimentacaoEstoqueDto.ProdutoDto.IdInterno, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.Quantidade, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotEmpty(movimentacaoEstoqueDto.Operacao, Errors.InvalidValue);

            //_produtoBll.AumentaEstoque(movimentacaoEstoqueDto.Quantidade, movimentacaoEstoqueDto.ProdutoDto.Id);
            _movEstoqueDal.Alterar(movimentacaoEstoqueDto);
        }

        //public void Salvar(MovimentacaoEstoqueDto movimentacaoEstoqueDto)
        //{
        //    if (movimentacaoEstoqueDto.IdProduto == 0 || movimentacaoEstoqueDto.IdProduto == null) Inserir(movimentacaoEstoqueDto);
        //    else Alterar(movimentacaoEstoqueDto);        
        //}

        //public void Remove(int idMovEstoque)
        //{
        //    AssertionConcern.AssertArgumentNotNull(idMovEstoque, Errors.InvalidId);

        //    _movEstoqueDal.Remove(idMovEstoque);
        //}

        //public void RemoveMass(int[] idMovEstoque)
        //{
        //    AssertionConcern.AssertArgumentArrayIntNull(idMovEstoque, Errors.InvalidId);

        //    _movEstoqueDal.RemoveMass(idMovEstoque);
        //}

        //public List<MovimentacaoEstoqueDto> FindAllFilter(string searchType, object filter)
        //{
        //    AssertionConcern.AssertArgumentNotEmpty(searchType, Errors.InvalidFilter);
        //    AssertionConcern.AssertArgumentNotNull(filter, Errors.InvalidValue);

        //    var lista = new List<MovimentacaoEstoqueDto>();

        //    lista = _movEstoqueDal.FindAllFilter(searchType, filter);

        //    return lista;
        //}

        //public double CalculaValorEntradaEstoque(double qtd, double valorCompra)
        //{
        //    double total = 0;

        //    AssertionConcern.AssertArgumentNotNull(qtd, Errors.InvalidValue);
        //    AssertionConcern.AssertArgumentNotNull(valorCompra, Errors.InvalidValue);

        //    total = qtd * valorCompra;

        //    return total;
        //}
    }
}
