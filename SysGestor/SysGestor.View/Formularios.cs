using SysGestor.View.VendaView;
using SysGestor.View.ClienteView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysGestor.View.FornecedorView;
using SysGestor.View.UsuarioView;
using SysGestor.View.LoginView;

namespace SysGestor.View
{
    public class Formularios
    {
        public static frmLogin FormLogin { get; set; }

        public static frmClienteNew FormClienteNew { get; set; }
        public static frmClienteGrid FormClienteGrid { get; set; }
        public static frmClienteEdit FormClienteEdit { get; set; }

        public static frmFornecedorNew FormFornecedorNew { get; set; }
        public static frmFornecedorGrid FormFornecedorGrid { get; set; }
        public static frmFornecedorEdit FormFornecedorEdit { get; set; }

        public static frmUsuarioNew FormUsuarioNew { get; set; }
        public static frmUsuarioGrid FormUsuarioGrid { get; set; }
        public static frmUsuarioEdit FormUsuarioEdit { get; set; }
        

        public static frmPedido FormPedido { get; set; }
    }
}
