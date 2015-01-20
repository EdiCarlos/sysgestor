using SysGestor.DAL.PessoaDal;
using SysGestor.DAL.PessoaDal.ClienteDal;
using SysGestor.DTO.PessoaDto.ClienteDto;
using System.Collections;
using System.Collections.Generic;

namespace SysGestor.BLL
{
    public class ClienteBll
    {
        PessoaDal _pessoaDal;
        ClienteDal _clienteDal;
        public ClienteBll()
        {
            _pessoaDal = new PessoaDal();
            _clienteDal = new ClienteDal();
        }

        public int GetIdPessoa()
        {
            return _pessoaDal.GetIdPessoa();
        }

        public void Inserir(ClienteDto clienteDto)
        {
            _pessoaDal.Inserir(clienteDto);
            var idPessoa = GetIdPessoa();
            _clienteDal.Inserir(idPessoa);
        }

        public void Alterar(ClienteDto clienteDto)
        {
            _pessoaDal.Alterar(clienteDto);
        }

        public IList<ClienteDto> FindById(int id)
        {
            IList<ClienteDto> lista = new List<ClienteDto>();

            lista = null;

            if (id != 0)
                lista = _clienteDal.FindById(id);
           
                return lista;          
        }

        public IList<ClienteDto> FindAll()
        {
            IList<ClienteDto> lista = new List<ClienteDto>();

            lista = null;
         
                lista = _clienteDal.FindAll();

            return lista;
        }
    }
}
