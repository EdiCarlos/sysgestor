using SysGestor.BLL;
using SysGestor.BLL.PessoaBll;
using SysGestor.DTO.PessoaDTO;
using SysGestor.DTO.PessoaDTO.ClienteDto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.ClienteView
{
    public partial class frmClienteNew : Form
    {
        AutoCompleteStringCollection source = new AutoCompleteStringCollection();
        private string _tipoPessoa;
        PessoaBll _pessoaBll;

        public frmClienteNew()
        {
            InitializeComponent();
        }

        private void frmClienteNew_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnNovo);
            pcbCabecalho.Controls.Add(btnGravar);
            pcbCabecalho.Controls.Add(btnCancelar);
            pcbCabecalho.Controls.Add(btnSair);
            tipoPessoa();
        }

        #region Eventos
        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            tipoPessoa();
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            tipoPessoa();
        }

        private void txtUf_Validated(object sender, EventArgs e)
        {
            loadSuggestionCidade();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampo();
            limpaCampo();
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                Formularios.FormClienteNew = null;
            }
        }

        private void frmClienteNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) ==
                DialogResult.Yes) Formularios.FormClienteNew = null;
            else e.Cancel = true;
        }
        #endregion

        #region Inserir Cliente
        private void btnGravar_Click(object sender, EventArgs e)
        {
            CidadeBll cidadeBll = new CidadeBll();
            CidadeDto cidadeDto = new CidadeDto();
            ClienteBll clienteBll = new ClienteBll();
            ClienteDto clienteDto = new ClienteDto();
            EnderecoBll enderecoBll = new EnderecoBll();
            EnderecoDto enderecoDto = new EnderecoDto();
            ContatoBll contatoBll = new ContatoBll();
            ContatoDto contatoDto = new ContatoDto();
            _pessoaBll = new PessoaBll();

            if (txtNome.Text == string.Empty || txtNome.Text.Length < 5)
            {
                MessageBox.Show("Campo nome não pode ser vazio.", "Validação de Nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            DateTime resultado = DateTime.MinValue;
            if (!DateTime.TryParse(this.mskDataNasc.Text.Trim(), out resultado))
            {
                MessageBox.Show("Data de nascimento inválida.", "Validação da Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskDataNasc.Focus();
                return;
            }

            if (txtLimiteCredito.Text == string.Empty)
            {
                MessageBox.Show("Campo limite de crédito não pode ser vazio.", "Validação de Limite de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLimiteCredito.Focus();
                return;
            }

            if (txtCidade.Text == " ")
            {
                MessageBox.Show("Campo uf e cidade não pode ser vazio.", "Validação da Cidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUf.Focus();
                return;
            }

            clienteDto.Nome = txtNome.Text.Trim();
            clienteDto.TipoPessoa = _tipoPessoa;
            clienteDto.CpfCnpj = mskCpfCnpj.Text.Trim();
            clienteDto.RgIe = txtRgIe.Text.Trim();
            clienteDto.DataNascimento = Convert.ToDateTime(mskDataNasc.Text.Trim());
            clienteDto.LimiteCredito = Convert.ToDouble(txtLimiteCredito.Text.Trim());
            clienteDto.DataCadastro = DateTime.Now;
            clienteDto.Observacao = txtObservacao.Text.Trim();

            enderecoDto.Logradouro = rtxFitaDetalheradouro.Text.Trim();
            enderecoDto.Numero = txtNumero.Text.Trim();
            enderecoDto.Complemento = txtComplemento.Text.Trim();
            enderecoDto.Bairro = txtBairro.Text.Trim();
            enderecoDto.Cep = mskCep.Text.Trim();
            enderecoDto.CidadeDto.Id = cidadeBll.GetIdCidade(txtCidade.Text.Trim());

            contatoDto.TelFixo = mskTelFixo.Text.Trim();
            contatoDto.TelCel = mskCelular.Text.Trim();
            contatoDto.TelComercial = mskTelComercial.Text.Trim();
            contatoDto.Email = txtEmail.Text.Trim();

            try
            {
                clienteBll.Inserir(clienteDto);

                contatoDto.PessoaDto.Id = _pessoaBll.GetIdPessoa();

                enderecoBll.Inserir(enderecoDto);

                contatoBll.Inserir(contatoDto);
                               
                MessageBox.Show("Cliente inserido com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                desabilitaCampo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
        #endregion

        #region Validação de Campos
        private void txtRgIe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void limpaCampo()
        {
            rbFisica.Checked = true;
            txtNome.Text = string.Empty;
            mskCpfCnpj.Text = string.Empty;
            txtRgIe.Text = string.Empty;
            mskDataNasc.Text = string.Empty;
            txtLimiteCredito.Text = string.Empty;
            rtxFitaDetalheradouro.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtUf.Text = string.Empty;
            txtCidade.Text = string.Empty;
            mskCep.Text = string.Empty;
            mskTelFixo.Text = string.Empty;
            mskCelular.Text = string.Empty;
            mskTelComercial.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtObservacao.Text = string.Empty;
        }

        private void desabilitaCampo()
        {
            txtNome.Enabled = false;
            mskCpfCnpj.Enabled = false;
            txtRgIe.Enabled = false;
            mskDataNasc.Enabled = false;
            txtLimiteCredito.Enabled = false;
            rtxFitaDetalheradouro.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtUf.Enabled = false;
            txtCidade.Enabled = false;
            mskCep.Enabled = false;
            mskTelFixo.Enabled = false;
            mskCelular.Enabled = false;
            mskTelComercial.Enabled = false;
            txtEmail.Enabled = false;
            txtObservacao.Enabled = false;

            btnGravar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void habilitaCampo()
        {
            txtNome.Enabled = true;
            mskCpfCnpj.Enabled = true;
            txtRgIe.Enabled = true;
            mskDataNasc.Enabled = true;
            txtLimiteCredito.Enabled = true;
            rtxFitaDetalheradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtUf.Enabled = true;
            txtCidade.Enabled = true;
            mskCep.Enabled = true;
            mskTelFixo.Enabled = true;
            mskCelular.Enabled = true;
            mskTelComercial.Enabled = true;
            txtEmail.Enabled = true;
            txtObservacao.Enabled = true;

            btnGravar.Enabled = true;
            btnNovo.Enabled = false;
        }
        #endregion

        #region Funções
        private void loadSuggestionCidade()
        {
            CidadeBll cidadeBll = new CidadeBll();

            IList<CidadeDto> listaCidade = new List<CidadeDto>();

            try
            {
                listaCidade = cidadeBll.FindSuggestionCidade(txtUf.Text.Trim());

                DataTable dtCidade = new DataTable();

                dtCidade.Columns.Add("Cidade", typeof(string));

                foreach (var item in listaCidade)
                {
                    DataRow row = dtCidade.NewRow();

                    row["Cidade"] = item.Cidade;

                    dtCidade.Rows.Add(row);
                }

                foreach (DataRow row in dtCidade.Rows)
                {
                    source.Add(Convert.ToString(row["Cidade"]));
                }

                txtCidade.AutoCompleteCustomSource = source;
                txtCidade.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtCidade.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tipoPessoa()
        {
            if (rbFisica.Checked)
            {
                lblCpfCnpj.Text = "CPF";
                mskCpfCnpj.Mask = "000,000,000-00";
                lblRgIe.Text = "RG";
                lblNomeRazaoSocial.Text = "Nome *";
                _tipoPessoa = "Física";
            }

            if (rbJuridica.Checked)
            {
                lblCpfCnpj.Text = "CNPJ";
                mskCpfCnpj.Mask = "00,000,000/0000-00";
                lblRgIe.Text = "Insc. Est.";
                lblNomeRazaoSocial.Text = "Razão Social *";
                _tipoPessoa = "Jurídica";
            }
        }
        #endregion

    }
}
