using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.VendaView
{
    public partial class frmFecharPedidoVista : Form
    {
        public frmFecharPedidoVista()
        {
            InitializeComponent();
        }

        private void frmFecharPedidoVista_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.FormFecharPedidoVista = null;
        }
    }
}
