
namespace SysGestor.DTO.Produto
{
    public class ValorProdutoDto
    {
        public int Id { get; set; }

        public double ValorCompra { get; set; }

        public double ValorVenda { get; set; }

        public decimal Margem { get; set; }

        public decimal Comissao { get; set; }

        public double UltimoValorCompra { get; set; }

        public double UltimoValorVenda { get; set; }

        public decimal UltimaMargem { get; set; }

        public decimal UltimaComissao { get; set; }

        public double ValorPrazo { get; set; }

        public double ValorCartao { get; set; }

        public decimal MargemPrazo { get; set; }

        public decimal MargemCartao { get; set; }

        public ProdutoDto ProdutoDto { get; set; }

        public ValorProdutoDto()
        {
            ProdutoDto = new ProdutoDto();
        }
    }
}
