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
        PedidoBll _pedidoBll;
        public frmBuscarPedido()
        {
            InitializeComponent();
        }

        private void frmBuscarPedido_Load(object sender, EventArgs e)
        {
            _pedidoBll = new PedidoBll();
            CarregaGrid();
        }

        private void frmBuscarPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.FormBuscarPedido = null;
        }

        private void CarregaGrid()
        {
            //if (rbProduto.Checked) searchType = "Produto";

            //if (rbDocumento.Checked) searchType = "Documento";

            dtgPrincipal.AutoGenerateColumns = false;

            var lista = new List<PedidoGridDto>();

            try
            {
                lista = _pedidoBll.FindAllPedido();

                dtgPrincipal.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // dtgCategoria.DefaultCellStyle.Format = "000000";
            dtgPrincipal.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
        }

     
    }
}
