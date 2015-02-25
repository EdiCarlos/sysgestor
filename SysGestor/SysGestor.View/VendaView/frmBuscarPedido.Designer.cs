namespace SysGestor.View.VendaView
{
    partial class frmBuscarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarPedido));
            this.dtgPrincipal = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbxPesquisa = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoVenda = new System.Windows.Forms.ComboBox();
            this.rbCpfCnpj = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbNumeroPedido = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
            this.gbxPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPrincipal
            // 
            this.dtgPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.dtgPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPrincipal.ColumnHeadersHeight = 30;
            this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nome,
            this.CpfCnpj,
            this.dataNasc,
            this.dataPedido,
            this.editar});
            this.dtgPrincipal.Location = new System.Drawing.Point(12, 156);
            this.dtgPrincipal.Name = "dtgPrincipal";
            this.dtgPrincipal.Size = new System.Drawing.Size(834, 328);
            this.dtgPrincipal.TabIndex = 1;
            this.dtgPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellContentClick);
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "Id";
            this.idCliente.HeaderText = "Nº Pedido";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Width = 80;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "NomeCliente";
            this.nome.HeaderText = "Nome Cliente";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // CpfCnpj
            // 
            this.CpfCnpj.DataPropertyName = "CpfCnpj";
            this.CpfCnpj.HeaderText = "CPF / CNPJ";
            this.CpfCnpj.Name = "CpfCnpj";
            this.CpfCnpj.ReadOnly = true;
            this.CpfCnpj.Width = 110;
            // 
            // dataNasc
            // 
            this.dataNasc.DataPropertyName = "TipoPedido";
            this.dataNasc.HeaderText = "Tipo";
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.ReadOnly = true;
            this.dataNasc.Width = 110;
            // 
            // dataPedido
            // 
            this.dataPedido.DataPropertyName = "DataPedido";
            this.dataPedido.HeaderText = "Data Pedido";
            this.dataPedido.Name = "dataPedido";
            this.dataPedido.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Image = global::SysGestor.View.Properties.Resources.edit_16x16;
            this.editar.Name = "editar";
            this.editar.ToolTipText = "Editar Cliente";
            this.editar.Width = 40;
            // 
            // gbxPesquisa
            // 
            this.gbxPesquisa.Controls.Add(this.label3);
            this.gbxPesquisa.Controls.Add(this.dtpDataFinal);
            this.gbxPesquisa.Controls.Add(this.dtpDataInicial);
            this.gbxPesquisa.Controls.Add(this.label1);
            this.gbxPesquisa.Controls.Add(this.cmbTipoVenda);
            this.gbxPesquisa.Controls.Add(this.rbCpfCnpj);
            this.gbxPesquisa.Controls.Add(this.rbCliente);
            this.gbxPesquisa.Controls.Add(this.rbNumeroPedido);
            this.gbxPesquisa.Controls.Add(this.txtPesquisa);
            this.gbxPesquisa.Controls.Add(this.label2);
            this.gbxPesquisa.Controls.Add(this.label10);
            this.gbxPesquisa.Location = new System.Drawing.Point(12, 12);
            this.gbxPesquisa.Name = "gbxPesquisa";
            this.gbxPesquisa.Size = new System.Drawing.Size(834, 126);
            this.gbxPesquisa.TabIndex = 6;
            this.gbxPesquisa.TabStop = false;
            this.gbxPesquisa.Text = "Pesquisar Pedido / Orçamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "e";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(564, 88);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(121, 24);
            this.dtpDataFinal.TabIndex = 5;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(370, 88);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(121, 24);
            this.dtpDataInicial.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo";
            // 
            // cmbTipoVenda
            // 
            this.cmbTipoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVenda.ForeColor = System.Drawing.Color.DarkBlue;
            this.cmbTipoVenda.FormattingEnabled = true;
            this.cmbTipoVenda.Items.AddRange(new object[] {
            "---Selecione o tipo de pedido------",
            "Orçamento",
            "Venda"});
            this.cmbTipoVenda.Location = new System.Drawing.Point(370, 31);
            this.cmbTipoVenda.Name = "cmbTipoVenda";
            this.cmbTipoVenda.Size = new System.Drawing.Size(217, 26);
            this.cmbTipoVenda.TabIndex = 3;
            this.cmbTipoVenda.Text = "---Selecione o tipo de pedido------";
            // 
            // rbCpfCnpj
            // 
            this.rbCpfCnpj.AutoSize = true;
            this.rbCpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCpfCnpj.ForeColor = System.Drawing.Color.Black;
            this.rbCpfCnpj.Location = new System.Drawing.Point(250, 32);
            this.rbCpfCnpj.Name = "rbCpfCnpj";
            this.rbCpfCnpj.Size = new System.Drawing.Size(91, 22);
            this.rbCpfCnpj.TabIndex = 2;
            this.rbCpfCnpj.Text = "Cpf / Cnpj";
            this.rbCpfCnpj.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCliente.ForeColor = System.Drawing.Color.Black;
            this.rbCliente.Location = new System.Drawing.Point(117, 32);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(116, 22);
            this.rbCliente.TabIndex = 2;
            this.rbCliente.Text = "Nome Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // rbNumeroPedido
            // 
            this.rbNumeroPedido.AutoSize = true;
            this.rbNumeroPedido.Checked = true;
            this.rbNumeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNumeroPedido.ForeColor = System.Drawing.Color.Black;
            this.rbNumeroPedido.Location = new System.Drawing.Point(8, 32);
            this.rbNumeroPedido.Name = "rbNumeroPedido";
            this.rbNumeroPedido.Size = new System.Drawing.Size(92, 22);
            this.rbNumeroPedido.TabIndex = 2;
            this.rbNumeroPedido.TabStop = true;
            this.rbNumeroPedido.Text = "Nº Pedido";
            this.rbNumeroPedido.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtPesquisa.Location = new System.Drawing.Point(8, 88);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(333, 24);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pedido entre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pesquisa";
            // 
            // frmBuscarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.gbxPesquisa);
            this.Controls.Add(this.dtgPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Pedido / Orçamento";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBuscarPedido_FormClosed);
            this.Load += new System.EventHandler(this.frmBuscarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
            this.gbxPesquisa.ResumeLayout(false);
            this.gbxPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPrincipal;
        private System.Windows.Forms.GroupBox gbxPesquisa;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbNumeroPedido;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoVenda;
        private System.Windows.Forms.RadioButton rbCpfCnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedido;
        private System.Windows.Forms.DataGridViewImageColumn editar;
    }
}