using SysGestor.BLL;
using SysGestor.BLL.PessoaBll;
using SysGestor.BLL.PessoaBll.FornecedorBll;
using SysGestor.DTO.PessoaDTO;
using SysGestor.DTO.PessoaDTO.FornecedorDto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.FornecedorView
{
    public partial class frmFornecedorEdit : Form
    {
        private string _tipoPessoa;
        AutoCompleteStringCollection source = new AutoCompleteStringCollection();

        CidadeBll cidadeBll;
        CidadeDto cidadeDto;
        FornecedorBll fornecedorBll;
        FornecedorDto fornecedorDto;
        EnderecoBll enderecoBll;
        EnderecoDto enderecoDto;
        ContatoBll contatoBll;
        ContatoDto contatoDto;

        public frmFornecedorEdit()
        {
            InitializeComponent();

            cidadeBll = new CidadeBll();
            cidadeDto = new CidadeDto();
            fornecedorBll = new FornecedorBll();
            fornecedorDto = new FornecedorDto();
            enderecoBll = new EnderecoBll();
            enderecoDto = new EnderecoDto();
            contatoBll = new ContatoBll();
            contatoDto = new ContatoDto();
        }

        private void frmFornecedorEdit_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnGravar);
            pcbCabecalho.Controls.Add(btnCancelar);
            pcbCabecalho.Controls.Add(btnSair);

            recuperaFornecedor();

            tipoPessoa();
        }

        #region Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampo();
            frmFornecedorGrid fornecedorGrid = new frmFornecedorGrid();
            fornecedorGrid.Show();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
                Dispose(true);
                Formularios.FormFornecedorEdit = null;
        }

        private void frmFornecedorEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose(true);
            Formularios.FormFornecedorEdit = null;
        }
        #endregion

        #region Editar
        private void recuperaFornecedor()
        {

            fornecedorDto = fornecedorBll.GetFornecedor(TrocaInfo.Id);

            enderecoDto = enderecoBll.GetEndereco(fornecedorDto.PessoaDto.Id);

            contatoDto = contatoBll.GetContato(fornecedorDto.PessoaDto.Id);

            cidadeDto = cidadeBll.GetUfCidade(fornecedorDto.PessoaDto.Id);

            txtNome.Text = fornecedorDto.Nome;

            rbFisica.Checked = fornecedorDto.TipoPessoa == "Física" ? true : false;
            rbJuridica.Checked = fornecedorDto.TipoPessoa == "Jurídica" ? true : false;

            mskCpfCnpj.Text = fornecedorDto.CpfCnpj;
            txtRgIe.Text = fornecedorDto.RgIe;
            mskDataNasc.Text = fornecedorDto.DataNascimento.ToString();
            txtObservacao.Text = fornecedorDto.Observacao;

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

            if (txtCidade.Text == " ")
            {
                MessageBox.Show("Campo uf e cidade não pode ser vazio.", "Validação da Cidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUf.Focus();
                return;
            }

            fornecedorDto.Nome = txtNome.Text.Trim();
            fornecedorDto.TipoPessoa = _tipoPessoa;
            fornecedorDto.CpfCnpj = mskCpfCnpj.Text.Trim();
            fornecedorDto.RgIe = txtRgIe.Text.Trim();
            fornecedorDto.DataNascimento = Convert.ToDateTime(mskDataNasc.Text.Trim());
            fornecedorDto.Observacao = txtObservacao.Text.Trim();

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

            fornecedorBll.Alterar(fornecedorDto, fornecedorDto.PessoaDto.Id);
            enderecoBll.Alterar(enderecoDto);
            contatoBll.Alterar(contatoDto);

            if (Formularios.FormFornecedorGrid == null) Formularios.FormFornecedorGrid = new frmFornecedorGrid();

            Formularios.FormFornecedorGrid.Show();
            Formularios.FormFornecedorGrid.Focus();

            this.Close();
            Formularios.FormFornecedorEdit = null;            
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
