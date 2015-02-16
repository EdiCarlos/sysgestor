using SysGestor.BLL.ProdutoBll;
using SysGestor.DTO.ProdutoDto;
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

                movEstqueDto.IdDocumento = txtDocumento.Text.Trim();
                movEstqueDto.Quantidade = txtQtd.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtQtd.Text.Trim());
                movEstqueDto.ValorCompra = txtValorCusto.Text.Trim() == "" ? 0 : Convert.ToDouble(txtValorCusto.Text.Trim());
                movEstqueDto.Observacao = txtObservacao.Text.Trim();
                movEstqueDto.ProdutoDto.Id = _produtoBll.GetIdListaProduto(txtProduto.Text.Trim());
                movEstqueDto.ProdutoDto.IdInterno = _produtoBll.GetIdListaCodigoInterno(txtProduto.Text.Trim());
                
                _movEstoqueBll.Salvar(movEstqueDto);
                _produtoBll.AumentaEstoque(movEstqueDto.Quantidade, movEstqueDto.ProdutoDto.Id);

                if (txtValorCusto.Text == "" || txtValorCusto.Text == null || txtComissao.Text == "" || txtComissao.Text == null)
                {
                    if (MessageBox.Show("Você deseja alterar o valor do produto?", Application.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    valorProdutoDto.ProdutoDto.Id = _produtoBll.GetIdProduto();
                    valorProdutoDto.ValorCompra = txtValorCusto.Text.Trim() == "" ? 0 : Convert.ToDouble(txtValorCusto.Text.Trim());
                    valorProdutoDto.Margem = txtMargem.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtMargem.Text.Trim());
                    valorProdutoDto.Comissao = txtComissao.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtComissao.Text.Trim());
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
            if (rbProduto.Checked) searchType = "Descricao";

            if (rbDocumento.Checked) searchType = "Categoria";

            dtgMovEstoque.AutoGenerateColumns = false;

            var lista = new List<MovimentacaoEstoqueDto>();

            try
            {
                lista = _movEstoqueBll.FindAllFilter(searchType, filter);
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
            dtgMovEstoque.Columns[5].DefaultCellStyle.Format= "C2";

            dtgMovEstoque.DataSource = lista;
        }


        #endregion

        #region Validação de Campos
        private void limpaCampo()
        {
            txtProduto.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtQtd.Text = string.Empty;
            txtObservacao.Text = string.Empty;
            txtValorCusto.Text = string.Empty;
            txtMargem.Text = string.Empty;
            txtComissao.Text = string.Empty;
            lblValorVenda.Text = string.Empty;
        }

        private void desabilitaCampo()
        {
            txtProduto.Enabled = false;
            txtDocumento.Enabled = false;
            txtQtd.Enabled = false;
            txtObservacao.Enabled = false;
            txtValorCusto.Enabled = false;
            txtMargem.Enabled = false;
            txtComissao.Enabled = false;
            lblValorVenda.Enabled = false;

            btnGravar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void habilitaCampo()
        {
            txtProduto.Enabled = true;
            txtDocumento.Enabled = true;
            txtQtd.Enabled = true;
            txtObservacao.Enabled = true;
            txtValorCusto.Enabled = true;
            txtMargem.Enabled = true;
            txtComissao.Enabled = true;
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
        #endregion

    }
}
