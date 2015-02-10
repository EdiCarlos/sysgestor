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

namespace SysGestor.View.ProdutoView.Unidade
{
    public partial class frmUnidadeNew : Form
    {
        UnidadeBll _unidadeBll;
        AutoCompleteStringCollection source = new AutoCompleteStringCollection();

        public frmUnidadeNew()
        {
            InitializeComponent();
        }

        private void frmUnidadeNew_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnGravar);
            pcbCabecalho.Controls.Add(btnSair);
            _unidadeBll = new UnidadeBll();
            loadSuggestionUnidade();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            UnidadeDto unidadeDto = new UnidadeDto();

            unidadeDto.Descricao = txtDescricao.Text.Trim();
            
            try
            {
                _unidadeBll.Inserir(unidadeDto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
            }
        }

        private void loadSuggestionUnidade()
        {

            var listaUnidade = new List<UnidadeDto>();

            try
            {
                listaUnidade = _unidadeBll.FindAll();

                DataTable dtUnidade = new DataTable();

                dtUnidade.Columns.Add("Unidade", typeof(string));

                foreach (var item in listaUnidade)
                {
                    DataRow row = dtUnidade.NewRow();

                    row["Unidade"] = item.Descricao;

                    dtUnidade.Rows.Add(row);
                }

                foreach (DataRow row in dtUnidade.Rows)
                {
                    source.Add(Convert.ToString(row["Unidade"]));
                }

                txtDescricao.AutoCompleteCustomSource = source;
                txtDescricao.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtDescricao.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
