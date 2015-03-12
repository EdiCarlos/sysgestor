using SysGestor.BLL;
using SysGestor.BLL.EmpresaBLL;
using SysGestor.BLL.PessoaBll;
using SysGestor.DTO.EmpresaDTO;
using SysGestor.DTO.PessoaDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.EmpresaView
{
    public partial class frmEmpresaEdit : Form
    {
        AutoCompleteStringCollection source = new AutoCompleteStringCollection();
        EmpresaBll _empresaBll;
        EmpresaDto _empresaDto;
        PessoaBll _pessoaBll;

        private string caminhoLogo;

        public frmEmpresaEdit()
        {
            InitializeComponent();
        }

        private void frmEmpresaEdit_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnNovo);
            pcbCabecalho.Controls.Add(btnGravar);
            pcbCabecalho.Controls.Add(btnCancelar);
            pcbCabecalho.Controls.Add(btnSair);

            _empresaBll = new EmpresaBll();
            _empresaDto = new EmpresaDto();
            _pessoaBll = new PessoaBll();

            _empresaDto = _empresaBll.GetEmpresaById(TrocaInfo.Id);
            TrocaInfo.Dispose();

            txtNomeFantasia.Text = _empresaDto.NomeFantasia;
            txtRazaoSocial.Text = _empresaDto.Nome;
            mskCnpj.Text = _empresaDto.CpfCnpj;
            txtIe.Text = _empresaDto.RgIe;
            pcbLogo.Image = Image.FromFile(_empresaDto.Logo);
            txtLogradouro.Text = _empresaDto.EnderecoDto.Logradouro;
            txtNumero.Text = _empresaDto.EnderecoDto.Numero;
            txtComplemento.Text = _empresaDto.EnderecoDto.Complemento;
            txtBairro.Text = _empresaDto.EnderecoDto.Bairro;
            txtUf.Text = _empresaDto.EnderecoDto.CidadeDto.Uf;
            txtCidade.Text = _empresaDto.EnderecoDto.CidadeDto.Cidade;
            mskCep.Text = _empresaDto.EnderecoDto.Cep;
            mskTelFixo.Text = _empresaDto.ContatoDto.TelFixo;
            mskCelular.Text = _empresaDto.ContatoDto.TelCel;
            mskTelComercial.Text = _empresaDto.ContatoDto.TelComercial;
            txtEmail.Text = _empresaDto.ContatoDto.Email;

        }

        #region Eventos
        private void txtUf_Validated(object sender, EventArgs e)
        {
            loadSuggestionCidade();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {

                CidadeBll cidadeBll = new CidadeBll();
                CidadeDto cidadeDto = new CidadeDto();
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

                _empresaDto.NomeFantasia = txtNomeFantasia.Text.Trim();
                _empresaDto.Nome = txtRazaoSocial.Text.Trim();
                _empresaDto.TipoPessoa = "Jurídica";
                _empresaDto.DataCadastro = DateTime.Now;
                _empresaDto.CpfCnpj = mskCnpj.Text.Trim();
                _empresaDto.RgIe = txtIe.Text.Trim();
                _empresaDto.Logo = caminhoLogo;

                enderecoDto.PessoaDto.Id = _empresaDto.Id;
                enderecoDto.Logradouro = txtLogradouro.Text.Trim();
                enderecoDto.Numero = txtNumero.Text.Trim();
                enderecoDto.Complemento = txtComplemento.Text.Trim();
                enderecoDto.Bairro = txtBairro.Text.Trim();
                enderecoDto.Cep = mskCep.Text.Trim();
                enderecoDto.CidadeDto.Id = cidadeBll.GetIdCidade(txtCidade.Text.Trim());

                contatoDto.PessoaDto.Id = _empresaDto.Id;
                contatoDto.TelFixo = mskTelFixo.Text.Trim();
                contatoDto.TelCel = mskCelular.Text.Trim();
                contatoDto.TelComercial = mskTelComercial.Text.Trim();
                contatoDto.Email = txtEmail.Text.Trim();


                _empresaBll.AlterarEmpresa(_empresaDto);

                enderecoBll.Alterar(enderecoDto);

                contatoBll.Alterar(contatoDto);

                desabilitaCampo();


                Image imagem = pcbLogo.Image;
                imagem.Save(temp + txtNomeFantasia.Text.Trim() + "-logo.png", System.Drawing.Imaging.ImageFormat.Png);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar empresa. - " + ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmEmpresaEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.FormEmpresaEdit = null;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FormEmpresaEdit = null;

            if (Formularios.FormEmpresaNew == null) Formularios.FormEmpresaNew = new frmEmpresaNew();

            Formularios.FormEmpresaNew.Show();
            Formularios.FormEmpresaNew.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FormEmpresaEdit = null;
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











        #region

        #endregion

        #region

        #endregion


    }
}
