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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            Formularios.FormPedido = null;
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToString();
        }
    }
}
