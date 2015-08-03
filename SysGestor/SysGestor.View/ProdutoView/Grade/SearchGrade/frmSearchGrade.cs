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

namespace SysGestor.View.ProdutoView.Grade.SearchGrade
{
    public partial class frmSearchGrade : Form
    {
        GradeBll _gradeBll;
        string searchValue;

        public frmSearchGrade()
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

            IList<GradeDto> grades = new List<GradeDto>();

            try
            {
                grades = _gradeBll.FindAll(searchValue, filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // dtgCategoria.DefaultCellStyle.Format = "000000";
            dtgPrincipal.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtgPrincipal.DataSource = grades;
        }

        private void frmSearchGrade_Load(object sender, EventArgs e)
        {
            _gradeBll = new GradeBll();

            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void dtgPrincipal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProdutoNew produto = (frmProdutoNew)this.Owner;
            produto.txtGrade.Text = System.Convert.IsDBNull(dtgPrincipal.CurrentRow.Cells[1].Value.ToString()) ? null :
                                                                (dtgPrincipal.CurrentRow.Cells[1].Value.ToString());

            Formularios.FormSearchCategoria = null;
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (Formularios.FormGradeNew == null) Formularios.FormGradeNew = new frmGradeNew();

            Formularios.FormGradeNew.Show();
            Formularios.FormGradeNew.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose(true);
            this.Close();
            Formularios.FormSearchGrade = null;
        }

        private void frmSearchGrade_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose(true);
            this.Close();
            Formularios.FormSearchGrade = null;
        }
    }
}
