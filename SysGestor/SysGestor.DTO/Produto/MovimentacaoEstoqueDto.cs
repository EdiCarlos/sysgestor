using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysGestor.DTO.PessoaDto.UsuarioDTO;

namespace SysGestor.DTO.Produto
{
    public class MovimentacaoEstoqueDto
    {
        public string  Documento { get; set; }

        public decimal Quantidade { get; set; }

        public DateTime Data { get; set; }

        public string Operacao { get; set; }

        public string Observacao { get; set; }       

        public ProdutoDto ProdutoDto { get; set; }

        public UsuarioDto UsuarioDto { get; set; }

        public UnidadeDto UnidadeDto { get; set; }


        public MovimentacaoEstoqueDto()
        {
            ProdutoDto = new ProdutoDto();
            UsuarioDto = new UsuarioDto();
            UnidadeDto = new UnidadeDto();
        }
    }
}
