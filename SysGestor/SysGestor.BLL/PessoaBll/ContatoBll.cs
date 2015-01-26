using SysGestor.DAL.PessoaDal;
using SysGestor.DTO.PessoaDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.PessoaBll
{
    public class ContatoBll
    {
        ContatoDal _contatoDal;

        public ContatoBll()
        {
            _contatoDal = new ContatoDal();
        }

        public void Inserir(ContatoDto contatoDto) 
        {
            _contatoDal.Inserir(contatoDto);
        }
    }
}
