
namespace SysGestor.DTO.PessoaDTO
{
    public class EnderecoDto
    {
        public int Id { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public string Bairro { get; set; }

        public PessoaDto PessoaDto { get; set; }

        public CidadeDto CidadeDto { get; set; }

        public EnderecoDto()
        {
            PessoaDto = new PessoaDto();
            CidadeDto = new CidadeDto();
        }
    }
}
