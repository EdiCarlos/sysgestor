using SysGestor.BLL.ProdutoBLL;
using SysGestor.DAL.PedidoDal;
using SysGestor.DTO.VendaDto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysGestor.BLL.ProdutoBLL;

namespace SysGestor.BLL.VendaBll
{
    public class ItemPedidoBll
    {
        ItemPedidoDal _itemPedidoDal;
        ProdutoBll _produtoBll;

        public ItemPedidoBll()
        {
            _itemPedidoDal = new ItemPedidoDal();
            _produtoBll = new ProdutoBll();
        }
        public void InserirItemPedido(ItemPedidoDto itemPedidoDto, int statusPedido)
        {
            AssertionConcern.AssertArgumentNotNull(itemPedidoDto.Quantidade, Errors.NullQtd);
            AssertionConcern.AssertArgumentIntNull(itemPedidoDto.ProdutoDto.Id, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotNull(itemPedidoDto.ProdutoDto.IdInterno, Errors.InvalidId);
            AssertionConcern.AssertArgumentIntNull(itemPedidoDto.PedidoDto.Id, Errors.InvalidId);

            try
            {
                if (statusPedido == 1) _produtoBll.BaixaEstoque(itemPedidoDto.Quantidade, itemPedidoDto.ProdutoDto.Id);
                _itemPedidoDal.InserirItemPedido(itemPedidoDto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //public void AlterarPedido(itemPedidoDto itemPedidoDto)

        //}

        public void Remove(int idPedido)
        {
            AssertionConcern.AssertArgumentIntNull(idPedido, Errors.InvalidId);

            _itemPedidoDal.Remove(idPedido);
        }

        public List<ItemPedidoGridDto> GetItensPedidoById(int idPedido)
        {
            AssertionConcern.AssertArgumentNotNull(idPedido, Errors.InvalidId);

            var lista = new List<ItemPedidoGridDto>();

            lista = _itemPedidoDal.GetItensPedidoById(idPedido).ToList();

            return lista;
        }

        public void CancelaItemPedido(int statusPedido, decimal qtd, int idItemPedido, int idProduto)
        {
            AssertionConcern.AssertArgumentIntNull(idItemPedido, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotNull(qtd, Errors.NullQtd);
            AssertionConcern.AssertArgumentIntNull(statusPedido, Errors.InvalidValue);

            try
            {
                if (statusPedido == 1) _produtoBll.AumentaEstoque(qtd, idProduto);
                _itemPedidoDal.CancelaItemPedido(idItemPedido);               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public void AlteraItemPedido(int statusPedido, int idItemPedido, decimal qtd, decimal qtdEstorno, int idProduto)
        {
            AssertionConcern.AssertArgumentIntNull(idItemPedido, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotNull(qtd, Errors.NullQtd);

            try
            {
                if (statusPedido == 1) _produtoBll.AumentaEstoque(qtdEstorno, idProduto);
                _itemPedidoDal.AlteraItemPedido(idItemPedido, qtd);
            
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public CancelaItemDto GetItemCancelar(int idPedido, string idInterno)
        {
            AssertionConcern.AssertArgumentIntNull(idPedido, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotEmpty(idInterno, Errors.InvalidId);

            return _itemPedidoDal.GetItemCancelar(idPedido, idInterno);
        }
    }
}
