using SysGestor.BLL;
using SysGestor.BLL.ProdutoBll;
using SysGestor.DTO.ProdutoDto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SysGestor.View.ProdutoView
{
    public partial class frmProdutoGrid : Form
    {
        ProdutoBll _produtoBll;
        string searchType;

        public frmProdutoGrid()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmProdutoGrid_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnSair);

            _produtoBll = new ProdutoBll();
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
            }
        }
               
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir esse(s) registro(s)?", Application.CompanyName,
                                                                                       MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int[] ids;
            int count = 0;

            for (int i = 0; i < dtgProduto.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgProduto.Rows[i].Cells[0].Value) == true)
                {
                    count++;
                }
            }

            ids = new int[count];
            int x = 0;

            for (int i = 0; i < dtgProduto.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgProduto.Rows[i].Cells[0].Value) == true)
                {
                    ids[x] = Convert.ToInt32(dtgProduto.Rows[i].Cells[1].Value.ToString());
                    x++;
                }
            }
            try
            {
                _produtoBll.RemoveMass(ids);
                MessageBox.Show("Registro(s), removido(s) com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void dtgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgProduto.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 9)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse registro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                dtgProduto.EndEdit();

                if (dtgProduto.CurrentRow.Cells[1].Value == null)
                    return;

                int id = Convert.ToInt32(dtgProduto.CurrentRow.Cells[1].Value.ToString());

                try
                {
                    _produtoBll.Remove(id);
                    MessageBox.Show("Registro, removido com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                carregaGrid(txtPesquisa.Text.Trim());
            }


            if (dtgProduto.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 8)
            {
                dtgProduto.EndEdit();

                if (dtgProduto.CurrentRow.Cells[1].Value == null)
                    return;

                TrocaInfo.Id = Convert.ToInt32(dtgProduto.CurrentRow.Cells[1].Value.ToString());

                this.Hide();

                frmProdutoEdit frmProdutoEdit = new frmProdutoEdit();
                frmProdutoEdit.Show();
            }
        }

        private void chkSelecionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgProduto.Rows)
            {
                if (chkSelecionarTodos.Checked)
                {
                    item.Cells[0].Value = true;
                }
                else
                {
                    item.Cells[0].Value = false;
                }
            }
        }
        #endregion

        #region Funções
        private void carregaGrid(string filter)
        {
            if (rbDescricao.Checked) searchType = "Descricao";

            if (rbCategoria.Checked) searchType = "Categoria";

            if (rbCodigo.Checked) searchType = "Id";

            if (rbIdInterno.Checked) searchType = "IdInterno";


            dtgProduto.AutoGenerateColumns = false;

            var produtos = new List<ProdutoDto>();

            try
            {
                produtos = _produtoBll.FindAllByDescricaoCategoriaIdInterno(searchType, filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // dtgCategoria.DefaultCellStyle.Format = "000000";
            dtgProduto.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtgProduto.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            dtgProduto.DataSource = produtos;
        }
        #endregion
    }
}
