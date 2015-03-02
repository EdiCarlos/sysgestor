using SysGestor.BLL;
using SysGestor.BLL.AuthenticationBLL;
using SysGestor.BLL.ProdutoBLL;
using SysGestor.DTO.AuthenticationDTO;
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
        ProdutoDto _produtoDto;
        ValorProdutoBll _valorProdutoBll;
        ValorProdutoDto _valorProdutoDto;
        UnidadeBll _unidadeBll;
        UnidadeDto _unidadeDto;
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
            _produtoDto = new ProdutoDto();
            _valorProdutoBll = new ValorProdutoBll();
            _valorProdutoDto = new ValorProdutoDto();
            _unidadeBll = new UnidadeBll();
            _unidadeBll = new UnidadeBll();

            loadSuggestionProduto();

        }
              
        #region Validação de Campos
        private void limpaCampo()
        {
            txtCodigoInterno.Text = string.Empty;
            txtCodigoProduto.Text = string.Empty;
            txtProduto.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            txtQtd.Text = string.Empty;
            txtValorCustoEstoque.Text = string.Empty;
            txtObservacao.Text = string.Empty;
            txtMargem.Text = string.Empty;
            lblValorVenda.Text = string.Empty;
        }

        private void desabilitaCampo()
        {
            txtCodigoInterno.Enabled = false;
            txtCodigoProduto.Enabled = false;
            txtProduto.Enabled = false;
            txtDocumento.Enabled = false;
            txtQtd.Enabled = false;
            txtValorCustoEstoque.Enabled = false;
            txtObservacao.Enabled = false;
            txtMargem.Enabled = false;
            lblValorVenda.Enabled = false;

            btnGravar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void habilitaCampo()
        {
            txtCodigoInterno.Enabled = true;
            txtCodigoProduto.Enabled = true;
            txtProduto.Enabled = true;
            txtDocumento.Enabled = true;
            txtQtd.Enabled = true;
            txtValorCustoEstoque.Enabled = true;
            txtObservacao.Enabled = true;
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
                txtProduto.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtProduto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
        private void txtCodigoInterno_Validated(object sender, EventArgs e)
        {
            if (txtCodigoInterno.Text == string.Empty) return;

            try
            {
                _produtoDto = _produtoBll.GetProdutoByIdInterno(txtCodigoInterno.Text.Trim());
                _unidadeDto = _unidadeBll.GetUnidadeById(_produtoDto.UnidadeDto.IdUnidMedida);
                _valorProdutoDto = _valorProdutoBll.GetValorProdutoById(_produtoDto.Id);

                txtCodigoProduto.Text = _produtoDto.Id.ToString();
                txtProduto.Text = _produtoDto.Descricao;
                lblUnidade.Text = _unidadeDto.Descricao;
                txtValorCustoEstoque.Text = _valorProdutoDto.ValorCompra.ToString("N2");
                txtMargem.Text = _valorProdutoDto.Margem.ToString();
                lblValorVenda.Text = _valorProdutoDto.ValorVenda.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produto não encontrado. - " + ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigoProduto_Validated(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text.Trim() == string.Empty) return;
            try
            {
                _produtoDto = _produtoBll.GetProdutoById(Convert.ToInt32(txtCodigoProduto.Text.Trim()));
                _unidadeDto = _unidadeBll.GetUnidadeById(_produtoDto.UnidadeDto.IdUnidMedida);
                _valorProdutoDto = _valorProdutoBll.GetValorProdutoById(_produtoDto.Id);

                txtCodigoInterno.Text = _produtoDto.IdInterno.ToString();
                txtProduto.Text = _produtoDto.Descricao;
                lblUnidade.Text = _unidadeDto.Descricao;
                txtValorCustoEstoque.Text = _valorProdutoDto.ValorCompra.ToString("N2");
                txtMargem.Text = _valorProdutoDto.Margem.ToString();
                lblValorVenda.Text = _valorProdutoDto.ValorVenda.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produto não encontrado. - " + ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            try
            {
            MovimentacaoEstoqueDto movEstqueDto = new MovimentacaoEstoqueDto();

            movEstqueDto.ProdutoDto.Id = Convert.ToInt32(txtCodigoProduto.Text.Trim());
            movEstqueDto.ProdutoDto.IdInterno = txtCodigoInterno.Text.Trim();
            movEstqueDto.Documento = txtDocumento.Text.Trim();
            movEstqueDto.Quantidade = txtQtd.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtQtd.Text.Trim());
            if (rbEntrada.Checked) movEstqueDto.Operacao = "C";
            if (rbSaida.Checked) movEstqueDto.Operacao = "D";           
            movEstqueDto.Observacao = txtObservacao.Text.Trim();
            movEstqueDto.UsuarioDto.IdUsuario = AuthenticationDto.Id;
            movEstqueDto.UnidadeDto.IdUnidMedida = _unidadeDto.IdUnidMedida;


                _movEstoqueBll.Inserir(movEstqueDto);

                if (movEstqueDto.Operacao == "C")
                    _produtoBll.AumentaEstoque(movEstqueDto.Quantidade, movEstqueDto.ProdutoDto.Id);

                if (movEstqueDto.Operacao == "D")
                    _produtoBll.BaixaEstoque(movEstqueDto.Quantidade, movEstqueDto.ProdutoDto.Id);


                if (txtValorCustoEstoque.Text != "" || txtValorCustoEstoque.Text != null)
                {
                    _valorProdutoDto.ProdutoDto.Id = movEstqueDto.ProdutoDto.Id;
                    _valorProdutoDto.ValorCompra = txtValorCustoEstoque.Text.Trim() == "" ? 0 : Convert.ToDouble(txtValorCustoEstoque.Text.Trim());
                    _valorProdutoDto.Margem = txtMargem.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtMargem.Text.Trim());
                    _valorProdutoDto.ValorVenda = lblValorVenda.Text.Trim() == "" ? 0 : Convert.ToDouble(lblValorVenda.Text.Trim());

                    _valorProdutoBll.Alterar(_valorProdutoDto);
                }

                MessageBox.Show("Movimento de estoque cadastrado com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                desabilitaCampo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar movimento de estoque. - " + ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtProduto_Validated(object sender, EventArgs e)
        {
            if (txtProduto.Text.Trim() == string.Empty) return;
            try
            {
                _produtoDto = _produtoBll.GetProdutoByDescricao(txtProduto.Text.Trim());
                _unidadeDto = _unidadeBll.GetUnidadeById(_produtoDto.UnidadeDto.IdUnidMedida);
                _valorProdutoDto = _valorProdutoBll.GetValorProdutoById(_produtoDto.Id);

                txtCodigoInterno.Text = _produtoDto.IdInterno.ToString();
                txtCodigoProduto.Text = _produtoDto.Id.ToString();
                lblUnidade.Text = _unidadeDto.Descricao;
                txtValorCustoEstoque.Text = _valorProdutoDto.ValorCompra.ToString("N2");
                txtMargem.Text = _valorProdutoDto.Margem.ToString();
                lblValorVenda.Text = _valorProdutoDto.ValorVenda.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produto não encontrado. - " + ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValorCustoEstoque_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMargem.Text) && !string.IsNullOrEmpty(txtValorCustoEstoque.Text))
                lblValorVenda.Text = _produtoBll.CalculaMargemLucro(Convert.ToDouble(txtValorCustoEstoque.Text), Convert.ToDouble(txtMargem.Text)).ToString("N2");
        }

        private void txtMargem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMargem.Text) && !string.IsNullOrEmpty(txtValorCustoEstoque.Text))
                lblValorVenda.Text = _produtoBll.CalculaMargemLucro(Convert.ToDouble(txtValorCustoEstoque.Text), Convert.ToDouble(txtMargem.Text)).ToString("N2");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampo();
            limpaCampo();
            txtCodigoInterno.Focus();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            if (Formularios.FormProdutoNew == null) Formularios.FormProdutoNew = new frmProdutoNew();

            Formularios.FormProdutoNew.Show();
            Formularios.FormProdutoNew.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                this.Close();

                Formularios.FormMovimentaEstoque = null;
            }
        }

        private void frmMovimentacaoEstoqueNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.FormMovimentaEstoque = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampo();
        }

        private void frmMovimentacaoEstoqueNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }
        #endregion    

     
    }
}
