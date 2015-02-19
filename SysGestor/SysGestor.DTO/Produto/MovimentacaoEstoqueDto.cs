using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DTO.Produto
{
    public class MovimentacaoEstoqueDto
    {
        public int Id { get; set; }

        public string  IdDocumento { get; set; }

        public decimal Quantidade { get; set; }

        public double ValorCompra { get; set; }

        public DateTime Data { get; set; }

        public string Observacao { get; set; }

        public string DescProduto { get; set; }

        public ProdutoDto ProdutoDto { get; set; }


        public MovimentacaoEstoqueDto()
        {
            ProdutoDto = new ProdutoDto();
        }
    }
}
