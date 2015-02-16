using SysGestor.DAL.ProdutoDal;
using SysGestor.DTO.ProdutoDto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.ProdutoBll
{
    public class MovimentacaoEstoqueBll
    {
        MovimentacaoEstoqueDal _movEstoqueDal;

        public MovimentacaoEstoqueBll()
        {
            _movEstoqueDal = new MovimentacaoEstoqueDal();
        }

        private void Inserir(MovimentacaoEstoqueDto movimentacaoEstoqueDto)
        {
            AssertionConcern.AssertArgumentNotEmpty(movimentacaoEstoqueDto.IdDocumento, Errors.InvalidDocumento);
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.Quantidade, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.ValorCompra, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.ProdutoDto.Id, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.ProdutoDto.IdInterno, Errors.InvalidValue);
          
            _movEstoqueDal.Inserir(movimentacaoEstoqueDto);
        }

        private void Alterar(MovimentacaoEstoqueDto movimentacaoEstoqueDto)
        {
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.Id, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotEmpty(movimentacaoEstoqueDto.IdDocumento, Errors.InvalidDocumento);
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.Quantidade, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(movimentacaoEstoqueDto.ValorCompra, Errors.InvalidValue);

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

        public List<MovimentacaoEstoqueDto> FindAllFilter(string searchType, object filter)
        {
            AssertionConcern.AssertArgumentNotEmpty(searchType, Errors.InvalidFilter);
            AssertionConcern.AssertArgumentNotNull(filter, Errors.InvalidValue);

            var lista = new List<MovimentacaoEstoqueDto>();

            lista = _movEstoqueDal.FindAllFilter(searchType, filter);

            return lista;
        }
    }
}
