using SysGestor.BLL;
using SysGestor.DTO.PessoaDto.ClienteDto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.ClienteView
{
    public partial class frmClienteGrid : Form
    {


        public frmClienteGrid()
        {
            InitializeComponent();
        }

        private void carregaGrid(string filtro)
        {
            dtgCliente.AutoGenerateColumns = false;

            ClienteBll clienteBll = new ClienteBll();

            IList<ClienteDto> clientes = new List<ClienteDto>();

            clientes = clienteBll.FindAll();

            if (clientes == null)
            {
                dtgCliente.DataSource = null;
                dtgCliente.Refresh();
                return;
            }
                
            if (rbNome.Checked)
            {
                dtgCliente.DataSource = null;
                dtgCliente.DataSource = clientes.Where(x => x.Nome.Contains(filtro)).ToList();
                dtgCliente.Refresh();
            }

            if (rbCpfCnpj.Checked)
            {
                dtgCliente.DataSource = null;
                dtgCliente.DataSource = clientes.Where(x => x.CpfCnpj.Contains(filtro)).ToList();
                dtgCliente.Refresh();
            }
        }

        private void frmClienteGrid_Load(object sender, EventArgs e)
        {
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteBll clienteBll = new ClienteBll();           

            if (dtgCliente.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse registro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                dtgCliente.EndEdit();

                if (dtgCliente.CurrentRow.Cells[1].Value == null)
                    return;

                int id = Convert.ToInt32(dtgCliente.CurrentRow.Cells[1].Value.ToString());

                clienteBll.Remove(id);

                carregaGrid(txtPesquisa.Text.Trim());
            }

            if (dtgCliente.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 5)
            {
                dtgCliente.EndEdit();

                if (dtgCliente.CurrentRow.Cells[1].Value == null)
                    return;

                TrocaInfo.Id = Convert.ToInt32(dtgCliente.CurrentRow.Cells[1].Value.ToString());

                this.Hide();

                frmClienteEdit frmClienteEdit = new frmClienteEdit();
                frmClienteEdit.Show();
            }           
        }

        private void chkSelecionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgCliente.Rows)
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

            ClienteBll clienteBll = new ClienteBll();           

                int[] ids;
                int count = 0;

                for (int i = 0; i < dtgCliente.RowCount; i++)
                {
                    if (Convert.ToBoolean(dtgCliente.Rows[i].Cells[0].Value) == true)
                    {
                        count++;
                    }
                }

                ids = new int[count];
                int x = 0;

                for (int i = 0; i < dtgCliente.RowCount; i++)
                {
                    if (Convert.ToBoolean(dtgCliente.Rows[i].Cells[0].Value) == true)
                    {                       
                        ids[x] = Convert.ToInt32(dtgCliente.Rows[i].Cells[1].Value.ToString());
                        x++;
                    }
                }

               clienteBll.RemoveMass(ids);

                carregaGrid(txtPesquisa.Text.Trim());
        }
    }
}
