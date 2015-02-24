using SysGestor.BLL;
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

namespace SysGestor.View.ProdutoView.MovimentacaoEstoque
{
    public partial class frmMovimentacaoEstoqueNew : Form
    {
        MovimentacaoEstoqueBll _movEstoqueBll;
        ProdutoBll _produtoBll;
        ValorProdutoBll _valorProdutoBll;
        string searchType;
        decimal auxiliar;

        AutoCompleteStringCollection sourceProduto;

        public frmMovimentacaoEstoqueNew()
        {
            InitializeComponent();
        }

        private void frmMovimentacaoEstoqueNew_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnNovo);
            pcbCabecalho.Controls.Add(btnGravar);
            pcbCabecalho.Controls.Add(btnCancelar);
            pcbCabecalho.Controls.Add(btnSair);

            _movEstoqueBll = new MovimentacaoEstoqueBll();
            _produtoBll = new ProdutoBll();
            _valorProdutoBll = new ValorProdutoBll();

            loadSuggestionProduto();
            carregaGrid(txtPesquisa.Text.Trim());
        }

        #region Funções
        private void GravaProduto()
        {
            try
            {
                MovimentacaoEstoqueDto movEstqueDto = new MovimentacaoEstoqueDto();
                ValorProdutoDto valorProdutoDto = new ValorProdutoDto();

                movEstqueDto.Id = TrocaInfo.Id;
                movEstqueDto.IdDocumento = txtDocumento.Text.Trim();
                movEstqueDto.Quantidade = txtQtd.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtQtd.Text.Trim());
                movEstqueDto.ValorCompra = txtValorCustoEstoque.Text.Trim() == "" ? 0 : Convert.ToDouble(txtValorCustoEstoque.Text.Trim());
                movEstqueDto.Observacao = txtObservacao.Text.Trim();
                movEstqueDto.ProdutoDto.Id = _produtoBll.GetIdListaProduto(txtProduto.Text.Trim());
                movEstqueDto.ProdutoDto.IdInterno = _produtoBll.GetIdListaCodigoInterno(txtProduto.Text.Trim());

                TrocaInfo.Dispose();

                if (movEstqueDto.Id != 0 || movEstqueDto.Id != null)
                    _produtoBll.BaixaEstoque(auxiliar, movEstqueDto.ProdutoDto.Id);

                    _movEstoqueBll.Salvar(movEstqueDto);

                if (txtValorCusto.Text != "" || txtValorCusto.Text != null)
                {
                    valorProdutoDto.ProdutoDto.Id = movEstqueDto.ProdutoDto.Id;
                    valorProdutoDto.ValorCompra = txtValorCusto.Text.Trim() == "" ? 0 : Convert.ToDouble(txtValorCusto.Text.Trim());
                    valorProdutoDto.Margem = txtMargem.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtMargem.Text.Trim());
                    valorProdutoDto.ValorVenda = lblValorVenda.Text.Trim() == "" ? 0 : Convert.ToDouble(lblValorVenda.Text.Trim());

                    _valorProdutoBll.Alterar(valorProdutoDto);
                }

                MessageBox.Show("Movimento de estoque cadastrado com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            desabilitaCampo();
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void carregaGrid(string filter)
        {
            if (rbProduto.Checked) searchType = "Produto";

            if (rbDocumento.Checked) searchType = "Documento";

            dtgMovEstoque.AutoGenerateColumns = false;

            var lista = new List<MovimentacaoEstoqueDto>();

            try
            {
                lista = _movEstoqueBll.FindAllFilter(searchType, filter);

                dtgMovEstoque.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // dtgCategoria.DefaultCellStyle.Format = "000000";
            dtgMovEstoque.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtgMovEstoque.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtgMovEstoque.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtgMovEstoque.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtgMovEstoque.Columns[5].DefaultCellStyle.Format = "C2";
           
        }


        #endregion

        #region Validação de Campos
        private void limpaCampo()
        {
            txtProduto.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtQtd.Text = string.Empty;
            txtValorCustoEstoque.Text = string.Empty;
            txtObservacao.Text = string.Empty;
            txtValorCusto.Text = string.Empty;
            txtMargem.Text = string.Empty;
            lblValorVenda.Text = string.Empty;
        }

        private void desabilitaCampo()
        {
            txtProduto.Enabled = false;
            txtDocumento.Enabled = false;
            txtQtd.Enabled = false;
            txtValorCustoEstoque.Enabled = false;
            txtObservacao.Enabled = false;
            txtValorCusto.Enabled = false;
            txtMargem.Enabled = false;
            lblValorVenda.Enabled = false;

            btnGravar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void habilitaCampo()
        {
            txtProduto.Enabled = true;
            txtDocumento.Enabled = true;
            txtQtd.Enabled = true;
            txtValorCustoEstoque.Enabled = true;
            txtObservacao.Enabled = true;
            txtValorCusto.Enabled = true;
            txtMargem.Enabled = true;
            lblValorVenda.Enabled = true;

            btnGravar.Enabled = true;
            btnNovo.Enabled = true;
        }
        #endregion

        #region Suggestion
        private void loadSuggestionProduto()
        {
            sourceProduto = new AutoCompleteStringCollection();

            var listaProduto = new List<ProdutoDto>();

            try
            {
                listaProduto = _produtoBll.FindAll();

                if (listaProduto == null) return; //Se for null sai da função

                DataTable dt = new DataTable();

                dt.Columns.Add("Produto", typeof(string));

                foreach (var item in listaProduto)
                {
                    DataRow row = dt.NewRow();

                    row["Produto"] = item.Descricao;

                    dt.Rows.Add(row);
                }

                foreach (DataRow row in dt.Rows)
                {
                    sourceProduto.Add(Convert.ToString(row["Produto"]));
                }

                txtProduto.AutoCompleteCustomSource = sourceProduto;
                txtProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtProduto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravaProduto();
        }

        private void txtValorCusto_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorCusto.Text))
                txtMargem.Enabled = true;
            txtMargem.Focus();
        }

        private void txtMargem_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMargem.Text))
                lblValorVenda.Text = _produtoBll.CalculaMargemLucro(Convert.ToDouble(txtValorCusto.Text),
                                     Convert.ToDouble(txtMargem.Text)).ToString("N2");

            txtMargem.Enabled = false;

            txtMargem.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampo();
            limpaCampo();
            txtProduto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampo();
        }

        private void txtProduto_MouseClick(object sender, MouseEventArgs e)
        {
            loadSuggestionProduto();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
            }
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            frmProdutoNew frmProdutoNew = new frmProdutoNew();
            frmProdutoNew.Show();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void txtValorCustoEstoque_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorCustoEstoque.Text))
                txtQtd.Enabled = true;
            txtQtd.Focus();
        }

        private void txtQtd_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQtd.Text))
                lblTotalEntradaProduto.Text = _movEstoqueBll.CalculaValorEntradaEstoque(Convert.ToDouble(txtQtd.Text),
                                             Convert.ToDouble(txtValorCustoEstoque.Text)).ToString("N2");

            txtQtd.Enabled = false;

            txtQtd.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir esse(s) registro(s)?", Application.CompanyName,
                                                                                     MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int[] ids;
            int count = 0;

            for (int i = 0; i < dtgMovEstoque.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgMovEstoque.Rows[i].Cells[0].Value) == true)
                {
                    count++;
                }
            }

            ids = new int[count];
            int x = 0;

            for (int i = 0; i < dtgMovEstoque.RowCount; i++)
            {
                if (Convert.ToBoolean(dtgMovEstoque.Rows[i].Cells[0].Value) == true)
                {
                    ids[x] = Convert.ToInt32(dtgMovEstoque.Rows[i].Cells[1].Value.ToString());
                    x++;
                }
            }
            try
            {
                _movEstoqueBll.RemoveMass(ids);
                MessageBox.Show("Registro(s), removido(s) com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            carregaGrid(txtPesquisa.Text.Trim());
        }

        private void chkSelecionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgMovEstoque.Rows)
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

        private void dtgMovEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgMovEstoque.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 9)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse registro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                dtgMovEstoque.EndEdit();

                if (dtgMovEstoque.CurrentRow.Cells[1].Value == null)
                    return;

                int id = Convert.ToInt32(dtgMovEstoque.CurrentRow.Cells[1].Value.ToString());

                try
                {
                    _movEstoqueBll.Remove(id);
                    MessageBox.Show("Registro, removido com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                carregaGrid(txtPesquisa.Text.Trim());
            }


            if (dtgMovEstoque.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 8)
            {
                dtgMovEstoque.EndEdit();

                if (dtgMovEstoque.CurrentRow.Cells[1].Value == null)
                    return;

                double valor, total;
                valor = Convert.ToDouble(dtgMovEstoque.CurrentRow.Cells[5].Value);
                total = (Convert.ToDouble(dtgMovEstoque.CurrentRow.Cells[4].Value)) *
                                                               (Convert.ToDouble(dtgMovEstoque.CurrentRow.Cells[5].Value));

                TrocaInfo.Id = Convert.ToInt32(dtgMovEstoque.CurrentRow.Cells[1].Value.ToString());
                txtProduto.Text = dtgMovEstoque.CurrentRow.Cells[3].Value.ToString();
                txtDocumento.Text = dtgMovEstoque.CurrentRow.Cells[2].Value.ToString();
                txtValorCustoEstoque.Text = valor.ToString("N2");
                txtQtd.Text = dtgMovEstoque.CurrentRow.Cells[4].Value.ToString();
                lblTotalEntradaProduto.Text = total.ToString("N2");
                txtObservacao.Text = dtgMovEstoque.CurrentRow.Cells[7].Value.ToString();
                auxiliar = Convert.ToDecimal(dtgMovEstoque.CurrentRow.Cells[4].Value);
                habilitaCampo();
            }
        }

        #endregion


    }
}
