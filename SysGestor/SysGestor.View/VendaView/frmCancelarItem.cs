using SysGestor.BLL;
using SysGestor.BLL.VendaBll;
using SysGestor.DTO.PessoaDto.ClienteDto;
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
    public partial class frmCancelarItem : Form
    {
        int idPedido;
        int statusPedido;
        decimal qtd;

        CancelaItemDto _cancelaItemDto;

        public frmPedido FormPedido { get; set; }

        public frmCancelarItem(int idPedido, int statusPedido, frmPedido _formPedido)
        {
            this.FormPedido = _formPedido;
            this.idPedido = idPedido;
            this.statusPedido = statusPedido;
            InitializeComponent();
        }

        private void frmCancelarItem_Load(object sender, EventArgs e)
        {
            _cancelaItemDto = new CancelaItemDto();

            PedidoBll pedidoBll = new PedidoBll();

            ClienteBll clienteBll = new ClienteBll();
            ClienteDto clienteDto = new ClienteDto();


            clienteDto = clienteBll.GetCliente(pedidoBll.GetIdClientePedido(idPedido));

            lblCliente.Text = clienteDto.Nome;

            lblIdPedido.Text = idPedido.ToString();


        }

        private void txtIdProduto_Validated(object sender, EventArgs e)
        {
            if (txtIdProduto.Text == string.Empty) return;

            ItemPedidoBll itemPedidoBll = new ItemPedidoBll();

            _cancelaItemDto = itemPedidoBll.GetItemCancelar(idPedido, txtIdProduto.Text.Trim());

            lblCliente.Text = _cancelaItemDto.Cliente;
            lblDescricao.Text = _cancelaItemDto.Produto;
            txtQtd.Text = _cancelaItemDto.Quantidade.ToString();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            ItemPedidoBll itemPedidoBll = new ItemPedidoBll();

            try
            {
                qtd = _cancelaItemDto.Quantidade - Convert.ToDecimal(txtQtd.Text);

                
                if (chkExcluirTodos.Checked)
                    itemPedidoBll.CancelaItemPedido(statusPedido, Convert.ToDecimal(txtQtd.Text), _cancelaItemDto.IdItemPedido, _cancelaItemDto.IdProduto);
                else
                    itemPedidoBll.AlteraItemPedido(statusPedido, _cancelaItemDto.IdItemPedido, qtd, Convert.ToDecimal(txtQtd.Text), _cancelaItemDto.IdProduto);

                FormPedido.CarregaGrid();

                Formularios.FormCancelarItem = null;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCancelarItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Formularios.FormCancelarItem = null;
            this.Close();
        }

        private void frmCancelarItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.FormCancelarItem = null;
        }

        private void chkExcluirTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtQtd.Enabled = true;
            txtQtd.Focus();
        }

        private void frmCancelarItem_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    ItemPedidoBll itemPedidoBll = new ItemPedidoBll();
                    try
                    {
                        qtd = _cancelaItemDto.Quantidade - Convert.ToDecimal(txtQtd.Text);

                        if (chkExcluirTodos.Checked)
                            itemPedidoBll.CancelaItemPedido(statusPedido, Convert.ToDecimal(txtQtd.Text), _cancelaItemDto.IdItemPedido, _cancelaItemDto.IdProduto);
                        else
                            itemPedidoBll.AlteraItemPedido(statusPedido, _cancelaItemDto.IdItemPedido, qtd, Convert.ToDecimal(txtQtd.Text), _cancelaItemDto.IdProduto);

                        FormPedido.CarregaGrid();

                        Formularios.FormCancelarItem = null;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case Keys.F3:
                    Formularios.FormCancelarItem = null;
                    this.Close();
                    break;
            }
        }

    }
}
