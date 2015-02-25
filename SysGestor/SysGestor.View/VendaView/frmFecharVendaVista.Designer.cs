namespace SysGestor.View.VendaView
{
    partial class frmFecharVendaVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFecharVendaVista));
            this.txtDescontoPorc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescontoDinh = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculaPagamento = new System.Windows.Forms.Button();
            this.txtCartaoDebito = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCartaoCedito = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnConfirmaImprimi = new System.Windows.Forms.Button();
            this.lblTroco = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescontoPorc
            // 
            this.txtDescontoPorc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescontoPorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoPorc.ForeColor = System.Drawing.Color.Red;
            this.txtDescontoPorc.Location = new System.Drawing.Point(222, 108);
            this.txtDescontoPorc.Name = "txtDescontoPorc";
            this.txtDescontoPorc.Size = new System.Drawing.Size(114, 38);
            this.txtDescontoPorc.TabIndex = 0;
            this.txtDescontoPorc.Text = "0";
            this.txtDescontoPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescontoPorc.Validated += new System.EventHandler(this.txtDescontoPorc_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Desconto(%)";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCliente.Location = new System.Drawing.Point(134, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 20);
            this.lblCliente.TabIndex = 11;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPedido.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblIdPedido.Location = new System.Drawing.Point(12, 26);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(0, 20);
            this.lblIdPedido.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nº Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblValor.Location = new System.Drawing.Point(12, 110);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(87, 31);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "00,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Desconto($)";
            // 
            // txtDescontoDinh
            // 
            this.txtDescontoDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescontoDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoDinh.ForeColor = System.Drawing.Color.Red;
            this.txtDescontoDinh.Location = new System.Drawing.Point(371, 108);
            this.txtDescontoDinh.Name = "txtDescontoDinh";
            this.txtDescontoDinh.Size = new System.Drawing.Size(114, 38);
            this.txtDescontoDinh.TabIndex = 1;
            this.txtDescontoDinh.Text = "0,00";
            this.txtDescontoDinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescontoDinh.Validated += new System.EventHandler(this.txtDescontoDinh_Validated);
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.ForeColor = System.Drawing.Color.Red;
            this.txtDinheiro.Location = new System.Drawing.Point(23, 41);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(263, 38);
            this.txtDinheiro.TabIndex = 0;
            this.txtDinheiro.Text = "0,00";
            this.txtDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculaPagamento);
            this.groupBox1.Controls.Add(this.txtCartaoDebito);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCartaoCedito);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCheque);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDinheiro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(11, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 391);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Composição do Pagamento";
            // 
            // btnCalculaPagamento
            // 
            this.btnCalculaPagamento.Location = new System.Drawing.Point(23, 345);
            this.btnCalculaPagamento.Name = "btnCalculaPagamento";
            this.btnCalculaPagamento.Size = new System.Drawing.Size(263, 23);
            this.btnCalculaPagamento.TabIndex = 4;
            this.btnCalculaPagamento.Text = "[F1] - Calcular Pagamento";
            this.btnCalculaPagamento.UseVisualStyleBackColor = true;
            this.btnCalculaPagamento.Click += new System.EventHandler(this.btnCalculaPagamento_Click);
            // 
            // txtCartaoDebito
            // 
            this.txtCartaoDebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCartaoDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartaoDebito.ForeColor = System.Drawing.Color.Red;
            this.txtCartaoDebito.Location = new System.Drawing.Point(23, 287);
            this.txtCartaoDebito.Name = "txtCartaoDebito";
            this.txtCartaoDebito.Size = new System.Drawing.Size(263, 38);
            this.txtCartaoDebito.TabIndex = 3;
            this.txtCartaoDebito.Text = "0,00";
            this.txtCartaoDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cartão de Débito";
            // 
            // txtCartaoCedito
            // 
            this.txtCartaoCedito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCartaoCedito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartaoCedito.ForeColor = System.Drawing.Color.Red;
            this.txtCartaoCedito.Location = new System.Drawing.Point(23, 205);
            this.txtCartaoCedito.Name = "txtCartaoCedito";
            this.txtCartaoCedito.Size = new System.Drawing.Size(263, 38);
            this.txtCartaoCedito.TabIndex = 2;
            this.txtCartaoCedito.Text = "0,00";
            this.txtCartaoCedito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cartão de Crédito";
            // 
            // txtCheque
            // 
            this.txtCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheque.ForeColor = System.Drawing.Color.Red;
            this.txtCheque.Location = new System.Drawing.Point(23, 123);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(263, 38);
            this.txtCheque.TabIndex = 1;
            this.txtCheque.Text = "0,00";
            this.txtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cheque";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dinheiro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(368, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Troco";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(521, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Total Pagamento";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalPagar.Location = new System.Drawing.Point(521, 110);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(87, 31);
            this.lblTotalPagar.TabIndex = 11;
            this.lblTotalPagar.Text = "00,00";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(412, 309);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(95, 23);
            this.btnConfirma.TabIndex = 14;
            this.btnConfirma.Text = "[F2] - Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(513, 309);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(95, 23);
            this.btnCancela.TabIndex = 15;
            this.btnCancela.Text = "[F3] - Cancela";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnConfirmaImprimi
            // 
            this.btnConfirmaImprimi.Location = new System.Drawing.Point(412, 347);
            this.btnConfirmaImprimi.Name = "btnConfirmaImprimi";
            this.btnConfirmaImprimi.Size = new System.Drawing.Size(196, 23);
            this.btnConfirmaImprimi.TabIndex = 14;
            this.btnConfirmaImprimi.Text = "[F4] - Confirma e Imprimi Comprovante";
            this.btnConfirmaImprimi.UseVisualStyleBackColor = true;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTroco.Location = new System.Drawing.Point(365, 211);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(87, 31);
            this.lblTroco.TabIndex = 11;
            this.lblTroco.Text = "00,00";
            // 
            // frmFecharVendaVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 571);
            this.Controls.Add(this.btnConfirmaImprimi);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIdPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescontoDinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescontoPorc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFecharVendaVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento a Vista";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFecharVendaVista_FormClosed);
            this.Load += new System.EventHandler(this.frmFecharVendaVista_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFecharVendaVista_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmFecharVendaVista_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescontoPorc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescontoDinh;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCartaoDebito;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCartaoCedito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnConfirmaImprimi;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Button btnCalculaPagamento;
    }
}