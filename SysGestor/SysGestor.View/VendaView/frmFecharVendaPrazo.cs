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
using System.Transactions;

namespace SysGestor.View.VendaView
{
    public partial class frmFecharVendaPrazo : Form
    {
        PedidoBll _pedidoBll;
        PedidoDto _pedidoDto;

        ParcelaBll _parcelaBll;
        ParcelaDto _parcelaDto;

        ClienteBll _clienteBll;
        ClienteDto _clienteDto;

        public frmFecharVendaPrazo(int idPedido, ClienteDto clienteDto, string valor, int idUsuario, frmPedido _formPedido)
        {
            Formularios.FormPedido = _formPedido;
            _pedidoBll = new PedidoBll();
            _parcelaBll = new ParcelaBll();
            _parcelaDto = new ParcelaDto();
            _pedidoDto = new PedidoDto();
            _clienteBll = new ClienteBll();
            _clienteDto = clienteDto;

            InitializeComponent();

            try
            {
                _clienteDto = _clienteBll.GetCliente(_clienteDto.IdCliente);

                lblDebito.Text = _clienteBll.GetDebitoByIdCLiente(_clienteDto.IdCliente).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do cliente. - " + ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            lblIdPedido.Text = idPedido.ToString();
            lblCliente.Text = _clienteDto.Nome;
            lblValorPedido.Text = valor;
            lblTotalPagar.Text = valor;
            _pedidoDto.UsuarioDto.IdUsuario = idUsuario;
            lblCredito.Text = _clienteDto.LimiteCredito.ToString("N2");

            double saldo = (Convert.ToDouble(lblCredito.Text) - Convert.ToDouble(lblDebito.Text));

            if (saldo < 0) lblSaldo.ForeColor = Color.Red;

            lblSaldo.Text = saldo.ToString("N2");
        }

        #region Eventos
        private void frmFecharVendaPrazo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Formularios.FormFecharVendaPrazo = null;
        }

        private void frmFecharVendaPrazo_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculaParcela_Click(object sender, EventArgs e)
        {
            CalculaParcelamento();
        }

        private void nudQtdParcela_ValueChanged(object sender, EventArgs e)
        {
            CalculaParcelamento();
        }

        private void frmFecharVendaPrazo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    CalculaParcelamento();
                    break;
                case Keys.F2:
                    ConfirmaOperação();
                    break;
                case Keys.F3:

                    break;

                case Keys.F4:

                    break;
            }
        }

        private void frmFecharVendaPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            ConfirmaOperação();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Formularios.FormPedido.RefreshPDV();

            this.Close();
            Formularios.FormFecharVendaPrazo = null;
        }
        #endregion

        #region Funções
        private void ConfirmaOperação()
        {
            if (dtgPrincipal.Rows.Count - 1 == 0)
            {
                MessageBox.Show("Não foi possível concluir parcelamento,\n\nverifique e tente de novamente.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    for (int i = 0; i < dtgPrincipal.Rows.Count; i++)
                    {
                        _parcelaDto.NumParcela = Convert.ToInt32(dtgPrincipal.Rows[i].Cells[0].Value);
                        _parcelaDto.PedidoDto.Id = Convert.ToInt32(dtgPrincipal.Rows[i].Cells[1].Value);
                        _parcelaDto.DataVencimento = Convert.ToDateTime(dtgPrincipal.Rows[i].Cells[3].Value);
                        _parcelaDto.ValorParcela = Convert.ToDouble(dtgPrincipal.Rows[i].Cells[2].Value);
                        _parcelaDto.QtdParcela = Convert.ToInt32(nudQtdParcela.Value);

                        _parcelaBll.InserirParcela(_parcelaDto, Convert.ToInt32(nudQtdParcela.Value));
                    }

                    _pedidoDto.Id = Convert.ToInt32(lblIdPedido.Text);
                    _pedidoDto.Status = 2;
                    _pedidoDto.Tipo = "P";


                    _pedidoBll.AlterarPedido(_pedidoDto);


                    scope.Complete();

                    MessageBox.Show("Operação concluída com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

                Formularios.FormPedido.RefreshPDV();

                this.Close();
                Formularios.FormFecharVendaPrazo = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível concluir parcelamento,\n\nverifique e tente de novamente. - " + ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CalculaParcelamento()
        {
            try
            {
                double[] ValorParcela = new double[Convert.ToInt32(nudQtdParcela.Value)];

                DateTime dataCompra = DateTime.Now.Date;

                int dia = dataCompra.Day;
                int mes = dataCompra.Month;
                int ano = dataCompra.Year;

                dia = Convert.ToInt32(txtDiaPagamento.Text);

                DateTime calculoParcela = new DateTime(ano, mes, dia);

                DateTime[] dataVenc = new DateTime[Convert.ToInt32(nudQtdParcela.Value)];

                if (ckbEntrada.Checked == false)
                {
                    for (int i = 0; i < Convert.ToInt32(nudQtdParcela.Value); i++)
                    {
                        calculoParcela = calculoParcela.AddMonths(1);
                        dataVenc[i] = calculoParcela;
                    }
                }

                if (ckbEntrada.Checked == true)
                {
                    dataVenc[0] = DateTime.Now.Date;

                    for (int i = 1; i < Convert.ToInt32(nudQtdParcela.Value); i++)
                    {
                        calculoParcela = calculoParcela.AddMonths(1);
                        dataVenc[i] = calculoParcela;
                    }
                }

                ValorParcela = _parcelaBll.CalculaParcela(Convert.ToDecimal(lblValorPedido.Text), Convert.ToInt32(nudQtdParcela.Value), Convert.ToDecimal(txtAcrescimo.Text));

                dtgPrincipal.Rows.Clear();
                for (int i = 0; i < ValorParcela.Length; i++)
                {
                    dtgPrincipal.Rows.Add();
                    dtgPrincipal.Rows[i].Cells[0].Value = i + 1;
                    dtgPrincipal.Rows[i].Cells[1].Value = lblIdPedido.Text;
                    dtgPrincipal.Rows[i].Cells[2].Value = ValorParcela[i].ToString("N2");
                    dtgPrincipal.Rows[i].Cells[3].Value = dataVenc[i].ToShortDateString();
                }

                lblTotalPagar.Text = calculaValorPedido().ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular parcelamento. - " + ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal calculaValorPedido()
        {
            decimal valorTotal = 0;
            try
            {
                int i = 0;
                for (i = 0; i < dtgPrincipal.Rows.Count - 1; i++)
                {
                    valorTotal += Convert.ToDecimal(dtgPrincipal.Rows[i].Cells[2].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular valor do  pedido. - " + ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valorTotal;
        }
        #endregion
    }
}
