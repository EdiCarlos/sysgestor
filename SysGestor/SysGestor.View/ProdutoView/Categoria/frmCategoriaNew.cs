using SysGestor.BLL.ProdutoBll;
using SysGestor.DTO.Produto;
using System;
using System.Windows.Forms;

namespace SysGestor.View.ProdutoView
{
    public partial class frmCategoriaNew : Form
    {
        CategoriaDto _categoriaDto;
        CategoriaBll _categoriaBll;

        public frmCategoriaNew()
        {
            InitializeComponent();
            _categoriaDto = new CategoriaDto();
            _categoriaBll = new CategoriaBll();
        }

        #region Eventos
        private void frmCategoriaNew_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnNovo);
            pcbCabecalho.Controls.Add(btnGravar);
            pcbCabecalho.Controls.Add(btnCancelar);
            pcbCabecalho.Controls.Add(btnSair);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            _categoriaDto.Descricao = txtDescricao.Text.Trim();

            try
            {
                _categoriaBll.Inserir(_categoriaDto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                desabilitaCampo();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampo();
            limpaCampo();
            txtDescricao.Focus();
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
            btnNovo.Enabled = true;
        }

        private void habilitaCampo()
        {
            txtDescricao.Enabled = true;

            btnGravar.Enabled = true;
            btnNovo.Enabled = false;
        }
        #endregion

       
    }
}
