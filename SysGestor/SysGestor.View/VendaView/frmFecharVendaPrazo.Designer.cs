namespace SysGestor.View.VendaView
{
    partial class frmFecharVendaPrazo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFecharVendaPrazo));
            this.btnConfirmaImprimi = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCalculaParcela = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorPedido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAcrescimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgPrincipal = new System.Windows.Forms.DataGridView();
            this.nudQtdParcela = new System.Windows.Forms.NumericUpDown();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaPagamento = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDebito = new System.Windows.Forms.Label();
            this.ckbEntrada = new System.Windows.Forms.CheckBox();
            this.parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdParcela)).BeginInit();
            this.gpbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmaImprimi
            // 
            this.btnConfirmaImprimi.Location = new System.Drawing.Point(544, 259);
            this.btnConfirmaImprimi.Name = "btnConfirmaImprimi";
            this.btnConfirmaImprimi.Size = new System.Drawing.Size(196, 23);
            this.btnConfirmaImprimi.TabIndex = 32;
            this.btnConfirmaImprimi.Text = "[F4] - Confirma e Imprimi Comprovante";
            this.btnConfirmaImprimi.UseVisualStyleBackColor = true;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(544, 220);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(95, 23);
            this.btnConfirma.TabIndex = 31;
            this.btnConfirma.Text = "[F2] - Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(645, 220);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(95, 23);
            this.btnCancela.TabIndex = 33;
            this.btnCancela.Text = "[F3] - Cancela";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalPagar.Location = new System.Drawing.Point(634, 59);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(87, 31);
            this.lblTotalPagar.TabIndex = 28;
            this.lblTotalPagar.Text = "00,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(634, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Total a Prazo";
            // 
            // btnCalculaParcela
            // 
            this.btnCalculaParcela.Location = new System.Drawing.Point(544, 181);
            this.btnCalculaParcela.Name = "btnCalculaParcela";
            this.btnCalculaParcela.Size = new System.Drawing.Size(196, 23);
            this.btnCalculaParcela.TabIndex = 4;
            this.btnCalculaParcela.Text = "[F1] - Calcular Parcela(s)";
            this.btnCalculaParcela.UseVisualStyleBackColor = true;
            this.btnCalculaParcela.Click += new System.EventHandler(this.btnCalculaParcela_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbEntrada);
            this.groupBox1.Controls.Add(this.btnConfirmaImprimi);
            this.groupBox1.Controls.Add(this.btnConfirma);
            this.groupBox1.Controls.Add(this.btnCalculaParcela);
            this.groupBox1.Controls.Add(this.btnCancela);
            this.groupBox1.Controls.Add(this.dtgPrincipal);
            this.groupBox1.Controls.Add(this.txtAcrescimo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudQtdParcela);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblValorPedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblTotalPagar);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 355);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parcelamento";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCliente.Location = new System.Drawing.Point(137, 42);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 20);
            this.lblCliente.TabIndex = 27;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPedido.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblIdPedido.Location = new System.Drawing.Point(15, 42);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(0, 20);
            this.lblIdPedido.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nº Parcelas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nº Pedido";
            // 
            // lblValorPedido
            // 
            this.lblValorPedido.AutoSize = true;
            this.lblValorPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblValorPedido.Location = new System.Drawing.Point(11, 59);
            this.lblValorPedido.Name = "lblValorPedido";
            this.lblValorPedido.Size = new System.Drawing.Size(87, 31);
            this.lblValorPedido.TabIndex = 26;
            this.lblValorPedido.Text = "00,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Valor Pedido";
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcrescimo.ForeColor = System.Drawing.Color.Red;
            this.txtAcrescimo.Location = new System.Drawing.Point(370, 57);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.Size = new System.Drawing.Size(114, 38);
            this.txtAcrescimo.TabIndex = 18;
            this.txtAcrescimo.Text = "0,00";
            this.txtAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Acréscimo(%)";
            // 
            // dtgPrincipal
            // 
            this.dtgPrincipal.AllowUserToAddRows = false;
            this.dtgPrincipal.AllowUserToDeleteRows = false;
            this.dtgPrincipal.AllowUserToResizeColumns = false;
            this.dtgPrincipal.AllowUserToResizeRows = false;
            this.dtgPrincipal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parcela,
            this.idPedido,
            this.valorParcela,
            this.dataVenc});
            this.dtgPrincipal.Location = new System.Drawing.Point(19, 105);
            this.dtgPrincipal.Name = "dtgPrincipal";
            this.dtgPrincipal.ReadOnly = true;
            this.dtgPrincipal.Size = new System.Drawing.Size(516, 230);
            this.dtgPrincipal.TabIndex = 34;
            // 
            // nudQtdParcela
            // 
            this.nudQtdParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdParcela.ForeColor = System.Drawing.Color.Red;
            this.nudQtdParcela.Location = new System.Drawing.Point(221, 57);
            this.nudQtdParcela.Name = "nudQtdParcela";
            this.nudQtdParcela.Size = new System.Drawing.Size(114, 38);
            this.nudQtdParcela.TabIndex = 35;
            this.nudQtdParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQtdParcela.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtdParcela.ValueChanged += new System.EventHandler(this.nudQtdParcela_ValueChanged);
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.label4);
            this.gpbCliente.Controls.Add(this.label2);
            this.gpbCliente.Controls.Add(this.lblIdPedido);
            this.gpbCliente.Controls.Add(this.lblCliente);
            this.gpbCliente.Controls.Add(this.lblDebito);
            this.gpbCliente.Controls.Add(this.label11);
            this.gpbCliente.Controls.Add(this.lblSaldo);
            this.gpbCliente.Controls.Add(this.label13);
            this.gpbCliente.Controls.Add(this.lblCredito);
            this.gpbCliente.Controls.Add(this.label5);
            this.gpbCliente.Controls.Add(this.txtDiaPagamento);
            this.gpbCliente.Controls.Add(this.label15);
            this.gpbCliente.Location = new System.Drawing.Point(12, 12);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(768, 162);
            this.gpbCliente.TabIndex = 36;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Cliente";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSaldo.Location = new System.Drawing.Point(421, 115);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(87, 31);
            this.lblSaldo.TabIndex = 26;
            this.lblSaldo.Text = "00,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(424, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Saldo";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCredito.Location = new System.Drawing.Point(13, 115);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(87, 31);
            this.lblCredito.TabIndex = 26;
            this.lblCredito.Text = "00,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Crédito";
            // 
            // txtDiaPagamento
            // 
            this.txtDiaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaPagamento.ForeColor = System.Drawing.Color.Red;
            this.txtDiaPagamento.Location = new System.Drawing.Point(625, 108);
            this.txtDiaPagamento.Name = "txtDiaPagamento";
            this.txtDiaPagamento.Size = new System.Drawing.Size(114, 38);
            this.txtDiaPagamento.TabIndex = 18;
            this.txtDiaPagamento.Text = "05";
            this.txtDiaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(622, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Dia Pagamento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Débito";
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDebito.Location = new System.Drawing.Point(217, 115);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(87, 31);
            this.lblDebito.TabIndex = 26;
            this.lblDebito.Text = "00,00";
            // 
            // ckbEntrada
            // 
            this.ckbEntrada.AutoSize = true;
            this.ckbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEntrada.Location = new System.Drawing.Point(502, 71);
            this.ckbEntrada.Name = "ckbEntrada";
            this.ckbEntrada.Size = new System.Drawing.Size(77, 21);
            this.ckbEntrada.TabIndex = 37;
            this.ckbEntrada.Text = "Entrada";
            this.ckbEntrada.UseVisualStyleBackColor = true;
            // 
            // parcela
            // 
            this.parcela.HeaderText = "Parcela";
            this.parcela.Name = "parcela";
            this.parcela.ReadOnly = true;
            this.parcela.Width = 50;
            // 
            // idPedido
            // 
            this.idPedido.HeaderText = "Id Pedido";
            this.idPedido.Name = "idPedido";
            this.idPedido.ReadOnly = true;
            // 
            // valorParcela
            // 
            this.valorParcela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorParcela.HeaderText = "Valor da Parcela";
            this.valorParcela.Name = "valorParcela";
            this.valorParcela.ReadOnly = true;
            // 
            // dataVenc
            // 
            this.dataVenc.HeaderText = "Vencimento";
            this.dataVenc.Name = "dataVenc";
            this.dataVenc.ReadOnly = true;
            // 
            // frmFecharVendaPrazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 546);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFecharVendaPrazo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento a Prazo";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFecharVendaPrazo_FormClosing);
            this.Load += new System.EventHandler(this.frmFecharVendaPrazo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFecharVendaPrazo_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmFecharVendaPrazo_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdParcela)).EndInit();
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmaImprimi;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCalculaParcela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAcrescimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgPrincipal;
        private System.Windows.Forms.NumericUpDown nudQtdParcela;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaPagamento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDebito;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ckbEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVenc;
    }
}