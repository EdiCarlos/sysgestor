using SysGestor.DAL.PessoaDal;
using SysGestor.DAL.PessoaDal.FornecedorDal;
using SysGestor.DTO.PessoaDto.FornecedorDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.PessoaBll.FornecedorBll
{
    public class FornecedorBll
    {
        PessoaDal _pessoaDal;
        FornecedorDal _fornecedorDal;

        public FornecedorBll()
        {
            _pessoaDal = new PessoaDal();
            _fornecedorDal = new FornecedorDal();
        }

        public int GetIdPessoa()
        {
            return _pessoaDal.GetIdPessoa();
        }

        public void Inserir(FornecedorDto fornecedorDto)
        {
            _pessoaDal.Inserir(fornecedorDto);
            var idPessoa = GetIdPessoa();
            _fornecedorDal.Inserir(fornecedorDto, idPessoa);
        }

        public void Alterar(FornecedorDto fornecedorDto, int idPessoa)
        {
            _pessoaDal.Alterar(fornecedorDto, idPessoa);
           // _fornecedorDal.Alterar(fornecedorDto);
        }

        public FornecedorDto GetFornecedor(int id)
        {
            return _fornecedorDal.GetFornecedor(id);   
        }

        public IList<FornecedorDto> FindAll()
        {
            IList<FornecedorDto> lista = new List<FornecedorDto>();

            lista = null;

            lista = _fornecedorDal.FindAll();

            return lista;
        }

        public void Remove(int idFornecedor)
        {
            _fornecedorDal.Remove(idFornecedor);
        }

        public void RemoveMass(int[] idFornecedor)
        {
            _fornecedorDal.RemoveMass(idFornecedor);
        }
    }
}
