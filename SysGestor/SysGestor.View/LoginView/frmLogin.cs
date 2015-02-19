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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pcLogin.Controls.Add(btnLogar);
            pcLogin.Controls.Add(lblCancelar);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Formularios.FormLogin = null;
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FormLogin = null;
        }
    }
}
