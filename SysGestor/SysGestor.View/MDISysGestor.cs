using SysGestor.BLL.AuthenticationBLL;
using SysGestor.DTO.AuthenticationDTO;
using SysGestor.View.ClienteView;
using SysGestor.View.EmpresaView;
using SysGestor.View.FornecedorView;
using SysGestor.View.LoginView;
using SysGestor.View.ProdutoView;
using SysGestor.View.ProdutoView.Categoria;
using SysGestor.View.ProdutoView.Grade;
using SysGestor.View.ProdutoView.MovimentacaoEstoque;
using SysGestor.View.ProdutoView.Unidade;
using SysGestor.View.RelatorioView.Etiqueta;
using SysGestor.View.UsuarioView;
using SysGestor.View.VendaView;
using System;
using System.Windows.Forms;

namespace SysGestor.View
{
    public partial class MDISysGestor : Form
    {
        public MDISysGestor()
        {
            InitializeComponent();
        }

        private void MDISysGestor_Load(object sender, EventArgs e)
        {
            if (Formularios.FormLogin == null) Formularios.FormLogin = new frmLogin(this);

            Formularios.FormLogin.Show();
            //Formularios.FormLogin.Focus();
        }

        #region Empresa
        private void novoToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (Formularios.FormEmpresaNew == null) Formularios.FormEmpresaNew = new frmEmpresaNew();

            Formularios.FormEmpresaNew.Show();
            Formularios.FormEmpresaNew.Focus();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Formularios.FormEmpresaGrid == null) Formularios.FormEmpresaGrid = new frmEmpresaGrid();

            Formularios.FormEmpresaGrid.Show();
            Formularios.FormEmpresaGrid.Focus();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormEmpresaGrid == null) Formularios.FormEmpresaGrid = new frmEmpresaGrid();

            Formularios.FormEmpresaGrid.Show();
            Formularios.FormEmpresaGrid.Focus();
        }
        #endregion

        #region Cliente
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormClienteGrid == null) Formularios.FormClienteGrid = new frmClienteGrid();

            Formularios.FormClienteGrid.Show();
            Formularios.FormClienteGrid.Focus();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (Formularios.FormClienteGrid == null) Formularios.FormClienteGrid = new frmClienteGrid();

            Formularios.FormClienteGrid.Show();
            Formularios.FormClienteGrid.Focus();
        }
        #endregion

        #region Produto
        private void btnProduto_Click(object sender, EventArgs e)
        {
            if (Formularios.FormProdutoGrid == null) Formularios.FormProdutoGrid = new frmProdutoGrid();

            Formularios.FormProdutoGrid.Show();
            Formularios.FormProdutoGrid.Focus();
        }

        private void produtoNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormProdutoGrid == null) Formularios.FormProdutoGrid = new frmProdutoGrid();

            Formularios.FormProdutoGrid.Show();
            Formularios.FormProdutoGrid.Focus();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormProdutoNew == null) Formularios.FormProdutoNew = new frmProdutoNew();

            Formularios.FormProdutoNew.Show();
            Formularios.FormProdutoNew.Focus();
        }

        private void produtoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Formularios.FormProdutoGrid == null) Formularios.FormProdutoGrid = new frmProdutoGrid();

            Formularios.FormProdutoGrid.Show();
            Formularios.FormProdutoGrid.Focus();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            if (Formularios.FormMovimentaEstoque == null) Formularios.FormMovimentaEstoque = new frmMovimentacaoEstoqueNew();

            Formularios.FormMovimentaEstoque.Show();
            Formularios.FormMovimentaEstoque.Focus();
        }

        private void movimentoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormMovimentaEstoque == null) Formularios.FormMovimentaEstoque = new frmMovimentacaoEstoqueNew();

            Formularios.FormMovimentaEstoque.Show();
            Formularios.FormMovimentaEstoque.Focus();
        }

        private void unidadeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            if (Formularios.FormUnidadeMedida == null) Formularios.FormUnidadeMedida = new frmUnidadeNew();

            Formularios.FormUnidadeMedida.Show();
            Formularios.FormUnidadeMedida.Focus();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormCategoriaGrid == null) Formularios.FormCategoriaGrid = new frmCategoriaGrid();

            Formularios.FormCategoriaGrid.Show();
            Formularios.FormCategoriaGrid.Focus();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Formularios.FormCategoriaGrid == null) Formularios.FormCategoriaGrid = new frmCategoriaGrid();

            Formularios.FormCategoriaGrid.Show();
            Formularios.FormCategoriaGrid.Focus();
        }

        private void novoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (Formularios.FormCategoriaNew == null) Formularios.FormCategoriaNew = new frmCategoriaNew();

            Formularios.FormCategoriaNew.Show();
            Formularios.FormCategoriaNew.Focus();
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Formularios.FormGradeGrid == null) Formularios.FormGradeGrid = new frmGradeGrid();

            Formularios.FormGradeGrid.Show();
            Formularios.FormGradeGrid.Focus();
        }

        private void novoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (Formularios.FormGradeNew == null) Formularios.FormGradeNew = new frmGradeNew();

            Formularios.FormGradeNew.Show();
            Formularios.FormGradeNew.Focus();
        }

        private void gradeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Formularios.FormGradeGrid == null) Formularios.FormGradeGrid = new frmGradeGrid();

            Formularios.FormGradeGrid.Show();
            Formularios.FormGradeGrid.Focus();
        }
        #endregion

        #region Fornecedor
        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormFornecedorGrid == null) Formularios.FormFornecedorGrid = new frmFornecedorGrid();

            Formularios.FormFornecedorGrid.Show();
            Formularios.FormFornecedorGrid.Focus();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Formularios.FormFornecedorGrid == null) Formularios.FormFornecedorGrid = new frmFornecedorGrid();

            Formularios.FormFornecedorGrid.Show();
            Formularios.FormFornecedorGrid.Focus();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            if (Formularios.FormFornecedorGrid == null) Formularios.FormFornecedorGrid = new frmFornecedorGrid();

            Formularios.FormFornecedorGrid.Show();
            Formularios.FormFornecedorGrid.Focus();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Formularios.FormFornecedorNew == null) Formularios.FormFornecedorNew = new frmFornecedorNew();

            Formularios.FormFornecedorNew.Show();
            Formularios.FormFornecedorNew.Focus();
        }
        #endregion

        #region Usuário
        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormUsuarioGrid == null) Formularios.FormUsuarioGrid = new frmUsuarioGrid();

            Formularios.FormUsuarioGrid.Show();
            Formularios.FormUsuarioGrid.Focus();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (Formularios.FormUsuarioGrid == null) Formularios.FormUsuarioGrid = new frmUsuarioGrid();

            Formularios.FormUsuarioGrid.Show();
            Formularios.FormUsuarioGrid.Focus();
        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Formularios.FormUsuarioNew == null) Formularios.FormUsuarioNew = new frmUsuarioNew();

            Formularios.FormUsuarioNew.Show();
            Formularios.FormUsuarioNew.Focus();
        }
        #endregion      
    
        #region Venda
        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormPedido == null) Formularios.FormPedido = new frmPedido();


            Formularios.FormPedido.Show();
            Formularios.FormPedido.Focus();
        }

        private void btnPdv_Click(object sender, EventArgs e)
        {
            if (Formularios.FormPedido == null) Formularios.FormPedido = new frmPedido();


            Formularios.FormPedido.Show();
            Formularios.FormPedido.Focus();
        }
        #endregion

        #region Sair
        private void btnLogout_Click(object sender, EventArgs e)
        {
            AuthenticationBll authentication = new AuthenticationBll();

            authentication.Logout();

            menuStripMdi.Enabled = false;
            tlpPrincipal.Enabled = false;
            lblUsuarioLogado.Text = "Login: ";

            if (Formularios.FormLogin == null) Formularios.FormLogin = new frmLogin(this);

            Formularios.FormLogin.Show();
            Formularios.FormLogin.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do sistema?", Application.CompanyName, MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {

                Formularios.FormUsuarioNew = null;
                Application.Exit();
            }
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthenticationBll authentication = new AuthenticationBll();

            authentication.Logout();

            menuStripMdi.Enabled = false;
            tlpPrincipal.Enabled = false;
            lblUsuarioLogado.Text = "Login: ";

            if (Formularios.FormLogin == null) Formularios.FormLogin = new frmLogin(this);

            Formularios.FormLogin.Show();
            Formularios.FormLogin.Focus();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do sistema?", Application.CompanyName, MessageBoxButtons.YesNo) ==
                         DialogResult.Yes)
            {

                Formularios.FormUsuarioNew = null;
                Application.Exit();
            }
        }

        private void MDISysGestor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Funções
        public void HabilitarForm(bool habilita)
        {
            menuStripMdi.Enabled = habilita;
            tlpPrincipal.Enabled = habilita;
            if (habilita == true) lblUsuarioLogado.Text = "Login: " + AuthenticationDto.Id + " - " + AuthenticationDto.Usuario;
            else lblUsuarioLogado.Text = "Login: ";
        }
        #endregion

       
        #region Relatórios
        private void etiquetaDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.FormEtiquetaProduto == null) Formularios.FormEtiquetaProduto = new frmEtiquetaProduto();

            Formularios.FormEtiquetaProduto.Show();
            Formularios.FormEtiquetaProduto.Focus();
        }
        #endregion

     

    }
}
