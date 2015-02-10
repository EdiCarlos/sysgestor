using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL
{
    public static class TrocaInfo 
    {
        public static int Id { get; set; }

        public static void Dispose() 
        {
            Id = 0;
        }

    }
}
