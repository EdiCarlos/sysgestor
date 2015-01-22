using SysGestor.DAL.PessoaDal;
using SysGestor.DTO.PessoaDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.PessoaBll
{
    public class EnderecoBll
    {
        EnderecoDal _enderecoDal;
        ClienteBll _clienteBll;
       
        public EnderecoBll()
        {
            _enderecoDal = new EnderecoDal();
            _clienteBll = new ClienteBll();
        }

        public void Inserir(EnderecoDto enderecoDto)
        {
            var idPessoa = _clienteBll.GetIdPessoa();
            _enderecoDal.Inserir(enderecoDto, idPessoa);
        }
    }
}
