using SysGestor.View.ClienteView;
using SysGestor.View.FornecedorView;
using SysGestor.View.LoginView;
using SysGestor.View.ProdutoView;
using SysGestor.View.ProdutoView.Categoria;
using SysGestor.View.ProdutoView.Grade;
using SysGestor.View.ProdutoView.MovimentacaoEstoque;
using SysGestor.View.ProdutoView.Unidade;
using SysGestor.View.UsuarioView;
using SysGestor.View.VendaView;
using SysGestor.View.Crediario;
using SysGestor.View.EmpresaView;
using SysGestor.View.RelatorioView.Etiqueta;

namespace SysGestor.View
{
    public class Formularios
    {
        public static frmLogin FormLogin { get; set; }
        public static MDISysGestor FormPrincipal { get; set; }

       
        public static frmClienteNew FormClienteNew { get; set; }
        public static frmClienteGrid FormClienteGrid { get; set; }
        public static frmClienteEdit FormClienteEdit { get; set; }

        public static frmFornecedorNew FormFornecedorNew { get; set; }
        public static frmFornecedorGrid FormFornecedorGrid { get; set; }
        public static frmFornecedorEdit FormFornecedorEdit { get; set; }

        public static frmProdutoNew FormProdutoNew { get; set; }
        public static frmProdutoEdit FormProdutoEdit { get; set; }
        public static frmProdutoGrid FormProdutoGrid { get; set; }

        public static frmUnidadeNew FormUnidadeMedida { get; set; }

        public static frmCategoriaNew FormCategoriaNew { get; set; }
        public static frmCategoriaEdit FormCategoriaEdit { get; set; }
        public static frmCategoriaGrid FormCategoriaGrid { get; set; }

        public static frmGradeNew FormGradeNew { get; set; }
        public static frmGradeEdit FormGradeEdit { get; set; }
        public static frmGradeGrid FormGradeGrid { get; set; }
       
        public static frmMovimentacaoEstoqueNew FormMovimentaEstoque { get; set; }

        public static frmUsuarioNew FormUsuarioNew { get; set; }
        public static frmUsuarioGrid FormUsuarioGrid { get; set; }
        public static frmUsuarioEdit FormUsuarioEdit { get; set; }
        

        public static frmPedido FormPedido { get; set; }
        public static frmCancelarItem FormCancelarItem { get; set; }
        public static frmBuscarPedido FormBuscarPedido { get; set; }
        public static frmFecharVendaVista FormFecharVendaVista { get; set; }
        public static frmFecharVendaPrazo FormFecharVendaPrazo { get; set; }

        public static frmCrediarioCliente FormCrediarioCliente { get; set; }
        public static frmPagamentoCrediario FormPagamentoCrediario { get; set; }

        public static frmEmpresaNew FormEmpresaNew { get; set; }
        public static frmEmpresaGrid FormEmpresaGrid { get; set; }
        public static frmEmpresaEdit FormEmpresaEdit { get; set; }

        public static frmEtiquetaProduto FormEtiquetaProduto { get; set; }
        public static frmRelatorioEtiquetaProduto FormRelatorioEtiquetaProduto { get; set; }

    }
}
