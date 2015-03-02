using SysGestor.BLL.AuthenticationBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.LoginView
{
    public partial class frmLogin : Form
    {
        MDISysGestor Formulario { get; set; }

        public frmLogin(MDISysGestor formulario)
        {
            InitializeComponent();

            this.Formulario = formulario;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pcLogin.Controls.Add(lblLogar);
            pcLogin.Controls.Add(lblCancelar);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void lblLogar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
            }
        }

        private void Logar()
        {
            bool logado = false;
            AuthenticationBll authenticationBll = new AuthenticationBll();

            try
            {
                logado = authenticationBll.Authentication(txtUsuario.Text.Trim(), txtSenha.Text.Trim());

                if (logado == false)
                {
                    MessageBox.Show("Usuário ou senha não foram informados corretamente.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                this.Formulario.HabilitarForm(logado);
                this.Close();
                Formularios.FormLogin = null;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
