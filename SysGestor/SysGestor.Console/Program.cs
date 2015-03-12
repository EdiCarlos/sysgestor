using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysGestor.DAL.Repositorio;
using SysGestor.BLL;
using SysGestor.DTO.PessoaDTO.ClienteDto;
using SysGestor.DAL.PessoaDal;


namespace SysGestor.DOS
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteBll clienteBll = new ClienteBll();
            ClienteDto clienteDto = new ClienteDto();
            PessoaDal pessoaDal = new PessoaDal();

            //clienteDto.Nome = "Adilson de Oliveira";
            //clienteDto.TipoPessoa = "Fisíca";
            //clienteDto.CpfCnpj = "1258745478963";
            //clienteDto.RgIe = "236587450";
            //clienteDto.DataNascimento = DateTime.Now;
            //clienteDto.DataCadastro = DateTime.Now;
            //clienteDto.Observacao = "asdfgasdffggggd";         

            //clienteBll.Inserir(clienteDto);


            clienteBll.FindAll();

            
           
                Console.WriteLine("Conectado com sucesso!!!");
                Console.ReadKey();
         
          
        }
    }
}
