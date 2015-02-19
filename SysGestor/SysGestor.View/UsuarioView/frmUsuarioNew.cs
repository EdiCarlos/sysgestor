using SysGestor.BLL.PessoaBll.UsuarioBLL;
using SysGestor.DTO.PessoaDto.UsuarioDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.UsuarioView
{
    public partial class frmUsuarioNew : Form
    {
        UsuarioBll _usuarioBll;
        UsuarioDto _usuarioDto;

        public frmUsuarioNew()
        {
            InitializeComponent();
        }

        private void frmUsuarioNew_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnNovo);
            pcbCabecalho.Controls.Add(btnGravar);
            pcbCabecalho.Controls.Add(btnCancelar);
            pcbCabecalho.Controls.Add(btnSair);

            _usuarioBll = new UsuarioBll();
            _usuarioDto = new UsuarioDto();
        }

        #region Validação de Campos
        private void limpaCampo()
        {
            rbAtivo.Checked = true;
            txtNome.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmaSenha.Text = string.Empty;
        }

        private void desabilitaCampo()
        {
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirmaSenha.Enabled = false;

            btnGravar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void habilitaCampo()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            txtConfirmaSenha.Enabled = true;


            btnGravar.Enabled = true;
            btnNovo.Enabled = false;
        }
        #endregion

        #region Eventos
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!_usuarioBll.ConfirmaSenha(txtSenha.Text.Trim(), txtConfirmaSenha.Text.Trim()))
            {
                MessageBox.Show("A senha não confere", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return;
            }

            _usuarioDto.Nome = txtNome.Text.Trim();
            _usuarioDto.Login = txtLogin.Text.Trim();
            _usuarioDto.Senha = _usuarioBll.GetCriptografiaMD5(txtSenha.Text.Trim());

            try
            {
                _usuarioBll.Inserir(_usuarioDto);

                MessageBox.Show("Usuário inserido com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                desabilitaCampo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
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

        private void frmUsuarioNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) ==
                DialogResult.Yes) Formularios.FormUsuarioNew = null;
            else e.Cancel = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                Formularios.FormUsuarioNew = null;
            }
        }
        #endregion

       

        #region

        #endregion

        #region

        #endregion
    }
}
