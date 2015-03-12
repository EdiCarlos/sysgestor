using System;

namespace SysGestor.DTO.VendaDto
{
    public class ParcelaDto
    {
        public int IdParcela { get; set; }

        public int NumParcela { get; set; }

        public PedidoDto PedidoDto { get; set; }

        public DateTime DataVencimento { get; set; }

        public double ValorParcela { get; set; }

        public DateTime DataPagamento { get; set; }

        public double ValorPago { get; set; }

        public double Desconto { get; set; }

        public decimal Juro { get; set; }

        public string Situacao { get; set; }

        public double Restante { get; set; }

        public string Historico { get; set; }

        public int QtdParcela { get; set; }

        public ParcelaDto()
        {
            PedidoDto = new PedidoDto();
        }
    }
}
