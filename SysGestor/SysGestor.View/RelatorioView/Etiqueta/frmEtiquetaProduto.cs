using SysGestor.BLL.RelatorioBLL.Etiqueta;
using SysGestor.DTO.RelatorioDto.Etiqueta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SysGestor.View.RelatorioView.Etiqueta
{
    public partial class frmEtiquetaProduto : Form
    {
        private string searchType;
        private List<EtiquetaProduto_3x7Dto> listaEtiqueta;

        public frmEtiquetaProduto()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmEtiquetaProduto_Load(object sender, EventArgs e)
        {
            listaEtiqueta = new List<EtiquetaProduto_3x7Dto>();

            CarregaGrid(txtPesquisa.Text.Trim());
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregaGrid(txtPesquisa.Text.Trim());
        }

        private void frmEtiquetaProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.FormEtiquetaProduto = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dtgPrincipal.RowCount; i++)
                {
                    if (Convert.ToBoolean(dtgPrincipal.Rows[i].Cells[0].Value) == true)
                    {
                        for (int x = 0; x < Convert.ToInt32(dtgPrincipal.Rows[i].Cells[4].Value.ToString()); x++)
                        {
                            var etiqueta = new EtiquetaProduto_3x7Dto();

                            etiqueta.Id = Convert.ToInt32(dtgPrincipal.Rows[i].Cells[1].Value.ToString());
                            etiqueta.CodigoBarra = Convert.ToString(dtgPrincipal.Rows[i].Cells[2].Value.ToString());
                            etiqueta.Descricao = Convert.ToString(dtgPrincipal.Rows[i].Cells[3].Value.ToString());
                            etiqueta.PrecoVista = Convert.ToDouble(dtgPrincipal.Rows[i].Cells[5].Value.ToString());
                            etiqueta.PrecoPrazo = Convert.ToDouble(dtgPrincipal.Rows[i].Cells[6].Value.ToString());
                            etiqueta.PrecoCartao = Convert.ToDouble(dtgPrincipal.Rows[i].Cells[7].Value.ToString());
                            etiqueta.IdEmpresa = Convert.ToInt32(dtgPrincipal.Rows[i].Cells[8].Value.ToString());
                            etiqueta.Empresa = Convert.ToString(dtgPrincipal.Rows[i].Cells[9].Value.ToString());

                            listaEtiqueta.Add(etiqueta);
                        }
                    }
                }

                lblQtdEtiqueta.Text = listaEtiqueta.Count().ToString() + " Etiqueta(s) para imprimir.";
                btnAdd.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar etiquetas para impressão. - " + ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPreviewPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Formularios.FormRelatorioEtiquetaProduto == null) Formularios.FormRelatorioEtiquetaProduto =
                new frmRelatorioEtiquetaProduto(listaEtiqueta);

            Formularios.FormRelatorioEtiquetaProduto.Show();
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
        #endregion

        #region Funções
        private void CarregaGrid(string filter)
        {
            try
            {
                if (rbDescricao.Checked) searchType = "Descricao";

                if (rbCodigo.Checked) searchType = "Codigo";

                if (rbCodigoBarras.Checked) searchType = "CodigoBarra";

                dtgPrincipal.AutoGenerateColumns = false;

                EtiquetaProduto_3x7Bll etiquetaBll = new EtiquetaProduto_3x7Bll();

                var lista = new EtiquetaProduto_3x7Collection();

                lista = etiquetaBll.FindAllFilter(searchType, filter);

                if (lista == null)
                {
                    dtgPrincipal.DataSource = null;
                    dtgPrincipal.Refresh();
                    return;
                }

                dtgPrincipal.DataSource = lista;

                for (int i = 0; i < lista.Count; i++)
                    dtgPrincipal.Rows[i].Cells[4].Value = 1;

                dtgPrincipal.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtgPrincipal.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtgPrincipal.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                btnAdd.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista de produtos. - " + ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
