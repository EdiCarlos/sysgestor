using SysGestor.BLL;
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
       
        public frmClienteNew()
        {
            InitializeComponent();
        }


        private void frmClienteNew_Load(object sender, EventArgs e)
        {
            tipoPessoa();
        }

        private void tipoPessoa()
        {
            if (rbFisica.Checked)
            {
                lblCpfCnpj.Text = "CPF";
                lblRgIe.Text = "RG";
                lblNomeRazaoSocial.Text = "Nome";
                _tipoPessoa = "Física";
            }

            if (rbJuridica.Checked)
            {
                lblCpfCnpj.Text = "CNPJ";
                lblRgIe.Text = "Insc. Est.";
                lblNomeRazaoSocial.Text = "Razão Social";
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

                clienteDto.Nome = txtNome.Text.Trim();
                clienteDto.TipoPessoa = _tipoPessoa;
                clienteDto.CpfCnpj = txtCpfCnpj.Text.Trim();
                clienteDto.RgIe = txtRgIe.Text.Trim();
                clienteDto.DataNascimento = Convert.ToDateTime(mskDataNasc.Text.Trim());
                clienteDto.DataCadastro = DateTime.Now;
                clienteDto.Observacao = txtObservacao.Text.Trim();

                clienteBll.Inserir(clienteDto);       
               
        }
        #endregion


    }
}
