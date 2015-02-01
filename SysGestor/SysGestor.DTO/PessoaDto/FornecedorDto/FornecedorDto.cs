using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DTO.PessoaDto.FornecedorDto
{
    public class FornecedorDto : PessoaDto
    {
        public int IdFornecedor { get; set; }

        public PessoaDto PessoaDto { get; set; }

        public FornecedorDto()
        {
            PessoaDto = new PessoaDto();         
        }
    }
}
