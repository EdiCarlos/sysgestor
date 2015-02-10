using SysGestor.BLL;
using SysGestor.BLL.ProdutoBll;
using SysGestor.DTO.ProdutoDto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SysGestor.View.ProdutoView.Categoria
{
    public partial class frmCategoriaGrid : Form
    {
        CategoriaBll _categoriaBll;
        string searchValue;

        public frmCategoriaGrid()
        {
            InitializeComponent();
        }

        private void carregaGrid(string filter)
        {          
            if (rbCodigo.Checked)
                searchValue = "Id";

            if(rbDescrição.Checked)
                searchValue = "Descricao";

            dtgCategoria.AutoGenerateColumns = false;            

            IList<CategoriaDto> categorias = new List<CategoriaDto>();

            try
            {            
                categorias = _categoriaBll.FindAll(searchValue, filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }

          
          // dtgCategoria.DefaultCellStyle.Format = "000000";
            dtgCategoria.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            dtgCategoria.DataSource = categorias;        
        }

        private void frmCategoriaGrid_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnSair);

            _categoriaBll = new CategoriaBll();

            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir esse(s) registro(s)?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int[] ids;
            int count = 0;

            for (int i = 0; i < dtgCategoria.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgCategoria.Rows[i].Cells[0].Value) == true)
                {
                    count++;
                }
            }

            ids = new int[count];
            int x = 0;

            for (int i = 0; i < dtgCategoria.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgCategoria.Rows[i].Cells[0].Value) == true)
                {
                    ids[x] = Convert.ToInt32(dtgCategoria.Rows[i].Cells[1].Value.ToString());
                    x++;
                }
            }

            _categoriaBll.RemoveMass(ids);

            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair da lista?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
            }
        }

        private void dtgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgCategoria.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse registro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                dtgCategoria.EndEdit();

                if (dtgCategoria.CurrentRow.Cells[1].Value == null)
                    return;

                int id = Convert.ToInt32(dtgCategoria.CurrentRow.Cells[1].Value.ToString());

                _categoriaBll.Remove(id);

                carregaGrid(txtPesquisa.Text.Trim());
            }

            if (dtgCategoria.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 3)
            {
                dtgCategoria.EndEdit();

                if (dtgCategoria.CurrentRow.Cells[1].Value == null)
                    return;

                TrocaInfo.Id = Convert.ToInt32(dtgCategoria.CurrentRow.Cells[1].Value.ToString());

                this.Hide();

                frmCategoriaEdit frmCategoriaEdit = new frmCategoriaEdit();
                frmCategoriaEdit.Show();
            }           
        }

        private void chkSelecionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgCategoria.Rows)
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
    }
}
