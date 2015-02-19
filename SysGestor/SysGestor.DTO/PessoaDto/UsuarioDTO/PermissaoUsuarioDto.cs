
namespace SysGestor.DTO.PessoaDto.UsuarioDTO
{
    public class PermissaoUsuarioDto
    {
        public UsuarioDto UsuarioDto { get; set; }

        public PermissaoDto PermissaoDto { get; set; }

        public PermissaoUsuarioDto()
        {
            UsuarioDto = new UsuarioDto();
            PermissaoDto = new PermissaoDto();
        }

    }
}
