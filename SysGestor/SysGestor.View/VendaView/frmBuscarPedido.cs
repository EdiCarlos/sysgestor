using SysGestor.BLL;
using SysGestor.BLL.VendaBll;
using SysGestor.DTO.VendaDto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SysGestor.View.VendaView
{
    public partial class frmBuscarPedido : Form
    {
        frmPedido FormPedido { get; set; }

        PedidoBll _pedidoBll;

        string searchType;
        int tipoVenda;
        int tipo;
        DateTime dataInicial, dataFinal;


        public frmBuscarPedido(frmPedido _formPedido)
        {
            InitializeComponent();
            this.FormPedido = _formPedido;
        }

        private void frmBuscarPedido_Load(object sender, EventArgs e)
        {
            _pedidoBll = new PedidoBll();
            CarregaGrid(txtPesquisa.Text.Trim());
        }

        private void frmBuscarPedido_FormClosed(object sender, FormClosedEventArgs e)
        {           
            Formularios.FormBuscarPedido = null;
        }

        private void CarregaGrid(string filter)
        {
            if (filter == "") filter = null;

            if (rbNumeroPedido.Checked) searchType = "Pedido";

            if (rbCliente.Checked) searchType = "Cliente";

            if (rbCpfCnpj.Checked) searchType = "CpfCnpj";

            if (cmbTipoVenda.Text == "Orçamento") tipoVenda = 0;

            if (cmbTipoVenda.Text == "Venda") tipoVenda = 1;

            dataInicial = dtpDataInicial.Value.Date;
            dataFinal = dtpDataFinal.Value.Date;

            dtgPrincipal.AutoGenerateColumns = false;

            var lista = new List<PedidoGridDto>();

            try
            {
                lista = _pedidoBll.FindAllPedido(searchType, tipoVenda, dataInicial, dataFinal, filter);

                dtgPrincipal.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // dtgCategoria.DefaultCellStyle.Format = "000000";
            dtgPrincipal.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregaGrid(txtPesquisa.Text.Trim());
        }

        private void dtgPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPrincipal.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 5)
            {
                dtgPrincipal.EndEdit();

                if (dtgPrincipal.CurrentRow.Cells[1].Value == null)
                    return;

                TrocaInfo.Id = Convert.ToInt32(dtgPrincipal.CurrentRow.Cells[0].Value.ToString());
                string cpfCnpj = dtgPrincipal.CurrentRow.Cells[2].Value.ToString();
              
                if (dtgPrincipal.CurrentRow.Cells[3].Value.ToString() == "Orçamento") tipo = 0;
                if (dtgPrincipal.CurrentRow.Cells[3].Value.ToString() == "Venda") tipo = 1;              

                FormPedido.RecuperaPedido(cpfCnpj, tipo);

                this.Close();
                Formularios.FormBuscarPedido = null;
            }
        }

    }
}
