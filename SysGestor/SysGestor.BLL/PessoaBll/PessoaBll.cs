using SysGestor.DAL.PessoaDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.PessoaBll
{
    public class PessoaBll
    {
        PessoaDal _pessoaDal;


        public PessoaBll()
        {
            _pessoaDal = new PessoaDal();
        }
        public int GetIdPessoa()
        {
            return _pessoaDal.GetIdPessoa();
        }
    }
}
