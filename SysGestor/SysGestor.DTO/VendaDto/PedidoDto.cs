using System;
using SysGestor.DTO.PessoaDto.ClienteDto;

namespace SysGestor.DTO.VendaDto
{
    public class PedidoDto
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int Status { get; set; }

        public ClienteDto ClienteDto { get; set; }

        public PedidoDto()
        {
            ClienteDto = new ClienteDto();
        }
    }
}
