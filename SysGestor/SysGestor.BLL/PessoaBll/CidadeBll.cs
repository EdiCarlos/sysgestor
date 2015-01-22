using SysGestor.DAL.PessoaDal;
using SysGestor.DTO.PessoaDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.PessoaBll
{
    public class CidadeBll
    {
        CidadeDal _cidadeDal;

        public CidadeBll()
        {
            _cidadeDal = new CidadeDal();
        }

        public IList<CidadeDto> FindUf() 
        {
            IList<CidadeDto> lista = new List<CidadeDto>();

            lista = _cidadeDal.FindUf();

            return lista;            
        }

        public IList<CidadeDto> FindCidade(string uf) 
        {
            IList<CidadeDto> lista = new List<CidadeDto>();

            lista = _cidadeDal.FindCidade(uf);

            return lista;   
        }
    }
}
