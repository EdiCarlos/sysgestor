using SysGestor.BLL;
using SysGestor.BLL.PessoaBll.UsuarioBLL;
using SysGestor.DTO.PessoaDTO.UsuarioDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.UsuarioView
{
    public partial class frmUsuarioGrid : Form
    {
        string searchValue;

        public frmUsuarioGrid()
        {
            InitializeComponent();
        }

        private void frmUsuarioGrid_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnSair);
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void carregaGrid(string filter)
        {
            if (rbNome.Checked)
                searchValue = "Nome";

            if (rbLogin.Checked)
                searchValue = "Login";

            dtgUsuario.AutoGenerateColumns = false;

            UsuarioBll usuarioBll = new UsuarioBll();

            IList<UsuarioDto> usuarios = new List<UsuarioDto>();

            try
            {
                 usuarios = usuarioBll.FindAllFilter(searchValue, filter);
                 dtgUsuario.DataSource = usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dtgUsuario.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void dtgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UsuarioBll usuarioBll = new UsuarioBll();

            if (dtgUsuario.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse registro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                dtgUsuario.EndEdit();

                if (dtgUsuario.CurrentRow.Cells[1].Value == null)
                    return;

                int id = Convert.ToInt32(dtgUsuario.CurrentRow.Cells[1].Value.ToString());

                usuarioBll.Remove(id);

                carregaGrid(txtPesquisa.Text.Trim());
            }

            if (dtgUsuario.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 4)
            {
                dtgUsuario.EndEdit();

                if (dtgUsuario.CurrentRow.Cells[1].Value == null)
                    return;

                TrocaInfo.Id = Convert.ToInt32(dtgUsuario.CurrentRow.Cells[1].Value.ToString());

                this.Hide();
                Formularios.FormUsuarioGrid = null;

                if (Formularios.FormUsuarioEdit == null) Formularios.FormUsuarioEdit = new frmUsuarioEdit();

                Formularios.FormUsuarioEdit.Show();
                Formularios.FormUsuarioEdit.Focus();
            }
        }

        private void chkSelecionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgUsuario.Rows)
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

            UsuarioBll usuarioBll = new UsuarioBll();

            int[] ids;
            int count = 0;

            for (int i = 0; i < dtgUsuario.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgUsuario.Rows[i].Cells[0].Value) == true)
                {
                    count++;
                }
            }

            ids = new int[count];
            int x = 0;

            for (int i = 0; i < dtgUsuario.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgUsuario.Rows[i].Cells[0].Value) == true)
                {
                    ids[x] = Convert.ToInt32(dtgUsuario.Rows[i].Cells[1].Value.ToString());
                    x++;
                }
            }

            usuarioBll.RemoveMass(ids);

            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair da lista?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                Formularios.FormUsuarioGrid = null;
            }
        }

        private void frmUsuarioGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) ==
              DialogResult.Yes) Formularios.FormUsuarioGrid = null;
            else e.Cancel = true;
        }

        private void btnLblNovo_Click(object sender, EventArgs e)
        {
            if (Formularios.FormUsuarioGrid == null) Formularios.FormUsuarioGrid = new frmUsuarioGrid();

            Formularios.FormUsuarioGrid.Show();
            Formularios.FormUsuarioGrid.Focus();
        }
    }
}
