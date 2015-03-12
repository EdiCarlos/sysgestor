using SysGestor.DAL.VendaDal;
using SysGestor.DTO.VendaDto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.VendaBll
{
    public class ParcelaBll
    {
        ParcelaDal _parcelaDal;

        public ParcelaBll()
        {
            _parcelaDal = new ParcelaDal();
        }

        public void InserirParcela(ParcelaDto parcelaDto, int qtdParcela)
        {
            AssertionConcern.AssertArgumentNotNull(parcelaDto.ValorParcela, Errors.InvalidValue);

            _parcelaDal.InserirParcela(parcelaDto, qtdParcela);
        }

        public void AlterarParcela(ParcelaDto parcelaDto)
        {
            AssertionConcern.AssertArgumentIntNull(parcelaDto.IdParcela, Errors.InvalidId);
            AssertionConcern.AssertArgumentIntNull(parcelaDto.PedidoDto.Id, Errors.InvalidId);

            _parcelaDal.AlterarParcela(parcelaDto);
        }

        public double[] CalculaParcela(decimal valorPedido, int qtdParcela, decimal juro)
        {
            double[] parcelas = new double[qtdParcela];

            if (juro > 0)
                valorPedido += (valorPedido * juro) / 100;

            if(qtdParcela == 2)
                valorPedido += (valorPedido * 5) / 100;

            if (qtdParcela == 3)
                valorPedido += (valorPedido * 6) / 100;

            if (qtdParcela >=4)
                valorPedido += (valorPedido * 8) / 100;

            double valorParcela = Convert.ToDouble( valorPedido / qtdParcela);

            for (int i = 0; i < qtdParcela; i++)
            {
                parcelas[i] = valorParcela;
            }

            return parcelas;
        }

        public ParcelaCollection GetCrediarioByIdCliente(int idCliente)
        {
            AssertionConcern.AssertArgumentIntNull(idCliente, Errors.InvalidId);

            return _parcelaDal.GetCrediarioByIdCliente(idCliente);
        }

        public ParcelaDto GetParcelaById(int idParcela)
        {
            AssertionConcern.AssertArgumentIntNull(idParcela, Errors.InvalidId);

            return _parcelaDal.GetParcelaById(idParcela);
        }
    }
}
