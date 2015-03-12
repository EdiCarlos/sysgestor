using SysGestor.BLL;
using SysGestor.BLL.VendaBll;
using SysGestor.DTO.PessoaDTO.ClienteDto;
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

namespace SysGestor.View.Crediario
{
    public partial class frmCrediarioCliente : Form
    {
        ParcelaBll _parcelaBll;
        ClienteBll _clienteBll;

        private int IdCliente;
        private int IdPedido;
        private int IdParcela;
        private string Valor;
        private string Cliente;

        public frmCrediarioCliente(int _idCliente)
        {
            InitializeComponent();

            this.IdCliente = _idCliente;
        }



        private void frmCrediarioCliente_Load(object sender, EventArgs e)
        {
            _parcelaBll = new ParcelaBll();
            _clienteBll = new ClienteBll();

            CarregaCrediario();
            GetCliente();
        }

        public void CarregaCrediario()
        {
            var lista = new ParcelaCollection();

            lista = _parcelaBll.GetCrediarioByIdCliente(IdCliente);

            dtgPrincipal.AutoGenerateColumns = false;

            dtgPrincipal.DataSource = lista;
        }

        private void GetCliente()
        {
            ClienteDto clienteDto = new ClienteDto();

            clienteDto = _clienteBll.GetCliente(IdCliente);

            lblCliente.Text = string.Format("{0} - {1}", clienteDto.IdCliente, clienteDto.Nome);

            Cliente = lblCliente.Text;
        }


        private void frmCrediarioCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Formularios.FormCrediarioCliente = null;
        }

        private void lblBtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FormCrediarioCliente = null;
        }

        private void lblBtnReceber_Click(object sender, EventArgs e)
        {
            if (Formularios.FormPagamentoCrediario == null) Formularios.FormPagamentoCrediario = new frmPagamentoCrediario(IdParcela, Cliente, this);

            Formularios.FormPagamentoCrediario.Show();
            Formularios.FormPagamentoCrediario.Focus();
        }

        private void dtgPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPrincipal.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1 && e.ColumnIndex == 5)
            {
              
                dtgPrincipal.EndEdit();

                if (dtgPrincipal.CurrentRow.Cells[0].Value == null)
                    return;

                IdParcela = Convert.ToInt32(dtgPrincipal.CurrentRow.Cells[0].Value.ToString());

                if (Formularios.FormPagamentoCrediario == null) Formularios.FormPagamentoCrediario = new frmPagamentoCrediario(IdParcela, Cliente, this);

                Formularios.FormPagamentoCrediario.Show();
                Formularios.FormPagamentoCrediario.Focus();
            }
        }

      
    }
}
