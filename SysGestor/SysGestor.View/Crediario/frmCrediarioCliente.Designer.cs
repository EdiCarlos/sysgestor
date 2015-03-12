namespace SysGestor.View.Crediario
{
    partial class frmCrediarioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrediarioCliente));
            this.dtgPrincipal = new System.Windows.Forms.DataGridView();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblBtnReceber = new System.Windows.Forms.Label();
            this.lblBtnVoltar = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorRecebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPrincipal
            // 
            this.dtgPrincipal.AllowUserToDeleteRows = false;
            this.dtgPrincipal.AllowUserToResizeColumns = false;
            this.dtgPrincipal.AllowUserToResizeRows = false;
            this.dtgPrincipal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo,
            this.historico,
            this.valorRecebido,
            this.restante,
            this.vencimento,
            this.pagamento});
            this.dtgPrincipal.Location = new System.Drawing.Point(12, 105);
            this.dtgPrincipal.Name = "dtgPrincipal";
            this.dtgPrincipal.ReadOnly = true;
            this.dtgPrincipal.RowTemplate.Height = 30;
            this.dtgPrincipal.Size = new System.Drawing.Size(783, 381);
            this.dtgPrincipal.TabIndex = 35;
            this.dtgPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellContentClick);
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(783, 68);
            this.lblCliente.TabIndex = 36;
            this.lblCliente.Text = "0000 - Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBtnReceber
            // 
            this.lblBtnReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBtnReceber.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnReceber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBtnReceber.ForeColor = System.Drawing.Color.Black;
            this.lblBtnReceber.Image = global::SysGestor.View.Properties.Resources.receber;
            this.lblBtnReceber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBtnReceber.Location = new System.Drawing.Point(687, 495);
            this.lblBtnReceber.Name = "lblBtnReceber";
            this.lblBtnReceber.Size = new System.Drawing.Size(108, 51);
            this.lblBtnReceber.TabIndex = 37;
            this.lblBtnReceber.Text = "[F12] - Receber";
            this.lblBtnReceber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblBtnReceber.Click += new System.EventHandler(this.lblBtnReceber_Click);
            // 
            // lblBtnVoltar
            // 
            this.lblBtnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBtnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBtnVoltar.ForeColor = System.Drawing.Color.Black;
            this.lblBtnVoltar.Image = global::SysGestor.View.Properties.Resources._return;
            this.lblBtnVoltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBtnVoltar.Location = new System.Drawing.Point(12, 495);
            this.lblBtnVoltar.Name = "lblBtnVoltar";
            this.lblBtnVoltar.Size = new System.Drawing.Size(95, 51);
            this.lblBtnVoltar.TabIndex = 37;
            this.lblBtnVoltar.Text = "&Voltar";
            this.lblBtnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblBtnVoltar.Click += new System.EventHandler(this.lblBtnVoltar_Click);
            // 
            // titulo
            // 
            this.titulo.DataPropertyName = "IdParcela";
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // historico
            // 
            this.historico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.historico.DataPropertyName = "Historico";
            this.historico.HeaderText = "Histórico";
            this.historico.Name = "historico";
            this.historico.ReadOnly = true;
            // 
            // valorRecebido
            // 
            this.valorRecebido.DataPropertyName = "ValorPago";
            this.valorRecebido.HeaderText = "V. Recebido";
            this.valorRecebido.Name = "valorRecebido";
            this.valorRecebido.ReadOnly = true;
            this.valorRecebido.Width = 90;
            // 
            // restante
            // 
            this.restante.DataPropertyName = "Restante";
            this.restante.HeaderText = "Restante";
            this.restante.Name = "restante";
            this.restante.ReadOnly = true;
            this.restante.Width = 90;
            // 
            // vencimento
            // 
            this.vencimento.DataPropertyName = "DataVencimento";
            this.vencimento.HeaderText = "Vencimento";
            this.vencimento.Name = "vencimento";
            this.vencimento.ReadOnly = true;
            this.vencimento.Width = 90;
            // 
            // pagamento
            // 
            this.pagamento.HeaderText = "Pagar";
            this.pagamento.Image = global::SysGestor.View.Properties.Resources.receber;
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            this.pagamento.Width = 50;
            // 
            // frmCrediarioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 555);
            this.Controls.Add(this.lblBtnReceber);
            this.Controls.Add(this.lblBtnVoltar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dtgPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCrediarioCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crediário do Cliente";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCrediarioCliente_FormClosing);
            this.Load += new System.EventHandler(this.frmCrediarioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPrincipal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblBtnVoltar;
        private System.Windows.Forms.Label lblBtnReceber;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn historico;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorRecebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn restante;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
        private System.Windows.Forms.DataGridViewImageColumn pagamento;
    }
}