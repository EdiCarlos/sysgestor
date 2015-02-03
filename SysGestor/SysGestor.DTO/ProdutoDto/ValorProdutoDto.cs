
namespace SysGestor.DTO.ProdutoDto
{
    public class ValorProdutoDto
    {
        public int Id { get; set; }

        public double ValorCompra { get; set; }

        public double ValorVenda { get; set; }

        public decimal Margem { get; set; }

        public decimal Comissao { get; set; }
    }
}
