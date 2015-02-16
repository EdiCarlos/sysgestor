﻿using SysGestor.View.ClienteView;
using SysGestor.View.FornecedorView;
using SysGestor.View.ProdutoView;
using SysGestor.View.ProdutoView.Categoria;
using SysGestor.View.ProdutoView.Grade;
using SysGestor.View.ProdutoView.MovimentacaoEstoque;
using SysGestor.View.ProdutoView.Unidade;
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
    }
}
