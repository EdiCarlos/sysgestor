using SysGestor.BLL;
using SysGestor.BLL.PessoaBll.FornecedorBll;
using SysGestor.BLL.ProdutoBLL;
using SysGestor.DTO.PessoaDto.FornecedorDto;
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
            txtIdInterno.Text = produtoDto.IdInterno;
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
            txtMargem.Text = Convert.ToString(valorProdutoDto.Margem);
            txtComissao.Text = Convert.ToString(valorProdutoDto.Comissao);
            lblValorVenda.Text = valorProdutoDto.ValorVenda.ToString("N2");


            lblUltValorCusto.Text = valorProdutoDto.ValorCompra.ToString("N2");
            lblUltMargem.Text = Convert.ToString(valorProdutoDto.Margem);
            lblUltComissao.Text = Convert.ToString(valorProdutoDto.Comissao);
            lblUltValorVenda.Text = valorProdutoDto.ValorVenda.ToString("N2");


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
                produtoDto.IdInterno = txtIdInterno.Text.Trim();
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
                valorProdutoDto.Margem = Convert.ToDecimal(txtMargem.Text.Trim());
                valorProdutoDto.Comissao = Convert.ToDecimal(txtComissao.Text.Trim());
                valorProdutoDto.ValorVenda = Convert.ToDouble(lblValorVenda.Text.Trim());

                //TODO
                //valorProdutoDto.UltimoValorCompra = Convert.ToDouble(lblUltValorCusto.Text);
                //valorProdutoDto.UltimaMargem = Convert.ToDecimal(lblUltMargem.Text);
                //valorProdutoDto.UltimaComissao = Convert.ToDecimal(lblUltComissao.Text);
                //valorProdutoDto.UltimoValorVenda = Convert.ToDouble(lblUltValorVenda.Text);

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
            txtMargem.Text = string.Empty;
            txtComissao.Text = string.Empty;
            lblValorVenda.Text = string.Empty;
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
            txtMargem.Enabled = false;
            txtComissao.Enabled = false;
            lblValorVenda.Enabled = false;
            txtObservacao.Enabled = false;

            btnGravar.Enabled = false;
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
            txtMargem.Enabled = true;
            txtComissao.Enabled = true;
            lblValorVenda.Enabled = true;
            txtObservacao.Enabled = true;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
            }
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
