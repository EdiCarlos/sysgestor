using SysGestor.View.ClienteView;
using SysGestor.View.FornecedorView;
using SysGestor.View.MenuForm;
using SysGestor.View.UsuarioView;
using SysGestor.View.VendaView;

namespace SysGestor.View
{
    public class Formularios
    {
       
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
        public static frmFecharPedidoVista FormFecharPedidoVista { get; set; }
        public static frmCancelarItem FormCancelarItem { get; set; }
        public static frmBuscarPedido FormBuscarPedido { get; set; }

        public static frmMenuFecharPedido FormMenuFecharPedido { get; set; }
    }
}
