using SysGestor.DAL.PedidoDAL;
using SysGestor.DTO.VendaDto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System.Collections.Generic;

namespace SysGestor.BLL.VendaBll
{
    public class PedidoBll
    {
        PedidoDal _pedidoDal;

        public PedidoBll()
        {
            _pedidoDal = new PedidoDal();
        }
        public void InserirPedido(PedidoDto pedidoDto)
        {
            AssertionConcern.AssertArgumentNotNull(pedidoDto.Status, Errors.InvalidValue);
            AssertionConcern.AssertArgumentIntNull(pedidoDto.UsuarioDto.IdUsuario, Errors.InvalidId);
            AssertionConcern.AssertArgumentIntNull(pedidoDto.ClienteDto.IdCliente, Errors.InvalidId);

            _pedidoDal.InserirPedido(pedidoDto);
        }

        public void AlterarPedido(PedidoDto pedidoDto)
        {
            AssertionConcern.AssertArgumentNotNull(pedidoDto.Status, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotEmpty(pedidoDto.Tipo, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(pedidoDto.UsuarioDto.Id, Errors.InvalidId);

            _pedidoDal.AlterarPedido(pedidoDto);
        }

        public void FecharPedido(PedidoDto pedidoDto)
        {
            AssertionConcern.AssertArgumentIntNull(pedidoDto.Status, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotEmpty(pedidoDto.Tipo, Errors.InvalidValue);
            AssertionConcern.AssertArgumentIntNull(pedidoDto.UsuarioDto.Id, Errors.InvalidId);

            _pedidoDal.FecharPedido(pedidoDto);
        }

        public void Remove(int idPedido)
        {
            AssertionConcern.AssertArgumentNotNull(idPedido, Errors.InvalidId);

            _pedidoDal.Remove(idPedido);
        }

        public int GetIdPedido()
        {
            return _pedidoDal.GetIdPedido();
        }

        public int GetIdClientePedido(int idPedido)
        {
            AssertionConcern.AssertArgumentIntNull(idPedido, Errors.InvalidValue);

            return _pedidoDal.GetIdClientePedido(idPedido);
        }

        public List<PedidoDto> FindAll()
        {
            return _pedidoDal.FindAll();
        }

        public List<PedidoGridDto> FindAllPedido()
        {
            return _pedidoDal.FindAllPedido();
        }
    }
}
