using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DTO.VendaDto
{
    public class ItemPedidoGridDto
    {
        public int Id { get; set; }

        public string IdInterno { get; set; }

        public string Descricao { get; set; }

        public decimal Quantidade { get; set; }

        public string Unidade { get; set; }

        public double ValorUnitario { get; set; }

        public double SubTotal { get; set; }
    }
}
