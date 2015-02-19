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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View
{
    public partial class MDISysGestor : Form
    {
        public MDISysGestor()
        {
            InitializeComponent();
        }
        #region Cliente
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormClienteNew == null) Formularios.FormClienteNew = new frmClienteNew();

            Formularios.FormClienteNew.Show();
            Formularios.FormClienteNew.Focus();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Formularios.FormClienteGrid == null) Formularios.FormClienteGrid = new frmClienteGrid();

            Formularios.FormClienteGrid.Show();
            Formularios.FormClienteGrid.Focus();
        }
        #endregion

        #region Fornecedor
        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormFornecedorNew == null) Formularios.FormFornecedorNew = new frmFornecedorNew();

            Formularios.FormFornecedorNew.Show();
            Formularios.FormFornecedorNew.Focus();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Formularios.FormFornecedorGrid == null) Formularios.FormFornecedorGrid = new frmFornecedorGrid();

            Formularios.FormFornecedorGrid.Show();
            Formularios.FormFornecedorGrid.Focus();
        }
        #endregion

        #region Fornecedor

        #endregion

        #region Fornecedor

        #endregion

        #region Fornecedor

        #endregion

        #region Fornecedor

        #endregion

        #region Fornecedor

        #endregion
        

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoriaNew frmCategoriaNew = new frmCategoriaNew();
            frmCategoriaNew.Show();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategoriaGrid frmCategoriaGrid = new frmCategoriaGrid();
            frmCategoriaGrid.Show();
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGradeNew frmGradeNew = new frmGradeNew();
            frmGradeNew.Show();
        }

        private void gradeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGradeGrid frmGradeGrid = new frmGradeGrid();
            frmGradeGrid.Show();
        }

        private void produtoNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutoNew frmProdutoNew = new frmProdutoNew();
            frmProdutoNew.Show();
        }

        private void unidadeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnidadeNew frmUnidade = new frmUnidadeNew();
            frmUnidade.Show();
        }

        private void produtoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProdutoGrid frmProdutoGrid = new frmProdutoGrid();
            frmProdutoGrid.Show();
        }

        private void movimentoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoEstoqueNew frmMovEstoqueNew = new frmMovimentacaoEstoqueNew();
            frmMovEstoqueNew.Show();
        }

        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPDV frmPdv = new frmPDV();
            frmPdv.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormPedido == null) Formularios.FormPedido = new frmPedido();
            
            Formularios.FormPedido.Show();
            Formularios.FormPedido.Focus();

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormUsuarioNew == null) Formularios.FormUsuarioNew = new frmUsuarioNew();

            Formularios.FormUsuarioNew.Show();
            Formularios.FormUsuarioNew.Focus();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDISysGestor_Load(object sender, EventArgs e)
        {
            if (Formularios.FormLogin == null) Formularios.FormLogin = new frmLogin();

            Formularios.FormLogin.Show();
            Formularios.FormLogin.Focus();
        }

      
    }
}
