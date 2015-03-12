using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DTO.RelatorioDto.Etiqueta
{
    public class EtiquetaProduto_3x7Dto
    {
         public string CodigoBarra { get; set; }

        public int Id { get; set; }

        public string Descricao { get; set; }

        public int IdEmpresa { get; set; }

        public string Empresa { get; set; }

        public double PrecoVista { get; set; }

        public double PrecoPrazo { get; set; }

        public double PrecoCartao { get; set; }

        public EtiquetaProduto_3x7Dto()
        {

        }

        public EtiquetaProduto_3x7Dto(int id, string codigoBarra, string descricao, string empresa, double precoVista, double precoPrazo, double precoCartao)
        {
            this.Id = id;
            this.CodigoBarra = codigoBarra;
            this.Descricao = descricao;
            this.Empresa = empresa;
            this.PrecoVista = precoVista;
            this.PrecoCartao = precoCartao;
            this.PrecoPrazo = precoPrazo;
        }
    }
}
