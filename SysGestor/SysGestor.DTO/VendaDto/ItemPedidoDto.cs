using SysGestor.DTO.Produto;

namespace SysGestor.DTO.VendaDto
{
    public class ItemPedidoDto
    {
        public int Id { get; set; }

        public decimal Quantidade { get; set; }

        public double Desconto { get; set; }

        public ProdutoDto ProdutoDto { get; set; }

        public PedidoDto PedidoDto { get; set; }


        public ItemPedidoDto()
        {
            ProdutoDto = new ProdutoDto();
            PedidoDto = new PedidoDto();
        }
    }
}
