using SysGestor.DAL.PedidoDAL;
using SysGestor.DTO.VendaDto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<PedidoGridDto> FindAllPedido(string searchValue, int tipoVenda, DateTime dataInicial, DateTime dataFinal, object filter)
        {
            var lista = new List<PedidoGridDto>();

            lista = _pedidoDal.FindAllPedido();

            if (searchValue == "Pedido" && filter != null)
                return lista.Where(x => x.Id == Convert.ToInt32(filter) && 
                                   x.Status == tipoVenda && 
                                   (x.DataPedido.Date >= dataInicial && x.DataPedido.Date <= dataFinal)).ToList();

            if (searchValue == "Cliente" && filter != null)
                return lista.Where(x => x.NomeCliente.ToUpper().Contains(Convert.ToString(filter).ToUpper()) &&
                                   x.Status == tipoVenda &&
                                   (x.DataPedido.Date >= dataInicial && x.DataPedido.Date <= dataFinal)).ToList();

            if (searchValue == "CpfCnpj" && filter != null)
                return lista.Where(x => x.CpfCnpj.Contains(Convert.ToString(filter)) && 
                                   x.Status == tipoVenda && 
                                   (x.DataPedido.Date >= dataInicial && x.DataPedido.Date <= dataFinal)).ToList();

            
            return lista;
        }
    }
}
