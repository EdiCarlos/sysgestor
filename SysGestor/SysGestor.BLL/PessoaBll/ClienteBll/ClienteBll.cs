using SysGestor.DAL.PessoaDal;
using SysGestor.DAL.PessoaDal.ClienteDal;
using SysGestor.DTO.PessoaDto;
using SysGestor.DTO.PessoaDto.ClienteDto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
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
            _clienteDal.Inserir(clienteDto, idPessoa);
        }

        public void Alterar(ClienteDto clienteDto, int idPessoa)
        {
            _pessoaDal.Alterar(clienteDto, idPessoa);
            _clienteDal.Alterar(clienteDto);
        }

        public ClienteDto GetCliente(int id)
        {
            return _clienteDal.GetCliente(id);   
        }

        public ClienteDto GetClienteByNome(string nome)
        {
            AssertionConcern.AssertArgumentNotEmpty(nome, Errors.InvalidValue);

            return _clienteDal.GetClienteByNome(nome);
        }

        public ClienteDto GetClienteByCpfCnpj(string cpfCnpj)
        {
            AssertionConcern.AssertArgumentNotEmpty(cpfCnpj, Errors.InvalidValue);

            return _clienteDal.GetClienteByCpfCnpj(cpfCnpj);
        }

        public IList<ClienteDto> FindAll()
        {
            IList<ClienteDto> lista = new List<ClienteDto>();

            lista = null;

            lista = _clienteDal.FindAll();

            return lista;
        }

        public void Remove(int idCliente)
        {
            _clienteDal.Remove(idCliente);
        }

        public void RemoveMass(int[] idCliente)
        {
            _clienteDal.RemoveMass(idCliente);
        }
    }
}
