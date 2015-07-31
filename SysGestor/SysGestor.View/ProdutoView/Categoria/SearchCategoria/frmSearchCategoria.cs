using SysGestor.BLL.ProdutoBLL;
using SysGestor.DTO.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.ProdutoView.Categoria.SearchCategoria
{
    public partial class frmSearchCategoria : Form
    {
        CategoriaBll _categoriaBll;
        string searchValue;

        public frmSearchCategoria()
        {
            InitializeComponent();
        }     

        private void carregaGrid(string filter)
        {
            if (rbCodigo.Checked)
                searchValue = "Id";

            if (rbDescrição.Checked)
                searchValue = "Descricao";

            dtgPrincipal.AutoGenerateColumns = false;

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
            dtgPrincipal.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtgPrincipal.DataSource = categorias;
        }

        private void frmSearchCategoria_Load(object sender, EventArgs e)
        {
            _categoriaBll = new CategoriaBll();

            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (Formularios.FormCategoriaNew == null) Formularios.FormCategoriaNew = new frmCategoriaNew();

            Formularios.FormCategoriaNew.Show();
            Formularios.FormCategoriaNew.Focus();
        }

        private void dtgPrincipal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProdutoNew produto = (frmProdutoNew)this.Owner;
            produto.txtCategoria.Text = System.Convert.IsDBNull(dtgPrincipal.CurrentRow.Cells[1].Value.ToString()) ? null :
                                                                (dtgPrincipal.CurrentRow.Cells[1].Value.ToString());

            Formularios.FormSearchCategoria = null;
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose(true);
            this.Close();
            Formularios.FormSearchCategoria = null;
        }

        private void frmSearchCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose(true);
            this.Close();
            Formularios.FormSearchCategoria = null;
        }
    }
}
