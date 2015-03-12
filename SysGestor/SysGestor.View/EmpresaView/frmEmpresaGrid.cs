using SysGestor.BLL;
using SysGestor.BLL.EmpresaBLL;
using SysGestor.DTO.EmpresaDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.EmpresaView
{
    public partial class frmEmpresaGrid : Form
    {
        private string searchType;

        public frmEmpresaGrid()
        {
            InitializeComponent();
        }
        
        #region Eventos
        private void dtgPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpresaBll empresaBll = new EmpresaBll();

            if (dtgPrincipal.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse registro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                dtgPrincipal.EndEdit();

                if (dtgPrincipal.CurrentRow.Cells[1].Value == null)
                    return;

                int id = Convert.ToInt32(dtgPrincipal.CurrentRow.Cells[1].Value.ToString());

                empresaBll.Remove(id);

                carregaGrid(txtPesquisa.Text.Trim());
            }

            if (dtgPrincipal.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 4)
            {
                dtgPrincipal.EndEdit();

                if (dtgPrincipal.CurrentRow.Cells[1].Value == null)
                    return;

                TrocaInfo.Id = Convert.ToInt32(dtgPrincipal.CurrentRow.Cells[1].Value.ToString());

                this.Close();
                Formularios.FormEmpresaGrid = null;

                if (Formularios.FormEmpresaEdit == null) Formularios.FormEmpresaEdit = new frmEmpresaEdit();

                Formularios.FormEmpresaEdit.Show();
                Formularios.FormEmpresaEdit.Focus();



            }
        }

        private void chkSelecionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgPrincipal.Rows)
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

        private void frmEmpresaGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.FormEmpresaGrid = null;
        }

        private void frmEmpresaGrid_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnSair);
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FormEmpresaGrid = null;
        }

        private void btnLblNovo_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FormEmpresaGrid = null;

            if (Formularios.FormEmpresaNew == null) Formularios.FormEmpresaNew = new frmEmpresaNew();

            Formularios.FormEmpresaNew.Show();
            Formularios.FormEmpresaNew.Focus();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir esse(s) registro(s)?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            EmpresaBll empresaBll = new EmpresaBll();

            int[] ids;
            int count = 0;

            for (int i = 0; i < dtgPrincipal.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgPrincipal.Rows[i].Cells[0].Value) == true)
                {
                    count++;
                }
            }

            ids = new int[count];
            int x = 0;

            for (int i = 0; i < dtgPrincipal.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgPrincipal.Rows[i].Cells[0].Value) == true)
                {
                    ids[x] = Convert.ToInt32(dtgPrincipal.Rows[i].Cells[1].Value.ToString());
                    x++;
                }
            }

            empresaBll.RemoveMass(ids);

            carregaGrid(txtPesquisa.Text.Trim());
        }
        #endregion

        #region Funções
        private void carregaGrid(string filtro)
        {
            if (rbNome.Checked) searchType = "Nome";

            if (rbCpfCnpj.Checked) searchType = "CpfCnpj";

            dtgPrincipal.AutoGenerateColumns = false;

            EmpresaBll empresaBll = new EmpresaBll();

            var empresas = new EmpresaCollection();

            empresas = empresaBll.FindAll(searchType, filtro);

            if (empresas == null)
            {
                dtgPrincipal.DataSource = null;
                dtgPrincipal.Refresh();
                return;
            }

            dtgPrincipal.DataSource = empresas;
        }
        #endregion

    }
}
