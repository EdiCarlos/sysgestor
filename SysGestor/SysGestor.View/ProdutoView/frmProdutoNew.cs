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
        }

        #region Eventos

        #endregion

        #region Inserir Produto

        #endregion

        #region Validação de Campos

        #endregion

        #region Funções

        #endregion


    }
}
