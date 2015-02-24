using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DTO.VendaDto
{
    public class CancelaItemDto
    {
        public int IdItemPedido { get; set; }

        public int IdPedido { get; set; }

        public int IdProduto { get; set; }

        public decimal Quantidade { get; set; }

        public string IdInterno { get; set; }

        public string Cliente { get; set; }

        public string Produto { get; set; }
    }
}
