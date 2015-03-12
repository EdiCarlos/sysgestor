using Microsoft.Reporting.WinForms;
using SysGestor.DTO.RelatorioDto.Etiqueta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestor.View.RelatorioView.Etiqueta
{
    
    public partial class frmRelatorioEtiquetaProduto : Form
    {
        private List<EtiquetaProduto_3x7Dto> listaEtiqueta;

        public frmRelatorioEtiquetaProduto(List<EtiquetaProduto_3x7Dto> _listaEtiqueta)
        {            
            InitializeComponent();

            listaEtiqueta = new List<EtiquetaProduto_3x7Dto>();

            this.listaEtiqueta = _listaEtiqueta;

            EtiquetaProduto_3x7DtoBindingSource.DataSource = listaEtiqueta;

            this.rpwEtiqueta.RefreshReport();

            rpwEtiqueta.SetDisplayMode(DisplayMode.PrintLayout);
            rpwEtiqueta.ZoomMode = ZoomMode.Percent;
            rpwEtiqueta.ZoomPercent = 100;
        }

        private void frmRelatorioEtiquetaProduto_Load(object sender, EventArgs e)
        {
            
        }

        private void frmRelatorioEtiquetaProduto_FormClosed(object sender, FormClosedEventArgs e)
        {          
            Formularios.FormRelatorioEtiquetaProduto = null;

            if (Formularios.FormEtiquetaProduto == null) Formularios.FormEtiquetaProduto = new frmEtiquetaProduto();

            Formularios.FormEtiquetaProduto.Show();
            Formularios.FormEtiquetaProduto.Focus();
        }
    }
}
