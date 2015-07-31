namespace SysGestor.View.ProdutoView.Categoria
{
    partial class frmCategoriaGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoriaGrid));
            this.pcbCabecalho = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSelecionarTodos = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.rbDescrição = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgCategoria = new System.Windows.Forms.DataGridView();
            this.selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnLblNovo = new System.Windows.Forms.Label();
            this.ttpCategoria = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCabecalho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbCabecalho
            // 
            this.pcbCabecalho.Image = global::SysGestor.View.Properties.Resources.img_sistema;
            this.pcbCabecalho.Location = new System.Drawing.Point(-1, -6);
            this.pcbCabecalho.Name = "pcbCabecalho";
            this.pcbCabecalho.Size = new System.Drawing.Size(809, 92);
            this.pcbCabecalho.TabIndex = 13;
            this.pcbCabecalho.TabStop = false;
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
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSelecionarTodos);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Location = new System.Drawing.Point(527, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 112);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // chkSelecionarTodos
            // 
            this.chkSelecionarTodos.AutoSize = true;
            this.chkSelecionarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelecionarTodos.Location = new System.Drawing.Point(6, 63);
            this.chkSelecionarTodos.Name = "chkSelecionarTodos";
            this.chkSelecionarTodos.Size = new System.Drawing.Size(135, 22);
            this.chkSelecionarTodos.TabIndex = 3;
            this.chkSelecionarTodos.Text = "Selecionar Tudo";
            this.chkSelecionarTodos.UseVisualStyleBackColor = true;
            this.chkSelecionarTodos.CheckedChanged += new System.EventHandler(this.chkSelecionarTodos_CheckedChanged);
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
            this.btnSair.Location = new System.Drawing.Point(716, 41);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 39);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Controls.Add(this.rbDescrição);
            this.groupBoxPesquisa.Controls.Add(this.rbCodigo);
            this.groupBoxPesquisa.Controls.Add(this.txtPesquisa);
            this.groupBoxPesquisa.Controls.Add(this.label10);
            this.groupBoxPesquisa.Location = new System.Drawing.Point(11, 90);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(504, 112);
            this.groupBoxPesquisa.TabIndex = 11;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Buscar Categoria";
            // 
            // rbDescrição
            // 
            this.rbDescrição.AutoSize = true;
            this.rbDescrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDescrição.ForeColor = System.Drawing.Color.Black;
            this.rbDescrição.Location = new System.Drawing.Point(182, 27);
            this.rbDescrição.Name = "rbDescrição";
            this.rbDescrição.Size = new System.Drawing.Size(94, 22);
            this.rbDescrição.TabIndex = 2;
            this.rbDescrição.Text = "Descrição";
            this.rbDescrição.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Checked = true;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.ForeColor = System.Drawing.Color.Black;
            this.rbCodigo.Location = new System.Drawing.Point(8, 27);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(74, 22);
            this.rbCodigo.TabIndex = 2;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
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
            // dtgCategoria
            // 
            this.dtgCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCategoria.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCategoria.ColumnHeadersHeight = 30;
            this.dtgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionar,
            this.idCliente,
            this.nome,
            this.editar,
            this.excluir});
            this.dtgCategoria.Location = new System.Drawing.Point(11, 208);
            this.dtgCategoria.Name = "dtgCategoria";
            this.dtgCategoria.Size = new System.Drawing.Size(782, 266);
            this.dtgCategoria.TabIndex = 10;
            this.dtgCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategoria_CellContentClick);
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
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "Descricao";
            this.nome.HeaderText = "Descrição";
            this.nome.Name = "nome";
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
            // btnLblNovo
            // 
            this.btnLblNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLblNovo.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold);
            this.btnLblNovo.ForeColor = System.Drawing.Color.Green;
            this.btnLblNovo.Image = global::SysGestor.View.Properties.Resources.new_32x32;
            this.btnLblNovo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLblNovo.Location = new System.Drawing.Point(708, 493);
            this.btnLblNovo.Name = "btnLblNovo";
            this.btnLblNovo.Size = new System.Drawing.Size(85, 39);
            this.btnLblNovo.TabIndex = 36;
            this.btnLblNovo.Text = "Novo";
            this.btnLblNovo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ttpCategoria.SetToolTip(this.btnLblNovo, "Cadastro de categoria.");
            this.btnLblNovo.Click += new System.EventHandler(this.btnLblNovo_Click);
            // 
            // frmCategoriaGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 541);
            this.Controls.Add(this.btnLblNovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBoxPesquisa);
            this.Controls.Add(this.dtgCategoria);
            this.Controls.Add(this.pcbCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategoriaGrid";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista - Categoria";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCategoriaGrid_FormClosed);
            this.Load += new System.EventHandler(this.frmCategoriaGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCabecalho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbCabecalho;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSelecionarTodos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.RadioButton rbDescrição;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgCategoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
        private System.Windows.Forms.Label btnLblNovo;
        private System.Windows.Forms.ToolTip ttpCategoria;
    }
}