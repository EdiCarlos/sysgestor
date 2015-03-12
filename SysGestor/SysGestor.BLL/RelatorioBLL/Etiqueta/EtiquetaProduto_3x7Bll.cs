using SysGestor.DAL.RelatorioDAL.Etiqueta;
using SysGestor.DTO.RelatorioDto.Etiqueta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.RelatorioBLL.Etiqueta
{
    public class EtiquetaProduto_3x7Bll
    {
        EtiquetaProduto_3x7Dal _etiqueta;

        public EtiquetaProduto_3x7Bll()
        {
            _etiqueta = new EtiquetaProduto_3x7Dal();
        }

        public EtiquetaProduto_3x7Collection FindAllFilter(string searchType, object filter)
        {
            return _etiqueta.FindAll(searchType, filter);
        }
    }
}
