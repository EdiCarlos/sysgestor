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

namespace SysGestor.View.Crediario
{
    public partial class frmPagamentoCrediario : Form
    {     
        private string Cliente;      
        private int IdParcela;
        ParcelaBll _parcelaBll;
        ParcelaDto _parcelaDto;

        double valor, descontoDinheiro, descontoPorcentagem, pagamento;
       

        public frmPagamentoCrediario(int idParcela, string cliente, frmCrediarioCliente _crediarioCliente)
        {
            Formularios.FormCrediarioCliente = _crediarioCliente;
            _parcelaBll = new ParcelaBll();
            _parcelaDto = new ParcelaDto();
        
            this.IdParcela = idParcela;
            this.Cliente = cliente;
          
            InitializeComponent();
            CarregarDadosDaParcela();

        }

        private void frmPagamentoCrediario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Formularios.FormPagamentoCrediario = null;
        }

        private void CarregarDadosDaParcela()
        {
          _parcelaDto =  _parcelaBll.GetParcelaById(IdParcela);

          lblIdPedido.Text = _parcelaDto.PedidoDto.Id.ToString();
          lblParcela.Text = string.Format("{0} de {1}", _parcelaDto.NumParcela,_parcelaDto.QtdParcela);
          lblCliente.Text = Cliente;
          lblValor.Text = _parcelaDto.ValorParcela.ToString("N2");

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

        private void ConfirmaOperacao()
        {
            if (pagamento == 0)
            {
                MessageBox.Show("Falha ao efetuar pagamento.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            _parcelaDto.DataPagamento = DateTime.Now;
            _parcelaDto.ValorPago = Convert.ToDouble(lblTotalPagar.Text);          
            _parcelaDto.Situacao = "F";       

            try
            {
                _parcelaBll.AlterarParcela(_parcelaDto);

                MessageBox.Show("Pagamento efetuado com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Formularios.FormCrediarioCliente.CarregaCrediario();

                this.Close();
                Formularios.FormPagamentoCrediario = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            ConfirmaOperacao();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Formularios.FormCrediarioCliente.CarregaCrediario();

            this.Close();
            Formularios.FormPagamentoCrediario = null;
        }

        private void frmPagamentoCrediario_KeyDown(object sender, KeyEventArgs e)
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
                    Formularios.FormPagamentoCrediario = null;
                    break;

                case Keys.F4:

                    break;
            }
        }
    }
}
