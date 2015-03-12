using System;
using SysGestor.DTO.PessoaDTO.ClienteDto;
using SysGestor.DTO.PessoaDTO.UsuarioDTO;

namespace SysGestor.DTO.VendaDto
{
    public class PedidoDto
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int Status { get; set; }

        public string Tipo { get; set; }

        public ClienteDto ClienteDto { get; set; }

        public UsuarioDto UsuarioDto { get; set; }

        public PedidoDto()
        {
            ClienteDto = new ClienteDto();
            UsuarioDto = new UsuarioDto();
        }
    }
}
