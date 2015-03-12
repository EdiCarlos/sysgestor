using SysGestor.DAL.PessoaDal;
using SysGestor.DTO.PessoaDTO;
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

        public void Alterar(EnderecoDto enderecoDto)
        {
            _enderecoDal.Alterar(enderecoDto);
        }
                
        public EnderecoDto GetEndereco(int id)
        {
            return _enderecoDal.GetEndereco(id);
        }
    }
}
