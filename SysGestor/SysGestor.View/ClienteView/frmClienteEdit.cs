using SysGestor.BLL;
using SysGestor.BLL.PessoaBll;
using SysGestor.DTO.PessoaDto;
using SysGestor.DTO.PessoaDto.ClienteDto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.ClienteView
{
    public partial class frmClienteEdit : Form
    {
        private string _tipoPessoa;
         AutoCompleteStringCollection source = new AutoCompleteStringCollection();

        CidadeBll cidadeBll;
        CidadeDto cidadeDto;
        ClienteBll clienteBll;
        ClienteDto clienteDto;
        EnderecoBll enderecoBll;
        EnderecoDto enderecoDto;
        ContatoBll contatoBll;
        ContatoDto contatoDto;

        public frmClienteEdit()
        {
            InitializeComponent();
        }

        private void frmClienteEdit_Load(object sender, EventArgs e)
        {
            cidadeBll = new CidadeBll();
            cidadeDto = new CidadeDto();
            clienteBll = new ClienteBll();
            clienteDto = new ClienteDto();
            enderecoBll = new EnderecoBll();
            enderecoDto = new EnderecoDto();
            contatoBll = new ContatoBll();
            contatoDto = new ContatoDto();

            recuperaCliente();

            tipoPessoa();
        }

        #region Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampo();
            frmClienteGrid clienteGrid = new frmClienteGrid();
            clienteGrid.Show();
            this.Close();
        }

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
        #endregion

        #region Editar
        private void recuperaCliente()
        {

            clienteDto = clienteBll.GetCliente(TrocaInfo.Id);

            enderecoDto = enderecoBll.GetEndereco(clienteDto.PessoaDto.Id);

            contatoDto = contatoBll.GetContato(clienteDto.PessoaDto.Id);

            cidadeDto = cidadeBll.GetUfCidade(clienteDto.PessoaDto.Id);

            txtNome.Text = clienteDto.Nome;
          
            rbFisica.Checked = clienteDto.TipoPessoa == "Física" ? true : false;
            rbJuridica.Checked = clienteDto.TipoPessoa == "Jurídica" ? true : false;

            mskCpfCnpj.Text = clienteDto.CpfCnpj;
            txtRgIe.Text = clienteDto.RgIe;
            mskDataNasc.Text = clienteDto.DataNascimento.ToString();
            txtLimiteCredito.Text = clienteDto.LimiteCredito.ToString();
            txtObservacao.Text = clienteDto.Observacao;

            txtLogradouro.Text = enderecoDto.Logradouro;
            txtNumero.Text = enderecoDto.Numero;
            txtComplemento.Text = enderecoDto.Complemento;
            txtBairro.Text = enderecoDto.Bairro;
            mskCep.Text = enderecoDto.Cep;
            txtUf.Text = cidadeDto.Uf;
            txtCidade.Text = cidadeDto.Cidade;

            mskTelFixo.Text = contatoDto.TelFixo;
            mskCelular.Text = contatoDto.TelCel;
            mskTelComercial.Text = contatoDto.TelComercial;
            txtEmail.Text = contatoDto.Email;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
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
            clienteDto.Observacao = txtObservacao.Text.Trim();

            enderecoDto.Logradouro = txtLogradouro.Text.Trim();
            enderecoDto.Numero = txtNumero.Text.Trim();
            enderecoDto.Complemento = txtComplemento.Text.Trim();
            enderecoDto.Bairro = txtBairro.Text.Trim();
            enderecoDto.Cep = mskCep.Text.Trim();
            enderecoDto.CidadeDto.Id = cidadeBll.GetIdCidade(txtCidade.Text.Trim());

            contatoDto.TelFixo = mskTelFixo.Text.Trim();
            contatoDto.TelCel = mskCelular.Text.Trim();
            contatoDto.TelComercial = mskTelComercial.Text.Trim();
            contatoDto.Email = txtEmail.Text.Trim();

            clienteBll.Alterar(clienteDto, clienteDto.PessoaDto.Id);
            enderecoBll.Alterar(enderecoDto);
            contatoBll.Alterar(contatoDto);


            frmClienteGrid clienteGrid = new frmClienteGrid();
            clienteGrid.Show();
            this.Close();
        }    
        #endregion

        #region Validação de Campos
        //private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

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
            txtLogradouro.Text = string.Empty;
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
            txtLogradouro.Enabled = false;
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
        }

        private void habilitaCampo()
        {
            txtNome.Enabled = true;
            mskCpfCnpj.Enabled = true;
            txtRgIe.Enabled = true;
            mskDataNasc.Enabled = true;
            txtLimiteCredito.Enabled = true;
            txtLogradouro.Enabled = true;
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
        }
        #endregion

        #region Funções
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

                //DataSet dsCidade = new DataSet();
                //dsCidade.Tables.Add(dtCidade);

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
        #endregion

    }
}
