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
    public partial class frmClienteNew : Form
    {
        private string _tipoPessoa;
        private int _idCidade;


        public frmClienteNew()
        {
            InitializeComponent();
        }


        private void frmClienteNew_Load(object sender, EventArgs e)
        {
            tipoPessoa();
            loadComboUf();
        }

        private void tipoPessoa()
        {
            if (rbFisica.Checked)
            {
                lblCpfCnpj.Text = "CPF";
                mskCpfCnpj.Mask = "000.000.000-00";
                lblRgIe.Text = "RG";
                lblNomeRazaoSocial.Text = "Nome *";
                _tipoPessoa = "Física";
            }

            if (rbJuridica.Checked)
            {
                lblCpfCnpj.Text = "CNPJ";
                mskCpfCnpj.Mask = "00.000.000/0000-00";
                lblRgIe.Text = "Insc. Est.";
                lblNomeRazaoSocial.Text = "Razão Social *";
                _tipoPessoa = "Jurídica";
            }
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            tipoPessoa();
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            tipoPessoa();
        }

        private void loadComboUf()
        {
            CidadeBll cidadeBll = new CidadeBll();

            IList<CidadeDto> listaUf = new List<CidadeDto>();

            listaUf = cidadeBll.FindUf();

            cmbUf.DataSource = listaUf;
            cmbUf.DisplayMember = "Uf";
            cmbUf.ValueMember = "Id";
        }

        private void loadComboCidade()
        {
            CidadeBll cidadeBll = new CidadeBll();

            IList<CidadeDto> listaCidade = new List<CidadeDto>();

            listaCidade = cidadeBll.FindCidade(cmbUf.Text);

            cmbCidade.DataSource = listaCidade;
            cmbCidade.DisplayMember = "Cidade";
            cmbCidade.ValueMember = "Id";
        }


        #region Inserir Cliente
        private void btnGravar_Click(object sender, EventArgs e)
        {
            DateTime resultado = DateTime.MinValue;

            if (!DateTime.TryParse(this.mskDataNasc.Text.Trim(), out resultado))
            {
                MessageBox.Show("Data de nascimento inválida.", "Validação da Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ClienteBll clienteBll = new ClienteBll();
            ClienteDto clienteDto = new ClienteDto();
            EnderecoBll enderecoBll = new EnderecoBll();
            EnderecoDto enderecoDto = new EnderecoDto();

            clienteDto.Nome = txtNome.Text.Trim();
            clienteDto.TipoPessoa = _tipoPessoa;
            clienteDto.CpfCnpj = mskCpfCnpj.Text.Trim();
            clienteDto.RgIe = txtRgIe.Text.Trim();
            clienteDto.DataNascimento = Convert.ToDateTime(mskDataNasc.Text.Trim());
            clienteDto.LimiteCredito = Convert.ToDouble(txtLimiteCredito.Text.Trim());
            clienteDto.DataCadastro = DateTime.Now;
            clienteDto.Observacao = txtObservacao.Text.Trim();

            enderecoDto.Logradouro = txtLogradouro.Text.Trim();
            enderecoDto.Numero = txtNumero.Text.Trim();
            enderecoDto.Complemento = txtComplemento.Text.Trim();
            enderecoDto.Bairro = txtBairro.Text.Trim();
            enderecoDto.Cep = mskCep.Text.Trim();
            enderecoDto.CidadeDto.Id = Convert.ToInt32(cmbCidade.SelectedValue);

            clienteBll.Inserir(clienteDto);
            enderecoBll.Inserir(enderecoDto);

        }
        #endregion


        private void cmbUf_SelectedIndexChanged(object sender, EventArgs e)
        {           
            loadComboCidade();
        }


    }
}
