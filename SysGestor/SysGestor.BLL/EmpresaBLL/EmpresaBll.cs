using SysGestor.DAL.EmpresaDAL;
using SysGestor.DAL.PessoaDal;
using SysGestor.DTO.EmpresaDTO;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.EmpresaBLL
{
   public class EmpresaBll
    {
       EmpresaDal _empresaDal;
       PessoaDal _pessoaDal;

       public EmpresaBll()
       {
           _empresaDal = new EmpresaDal();
           _pessoaDal = new PessoaDal();
       }
       public bool InserirEmpresa(EmpresaDto empresaDto)
       {
           _pessoaDal.Inserir(empresaDto);
           var idPessoa =_pessoaDal.GetIdPessoa();

           empresaDto.Id = idPessoa;

           if (_empresaDal.FindAll() == null)
           {
               _empresaDal.InserirEmpresa(empresaDto);
               return true;
           }
           else
           {
               return false;
           }
       }

       public EmpresaCollection FindAll()
       {
           return _empresaDal.FindAll();
       }

       public EmpresaCollection FindAll(string searchType, object filter)
       {
                return _empresaDal.FindAll(searchType,filter);
       }

       public void AlterarEmpresa(EmpresaDto empresaDto)
       {
           AssertionConcern.AssertArgumentIntNull(empresaDto.IdEmpresa, Errors.InvalidId);

           _empresaDal.AlterarEmpresa(empresaDto);
       }

       public EmpresaDto GetEmpresaById(int idEmpresa)
       {
           AssertionConcern.AssertArgumentIntNull(idEmpresa, Errors.InvalidId);

           return _empresaDal.GetEmpresaById(idEmpresa);
       }

       public void Remove(int idEmpresa)
       {
           AssertionConcern.AssertArgumentIntNull(idEmpresa, Errors.InvalidId);

           _empresaDal.Remove(idEmpresa);
       }

       public void RemoveMass(int[] idEmpresa)
       {
           AssertionConcern.AssertArgumentArrayIntNull(idEmpresa, Errors.InvalidId);

           _empresaDal.RemoveMass(idEmpresa);
       }
    }
}
