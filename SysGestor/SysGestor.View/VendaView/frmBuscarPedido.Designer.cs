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
            this.gbxExcluir = new System.Windows.Forms.GroupBox();
            this.chkSelecionarTodos = new System.Windows.Forms.CheckBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbxPesquisa = new System.Windows.Forms.GroupBox();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbNumeroPedido = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
            this.gbxExcluir.SuspendLayout();
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
            this.selecionar,
            this.idCliente,
            this.nome,
            this.CpfCnpj,
            this.dataNasc,
            this.dataPedido,
            this.editar,
            this.excluir});
            this.dtgPrincipal.Location = new System.Drawing.Point(12, 142);
            this.dtgPrincipal.Name = "dtgPrincipal";
            this.dtgPrincipal.Size = new System.Drawing.Size(834, 342);
            this.dtgPrincipal.TabIndex = 1;
            // 
            // gbxExcluir
            // 
            this.gbxExcluir.Controls.Add(this.chkSelecionarTodos);
            this.gbxExcluir.Controls.Add(this.btnExcluir);
            this.gbxExcluir.Location = new System.Drawing.Point(580, 12);
            this.gbxExcluir.Name = "gbxExcluir";
            this.gbxExcluir.Size = new System.Drawing.Size(266, 112);
            this.gbxExcluir.TabIndex = 7;
            this.gbxExcluir.TabStop = false;
            // 
            // chkSelecionarTodos
            // 
            this.chkSelecionarTodos.AutoSize = true;
            this.chkSelecionarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelecionarTodos.Location = new System.Drawing.Point(11, 70);
            this.chkSelecionarTodos.Name = "chkSelecionarTodos";
            this.chkSelecionarTodos.Size = new System.Drawing.Size(135, 22);
            this.chkSelecionarTodos.TabIndex = 3;
            this.chkSelecionarTodos.Text = "Selecionar Tudo";
            this.chkSelecionarTodos.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::SysGestor.View.Properties.Resources.lixeira_32x32;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(162, 53);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 42);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // gbxPesquisa
            // 
            this.gbxPesquisa.Controls.Add(this.rbCliente);
            this.gbxPesquisa.Controls.Add(this.rbNumeroPedido);
            this.gbxPesquisa.Controls.Add(this.txtPesquisa);
            this.gbxPesquisa.Controls.Add(this.label10);
            this.gbxPesquisa.Location = new System.Drawing.Point(12, 12);
            this.gbxPesquisa.Name = "gbxPesquisa";
            this.gbxPesquisa.Size = new System.Drawing.Size(562, 112);
            this.gbxPesquisa.TabIndex = 6;
            this.gbxPesquisa.TabStop = false;
            this.gbxPesquisa.Text = "Pesquisar Pedido / Orçamento";
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCliente.ForeColor = System.Drawing.Color.Black;
            this.rbCliente.Location = new System.Drawing.Point(182, 27);
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
            this.rbNumeroPedido.Location = new System.Drawing.Point(8, 27);
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
            this.txtPesquisa.Location = new System.Drawing.Point(8, 70);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(487, 24);
            this.txtPesquisa.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pesquisa";
            // 
            // selecionar
            // 
            this.selecionar.HeaderText = "Selec.";
            this.selecionar.Name = "selecionar";
            this.selecionar.Width = 40;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "IdCliente";
            this.idCliente.HeaderText = "Nº Pedido";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Width = 80;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "Nome";
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
            this.dataNasc.DataPropertyName = "DataNascimento";
            this.dataNasc.HeaderText = "Tipo";
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.ReadOnly = true;
            this.dataNasc.Width = 110;
            // 
            // dataPedido
            // 
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
            // excluir
            // 
            this.excluir.HeaderText = "Excluir";
            this.excluir.Image = global::SysGestor.View.Properties.Resources.lixeira_16x16;
            this.excluir.Name = "excluir";
            this.excluir.ToolTipText = "Excluir Cliente";
            this.excluir.Width = 40;
            // 
            // frmBuscarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.gbxExcluir);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
            this.gbxExcluir.ResumeLayout(false);
            this.gbxExcluir.PerformLayout();
            this.gbxPesquisa.ResumeLayout(false);
            this.gbxPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPrincipal;
        private System.Windows.Forms.GroupBox gbxExcluir;
        private System.Windows.Forms.CheckBox chkSelecionarTodos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbxPesquisa;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbNumeroPedido;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedido;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
    }
}