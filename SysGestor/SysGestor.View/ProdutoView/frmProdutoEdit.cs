using SysGestor.BLL;
using SysGestor.BLL.PessoaBll.FornecedorBll;
using SysGestor.BLL.ProdutoBLL;
using SysGestor.DTO.PessoaDTO.FornecedorDto;
using SysGestor.DTO.Produto;
using SysGestor.View.FornecedorView;
using SysGestor.View.ProdutoView.Grade;
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
    public partial class frmProdutoEdit : Form
    {
        ProdutoBll _produtoBll;
        ValorProdutoBll _valorProdutoBll;
        GradeBll _gradeBll;
        UnidadeBll _unidadeBll;
        CategoriaBll _categoriaBll;
        FornecedorBll _fornecedorBll;


        AutoCompleteStringCollection sourceUnidade;
        AutoCompleteStringCollection sourceCategoria;
        AutoCompleteStringCollection sourceFornecedor;
        AutoCompleteStringCollection sourceGrade;

        public frmProdutoEdit()
        {
            InitializeComponent();
        }

        private void frmProdutoEdit_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnGravar);
            pcbCabecalho.Controls.Add(btnCancelar);
            pcbCabecalho.Controls.Add(btnSair);

            _produtoBll = new ProdutoBll();
            _valorProdutoBll = new ValorProdutoBll();
            _gradeBll = new GradeBll();
            _categoriaBll = new CategoriaBll();
            _fornecedorBll = new FornecedorBll();
            _unidadeBll = new UnidadeBll();

            RecuperaProduto();

            LoadSuggestions(); ;
        }

        #region Funções
        private void RecuperaProduto()
        {
            ProdutoDto produtoDto = new ProdutoDto();
            ValorProdutoDto valorProdutoDto = new ValorProdutoDto();

            produtoDto = _produtoBll.GetProdutoById(TrocaInfo.Id);
            TrocaInfo.Dispose();

            valorProdutoDto = _valorProdutoBll.GetValorProdutoById(produtoDto.Id);

            lblId.Text = Convert.ToString(produtoDto.Id);
            lblIdInterno.Text = produtoDto.IdInterno;
            txtReferencia.Text = produtoDto.Referencia;
            txtDescricao.Text = produtoDto.Descricao;
            txtGrade.Text = produtoDto.GradeDto.Descricao;
            txtMarca.Text = produtoDto.Marca;
            txtUnidMedida.Text = produtoDto.UnidadeDto.Descricao;
            txtLocalizacaoFisica.Text = produtoDto.LocalizacaoFisica;
            txtEstoqueMinimo.Text = Convert.ToString(produtoDto.EstoqueMinimo);
            txtCategoria.Text = produtoDto.Categoria;
            txtFornecedor.Text = produtoDto.FornecedorDto.Nome;
            txtObservacao.Text = produtoDto.Observacao;

            txtValorCusto.Text = valorProdutoDto.ValorCompra.ToString("N2");
            txtMargemVista.Text = Convert.ToString(valorProdutoDto.Margem);
            txtMargemPrazo.Text = Convert.ToString(valorProdutoDto.MargemPrazo);
            txtMargemCartao.Text = Convert.ToString(valorProdutoDto.MargemCartao);
            txtComissao.Text = Convert.ToString(valorProdutoDto.Comissao);
            lblValorVista.Text = valorProdutoDto.ValorVenda.ToString("N2");
            lblValorPrazo.Text = valorProdutoDto.ValorPrazo.ToString("N2");
            lblValorCartao.Text = valorProdutoDto.ValorCartao.ToString("N2");


            lblUltValorCusto.Text = valorProdutoDto.ValorCompra.ToString("N2");
            lblUltMargemVista.Text = Convert.ToString(valorProdutoDto.Margem);
            lblUltMargemPrazo.Text = Convert.ToString(valorProdutoDto.MargemPrazo);
            lblUltMargemCartao.Text = Convert.ToString(valorProdutoDto.MargemCartao);
            lblUltComissao.Text = Convert.ToString(valorProdutoDto.Comissao);
            lblUltValorVendaVista.Text = valorProdutoDto.ValorVenda.ToString("N2");
            lblUltValorVendaPrazo.Text = valorProdutoDto.ValorPrazo.ToString("N2");
            lblUltValorVendaCartao.Text = valorProdutoDto.ValorCartao.ToString("N2");


        }

        private void LoadSuggestions()
        {
            loadSuggestionGrade();
            loadSuggestionCategoria();
            loadSuggestionFornecedor();
            loadSuggestionUnidadeMedida();
        }

        private void GravaProduto()
        {
            try
            {
                ProdutoDto produtoDto = new ProdutoDto();
                ValorProdutoDto valorProdutoDto = new ValorProdutoDto();

                produtoDto.Id = Convert.ToInt32(lblId.Text.Trim());
                produtoDto.IdInterno = lblIdInterno.Text.Trim();
                produtoDto.Referencia = txtReferencia.Text.Trim();
                produtoDto.Descricao = txtDescricao.Text.Trim();
                produtoDto.GradeDto.Id = _gradeBll.GetIdListaGrade(txtGrade.Text.Trim());
                produtoDto.Marca = txtMarca.Text.Trim();
                produtoDto.UnidadeDto.IdUnidMedida = _unidadeBll.GetIdListaUnidade(txtUnidMedida.Text.Trim());
                produtoDto.LocalizacaoFisica = txtLocalizacaoFisica.Text.Trim();
                produtoDto.EstoqueMinimo = Convert.ToDecimal(txtEstoqueMinimo.Text.Trim());
                produtoDto.CategoriaDto.Id = _categoriaBll.GetIdListaCategoria(txtCategoria.Text.Trim());
                produtoDto.FornecedorDto.Id = _fornecedorBll.GetIdListaFornecedor(txtFornecedor.Text.Trim());
                produtoDto.Observacao = txtObservacao.Text.Trim();

                _produtoBll.Alterar(produtoDto);

                valorProdutoDto.ProdutoDto.Id = produtoDto.Id;
                valorProdutoDto.ValorCompra = Convert.ToDouble(txtValorCusto.Text.Trim());
                valorProdutoDto.Margem = Convert.ToDecimal(txtMargemVista.Text.Trim());
                valorProdutoDto.MargemPrazo = Convert.ToDecimal(txtMargemPrazo.Text.Trim());
                valorProdutoDto.MargemCartao = Convert.ToDecimal(txtMargemCartao.Text.Trim());
                valorProdutoDto.Comissao = Convert.ToDecimal(txtComissao.Text.Trim());
                valorProdutoDto.ValorVenda = Convert.ToDouble(lblValorVista.Text.Trim());
                valorProdutoDto.ValorPrazo = Convert.ToDouble(lblValorPrazo.Text.Trim());
                valorProdutoDto.ValorCartao = Convert.ToDouble(lblValorCartao.Text.Trim());           

                _valorProdutoBll.Alterar(valorProdutoDto);

                MessageBox.Show("Produto alterado com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            desabilitaCampo();

            LoadSuggestions();
        }
       
        #endregion

        #region Validação de Campos
        private void limpaCampo()
        {
            lblId.Text = string.Empty;
            lblIdInterno.Text = string.Empty;
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
            lblIdInterno.Enabled = false;
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
        }

        private void habilitaCampo()
        {
            lblId.Enabled = true;
            lblIdInterno.Enabled = true;
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
        }
        #endregion

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

        private void txtMargemVista_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMargemVista.Text))
                lblValorVista.Text = _produtoBll.CalculaMargemLucro(Convert.ToDouble(txtValorCusto.Text),
                                     Convert.ToDouble(txtMargemVista.Text)).ToString("N2");

            txtMargemVista.Enabled = false;
            txtMargemPrazo.Enabled = true;           
            txtMargemPrazo.Focus();
        }

        private void txtMargemPrazo_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMargemPrazo.Text))
                lblValorPrazo.Text = _produtoBll.CalculaMargemLucro(Convert.ToDouble(txtValorCusto.Text),
                                     Convert.ToDouble(txtMargemPrazo.Text)).ToString("N2");

            txtMargemPrazo.Enabled = false;
            txtMargemCartao.Enabled = true;
            txtMargemCartao.Focus();
        }

        private void txtMargemCartao_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMargemCartao.Text))
                lblValorCartao.Text = _produtoBll.CalculaMargemLucro(Convert.ToDouble(txtValorCusto.Text),
                                     Convert.ToDouble(txtMargemCartao.Text)).ToString("N2");

            txtMargemCartao.Enabled = false;
            txtObservacao.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
                Dispose(true);
                this.Close();
                Formularios.FormProdutoEdit = null;
        }

        private void frmProdutoEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.FormProdutoEdit = null;
        }

        private void btnLblExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProdutoGrid frmProdutoGrid = new frmProdutoGrid();
            frmProdutoGrid.Show();
        }

        private void btnLblNovo_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProdutoNew frmProdutoNew = new frmProdutoNew();
            frmProdutoNew.Show();
        }

        private void txtGrade_MouseClick(object sender, MouseEventArgs e)
        {
            LoadSuggestions();
        }

        private void txtUnidMedida_MouseClick(object sender, MouseEventArgs e)
        {
            LoadSuggestions();
        }

        private void txtCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            LoadSuggestions();
        }

        private void txtFornecedor_MouseClick(object sender, MouseEventArgs e)
        {
            LoadSuggestions();
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

                if (listaGrade == null) return; //Se for null sai da função

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

                if (listaUnidade == null) return; //Se for null sai da função

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

                if (listaCategoria == null) return; //Se for null sai da função

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

                if (listaFornecedor == null) return; //Se for null sai da função

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
