namespace SysGestor.View.ProdutoView.MovimentacaoEstoque
{
    partial class frmMovimentacaoEstoqueNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentacaoEstoqueNew));
            this.btnSair = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pcbCabecalho = new System.Windows.Forms.PictureBox();
            this.dtgMovEstoque = new System.Windows.Forms.DataGridView();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.rbDocumento = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxEndereco = new System.Windows.Forms.GroupBox();
            this.chkSelecionarTodos = new System.Windows.Forms.CheckBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.groupBoxPreco = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMargem = new System.Windows.Forms.TextBox();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValorCusto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovEstoque)).BeginInit();
            this.groupBoxEndereco.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxPreco.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::SysGestor.View.Properties.Resources.sair_32x32;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(715, 47);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 39);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Excluir";
            this.dataGridViewImageColumn2.Image = global::SysGestor.View.Properties.Resources.excluir_16x16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ToolTipText = "Excluir Cliente";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::SysGestor.View.Properties.Resources.edit_16x16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Editar Cliente";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // pcbCabecalho
            // 
            this.pcbCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbCabecalho.Image = global::SysGestor.View.Properties.Resources.img_sistema;
            this.pcbCabecalho.Location = new System.Drawing.Point(-1, 0);
            this.pcbCabecalho.Name = "pcbCabecalho";
            this.pcbCabecalho.Size = new System.Drawing.Size(809, 92);
            this.pcbCabecalho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCabecalho.TabIndex = 18;
            this.pcbCabecalho.TabStop = false;
            // 
            // dtgMovEstoque
            // 
            this.dtgMovEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMovEstoque.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgMovEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgMovEstoque.ColumnHeadersHeight = 30;
            this.dtgMovEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgMovEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionar,
            this.idCliente,
            this.idinterno,
            this.descricao,
            this.categoria,
            this.marca,
            this.localizacao,
            this.editar,
            this.excluir});
            this.dtgMovEstoque.Location = new System.Drawing.Point(11, 345);
            this.dtgMovEstoque.Name = "dtgMovEstoque";
            this.dtgMovEstoque.Size = new System.Drawing.Size(782, 280);
            this.dtgMovEstoque.TabIndex = 15;
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProduto.ForeColor = System.Drawing.Color.Black;
            this.rbProduto.Location = new System.Drawing.Point(201, 17);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(79, 22);
            this.rbProduto.TabIndex = 2;
            this.rbProduto.Text = "Produto";
            this.rbProduto.UseVisualStyleBackColor = true;
            // 
            // rbDocumento
            // 
            this.rbDocumento.AutoSize = true;
            this.rbDocumento.Checked = true;
            this.rbDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDocumento.ForeColor = System.Drawing.Color.Black;
            this.rbDocumento.Location = new System.Drawing.Point(12, 17);
            this.rbDocumento.Name = "rbDocumento";
            this.rbDocumento.Size = new System.Drawing.Size(104, 22);
            this.rbDocumento.TabIndex = 2;
            this.rbDocumento.TabStop = true;
            this.rbDocumento.Text = "Documento";
            this.rbDocumento.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtPesquisa.Location = new System.Drawing.Point(8, 60);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(487, 24);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pesquisa";
            // 
            // groupBoxEndereco
            // 
            this.groupBoxEndereco.Controls.Add(this.rbProduto);
            this.groupBoxEndereco.Controls.Add(this.rbDocumento);
            this.groupBoxEndereco.Controls.Add(this.txtPesquisa);
            this.groupBoxEndereco.Controls.Add(this.label10);
            this.groupBoxEndereco.Location = new System.Drawing.Point(11, 245);
            this.groupBoxEndereco.Name = "groupBoxEndereco";
            this.groupBoxEndereco.Size = new System.Drawing.Size(504, 94);
            this.groupBoxEndereco.TabIndex = 16;
            this.groupBoxEndereco.TabStop = false;
            this.groupBoxEndereco.Text = "Buscar Movimentação";
            // 
            // chkSelecionarTodos
            // 
            this.chkSelecionarTodos.AutoSize = true;
            this.chkSelecionarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelecionarTodos.Location = new System.Drawing.Point(11, 60);
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
            this.btnExcluir.Location = new System.Drawing.Point(162, 43);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 42);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkSelecionarTodos);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Location = new System.Drawing.Point(527, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 94);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCadProduto);
            this.groupBox2.Controls.Add(this.txtProduto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtQtd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtObservacao);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDocumento);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 142);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Movimentação de Estoque";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::SysGestor.View.Properties.Resources.new_32x32;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(395, 47);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(87, 39);
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::SysGestor.View.Properties.Resources.cancel_32x32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(596, 47);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 39);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Transparent;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Image = global::SysGestor.View.Properties.Resources.Save_32x32;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(490, 47);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(98, 39);
            this.btnGravar.TabIndex = 22;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtDocumento.Location = new System.Drawing.Point(284, 35);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(104, 24);
            this.txtDocumento.TabIndex = 2;
            this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Documento *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade *";
            // 
            // txtQtd
            // 
            this.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtQtd.Location = new System.Drawing.Point(394, 35);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 24);
            this.txtQtd.TabIndex = 3;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxPreco
            // 
            this.groupBoxPreco.Controls.Add(this.label9);
            this.groupBoxPreco.Controls.Add(this.txtMargem);
            this.groupBoxPreco.Controls.Add(this.lblValorVenda);
            this.groupBoxPreco.Controls.Add(this.label8);
            this.groupBoxPreco.Controls.Add(this.txtComissao);
            this.groupBoxPreco.Controls.Add(this.label11);
            this.groupBoxPreco.Controls.Add(this.txtValorCusto);
            this.groupBoxPreco.Controls.Add(this.label7);
            this.groupBoxPreco.Location = new System.Drawing.Point(524, 96);
            this.groupBoxPreco.Name = "groupBoxPreco";
            this.groupBoxPreco.Size = new System.Drawing.Size(269, 143);
            this.groupBoxPreco.TabIndex = 1;
            this.groupBoxPreco.TabStop = false;
            this.groupBoxPreco.Text = "Preços";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(145, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Valor Venda";
            // 
            // txtMargem
            // 
            this.txtMargem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMargem.Enabled = false;
            this.txtMargem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargem.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtMargem.Location = new System.Drawing.Point(148, 40);
            this.txtMargem.Name = "txtMargem";
            this.txtMargem.Size = new System.Drawing.Size(110, 24);
            this.txtMargem.TabIndex = 1;
            this.txtMargem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMargem.Validated += new System.EventHandler(this.txtMargem_Validated);
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVenda.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblValorVenda.Location = new System.Drawing.Point(148, 107);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(110, 25);
            this.lblValorVenda.TabIndex = 1001;
            this.lblValorVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(145, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Margem(%)*";
            // 
            // txtComissao
            // 
            this.txtComissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComissao.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtComissao.Location = new System.Drawing.Point(9, 108);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(110, 24);
            this.txtComissao.TabIndex = 2;
            this.txtComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Comissão(%)";
            // 
            // txtValorCusto
            // 
            this.txtValorCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCusto.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtValorCusto.Location = new System.Drawing.Point(9, 40);
            this.txtValorCusto.Name = "txtValorCusto";
            this.txtValorCusto.Size = new System.Drawing.Size(110, 24);
            this.txtValorCusto.TabIndex = 0;
            this.txtValorCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorCusto.Validated += new System.EventHandler(this.txtValorCusto_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Valor Custo*";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtObservacao.Location = new System.Drawing.Point(11, 81);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(481, 51);
            this.txtObservacao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Observação";
            // 
            // selecionar
            // 
            this.selecionar.HeaderText = "Selec.";
            this.selecionar.Name = "selecionar";
            this.selecionar.Width = 40;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "Id";
            this.idCliente.HeaderText = "Código";
            this.idCliente.Name = "idCliente";
            this.idCliente.Width = 80;
            // 
            // idinterno
            // 
            this.idinterno.DataPropertyName = "IdDocumento";
            this.idinterno.HeaderText = "Documento";
            this.idinterno.Name = "idinterno";
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "DescProduto";
            this.descricao.HeaderText = "Produto";
            this.descricao.Name = "descricao";
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "Quantidade";
            this.categoria.HeaderText = "Qtd.";
            this.categoria.Name = "categoria";
            this.categoria.Width = 111;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "ValorCompra";
            this.marca.HeaderText = "Valor Custo";
            this.marca.Name = "marca";
            this.marca.Width = 110;
            // 
            // localizacao
            // 
            this.localizacao.DataPropertyName = "Data";
            this.localizacao.HeaderText = "Data Entrada";
            this.localizacao.Name = "localizacao";
            this.localizacao.Width = 110;
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
            // btnCadProduto
            // 
            this.btnCadProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProduto.Location = new System.Drawing.Point(251, 35);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(27, 24);
            this.btnCadProduto.TabIndex = 1;
            this.btnCadProduto.Text = "...";
            this.btnCadProduto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadProduto.UseVisualStyleBackColor = true;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtProduto.Location = new System.Drawing.Point(13, 35);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(234, 24);
            this.txtProduto.TabIndex = 0;
            this.txtProduto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtProduto_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Produto *";
            // 
            // frmMovimentacaoEstoqueNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 639);
            this.Controls.Add(this.groupBoxPreco);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pcbCabecalho);
            this.Controls.Add(this.dtgMovEstoque);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxEndereco);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovimentacaoEstoqueNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar - Movimentação de Estoque";
            this.Load += new System.EventHandler(this.frmMovimentacaoEstoqueNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCabecalho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovEstoque)).EndInit();
            this.groupBoxEndereco.ResumeLayout(false);
            this.groupBoxEndereco.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxPreco.ResumeLayout(false);
            this.groupBoxPreco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.PictureBox pcbCabecalho;
        private System.Windows.Forms.DataGridView dtgMovEstoque;
        private System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.RadioButton rbDocumento;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxEndereco;
        private System.Windows.Forms.CheckBox chkSelecionarTodos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPreco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMargem;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValorCusto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizacao;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label3;
    }
}