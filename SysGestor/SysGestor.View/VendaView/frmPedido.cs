using SysGestor.BLL;
using SysGestor.BLL.ProdutoBLL;
using SysGestor.BLL.VendaBll;
using SysGestor.DTO.AuthenticationDTO;
using SysGestor.DTO.PessoaDto.ClienteDto;
using SysGestor.DTO.Produto;
using SysGestor.DTO.VendaDto;
using SysGestor.View.ProdutoView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace SysGestor.View.VendaView
{
    public partial class frmPedido : Form
    {
        ProdutoBll _produtoBll;
        ProdutoDto _produtoDto;
        ValorProdutoBll _valorProdutoBll;
        UnidadeBll _unidadeBll;
        ClienteBll _clienteBll;
        ClienteDto _clienteDto;
        PedidoBll _pedidoBll;

        decimal total;
        int statusPedido;
        int idPedido;
        string aumentarQtdItem;
        bool statusItemInsert; //guarda se o item foi inserido ou não

        AutoCompleteStringCollection sourceCpfCnpj;
        AutoCompleteStringCollection sourceCliente;

        public frmPedido()
        {
            InitializeComponent();

            _produtoBll = new ProdutoBll();
            _produtoDto = new ProdutoDto();
            _valorProdutoBll = new ValorProdutoBll();
            _unidadeBll = new UnidadeBll();
            _clienteBll = new ClienteBll();
            _clienteDto = new ClienteDto();
            _pedidoBll = new PedidoBll();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblUsuario.Text = string.Format("{0} - {1}", AuthenticationDto.Id, AuthenticationDto.Usuario);
            lblProduto.Text = "                        CAIXA LIVRE";
            dtgItensPedido.Focus();
            SuggestionCpfCnpj();
            SuggestionCliente();
        }


        #region Eventos
        private void txtCodigoProduto_Validated(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text.Trim() == "*")
            {
                aumentarQtdItem = "*";
                txtCodigoProduto.Text = string.Empty;
                txtCodigoProduto.Focus();
                return;
            }

            if (aumentarQtdItem == "*")
            {
                aumentarQtdItem = string.Empty;
                txtQtd.Text = txtCodigoProduto.Text;
                txtCodigoProduto.Text = string.Empty;
                txtCodigoProduto.Focus();
                return;
            }

            if (rbVenda.Checked == false && rbOrcamento.Checked == false)
            {
                MessageBox.Show("Escolha o tipo de pedido,\n antes de continuar. \n\n1 - VENDA\n\n2 - ORÇAMENTO ", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                rbVenda.Focus();
                return;
            }
          
            if (idPedido == 0 && txtCodigoProduto.Text != string.Empty) GravarPedido();


            if (txtCodigoProduto.Text == string.Empty) return;

            ValorProdutoDto valorProdutoDto = new ValorProdutoDto();
            UnidadeDto unidadeDto = new UnidadeDto();
            try
            {
                _produtoDto = _produtoBll.GetProdutoByIdInterno(txtCodigoProduto.Text.Trim());
                unidadeDto = _unidadeBll.GetUnidadeById(_produtoDto.UnidadeDto.IdUnidMedida);
                valorProdutoDto = _valorProdutoBll.GetValorProdutoById(_produtoDto.Id);

                decimal valorUnitario = Convert.ToDecimal(valorProdutoDto.ValorVenda);
                decimal qtd = Convert.ToDecimal(txtQtd.Text.Trim());
                decimal subTotal = qtd * valorUnitario;


                lblProduto.Text = _produtoDto.Descricao;
                lblUnidade.Text = string.Format("x  {0}", unidadeDto.Descricao);
                lblValorUnit.Text = valorProdutoDto.ValorVenda.ToString("N2");
                lblSubTotal.Text = subTotal.ToString("N2");


                SystemSounds.Beep.Play();

                if (idPedido == 0)
                {
                    txtCodigoProduto.Text = string.Empty;
                    txtCodigoProduto.Focus();
                    return;
                }

                GravarItemDoPedido();
                txtCodigoProduto.Text = string.Empty;
                txtQtd.Text = "1";
                txtCodigoProduto.Focus();

                CarregaGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCliente_Validated(object sender, EventArgs e)
        {
            if (txtCliente.Text == string.Empty) return;

            try
            {
                _clienteDto = _clienteBll.GetClienteByNome(txtCliente.Text.Trim());

                txtCpf.Text = _clienteDto.CpfCnpj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCpf_Validated(object sender, EventArgs e)
        {
            if (txtCpf.Text == string.Empty) return;

            try
            {
                _clienteDto = _clienteBll.GetClienteByCpfCnpj(txtCpf.Text.Trim());

                txtCliente.Text = _clienteDto.Nome;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToString();
        }

        private void frmPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            Formularios.FormPedido = null;
        }

        private void txtCodigoProduto_TextChanged(object sender, EventArgs e)
        {


        }

        private void frmPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void txtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
            }
        }
        #endregion

        #region Eventos Btn de F
        private void btnF1_Ajuda_Click(object sender, EventArgs e)
        {

        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            if (Formularios.FormProdutoNew == null) Formularios.FormProdutoNew = new frmProdutoNew();

            Formularios.FormProdutoNew.Show();
            Formularios.FormProdutoNew.Focus();
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            if (Formularios.FormFecharVendaVista == null) Formularios.FormFecharVendaVista = new frmFecharVendaVista(idPedido, txtCliente.Text, lblTotal.Text, AuthenticationDto.Id, this);

            Formularios.FormFecharVendaVista.Show();
            Formularios.FormFecharVendaVista.Focus();
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            if (idPedido == 0 && statusPedido == 0) return;

            if (Formularios.FormCancelarItem == null) Formularios.FormCancelarItem = new frmCancelarItem(idPedido, statusPedido, this);

            Formularios.FormCancelarItem.Show();
            Formularios.FormCancelarItem.Focus();
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar \n\n o pedido de Nº " + idPedido + " ?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                try
                {
                    CancelaPedido();
                    MessageBox.Show("Pedido Nº " + idPedido + " \n\n ***Removido com sucesso!***", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshPDV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnF8_Click(object sender, EventArgs e)
        {
            if (Formularios.FormBuscarPedido == null) Formularios.FormBuscarPedido = new frmBuscarPedido(this);

            Formularios.FormBuscarPedido.Show();
            Formularios.FormBuscarPedido.Focus();
        }

        private void frmPedido_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    if (Formularios.FormProdutoNew == null) Formularios.FormProdutoNew = new frmProdutoNew();

                    Formularios.FormProdutoNew.Show();
                    Formularios.FormProdutoNew.Focus();
                    break;

                case Keys.F3:
                    if (Formularios.FormFecharVendaVista == null) Formularios.FormFecharVendaVista = new frmFecharVendaVista(idPedido, txtCliente.Text, lblTotal.Text, AuthenticationDto.Id, this);

                    Formularios.FormFecharVendaVista.Show();
                    Formularios.FormFecharVendaVista.Focus();
                    break;

                case Keys.F5:
                    if (idPedido == 0 && statusPedido == 0) return;

                    if (Formularios.FormCancelarItem == null) Formularios.FormCancelarItem = new frmCancelarItem(idPedido, statusPedido, this);

                    Formularios.FormCancelarItem.Show();
                    Formularios.FormCancelarItem.Focus();
                    break;
                case Keys.F6:
                    if (MessageBox.Show("Deseja realmente cancelar \n\n o pedido de Nº " + idPedido + " ?", Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        try
                        {
                            CancelaPedido();
                            MessageBox.Show("Pedido Nº " + idPedido + " \n\n ***Removido com sucesso!***", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            RefreshPDV();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;

                case Keys.F8:
                    if (Formularios.FormBuscarPedido == null) Formularios.FormBuscarPedido = new frmBuscarPedido(this);

                    Formularios.FormBuscarPedido.Show();
                    Formularios.FormBuscarPedido.Focus();
                    break;


            }
        }
        #endregion

        #region Funções
        private void GravarPedido()
        {
            PedidoDto pedidoDto = new PedidoDto();

            if (rbVenda.Checked) statusPedido = 1;
            if (rbOrcamento.Checked) statusPedido = 0;

            pedidoDto.Status = statusPedido;
            pedidoDto.UsuarioDto.IdUsuario = AuthenticationDto.Id;
            pedidoDto.ClienteDto.IdCliente = _clienteDto.IdCliente;

            try
            {
                _pedidoBll.InserirPedido(pedidoDto);
                idPedido = _pedidoBll.GetIdPedido();

                lblProduto.Text = "                        CAIXA OCUPADO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GravarItemDoPedido()
        {
            ItemPedidoDto itemPedidoDto = new ItemPedidoDto();
            ItemPedidoBll itemPedidoBll = new ItemPedidoBll();

            itemPedidoDto.Quantidade = Convert.ToDecimal(txtQtd.Text.Trim());
            itemPedidoDto.Desconto = 0;
            itemPedidoDto.ProdutoDto.Id = _produtoDto.Id;
            itemPedidoDto.ProdutoDto.IdInterno = _produtoDto.IdInterno;
            itemPedidoDto.PedidoDto.Id = idPedido;

            try
            {
                statusItemInsert = true;

                itemPedidoBll.InserirItemPedido(itemPedidoDto, statusPedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusItemInsert = false;
            }
        }

        public void CarregaGrid()
        {
            ItemPedidoBll itemPedidoBll = new ItemPedidoBll();

            dtgItensPedido.AutoGenerateColumns = false;

            var lista = new List<ItemPedidoGridDto>();



            try
            {
                if (statusItemInsert == false) return;

                lista = itemPedidoBll.GetItensPedidoById(idPedido).ToList();

                if (lista == null) return;

                dtgItensPedido.DataSource = lista;

                for (int i = 0; i < lista.Count; i++)
                    dtgItensPedido.Rows[i].Cells[0].Value = i + 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // dtgCategoria.DefaultCellStyle.Format = "000000";
            dtgItensPedido.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtgItensPedido.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtgItensPedido.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtgItensPedido.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtgItensPedido.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtgItensPedido.Columns[5].DefaultCellStyle.Format = "C2";
            dtgItensPedido.Columns[6].DefaultCellStyle.Format = "C2";

            lblTotal.Text = calculaValorPedido().ToString("N2");
        }

        private decimal calculaValorPedido()
        {
            decimal valorTotal = 0;
            int i = 0;
            for (i = 0; i < dtgItensPedido.Rows.Count; i++)
            {
                valorTotal += Convert.ToDecimal(dtgItensPedido.Rows[i].Cells[6].Value.ToString());
            }
            return valorTotal;
        }

        public void RecuperaPedido(string cpfCnpj, int tipo)
        {
            idPedido = TrocaInfo.Id;
            TrocaInfo.Dispose();

            statusItemInsert = true;

            statusPedido = tipo;

            if (tipo == 0) rbOrcamento.Checked = true;
            if (tipo == 1) rbVenda.Checked = true;

            CarregaGrid();

            txtCpf.Text = cpfCnpj;

            try
            {
                _clienteDto = _clienteBll.GetClienteByCpfCnpj(txtCpf.Text.Trim());

                txtCliente.Text = _clienteDto.Nome;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelaPedido()
        {
            int[] IdProduto;
            string[] idProdutoInterno;
            int[] idItemPedido;
            decimal[] qtdEstorno;

            int x = dtgItensPedido.RowCount;

            IdProduto = new int[x];
            idProdutoInterno = new string[x];
            idItemPedido = new int[x];
            qtdEstorno = new decimal[x];

            for (int i = 0; i < dtgItensPedido.RowCount; i++)
            {
                idProdutoInterno[i] = dtgItensPedido.Rows[i].Cells[1].Value.ToString();
            }


            ItemPedidoBll itemPedidoBll = new ItemPedidoBll();
            CancelaItemDto cancelaItemDto = new CancelaItemDto();

            for (int i = 0; i < dtgItensPedido.RowCount; i++)
            {
                cancelaItemDto = itemPedidoBll.GetItemCancelar(idPedido, idProdutoInterno[i]);

                qtdEstorno[i] = cancelaItemDto.Quantidade;
                IdProduto[i] = cancelaItemDto.IdProduto;
                idItemPedido[i] = cancelaItemDto.IdItemPedido;
            }

            for (int i = 0; i < dtgItensPedido.RowCount; i++)
            {
                itemPedidoBll.CancelaItemPedido(statusPedido, qtdEstorno[i], idItemPedido[i], IdProduto[i]);
            }

            _pedidoBll.Remove(idPedido);
        }

        public void RefreshPDV()
        {
            total = 0;
            statusPedido = 0;
            idPedido = 0;
            aumentarQtdItem = null;
            statusItemInsert = true;

            txtCodigoProduto.Text = string.Empty;
            lblProduto.Text = "                        CAIXA LIVRE";
            lblValorUnit.Text = string.Empty;
            lblSubTotal.Text = string.Empty;
            lblTotal.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtCliente.Text = string.Empty;

            dtgItensPedido.DataSource = null;
            dtgItensPedido.Rows.Clear();
        }
        #endregion

        #region Suggestion
        private void SuggestionCpfCnpj()
        {
            sourceCpfCnpj = new AutoCompleteStringCollection();

            var listaCpfCnpj = new List<ClienteDto>();

            try
            {
                listaCpfCnpj = _clienteBll.FindAll().ToList();

                if (listaCpfCnpj == null) return; //Se for null sai da função

                DataTable dt = new DataTable();

                dt.Columns.Add("CpfCnpj", typeof(string));

                foreach (var item in listaCpfCnpj)
                {
                    DataRow row = dt.NewRow();

                    row["CpfCnpj"] = item.CpfCnpj;

                    dt.Rows.Add(row);
                }

                foreach (DataRow row in dt.Rows)
                {
                    sourceCpfCnpj.Add(Convert.ToString(row["CpfCnpj"]));
                }

                txtCpf.AutoCompleteCustomSource = sourceCpfCnpj;
                txtCpf.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtCpf.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuggestionCliente()
        {
            sourceCliente = new AutoCompleteStringCollection();

            var listaCliente = new List<ClienteDto>();

            try
            {
                listaCliente = _clienteBll.FindAll().ToList();

                if (listaCliente == null) return; //Se for null sai da função

                DataTable dt = new DataTable();

                dt.Columns.Add("Cliente", typeof(string));

                foreach (var item in listaCliente)
                {
                    DataRow row = dt.NewRow();

                    row["Cliente"] = item.Nome;

                    dt.Rows.Add(row);
                }

                foreach (DataRow row in dt.Rows)
                {
                    sourceCliente.Add(Convert.ToString(row["Cliente"]));
                }

                txtCliente.AutoCompleteCustomSource = sourceCliente;
                txtCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion











    }
}
