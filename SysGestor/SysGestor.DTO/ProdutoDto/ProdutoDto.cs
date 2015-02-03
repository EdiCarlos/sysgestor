using SysGestor.DTO.PessoaDto.FornecedorDto;

namespace SysGestor.DTO.ProdutoDto
{
    public class ProdutoDto
    {
        public int Id { get; set; }

        public string IdInterno { get; set; }

        public string Descricao { get; set; }

        public decimal EstoqueMinimo { get; set; }

        public string LocalizacaoFisica { get; set; }

        public int Ativo { get; set; }

        public ValorProdutoDto ValorProdutoDto { get; set; }

        public CategoriaDto CategoriaDto { get; set; }

        public GradeDto GradeDto { get; set; }

        public FornecedorDto FornecedorDto { get; set; }

        public ProdutoDto()
        {
            ValorProdutoDto = new ValorProdutoDto();
            CategoriaDto = new CategoriaDto();
            GradeDto = new GradeDto();
            FornecedorDto = new FornecedorDto();
        }


    }
}
