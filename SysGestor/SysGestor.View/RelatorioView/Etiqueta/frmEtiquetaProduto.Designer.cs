namespace SysGestor.View.RelatorioView.Etiqueta
{
    partial class frmEtiquetaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEtiquetaProduto));
            this.dtgPrincipal = new System.Windows.Forms.DataGridView();
            this.selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoPrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxBusca = new System.Windows.Forms.GroupBox();
            this.rbCodigoBarras = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ttPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPreviewPrint = new System.Windows.Forms.Button();
            this.lblQtdEtiqueta = new System.Windows.Forms.Label();
            this.chkSelecionarTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
            this.groupBoxBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPrincipal
            // 
            this.dtgPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPrincipal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPrincipal.ColumnHeadersHeight = 30;
            this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionar,
            this.id,
            this.codigoBarra,
            this.Descricao,
            this.qtd,
            this.precoVista,
            this.precoPrazo,
            this.precoCartao,
            this.idEmpresa,
            this.empresa});
            this.dtgPrincipal.Location = new System.Drawing.Point(12, 126);
            this.dtgPrincipal.Name = "dtgPrincipal";
            this.dtgPrincipal.Size = new System.Drawing.Size(826, 374);
            this.dtgPrincipal.TabIndex = 37;
            // 
            // selecionar
            // 
            this.selecionar.HeaderText = "Selec.";
            this.selecionar.Name = "selecionar";
            this.selecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selecionar.Width = 40;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
            // 
            // codigoBarra
            // 
            this.codigoBarra.DataPropertyName = "CodigoBarra";
            this.codigoBarra.HeaderText = "Cód. Barras";
            this.codigoBarra.Name = "codigoBarra";
            this.codigoBarra.ReadOnly = true;
            this.codigoBarra.Width = 200;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // qtd
            // 
            this.qtd.HeaderText = "Qtd. Etiq.";
            this.qtd.Name = "qtd";
            this.qtd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.qtd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.qtd.Width = 60;
            // 
            // precoVista
            // 
            this.precoVista.DataPropertyName = "PrecoVista";
            this.precoVista.HeaderText = "Preco à Vista";
            this.precoVista.Name = "precoVista";
            this.precoVista.ReadOnly = true;
            this.precoVista.Visible = false;
            // 
            // precoPrazo
            // 
            this.precoPrazo.DataPropertyName = "PrecoPrazo";
            this.precoPrazo.HeaderText = "Preço à Prazo";
            this.precoPrazo.Name = "precoPrazo";
            this.precoPrazo.ReadOnly = true;
            this.precoPrazo.Visible = false;
            // 
            // precoCartao
            // 
            this.precoCartao.DataPropertyName = "PrecoCartao";
            this.precoCartao.HeaderText = "Preço Cartão";
            this.precoCartao.Name = "precoCartao";
            this.precoCartao.ReadOnly = true;
            this.precoCartao.Visible = false;
            // 
            // idEmpresa
            // 
            this.idEmpresa.DataPropertyName = "IdEmpresa";
            this.idEmpresa.HeaderText = "Id Empresa";
            this.idEmpresa.Name = "idEmpresa";
            this.idEmpresa.ReadOnly = true;
            this.idEmpresa.Visible = false;
            // 
            // empresa
            // 
            this.empresa.DataPropertyName = "Empresa";
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            this.empresa.Visible = false;
            // 
            // groupBoxBusca
            // 
            this.groupBoxBusca.Controls.Add(this.rbCodigoBarras);
            this.groupBoxBusca.Controls.Add(this.rbCodigo);
            this.groupBoxBusca.Controls.Add(this.rbDescricao);
            this.groupBoxBusca.Controls.Add(this.txtPesquisa);
            this.groupBoxBusca.Controls.Add(this.label10);
            this.groupBoxBusca.Location = new System.Drawing.Point(12, 8);
            this.groupBoxBusca.Name = "groupBoxBusca";
            this.groupBoxBusca.Size = new System.Drawing.Size(504, 112);
            this.groupBoxBusca.TabIndex = 38;
            this.groupBoxBusca.TabStop = false;
            this.groupBoxBusca.Text = "Buscar Produto";
            // 
            // rbCodigoBarras
            // 
            this.rbCodigoBarras.AutoSize = true;
            this.rbCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigoBarras.ForeColor = System.Drawing.Color.Black;
            this.rbCodigoBarras.Location = new System.Drawing.Point(318, 27);
            this.rbCodigoBarras.Name = "rbCodigoBarras";
            this.rbCodigoBarras.Size = new System.Drawing.Size(142, 22);
            this.rbCodigoBarras.TabIndex = 2;
            this.rbCodigoBarras.Text = "Código de Barras";
            this.rbCodigoBarras.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.ForeColor = System.Drawing.Color.Black;
            this.rbCodigo.Location = new System.Drawing.Point(173, 27);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(74, 22);
            this.rbCodigo.TabIndex = 2;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Checked = true;
            this.rbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDescricao.ForeColor = System.Drawing.Color.Black;
            this.rbDescricao.Location = new System.Drawing.Point(8, 27);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(94, 22);
            this.rbDescricao.TabIndex = 2;
            this.rbDescricao.TabStop = true;
            this.rbDescricao.Text = "Descrição";
            this.rbDescricao.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtPesquisa.Location = new System.Drawing.Point(8, 70);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(282, 24);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(794, 506);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 34);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ttPrincipal.SetToolTip(this.btnAdd, "Adicionar produto na lista de impressão.");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPreviewPrint
            // 
            this.btnPreviewPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPreviewPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviewPrint.FlatAppearance.BorderSize = 0;
            this.btnPreviewPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPreviewPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPreviewPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviewPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviewPrint.Image")));
            this.btnPreviewPrint.Location = new System.Drawing.Point(744, 506);
            this.btnPreviewPrint.Name = "btnPreviewPrint";
            this.btnPreviewPrint.Size = new System.Drawing.Size(44, 34);
            this.btnPreviewPrint.TabIndex = 39;
            this.btnPreviewPrint.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ttPrincipal.SetToolTip(this.btnPreviewPrint, "Visualizar impressão de etiqueta(s).");
            this.btnPreviewPrint.UseVisualStyleBackColor = false;
            this.btnPreviewPrint.Click += new System.EventHandler(this.btnPreviewPrint_Click);
            // 
            // lblQtdEtiqueta
            // 
            this.lblQtdEtiqueta.AutoSize = true;
            this.lblQtdEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdEtiqueta.Location = new System.Drawing.Point(42, 521);
            this.lblQtdEtiqueta.Name = "lblQtdEtiqueta";
            this.lblQtdEtiqueta.Size = new System.Drawing.Size(0, 13);
            this.lblQtdEtiqueta.TabIndex = 0;
            this.lblQtdEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkSelecionarTodos
            // 
            this.chkSelecionarTodos.AutoSize = true;
            this.chkSelecionarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelecionarTodos.Location = new System.Drawing.Point(538, 80);
            this.chkSelecionarTodos.Name = "chkSelecionarTodos";
            this.chkSelecionarTodos.Size = new System.Drawing.Size(135, 22);
            this.chkSelecionarTodos.TabIndex = 40;
            this.chkSelecionarTodos.Text = "Selecionar Tudo";
            this.chkSelecionarTodos.UseVisualStyleBackColor = true;
            this.chkSelecionarTodos.CheckedChanged += new System.EventHandler(this.chkSelecionarTodos_CheckedChanged);
            // 
            // frmEtiquetaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 547);
            this.Controls.Add(this.chkSelecionarTodos);
            this.Controls.Add(this.btnPreviewPrint);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBoxBusca);
            this.Controls.Add(this.dtgPrincipal);
            this.Controls.Add(this.lblQtdEtiqueta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEtiquetaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiquetas de Produto";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEtiquetaProduto_FormClosed);
            this.Load += new System.EventHandler(this.frmEtiquetaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
            this.groupBoxBusca.ResumeLayout(false);
            this.groupBoxBusca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPrincipal;
        private System.Windows.Forms.GroupBox groupBoxBusca;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbCodigoBarras;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolTip ttPrincipal;
        private System.Windows.Forms.Label lblQtdEtiqueta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVista;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoPrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCartao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.Button btnPreviewPrint;
        private System.Windows.Forms.CheckBox chkSelecionarTodos;
    }
}