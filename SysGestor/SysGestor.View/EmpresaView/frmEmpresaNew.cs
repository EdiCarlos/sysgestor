using SysGestor.BLL.EmpresaBLL;
using SysGestor.BLL.PessoaBll;
using SysGestor.DTO.EmpresaDTO;
using SysGestor.DTO.PessoaDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using System.IO;

namespace SysGestor.View.EmpresaView
{
    public partial class frmEmpresaNew : Form
    {
        AutoCompleteStringCollection source = new AutoCompleteStringCollection();
        EmpresaBll _empresaBll;
        PessoaBll _pessoaBll;

        string caminhoLogo;

        public frmEmpresaNew()
        {
            InitializeComponent();
        }
        
        #region Eventos
        private void frmEmpresaNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            Formularios.FormEmpresaNew = null;
        }

        private void frmEmpresaNew_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnNovo);
            pcbCabecalho.Controls.Add(btnGravar);
            pcbCabecalho.Controls.Add(btnCancelar);
            pcbCabecalho.Controls.Add(btnSair);

            _empresaBll = new EmpresaBll();
            _pessoaBll = new PessoaBll();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                
                    CidadeBll cidadeBll = new CidadeBll();
                    CidadeDto cidadeDto = new CidadeDto();
                    EmpresaDto empresaDto = new EmpresaDto();
                    EnderecoDto enderecoDto = new EnderecoDto();
                    ContatoDto contatoDto = new ContatoDto();
                    EnderecoBll enderecoBll = new EnderecoBll();
                    ContatoBll contatoBll = new ContatoBll();

                    string temp = @"C:\temp\";

                    if (!Directory.Exists(temp))
                    {
                        Directory.CreateDirectory(temp);
                    }

                    caminhoLogo = temp + txtNomeFantasia.Text.Trim() + "-logo.png";

                    empresaDto.NomeFantasia = txtNomeFantasia.Text.Trim();
                    empresaDto.Nome = txtRazaoSocial.Text.Trim();
                    empresaDto.TipoPessoa = "Jurídica";
                    empresaDto.DataCadastro = DateTime.Now;
                    empresaDto.CpfCnpj = mskCnpj.Text.Trim();
                    empresaDto.RgIe = txtIe.Text.Trim();
                    empresaDto.Logo = caminhoLogo;

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


                  _empresaBll.InserirEmpresa(empresaDto);

                  contatoDto.PessoaDto.Id = _pessoaBll.GetIdPessoa();

                    enderecoBll.Inserir(enderecoDto);

                    contatoBll.Inserir(contatoDto);

                    desabilitaCampo();                   

                    Image imagem = pcbLogo.Image;                   
                    imagem.Save(temp + txtNomeFantasia.Text.Trim() + "-logo.png", System.Drawing.Imaging.ImageFormat.Png);
                                           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar empresa. - " + ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtUf_Validated(object sender, EventArgs e)
        {
            loadSuggestionCidade();
        }

        private void btnBuscaImagem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.ofdFoto.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pcbLogo.Image = null;
                caminhoLogo = string.Empty;

                foreach (var item in ofdFoto.FileNames)
                {
                    caminhoLogo += item;


                    try
                    {
                        Image imagem = Image.FromFile(caminhoLogo);

                        pcbLogo.Image = imagem;

                    }
                    catch (SecurityException ex)
                    {
                        // O usuário  não possui permissão para ler arquivos
                        MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                    "Mensagem : " + ex.Message + "\n\n" +
                                                    "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        // Não pode carregar a imagem (problemas de permissão)
                        MessageBox.Show("Não é possível exibir a imagem : " + item.Substring(('\\'))
                                                   + ". Você pode não ter permissão para ler o arquivo , ou " +
                                                   " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                    }
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaCampo();
            habilitaCampo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FormEmpresaNew = null;
        }
        #endregion
        
        #region Funções
        private void limpaCampo()
        {
            txtRazaoSocial.Text = string.Empty;
            txtNomeFantasia.Text = string.Empty;
            mskCnpj.Text = string.Empty;
            txtIe.Text = string.Empty;
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
        }

        private void desabilitaCampo()
        {
            txtRazaoSocial.Enabled = false;
            txtNomeFantasia.Enabled = false;
            mskCnpj.Enabled = false;
            txtIe.Enabled = false;
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
            btnGravar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void habilitaCampo()
        {
            txtRazaoSocial.Enabled = true;
            txtNomeFantasia.Enabled = true;
            mskCnpj.Enabled = true;
            txtIe.Enabled = true;
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
            btnGravar.Enabled = true;
            btnNovo.Enabled = false;
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
