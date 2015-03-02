using SysGestor.BLL;
using SysGestor.BLL.ProdutoBLL;
using SysGestor.DTO.Produto;
using System;
using System.Windows.Forms;

namespace SysGestor.View.ProdutoView.Categoria
{
    public partial class frmCategoriaEdit : Form
    {
        CategoriaDto _categoriaDto;
        CategoriaBll _categoriaBll;

        public frmCategoriaEdit()
        {
            InitializeComponent();
            _categoriaDto = new CategoriaDto();
            _categoriaBll = new CategoriaBll();
        }     
            
        #region Eventos
        private void frmCategoriaEdit_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnGravar);
            pcbCabecalho.Controls.Add(btnCancelar);
            pcbCabecalho.Controls.Add(btnSair);

            _categoriaDto = _categoriaBll.GetCategoria(TrocaInfo.Id);
            TrocaInfo.Dispose();

            txtDescricao.Text = _categoriaDto.Descricao;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            _categoriaDto.Descricao = txtDescricao.Text.Trim();

            try
            {
                _categoriaBll.Alterar(_categoriaDto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                desabilitaCampo();
                this.Close();
                frmCategoriaGrid frmCategoriaGrid = new frmCategoriaGrid();
                frmCategoriaGrid.Show();
            }
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
                Formularios.FormCategoriaEdit = null;
            }
        }

        private void frmCategoriaEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.FormCategoriaEdit = null;
        }
        #endregion

        #region Validação de Campos
        private void limpaCampo()
        {
            txtDescricao.Text = string.Empty;
        }

        private void desabilitaCampo()
        {
            txtDescricao.Enabled = false;

            btnGravar.Enabled = false;         
        }

        private void habilitaCampo()
        {
            txtDescricao.Enabled = true;

            btnGravar.Enabled = true;       
        }
        #endregion

    }
}
