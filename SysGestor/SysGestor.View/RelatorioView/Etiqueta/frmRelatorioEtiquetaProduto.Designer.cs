namespace SysGestor.View.RelatorioView.Etiqueta
{
    partial class frmRelatorioEtiquetaProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioEtiquetaProduto));
            this.rpwEtiqueta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EtiquetaProduto_3x7DtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EtiquetaProduto_3x7DtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpwEtiqueta
            // 
            this.rpwEtiqueta.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS1";
            reportDataSource1.Value = this.EtiquetaProduto_3x7DtoBindingSource;
            this.rpwEtiqueta.LocalReport.DataSources.Add(reportDataSource1);
            this.rpwEtiqueta.LocalReport.ReportEmbeddedResource = "SysGestor.View.RelatorioView.Etiqueta.ArquivosRDLC.EtiquetaProduto_3x7.rdlc";
            this.rpwEtiqueta.Location = new System.Drawing.Point(0, 0);
            this.rpwEtiqueta.Name = "rpwEtiqueta";
            this.rpwEtiqueta.Size = new System.Drawing.Size(759, 443);
            this.rpwEtiqueta.TabIndex = 0;
            // 
            // EtiquetaProduto_3x7DtoBindingSource
            // 
            this.EtiquetaProduto_3x7DtoBindingSource.DataSource = typeof(SysGestor.DTO.RelatorioDto.Etiqueta.EtiquetaProduto_3x7Dto);
            // 
            // frmRelatorioEtiquetaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 443);
            this.Controls.Add(this.rpwEtiqueta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioEtiquetaProduto";
            this.Text = "Relatório de Etiquetas de Produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelatorioEtiquetaProduto_FormClosed);
            this.Load += new System.EventHandler(this.frmRelatorioEtiquetaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EtiquetaProduto_3x7DtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpwEtiqueta;
        private System.Windows.Forms.BindingSource EtiquetaProduto_3x7DtoBindingSource;
    }
}