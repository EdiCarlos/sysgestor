
namespace SysGestor.DTO.PessoaDto.UsuarioDTO
{
    public class UsuarioDto : PessoaDto
    {
        public int IdUsuario { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }
    }
}
