using SysGestor.BLL;
using SysGestor.BLL.ProdutoBll;
using SysGestor.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SysGestor.View.ProdutoView.Grade
{
    public partial class frmGradeGrid : Form
    {
         GradeBll _gradeBll;
         string searchValue;

        public frmGradeGrid()
        {
            InitializeComponent();
        }

        private void frmGradeGrid_Load(object sender, EventArgs e)
        {
            _gradeBll = new GradeBll();

            pcbCabecalho.Controls.Add(btnSair);

            carregaGrid(txtPesquisa.Text.Trim());

        }       

        private void carregaGrid(string filter)
        {          
            if (rbCodigo.Checked)
                searchValue = "Id";

            if(rbDescrição.Checked)
                searchValue = "Descricao";

            dtgGrade.AutoGenerateColumns = false;            

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
            dtgGrade.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
         
            dtgGrade.DataSource = grades;        
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

            for (int i = 0; i < dtgGrade.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgGrade.Rows[i].Cells[0].Value) == true)
                {
                    count++;
                }
            }

            ids = new int[count];
            int x = 0;

            for (int i = 0; i < dtgGrade.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgGrade.Rows[i].Cells[0].Value) == true)
                {
                    ids[x] = Convert.ToInt32(dtgGrade.Rows[i].Cells[1].Value.ToString());
                    x++;
                }
            }

            _gradeBll.RemoveMass(ids);

            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair da lista?", Application.CompanyName, 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
            }
        }

        private void dtgGrade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgGrade.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse registro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                dtgGrade.EndEdit();

                if (dtgGrade.CurrentRow.Cells[1].Value == null)
                    return;

                int id = Convert.ToInt32(dtgGrade.CurrentRow.Cells[1].Value.ToString());

                _gradeBll.Remove(id);

                carregaGrid(txtPesquisa.Text.Trim());
            }

            if (dtgGrade.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 3)
            {
                dtgGrade.EndEdit();

                if (dtgGrade.CurrentRow.Cells[1].Value == null)
                    return;

                TrocaInfo.Id = Convert.ToInt32(dtgGrade.CurrentRow.Cells[1].Value.ToString());

                this.Hide();

                frmGradeEdit frmGradeEdit = new frmGradeEdit();
                frmGradeEdit.Show();
            }           
        }

        private void chkSelecionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgGrade.Rows)
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
