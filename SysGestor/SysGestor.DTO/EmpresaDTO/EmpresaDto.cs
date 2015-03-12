using SysGestor.DTO.PessoaDTO;

namespace SysGestor.DTO.EmpresaDTO
{
    public class EmpresaDto : PessoaDto
    {
        public int IdEmpresa { get; set; }

        public string NomeFantasia { get; set; }

        public string Logo { get; set; }

        public PessoaDto PessoaDto { get; set; }

        public EnderecoDto EnderecoDto { get; set; }

        public ContatoDto ContatoDto { get; set; }

        public EmpresaDto()
        {
            PessoaDto = new PessoaDto();
            EnderecoDto = new EnderecoDto();
            ContatoDto = new ContatoDto();
        }


    }
}
