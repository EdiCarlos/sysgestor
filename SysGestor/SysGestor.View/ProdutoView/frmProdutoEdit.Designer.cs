namespace SysGestor.View.ProdutoView
{
    partial class frmProdutoEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutoEdit));
            this.btnCadUnidMedida = new System.Windows.Forms.Button();
            this.btnCadGrade = new System.Windows.Forms.Button();
            this.btnCadFornecedor = new System.Windows.Forms.Button();
            this.btnCadCategoria = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdInterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTipProduto = new System.Windows.Forms.ToolTip(this.components);
            this.txtMargem = new System.Windows.Forms.TextBox();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.btnLblExcluir = new System.Windows.Forms.Label();
            this.btnLblNovo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnidMedida = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocalizacaoFisica = new System.Windows.Forms.TextBox();
            this.txtValorCusto = new System.Windows.Forms.TextBox();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxPreco = new System.Windows.Forms.GroupBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxDados = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pcbCabecalho = new System.Windows.Forms.PictureBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBoxUltimoPreco = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblUltComissao = new System.Windows.Forms.Label();
            this.lblUltValorCusto = new System.Windows.Forms.Label();
            this.lblUltMargem = new System.Windows.Forms.Label();
            this.lblUltValorVenda = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxPreco.SuspendLayout();
            this.groupBoxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCabecalho)).BeginInit();
            this.groupBoxUltimoPreco.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadUnidMedida
            // 
            this.btnCadUnidMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadUnidMedida.Location = new System.Drawing.Point(744, 166);
            this.btnCadUnidMedida.Name = "btnCadUnidMedida";
            this.btnCadUnidMedida.Size = new System.Drawing.Size(27, 24);
            this.btnCadUnidMedida.TabIndex = 7;
            this.btnCadUnidMedida.Text = "...";
            this.btnCadUnidMedida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTipProduto.SetToolTip(this.btnCadUnidMedida, "Cadastrar unidade de medida.");
            this.btnCadUnidMedida.UseVisualStyleBackColor = true;
            this.btnCadUnidMedida.Click += new System.EventHandler(this.btnCadUnidMedida_Click);
            // 
            // btnCadGrade
            // 
            this.btnCadGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadGrade.Location = new System.Drawing.Point(742, 119);
            this.btnCadGrade.Name = "btnCadGrade";
            this.btnCadGrade.Size = new System.Drawing.Size(27, 24);
            this.btnCadGrade.TabIndex = 4;
            this.btnCadGrade.Text = "...";
            this.btnCadGrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTipProduto.SetToolTip(this.btnCadGrade, "Cadastrar grade.");
            this.btnCadGrade.UseVisualStyleBackColor = true;
            this.btnCadGrade.Click += new System.EventHandler(this.btnCadGrade_Click);
            // 
            // btnCadFornecedor
            // 
            this.btnCadFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadFornecedor.Location = new System.Drawing.Point(744, 259);
            this.btnCadFornecedor.Name = "btnCadFornecedor";
            this.btnCadFornecedor.Size = new System.Drawing.Size(27, 24);
            this.btnCadFornecedor.TabIndex = 13;
            this.btnCadFornecedor.Text = "...";
            this.btnCadFornecedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTipProduto.SetToolTip(this.btnCadFornecedor, "Cadastrar fornecedor.");
            this.btnCadFornecedor.UseVisualStyleBackColor = true;
            this.btnCadFornecedor.Click += new System.EventHandler(this.btnCadFornecedor_Click);
            // 
            // btnCadCategoria
            // 
            this.btnCadCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCategoria.Location = new System.Drawing.Point(354, 259);
            this.btnCadCategoria.Name = "btnCadCategoria";
            this.btnCadCategoria.Size = new System.Drawing.Size(27, 24);
            this.btnCadCategoria.TabIndex = 11;
            this.btnCadCategoria.Text = "...";
            this.btnCadCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTipProduto.SetToolTip(this.btnCadCategoria, "Cadastrar categoria.");
            this.btnCadCategoria.UseVisualStyleBackColor = true;
            this.btnCadCategoria.Click += new System.EventHandler(this.btnCadCategoria_Click);
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblId.Location = new System.Drawing.Point(9, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(214, 24);
            this.lblId.TabIndex = 1000;
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdInterno
            // 
            this.txtIdInterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdInterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdInterno.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtIdInterno.Location = new System.Drawing.Point(283, 46);
            this.txtIdInterno.Name = "txtIdInterno";
            this.txtIdInterno.Size = new System.Drawing.Size(214, 24);
            this.txtIdInterno.TabIndex = 0;
            this.txtIdInterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cód. Produto";
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtMarca.Location = new System.Drawing.Point(9, 164);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(517, 24);
            this.txtMarca.TabIndex = 5;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtDescricao.Location = new System.Drawing.Point(9, 119);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(517, 24);
            this.txtDescricao.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Marca";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtObservacao.Location = new System.Drawing.Point(13, 22);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(467, 61);
            this.txtObservacao.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Location = new System.Drawing.Point(16, 535);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 92);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observação";
            // 
            // txtMargem
            // 
            this.txtMargem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMargem.Enabled = false;
            this.txtMargem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargem.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtMargem.Location = new System.Drawing.Point(216, 40);
            this.txtMargem.Name = "txtMargem";
            this.txtMargem.Size = new System.Drawing.Size(150, 24);
            this.txtMargem.TabIndex = 1;
            this.txtMargem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipProduto.SetToolTip(this.txtMargem, "Margem de lucro.");
            this.txtMargem.Validated += new System.EventHandler(this.txtMargem_Validated);
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVenda.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblValorVenda.Location = new System.Drawing.Point(216, 84);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(150, 25);
            this.lblValorVenda.TabIndex = 1001;
            this.lblValorVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipProduto.SetToolTip(this.lblValorVenda, "Valor de venda, calculado a margem de lucro.");
            // 
            // txtComissao
            // 
            this.txtComissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComissao.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtComissao.Location = new System.Drawing.Point(9, 85);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(150, 24);
            this.txtComissao.TabIndex = 2;
            this.txtComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipProduto.SetToolTip(this.txtComissao, "Comissão do funcionário sobre esse produto.");
            // 
            // btnLblExcluir
            // 
            this.btnLblExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLblExcluir.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold);
            this.btnLblExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnLblExcluir.Image = global::SysGestor.View.Properties.Resources.lixeira_32x32;
            this.btnLblExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLblExcluir.Location = new System.Drawing.Point(684, 595);
            this.btnLblExcluir.Name = "btnLblExcluir";
            this.btnLblExcluir.Size = new System.Drawing.Size(103, 39);
            this.btnLblExcluir.TabIndex = 31;
            this.btnLblExcluir.Text = "Excluir";
            this.btnLblExcluir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTipProduto.SetToolTip(this.btnLblExcluir, "Excluir produto.");
            this.btnLblExcluir.Click += new System.EventHandler(this.btnLblExcluir_Click);
            this.btnLblExcluir.Validated += new System.EventHandler(this.btnLblExcluir_Click);
            // 
            // btnLblNovo
            // 
            this.btnLblNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLblNovo.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold);
            this.btnLblNovo.ForeColor = System.Drawing.Color.Green;
            this.btnLblNovo.Image = global::SysGestor.View.Properties.Resources.new_32x32;
            this.btnLblNovo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLblNovo.Location = new System.Drawing.Point(584, 595);
            this.btnLblNovo.Name = "btnLblNovo";
            this.btnLblNovo.Size = new System.Drawing.Size(85, 39);
            this.btnLblNovo.TabIndex = 32;
            this.btnLblNovo.Text = "Novo";
            this.btnLblNovo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTipProduto.SetToolTip(this.btnLblNovo, "Cadastrar produto.");
            this.btnLblNovo.Click += new System.EventHandler(this.btnLblNovo_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cód. Interno*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Descrição *";
            // 
            // txtUnidMedida
            // 
            this.txtUnidMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnidMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidMedida.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtUnidMedida.Location = new System.Drawing.Point(540, 166);
            this.txtUnidMedida.Name = "txtUnidMedida";
            this.txtUnidMedida.Size = new System.Drawing.Size(200, 24);
            this.txtUnidMedida.TabIndex = 6;
            this.txtUnidMedida.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUnidMedida_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(537, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Und. Medida*";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtFornecedor.Location = new System.Drawing.Point(399, 259);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(341, 24);
            this.txtFornecedor.TabIndex = 12;
            this.txtFornecedor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFornecedor_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Comissão(%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fornecedor";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCategoria.Location = new System.Drawing.Point(9, 259);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(341, 24);
            this.txtCategoria.TabIndex = 10;
            this.txtCategoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCategoria_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Categoria*";
            // 
            // txtGrade
            // 
            this.txtGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtGrade.Location = new System.Drawing.Point(540, 119);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(198, 24);
            this.txtGrade.TabIndex = 3;
            this.txtGrade.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGrade_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grade";
            // 
            // txtLocalizacaoFisica
            // 
            this.txtLocalizacaoFisica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalizacaoFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalizacaoFisica.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtLocalizacaoFisica.Location = new System.Drawing.Point(9, 211);
            this.txtLocalizacaoFisica.Name = "txtLocalizacaoFisica";
            this.txtLocalizacaoFisica.Size = new System.Drawing.Size(517, 24);
            this.txtLocalizacaoFisica.TabIndex = 8;
            // 
            // txtValorCusto
            // 
            this.txtValorCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCusto.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtValorCusto.Location = new System.Drawing.Point(9, 40);
            this.txtValorCusto.Name = "txtValorCusto";
            this.txtValorCusto.Size = new System.Drawing.Size(150, 24);
            this.txtValorCusto.TabIndex = 0;
            this.txtValorCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorCusto.Validated += new System.EventHandler(this.txtValorCusto_Validated);
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoqueMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueMinimo.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(540, 211);
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(231, 24);
            this.txtEstoqueMinimo.TabIndex = 9;
            this.txtEstoqueMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(213, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Valor Venda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Margem(%)*";
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
            this.groupBoxPreco.Location = new System.Drawing.Point(15, 411);
            this.groupBoxPreco.Name = "groupBoxPreco";
            this.groupBoxPreco.Size = new System.Drawing.Size(380, 118);
            this.groupBoxPreco.TabIndex = 24;
            this.groupBoxPreco.TabStop = false;
            this.groupBoxPreco.Text = "Preço Atual";
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtReferencia.Location = new System.Drawing.Point(557, 46);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(214, 24);
            this.txtReferencia.TabIndex = 1;
            this.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Localização Física";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(537, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Estoque Mín.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(554, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Referência";
            // 
            // groupBoxDados
            // 
            this.groupBoxDados.Controls.Add(this.btnCadUnidMedida);
            this.groupBoxDados.Controls.Add(this.btnCadGrade);
            this.groupBoxDados.Controls.Add(this.btnCadFornecedor);
            this.groupBoxDados.Controls.Add(this.btnCadCategoria);
            this.groupBoxDados.Controls.Add(this.lblId);
            this.groupBoxDados.Controls.Add(this.txtIdInterno);
            this.groupBoxDados.Controls.Add(this.label4);
            this.groupBoxDados.Controls.Add(this.txtMarca);
            this.groupBoxDados.Controls.Add(this.txtDescricao);
            this.groupBoxDados.Controls.Add(this.label12);
            this.groupBoxDados.Controls.Add(this.label1);
            this.groupBoxDados.Controls.Add(this.label6);
            this.groupBoxDados.Controls.Add(this.txtUnidMedida);
            this.groupBoxDados.Controls.Add(this.label10);
            this.groupBoxDados.Controls.Add(this.txtFornecedor);
            this.groupBoxDados.Controls.Add(this.label5);
            this.groupBoxDados.Controls.Add(this.txtCategoria);
            this.groupBoxDados.Controls.Add(this.label3);
            this.groupBoxDados.Controls.Add(this.txtGrade);
            this.groupBoxDados.Controls.Add(this.label2);
            this.groupBoxDados.Controls.Add(this.txtLocalizacaoFisica);
            this.groupBoxDados.Controls.Add(this.txtEstoqueMinimo);
            this.groupBoxDados.Controls.Add(this.txtReferencia);
            this.groupBoxDados.Controls.Add(this.label15);
            this.groupBoxDados.Controls.Add(this.label14);
            this.groupBoxDados.Controls.Add(this.label13);
            this.groupBoxDados.Location = new System.Drawing.Point(12, 101);
            this.groupBoxDados.Name = "groupBoxDados";
            this.groupBoxDados.Size = new System.Drawing.Size(782, 304);
            this.groupBoxDados.TabIndex = 23;
            this.groupBoxDados.TabStop = false;
            this.groupBoxDados.Text = "Informações do Produto";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::SysGestor.View.Properties.Resources.sair_32x32;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(718, 51);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 39);
            this.btnSair.TabIndex = 29;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(600, 52);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 39);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pcbCabecalho
            // 
            this.pcbCabecalho.Image = global::SysGestor.View.Properties.Resources.img_sistema;
            this.pcbCabecalho.Location = new System.Drawing.Point(-1, 4);
            this.pcbCabecalho.Name = "pcbCabecalho";
            this.pcbCabecalho.Size = new System.Drawing.Size(809, 92);
            this.pcbCabecalho.TabIndex = 26;
            this.pcbCabecalho.TabStop = false;
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
            this.btnGravar.Location = new System.Drawing.Point(495, 52);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(98, 39);
            this.btnGravar.TabIndex = 30;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // groupBoxUltimoPreco
            // 
            this.groupBoxUltimoPreco.Controls.Add(this.label16);
            this.groupBoxUltimoPreco.Controls.Add(this.lblUltComissao);
            this.groupBoxUltimoPreco.Controls.Add(this.lblUltValorCusto);
            this.groupBoxUltimoPreco.Controls.Add(this.lblUltMargem);
            this.groupBoxUltimoPreco.Controls.Add(this.lblUltValorVenda);
            this.groupBoxUltimoPreco.Controls.Add(this.label18);
            this.groupBoxUltimoPreco.Controls.Add(this.label19);
            this.groupBoxUltimoPreco.Controls.Add(this.label20);
            this.groupBoxUltimoPreco.Location = new System.Drawing.Point(411, 411);
            this.groupBoxUltimoPreco.Name = "groupBoxUltimoPreco";
            this.groupBoxUltimoPreco.Size = new System.Drawing.Size(380, 118);
            this.groupBoxUltimoPreco.TabIndex = 24;
            this.groupBoxUltimoPreco.TabStop = false;
            this.groupBoxUltimoPreco.Text = "Último Preço";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(214, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Valor Venda";
            // 
            // lblUltComissao
            // 
            this.lblUltComissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUltComissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUltComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltComissao.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUltComissao.Location = new System.Drawing.Point(9, 84);
            this.lblUltComissao.Name = "lblUltComissao";
            this.lblUltComissao.Size = new System.Drawing.Size(150, 25);
            this.lblUltComissao.TabIndex = 1001;
            this.lblUltComissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUltValorCusto
            // 
            this.lblUltValorCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUltValorCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUltValorCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltValorCusto.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUltValorCusto.Location = new System.Drawing.Point(9, 40);
            this.lblUltValorCusto.Name = "lblUltValorCusto";
            this.lblUltValorCusto.Size = new System.Drawing.Size(150, 25);
            this.lblUltValorCusto.TabIndex = 1001;
            this.lblUltValorCusto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUltMargem
            // 
            this.lblUltMargem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUltMargem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUltMargem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltMargem.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUltMargem.Location = new System.Drawing.Point(217, 40);
            this.lblUltMargem.Name = "lblUltMargem";
            this.lblUltMargem.Size = new System.Drawing.Size(150, 25);
            this.lblUltMargem.TabIndex = 1001;
            this.lblUltMargem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUltValorVenda
            // 
            this.lblUltValorVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUltValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUltValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltValorVenda.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUltValorVenda.Location = new System.Drawing.Point(217, 84);
            this.lblUltValorVenda.Name = "lblUltValorVenda";
            this.lblUltValorVenda.Size = new System.Drawing.Size(150, 25);
            this.lblUltValorVenda.TabIndex = 1001;
            this.lblUltValorVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(214, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Margem(%)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "Comissão(%)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "Valor Custo";
            // 
            // frmProdutoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 639);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLblExcluir);
            this.Controls.Add(this.groupBoxUltimoPreco);
            this.Controls.Add(this.groupBoxPreco);
            this.Controls.Add(this.btnLblNovo);
            this.Controls.Add(this.groupBoxDados);
            this.Controls.Add(this.pcbCabecalho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 677);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(822, 677);
            this.Name = "frmProdutoEdit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar - Produto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmProdutoEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPreco.ResumeLayout(false);
            this.groupBoxPreco.PerformLayout();
            this.groupBoxDados.ResumeLayout(false);
            this.groupBoxDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCabecalho)).EndInit();
            this.groupBoxUltimoPreco.ResumeLayout(false);
            this.groupBoxUltimoPreco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadUnidMedida;
        private System.Windows.Forms.ToolTip toolTipProduto;
        private System.Windows.Forms.Button btnCadGrade;
        private System.Windows.Forms.Button btnCadFornecedor;
        private System.Windows.Forms.Button btnCadCategoria;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIdInterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMargem;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnidMedida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pcbCabecalho;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocalizacaoFisica;
        private System.Windows.Forms.TextBox txtValorCusto;
        private System.Windows.Forms.Label btnLblExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxPreco;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label btnLblNovo;
        private System.Windows.Forms.GroupBox groupBoxDados;
        private System.Windows.Forms.GroupBox groupBoxUltimoPreco;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblUltComissao;
        private System.Windows.Forms.Label lblUltValorCusto;
        private System.Windows.Forms.Label lblUltMargem;
        private System.Windows.Forms.Label lblUltValorVenda;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}