using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DTO.VendaDto
{
    public class PedidoGridDto
    {
        public int Id { get; set; }

        public string NomeCliente { get; set; }

        public string CpfCnpj { get; set; }

        public int Status { get; set; }

        public string TipoPedido { get; set; }

        public DateTime DataPedido { get; set; }

    }
}
