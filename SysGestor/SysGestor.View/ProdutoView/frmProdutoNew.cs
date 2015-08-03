using SysGestor.BLL.EmpresaBLL;
using SysGestor.BLL.PessoaBll.FornecedorBll;
using SysGestor.BLL.ProdutoBLL;
using SysGestor.DTO.PessoaDTO.FornecedorDto;
using SysGestor.DTO.Produto;
using SysGestor.View.FornecedorView;
using SysGestor.View.ProdutoView.Categoria.SearchCategoria;
using SysGestor.View.ProdutoView.Grade;
using SysGestor.View.ProdutoView.Grade.SearchGrade;
using SysGestor.View.ProdutoView.Unidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.ProdutoView
{
    public partial class frmProdutoNew : Form
    {
        ProdutoBll _produtoBll;
        ValorProdutoBll _valorProdutoBll;
        GradeBll _gradeBll;
        CategoriaBll _categoriaBll;
        FornecedorBll _fornecedorBll;
        UnidadeBll _unidadeBll;

        private object IdEmpresa = 0;

        AutoCompleteStringCollection sourceGrade;
        AutoCompleteStringCollection sourceCategoria;
        AutoCompleteStringCollection sourceFornecedor;
        AutoCompleteStringCollection sourceUnidade;

        public frmProdutoNew()
        {
            InitializeComponent();
        }

        private void frmProdutoNew_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnNovo);
            pcbCabecalho.Controls.Add(btnGravar);
            pcbCabecalho.Controls.Add(btnCancelar);
            pcbCabecalho.Controls.Add(btnSair);
            _produtoBll = new ProdutoBll();
            _valorProdutoBll = new ValorProdutoBll();
            _gradeBll = new GradeBll();
            _categoriaBll = new CategoriaBll();
            _fornecedorBll = new FornecedorBll();
            _unidadeBll = new UnidadeBll();

            LoadSuggestions();
            CarregaEmpresa();
        }

        #region Eventos
        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravaProduto();
        }

        private void btnCadGrade_Click(object sender, EventArgs e)
        {
            frmGradeNew frmGradeNew = new frmGradeNew();
            frmGradeNew.Show();
        }

        private void btnCadUnidMedida_Click(object sender, EventArgs e)
        {
            frmUnidadeNew frmUnidadeNew = new frmUnidadeNew();
            frmUnidadeNew.Show();
        }

        private void btnCadCategoria_Click(object sender, EventArgs e)
        {
            frmCategoriaNew frmCategoriaNew = new frmCategoriaNew();
            frmCategoriaNew.Show();
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedorNew frmFornecedorNew = new frmFornecedorNew();
            frmFornecedorNew.Show();
        }

        private void txtValorCusto_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorCusto.Text))
                txtMargemVista.Enabled = true;
            txtMargemVista.Focus();
        }

        private void txtMargem_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMargemVista.Text))
                lblValorVista.Text = _produtoBll.CalculaMargemLucro(Convert.ToDouble(txtValorCusto.Text),
                                     Convert.ToDouble(txtMargemVista.Text)).ToString("0.00");

            txtMargemVista.Enabled = false;
            txtMargemPrazo.Enabled = true;
            txtMargemPrazo.Focus();
        }

        private void txtMargemPrazo_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMargemPrazo.Text))
                lblValorPrazo.Text = _produtoBll.CalculaMargemLucro(Convert.ToDouble(txtValorCusto.Text),
                                     Convert.ToDouble(txtMargemPrazo.Text)).ToString("0.00");

            txtMargemPrazo.Enabled = false;
            txtMargemCartao.Enabled = true;
            txtMargemCartao.Focus();
        }

        private void txtMargemCartao_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMargemCartao.Text))
                lblValorCartao.Text = _produtoBll.CalculaMargemLucro(Convert.ToDouble(txtValorCusto.Text),
                                     Convert.ToDouble(txtMargemCartao.Text)).ToString("0.00");

            txtMargemCartao.Enabled = false;
            txtObservacao.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampo();
            limpaCampo();
            txtIdInterno.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                Formularios.FormProdutoNew = null;
                this.Close();
            }
        }

        private void frmProdutoNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.No) e.Cancel = true;
            else
            {
                Dispose(true);
                Formularios.FormProdutoNew = null;
                this.Close();
            }
        }

        private void btnLblEditar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Formularios.FormProdutoGrid == null) Formularios.FormProdutoGrid = new frmProdutoGrid();

            Formularios.FormProdutoGrid.Show();
            Formularios.FormProdutoGrid.Focus();
        }

        private void btnLblExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Formularios.FormProdutoGrid == null) Formularios.FormProdutoGrid = new frmProdutoGrid();

            Formularios.FormProdutoGrid.Show();
            Formularios.FormProdutoGrid.Focus();
        }

        private void txtCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            LoadSuggestions();
        }

        private void btnSearchCategoria_Click(object sender, EventArgs e)
        {
            if (Formularios.FormSearchCategoria == null) Formularios.FormSearchCategoria = new frmSearchCategoria();

            Formularios.FormSearchCategoria.Owner = this;
            Formularios.FormSearchCategoria.Show();
            Formularios.FormSearchCategoria.Focus();
        }

        private void txtGrade_Click(object sender, EventArgs e)
        {
            LoadSuggestions();
        }

        private void btnSearchGrade_Click(object sender, EventArgs e)
        {
            if (Formularios.FormSearchGrade == null) Formularios.FormSearchGrade = new frmSearchGrade();

            Formularios.FormSearchGrade.Owner = this;
            Formularios.FormSearchGrade.Show();
            Formularios.FormSearchGrade.Focus();
        }

        private void txtUnidMedida_Click(object sender, EventArgs e)
        {
            LoadSuggestions();
        }

        private void txtFornecedor_Click(object sender, EventArgs e)
        {
            LoadSuggestions();
        }

        private void txtIdInterno_Validated(object sender, EventArgs e)
        {
            int valor = 0;

            if (!int.TryParse(txtIdInterno.Text.Trim(), out valor))
            {
                MessageBox.Show("Código digitado incorretamente.\n\nVerifique e tente novamente.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdInterno.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(txtIdInterno.Text.Trim()))
            {
                txtIdInterno.Text = txtIdInterno.Text.PadLeft(10, '0');
                lblCodBarras.Text = txtIdInterno.Text.Trim();
            }
        }

        private void btnGerarCodBarras_Click(object sender, EventArgs e)
        {
            string codigoInterno = string.Empty;

            codigoInterno = _produtoBll.VerificaCodigoInternoCadastrado();

            codigoInterno = (Convert.ToInt32(codigoInterno) + 1).ToString().PadLeft(10, '0');

            txtIdInterno.Text = codigoInterno;

            lblCodBarras.Text = codigoInterno;
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdEmpresa = cmbEmpresa.SelectedValue.ToString();
        }

        private void frmProdutoNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }
        #endregion

        #region Validação de Campos
        private void limpaCampo()
        {
            lblId.Text = string.Empty;
            txtIdInterno.Text = string.Empty;
            txtReferencia.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtGrade.Text = string.Empty;
            txtUnidMedida.Text = string.Empty;
            txtLocalizacaoFisica.Text = string.Empty;
            txtEstoqueMinimo.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtFornecedor.Text = string.Empty;
            txtValorCusto.Text = string.Empty;
            txtMargemVista.Text = string.Empty;
            txtMargemPrazo.Text = string.Empty;
            txtMargemCartao.Text = string.Empty;
            txtComissao.Text = string.Empty;
            lblValorVista.Text = string.Empty;
            lblValorPrazo.Text = string.Empty;
            lblValorCartao.Text = string.Empty;
            txtObservacao.Text = string.Empty;
        }

        private void desabilitaCampo()
        {
            lblId.Enabled = false;
            txtIdInterno.Enabled = false;
            txtReferencia.Enabled = false;
            txtDescricao.Enabled = false;
            txtMarca.Enabled = false;
            txtGrade.Enabled = false;
            txtUnidMedida.Enabled = false;
            txtLocalizacaoFisica.Enabled = false;
            txtEstoqueMinimo.Enabled = false;
            txtCategoria.Enabled = false;
            txtFornecedor.Enabled = false;
            txtValorCusto.Enabled = false;
            txtMargemVista.Enabled = false;
            txtMargemPrazo.Enabled = false;
            txtMargemCartao.Enabled = false;
            txtComissao.Enabled = false;
            lblValorVista.Enabled = false;
            lblValorPrazo.Enabled = false;
            lblValorCartao.Enabled = false;
            txtObservacao.Enabled = false;

            btnGravar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void habilitaCampo()
        {
            lblId.Enabled = true;
            txtIdInterno.Enabled = true;
            txtReferencia.Enabled = true;
            txtDescricao.Enabled = true;
            txtMarca.Enabled = true;
            txtGrade.Enabled = true;
            txtUnidMedida.Enabled = true;
            txtLocalizacaoFisica.Enabled = true;
            txtEstoqueMinimo.Enabled = true;
            txtCategoria.Enabled = true;
            txtFornecedor.Enabled = true;
            txtValorCusto.Enabled = true;
            txtMargemVista.Enabled = true;
            txtMargemPrazo.Enabled = false;
            txtMargemCartao.Enabled = false;
            txtComissao.Enabled = false;
            lblValorVista.Enabled = false;
            lblValorPrazo.Enabled = false;
            lblValorCartao.Enabled = false;
            txtObservacao.Enabled = false;

            btnGravar.Enabled = true;
            btnNovo.Enabled = true;
        }
        #endregion

        #region Funções
        private void LoadSuggestions()
        {
            loadSuggestionGrade();
            loadSuggestionCategoria();
            loadSuggestionFornecedor();
            loadSuggestionUnidadeMedida();
        }

        private void GravaProduto()
        {
            if (cmbEmpresa.Text == "---Selecione a Empresa---")
            {
                MessageBox.Show("Você não selecionou a empresa.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ProdutoDto produtoDto = new ProdutoDto();
                ValorProdutoDto valorProdutoDto = new ValorProdutoDto();

                produtoDto.IdInterno = txtIdInterno.Text.Trim();
                produtoDto.Referencia = txtReferencia.Text.Trim();
                produtoDto.Descricao = txtDescricao.Text.Trim();
                produtoDto.GradeDto.Id = _gradeBll.GetIdListaGrade(txtGrade.Text.Trim());
                produtoDto.Marca = txtMarca.Text.Trim();
                produtoDto.UnidadeDto.IdUnidMedida = _unidadeBll.GetIdListaUnidade(txtUnidMedida.Text.Trim());
                produtoDto.LocalizacaoFisica = txtLocalizacaoFisica.Text.Trim();
                produtoDto.EstoqueMinimo = txtEstoqueMinimo.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtEstoqueMinimo.Text.Trim());
                produtoDto.CategoriaDto.Id = _categoriaBll.GetIdListaCategoria(txtCategoria.Text.Trim());
                produtoDto.FornecedorDto.Id = _fornecedorBll.GetIdListaFornecedor(txtFornecedor.Text.Trim());
                produtoDto.Observacao = txtObservacao.Text.Trim();
                produtoDto.EmpresaDto.IdEmpresa = Convert.ToInt32(IdEmpresa);

                if (txtValorCusto.Text == "" || txtValorCusto.Text == null)
                {
                    MessageBox.Show("Você não preencheu o valor do produto.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _produtoBll.Inserir(produtoDto);

                valorProdutoDto.ProdutoDto.Id = _produtoBll.GetIdProduto();
                valorProdutoDto.ValorCompra = txtValorCusto.Text.Trim() == "" ? 0 : Convert.ToDouble(txtValorCusto.Text.Trim());
                valorProdutoDto.Margem = txtMargemVista.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtMargemVista.Text.Trim());
                valorProdutoDto.MargemPrazo = txtMargemPrazo.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtMargemPrazo.Text.Trim());
                valorProdutoDto.MargemCartao = txtMargemCartao.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtMargemCartao.Text.Trim());
                valorProdutoDto.Comissao = txtComissao.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtComissao.Text.Trim());
                valorProdutoDto.ValorVenda = lblValorVista.Text.Trim() == "" ? 0 : Convert.ToDouble(lblValorVista.Text.Trim());
                valorProdutoDto.ValorPrazo = lblValorPrazo.Text.Trim() == "" ? 0 : Convert.ToDouble(lblValorPrazo.Text.Trim());
                valorProdutoDto.ValorCartao = lblValorCartao.Text.Trim() == "" ? 0 : Convert.ToDouble(lblValorCartao.Text.Trim());

                _valorProdutoBll.Inserir(valorProdutoDto);

                MessageBox.Show("Produto cadastrado com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            desabilitaCampo();

            LoadSuggestions();
        }


        private void CarregaEmpresa()
        {
            var empresaBll = new EmpresaBll();

            try
            {
                cmbEmpresa.DataSource = empresaBll.FindAll();
                cmbEmpresa.DisplayMember = "nomefantasia";
                cmbEmpresa.ValueMember = "idempresa";
                cmbEmpresa.Text = "---Selecione a Empresa---";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Suggestion
        private void loadSuggestionGrade()
        {
            sourceGrade = new AutoCompleteStringCollection();

            var listaGrade = new List<GradeDto>();

            try
            {
                listaGrade = _gradeBll.FindAll();

                if (listaGrade == null || listaGrade.Count == 0) return; //Se for null ou sem itens sai da função

                DataTable dt = new DataTable();

                dt.Columns.Add("Grade", typeof(string));

                foreach (var item in listaGrade)
                {
                    DataRow row = dt.NewRow();

                    row["Grade"] = item.Descricao;

                    dt.Rows.Add(row);
                }

                foreach (DataRow row in dt.Rows)
                {
                    sourceGrade.Add(Convert.ToString(row["Grade"]));
                }

                txtGrade.AutoCompleteCustomSource = sourceGrade;
                txtGrade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtGrade.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadSuggestionUnidadeMedida()
        {
            sourceUnidade = new AutoCompleteStringCollection();

            var listaUnidade = new List<UnidadeDto>();

            try
            {
                listaUnidade = _unidadeBll.FindAll();

                if (listaUnidade == null || listaUnidade.Count == 0) return; //Se for null ou sem itens sai da função

                DataTable dt = new DataTable();

                dt.Columns.Add("Unidade", typeof(string));

                foreach (var item in listaUnidade)
                {
                    DataRow row = dt.NewRow();

                    row["Unidade"] = item.Descricao;

                    dt.Rows.Add(row);
                }

                foreach (DataRow row in dt.Rows)
                {
                    sourceUnidade.Add(Convert.ToString(row["Unidade"]));
                }

                txtUnidMedida.AutoCompleteCustomSource = sourceUnidade;
                txtUnidMedida.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtUnidMedida.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadSuggestionCategoria()
        {
            sourceCategoria = new AutoCompleteStringCollection();

            var listaCategoria = new List<CategoriaDto>();

            try
            {
                listaCategoria = _categoriaBll.FindAll();

                if (listaCategoria == null || listaCategoria.Count == 0) return; //Se for null ou sem itens sai da função

                DataTable dt = new DataTable();

                dt.Columns.Add("Categoria", typeof(string));

                foreach (var item in listaCategoria)
                {
                    DataRow row = dt.NewRow();

                    row["Categoria"] = item.Descricao;

                    dt.Rows.Add(row);
                }

                foreach (DataRow row in dt.Rows)
                {
                    sourceCategoria.Add(Convert.ToString(row["Categoria"]));
                }

                txtCategoria.AutoCompleteCustomSource = sourceCategoria;
                txtCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtCategoria.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadSuggestionFornecedor()
        {
            sourceFornecedor = new AutoCompleteStringCollection();

            var listaFornecedor = new List<FornecedorDto>();

            try
            {
                listaFornecedor = _fornecedorBll.FindAll();

                if (listaFornecedor == null || listaFornecedor.Count == 0) return; //Se for null ou sem itens sai da função

                DataTable dt = new DataTable();

                dt.Columns.Add("Fornecedor", typeof(string));

                foreach (var item in listaFornecedor)
                {
                    DataRow row = dt.NewRow();

                    row["Fornecedor"] = item.Nome;

                    dt.Rows.Add(row);
                }

                foreach (DataRow row in dt.Rows)
                {
                    sourceFornecedor.Add(Convert.ToString(row["Fornecedor"]));
                }

                txtFornecedor.AutoCompleteCustomSource = sourceFornecedor;
                txtFornecedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtFornecedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

       
    }
}
