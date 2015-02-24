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

        private void Inserir(MovimentacaoEstoqueDto movimentacaoEstoqueDto)
        {
            AssertionConcern.AssertArgumentNotEmpty(movimentacaoEstoqueDto.IdDocumento, Errors.InvalidDocumento);
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.Quantidade, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.ValorCompra, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.ProdutoDto.Id, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.ProdutoDto.IdInterno, Errors.InvalidValue);

            _produtoBll.AumentaEstoque(movimentacaoEstoqueDto.Quantidade, movimentacaoEstoqueDto.ProdutoDto.Id);
            _movEstoqueDal.Inserir(movimentacaoEstoqueDto);
        }

        private void Alterar(MovimentacaoEstoqueDto movimentacaoEstoqueDto)
        {
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.Id, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotEmpty(movimentacaoEstoqueDto.IdDocumento, Errors.InvalidDocumento);
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.Quantidade, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.ValorCompra, Errors.InvalidValue);

            _produtoBll.AumentaEstoque(movimentacaoEstoqueDto.Quantidade, movimentacaoEstoqueDto.ProdutoDto.Id);
            _movEstoqueDal.Alterar(movimentacaoEstoqueDto);
        }

        public void Salvar(MovimentacaoEstoqueDto movimentacaoEstoqueDto)
        {
            if (movimentacaoEstoqueDto.Id == 0 || movimentacaoEstoqueDto == null) Inserir(movimentacaoEstoqueDto);
            else Alterar(movimentacaoEstoqueDto);        
        }

        public void Remove(int idMovEstoque)
        {
            AssertionConcern.AssertArgumentNotNull(idMovEstoque, Errors.InvalidId);

            _movEstoqueDal.Remove(idMovEstoque);
        }

        public void RemoveMass(int[] idMovEstoque)
        {
            AssertionConcern.AssertArgumentArrayIntNull(idMovEstoque, Errors.InvalidId);

            _movEstoqueDal.RemoveMass(idMovEstoque);
        }

        public List<MovimentacaoEstoqueDto> FindAllFilter(string searchType, object filter)
        {
            AssertionConcern.AssertArgumentNotEmpty(searchType, Errors.InvalidFilter);
            AssertionConcern.AssertArgumentNotNull(filter, Errors.InvalidValue);

            var lista = new List<MovimentacaoEstoqueDto>();

            lista = _movEstoqueDal.FindAllFilter(searchType, filter);

            return lista;
        }

        public double CalculaValorEntradaEstoque(double qtd, double valorCompra)
        {
            double total = 0;

            AssertionConcern.AssertArgumentNotNull(qtd, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(valorCompra, Errors.InvalidValue);

            total = qtd * valorCompra;

            return total;
        }
    }
}
