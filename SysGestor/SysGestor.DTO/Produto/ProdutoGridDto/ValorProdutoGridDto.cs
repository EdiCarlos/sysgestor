using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DTO.Produto.ProdutoGridDto
{
    public class ValorProdutoGridDto
    {
        public int Id { get; set; }

        public int IdProduto { get; set; }

        public string DescricaoProduto { get; set; }

        public double ValorCompra { get; set; }

        public double ValorVenda { get; set; }

        public decimal Margem { get; set; }

        public decimal Comissao { get; set; }       
    }
}
