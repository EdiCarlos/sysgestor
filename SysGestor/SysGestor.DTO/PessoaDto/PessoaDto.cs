using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DTO.PessoaDTO
{
    public class PessoaDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string TipoPessoa { get; set; }

        public string CpfCnpj { get; set; }

        public string RgIe { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataCadastro { get; set; }

        public int Ativo { get; set; }

        public string Observacao { get; set; }
    }
}
