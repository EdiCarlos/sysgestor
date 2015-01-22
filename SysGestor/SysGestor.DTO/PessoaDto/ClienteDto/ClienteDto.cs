
namespace SysGestor.DTO.PessoaDto.ClienteDto
{
    public class ClienteDto : PessoaDto
    {
        public int IdCliente { get; set; }

        public double LimiteCredito { get; set; }

        public PessoaDto PessoaDto { get; set; }

        public ClienteDto()
        {
            PessoaDto = new PessoaDto();
        }
    }
}
