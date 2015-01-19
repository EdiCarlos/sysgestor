using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysGestor.DAL.Repositorio;


namespace SysGestor.DOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexao.Conectar();
           
                Console.WriteLine("Conectado com sucesso!!!");
                Console.ReadKey();
         
          
        }
    }
}
