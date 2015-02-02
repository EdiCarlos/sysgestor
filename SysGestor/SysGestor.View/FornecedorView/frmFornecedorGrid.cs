using SysGestor.BLL;
using SysGestor.BLL.PessoaBll.FornecedorBll;
using SysGestor.DTO.PessoaDto.FornecedorDto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.FornecedorView
{
    public partial class frmFornecedorGrid : Form
    {
        public frmFornecedorGrid()
        {
            InitializeComponent();
        }

        private void carregaGrid(string filtro)
        {
            dtgFornecedor.AutoGenerateColumns = false;

            FornecedorBll fornecedorBll = new FornecedorBll();

            IList<FornecedorDto> fornecedores = new List<FornecedorDto>();

            fornecedores = fornecedorBll.FindAll();

            if (fornecedores == null)
            {
                dtgFornecedor.DataSource = null;
                dtgFornecedor.Refresh();
                return;
            }

            if (rbNome.Checked)
            {
                dtgFornecedor.DataSource = null;
                dtgFornecedor.DataSource = fornecedores.Where(x => x.Nome.Contains(filtro)).ToList();
                dtgFornecedor.Refresh();
            }

            if (rbCpfCnpj.Checked)
            {
                dtgFornecedor.DataSource = null;
                dtgFornecedor.DataSource = fornecedores.Where(x => x.CpfCnpj.Contains(filtro)).ToList();
                dtgFornecedor.Refresh();
            }
        }

        private void frmFornecedorGrid_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnSair);
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void dtgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FornecedorBll fornecedorBll = new FornecedorBll();

            if (dtgFornecedor.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse registro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                dtgFornecedor.EndEdit();

                if (dtgFornecedor.CurrentRow.Cells[1].Value == null)
                    return;

                int id = Convert.ToInt32(dtgFornecedor.CurrentRow.Cells[1].Value.ToString());

                fornecedorBll.Remove(id);

                carregaGrid(txtPesquisa.Text.Trim());
            }

            if (dtgFornecedor.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 5)
            {
                dtgFornecedor.EndEdit();

                if (dtgFornecedor.CurrentRow.Cells[1].Value == null)
                    return;

                TrocaInfo.Id = Convert.ToInt32(dtgFornecedor.CurrentRow.Cells[1].Value.ToString());

                this.Hide();

                frmFornecedorEdit frmFornecedorEdit = new frmFornecedorEdit();
                frmFornecedorEdit.Show();
            }
        }

        private void chkSelecionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgFornecedor.Rows)
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir esse(s) registro(s)?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            FornecedorBll fornecedorBll = new FornecedorBll();

            int[] ids;
            int count = 0;

            for (int i = 0; i < dtgFornecedor.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgFornecedor.Rows[i].Cells[0].Value) == true)
                {
                    count++;
                }
            }

            ids = new int[count];
            int x = 0;

            for (int i = 0; i < dtgFornecedor.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgFornecedor.Rows[i].Cells[0].Value) == true)
                {
                    ids[x] = Convert.ToInt32(dtgFornecedor.Rows[i].Cells[1].Value.ToString());
                    x++;
                }
            }

            fornecedorBll.RemoveMass(ids);

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
    }
}
