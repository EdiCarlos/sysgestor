using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DTO.PessoaDto.ClienteDto
{
    public class ClienteDto : PessoaDto
    {
        public int IdCliente { get; set; }

        public PessoaDto PessoaDto { get; set; }

        public ClienteDto()
        {
            PessoaDto = new PessoaDto();
        }
    }
}
