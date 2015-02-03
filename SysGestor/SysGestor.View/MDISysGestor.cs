using SysGestor.View.ClienteView;
using SysGestor.View.FornecedorView;
using SysGestor.View.ProdutoView;
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

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteNew frmClienteView = new frmClienteNew();
            frmClienteView.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClienteGrid frmClienteGrid = new frmClienteGrid();
            frmClienteGrid.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedorNew frmFornecedorNew = new frmFornecedorNew();
            frmFornecedorNew.Show();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFornecedorGrid frmFornecedorGrid = new frmFornecedorGrid();
            frmFornecedorGrid.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoriaNew frmCategoriaNew = new frmCategoriaNew();
            frmCategoriaNew.Show();
        }
    }
}
