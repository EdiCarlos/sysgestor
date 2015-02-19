using SysGestor.BLL;
using SysGestor.BLL.ProdutoBll;
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

namespace SysGestor.View.ProdutoView.Grade
{
    public partial class frmGradeEdit : Form
    {
        GradeDto _gradeDto;
        GradeBll _gradeBll;

        public frmGradeEdit()
        {
            InitializeComponent();
            _gradeDto = new GradeDto();
            _gradeBll = new GradeBll();
        }     
            
        #region Eventos
        private void frmGradeEdit_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnGravar);
            pcbCabecalho.Controls.Add(btnCancelar);
            pcbCabecalho.Controls.Add(btnSair);

            _gradeDto = _gradeBll.GetGrade(TrocaInfo.Id);
            TrocaInfo.Dispose();

            txtDescricao.Text = _gradeDto.Descricao;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            _gradeDto.Descricao = txtDescricao.Text.Trim();

            try
            {
                _gradeBll.Alterar(_gradeDto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                desabilitaCampo();
                this.Close();
                frmGradeGrid frmGradeGrid = new frmGradeGrid();
                frmGradeGrid.Show();
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
        }

        private void habilitaCampo()
        {
            txtDescricao.Enabled = true;

            btnGravar.Enabled = true;       
        }
        #endregion
    }
}
