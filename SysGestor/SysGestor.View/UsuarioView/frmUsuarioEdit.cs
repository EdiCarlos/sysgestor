using SysGestor.BLL;
using SysGestor.BLL.PessoaBll.UsuarioBLL;
using SysGestor.DTO.PessoaDTO.UsuarioDTO;
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
    public partial class frmUsuarioEdit : Form
    {
        UsuarioBll _usuarioBll;
        UsuarioDto _usuarioDto;

        public frmUsuarioEdit()
        {
            InitializeComponent();
        }

        private void frmUsuarioEdit_Load(object sender, EventArgs e)
        {
            pcbCabecalho.Controls.Add(btnGravar);
            pcbCabecalho.Controls.Add(btnCancelar);
            pcbCabecalho.Controls.Add(btnSair);

            _usuarioBll = new UsuarioBll();
            _usuarioDto = new UsuarioDto();

            RecuperaUsuario();
        }       

        #region Eventos
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Digite a senha e confirme, para concluir a alteração.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return;
            }

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
                _usuarioBll.Alterar(_usuarioDto);

                MessageBox.Show("Usuário alterado com sucesso.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                desabilitaCampo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampo();
        }
       

        private void frmUsuarioEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) ==
            DialogResult.Yes) Formularios.FormUsuarioEdit = null;
            else e.Cancel = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do cadastro?", Application.CompanyName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose(true);
                Formularios.FormUsuarioEdit = null;
            }
        }
        #endregion

        #region Funções
        private void RecuperaUsuario()
        {
            _usuarioDto = _usuarioBll.GetUsuarioById(TrocaInfo.Id);
            TrocaInfo.Dispose();

            txtNome.Text = _usuarioDto.Nome;
            txtLogin.Text = _usuarioDto.Login;
          //  txtSenha.Text = _usuarioDto.Senha;
        }

        #endregion

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
        }

        private void habilitaCampo()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            txtConfirmaSenha.Enabled = true;


            btnGravar.Enabled = true;
        }
        #endregion

    }
}
