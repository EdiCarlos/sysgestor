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
    public partial class frmFecharVendaVista : Form
    {
        PedidoBll _pedidoBll;
        PedidoDto _pedidoDto;

        double valor, descontoDinheiro, descontoPorcentagem, pagamento;

        public frmFecharVendaVista(int idPedido, string cliente, string valor, int idUsuario, frmPedido _formPedido)
        {
            Formularios.FormPedido = _formPedido;
            _pedidoBll = new PedidoBll();
            _pedidoDto = new PedidoDto();

            InitializeComponent();

            lblIdPedido.Text = idPedido.ToString();
            lblCliente.Text = cliente;
            lblValor.Text = valor;
            lblTotalPagar.Text = valor;
            _pedidoDto.UsuarioDto.IdUsuario = idUsuario;
        }

        private void frmFecharVendaVista_Load(object sender, EventArgs e)
        {
           
        }

        private void frmFecharVendaVista_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.FormFecharVendaVista = null;
        }

        private void txtDescontoPorc_Validated(object sender, EventArgs e)
        {
            descontoPorcentagem = Convert.ToDouble(txtDescontoPorc.Text.Trim());

            valor = Convert.ToDouble(lblValor.Text);

            txtDescontoDinh.Text = "0,00";

            if (descontoPorcentagem > 0)
                valor -= (valor * (descontoPorcentagem / 100));

            lblTotalPagar.Text = valor.ToString("N2");
        }

        private void txtDescontoDinh_Validated(object sender, EventArgs e)
        {
            descontoDinheiro = Convert.ToDouble(txtDescontoDinh.Text.Trim());

            valor = Convert.ToDouble(lblValor.Text);

            txtDescontoPorc.Text = "0";

            if (descontoDinheiro > 0)
                valor -= descontoDinheiro;

            lblTotalPagar.Text = valor.ToString("N2");
        }

        private void btnCalculaPagamento_Click(object sender, EventArgs e)
        {
            double troco, dinheiro, cheque, cartaoCredito, cartaoDebito;

            valor = Convert.ToDouble(lblTotalPagar.Text);
            troco = Convert.ToDouble(lblTroco.Text);
            dinheiro = Convert.ToDouble(txtDinheiro.Text);
            cheque = Convert.ToDouble(txtCheque.Text);
            cartaoCredito = Convert.ToDouble(txtCartaoCedito.Text);
            cartaoDebito = Convert.ToDouble(txtCartaoDebito.Text);

            pagamento = dinheiro + cheque + cartaoDebito + cartaoCredito;

            if (pagamento >= valor) troco = pagamento - valor;

            if (pagamento < valor)
            {
                MessageBox.Show("Pagamento menor que o valor devido.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblTroco.Text = troco.ToString("N2");
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            ConfirmaOperacao();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Formularios.FormPedido.RefreshPDV();

            this.Close();
            Formularios.FormFecharVendaVista = null;
        }

        private void frmFecharVendaVista_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    double troco, dinheiro, cheque, cartaoCredito, cartaoDebito, pagamento;

                    valor = Convert.ToDouble(lblTotalPagar.Text);
                    troco = Convert.ToDouble(lblTroco.Text);
                    dinheiro = Convert.ToDouble(txtDinheiro.Text);
                    cheque = Convert.ToDouble(txtCheque.Text);
                    cartaoCredito = Convert.ToDouble(txtCartaoCedito.Text);
                    cartaoDebito = Convert.ToDouble(txtCartaoDebito.Text);

                    pagamento = dinheiro + cheque + cartaoDebito + cartaoCredito;

                    if (pagamento >= valor) troco = pagamento - valor;

                    if (pagamento < valor)
                    {
                        MessageBox.Show("Pagamento menor que o valor devido.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    lblTroco.Text = troco.ToString("N2");
                    break;

                case Keys.F2:
                      ConfirmaOperacao();
                      break;
                case Keys.F3:
                    this.Close();
                    Formularios.FormFecharVendaVista = null;
                    break;

                case Keys.F4:

                    break;
            }
        }

        private void frmFecharVendaVista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void ConfirmaOperacao()
        {
            if (pagamento == 0)
            {
                MessageBox.Show("Falha ao efetuar pagamento.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _pedidoDto.Id = Convert.ToInt32(lblIdPedido.Text);
            _pedidoDto.Status = 2;
            _pedidoDto.Tipo = "V";

            try
            {
                _pedidoBll.AlterarPedido(_pedidoDto);

                MessageBox.Show("Pagamento efetuado com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Formularios.FormPedido.RefreshPDV();

                this.Close();
                Formularios.FormFecharVendaVista = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
