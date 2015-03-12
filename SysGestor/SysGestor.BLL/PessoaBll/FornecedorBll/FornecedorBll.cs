using SysGestor.DAL.PessoaDal;
using SysGestor.DAL.PessoaDal.FornecedorDal;
using SysGestor.DTO.PessoaDTO.FornecedorDto;
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

        public List<FornecedorDto> FindAll()
        {
           var lista = new List<FornecedorDto>();

            lista = null;

            lista = _fornecedorDal.FindAll().ToList();

            if (lista != null) return lista;
            else return null;
        }

        public void Remove(int idFornecedor)
        {
            _fornecedorDal.Remove(idFornecedor);
        }

        public void RemoveMass(int[] idFornecedor)
        {
            _fornecedorDal.RemoveMass(idFornecedor);
        }

        public int GetIdListaFornecedor(string nome)
        {
            int id = 0;

            if (!string.IsNullOrEmpty(nome))
            {
                var listaFornecedor = new List<FornecedorDto>();

                listaFornecedor = FindAll();

                if (listaFornecedor != null)
                {
                    var p = from x in listaFornecedor where x.Nome == nome select x.IdFornecedor; //consulta linq

                    id = p.FirstOrDefault();
                }
            }
            return id;
        }
    }
}
