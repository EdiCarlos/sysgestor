
namespace SysGestor.DTO.PessoaDto
{
    public class ContatoDto
    {
        public int Id { get; set; }

        public string TelFixo { get; set; }

        public string TelCel { get; set; }

        public string TelComercial { get; set; }

        public string Email { get; set; }

        public PessoaDto PessoaDto { get; set; }

        public ContatoDto()
        {
            PessoaDto = new PessoaDto();
        }
    }
}
