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
    public partial class frmPDV : Form
    {
        public frmPDV()
        {
            InitializeComponent();
        }

        public void carregaFitaDetalhe(string texto)
        {
            string empresa = "LOJA MDELO";
            string endereco = "Rua Sete de Setembro, 2.252 - Centro";
            string cidade = "Morro Agudo - SP";
            string cnpj = "11.111.111/1111-11";
            DateTime hora = DateTime.Now;
            string divisao = "========================================";


            rtxFitaDetalhe.Text = string.Format("\t\t{0}\n{1}\n\t\t{2}\n\t\t{3}\n\t\t\t{4}\n{5}\n\n",
                                                 empresa, endereco, cidade, cnpj, hora, divisao);

            //if (texto != "")
            //{
            //    if (this.rtxFitaDetalhe.InvokeRequired && !rtxFitaDetalhe.IsDisposed)
            //    {
            //        Invoke(new MethodInvoker(delegate()
            //            {
            //                rtxFitaDetalhe.AppendText( texto + "\n");
            //            }));
            //    }
            //    else if (!rtxFitaDetalhe.IsDisposed)
            //    {
            //        rtxFitaDetalhe.AppendText( texto + "\n");
            //    }
            //}
        }

        private void frmPDV_Load(object sender, EventArgs e)
        {
           // carregaFitaDetalhe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregaFitaDetalhe(lblProduto.Text);
        }
    }
}
