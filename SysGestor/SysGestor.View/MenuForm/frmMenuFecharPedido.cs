using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.MenuForm
{
    public partial class frmMenuFecharPedido : Form
    {
        public frmMenuFecharPedido()
        {
            InitializeComponent();
        }

        private void frmMenuFecharPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.FormMenuFecharPedido = null;
        }
    }
}
