namespace SysGestor.View.EmpresaView
{
    partial class frmEmpresaGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresaGrid));
            this.ttpPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.dtgPrincipal = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxBusca = new System.Windows.Forms.GroupBox();
            this.rbCpfCnpj = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.chkSelecionarTodos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.pcbCabecalho = new System.Windows.Forms.PictureBox();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnLblNovo = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
            this.groupBoxBusca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCabecalho)).BeginInit();
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
            this.nome,
            this.CpfCnpj,
            this.editar,
            this.excluir});
            this.dtgPrincipal.Location = new System.Drawing.Point(11, 214);
            this.dtgPrincipal.Name = "dtgPrincipal";
            this.dtgPrincipal.Size = new System.Drawing.Size(782, 360);
            this.dtgPrincipal.TabIndex = 36;
            this.dtgPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellContentClick);
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
            // groupBoxBusca
            // 
            this.groupBoxBusca.Controls.Add(this.rbCpfCnpj);
            this.groupBoxBusca.Controls.Add(this.rbNome);
            this.groupBoxBusca.Controls.Add(this.txtPesquisa);
            this.groupBoxBusca.Controls.Add(this.label10);
            this.groupBoxBusca.Location = new System.Drawing.Point(11, 96);
            this.groupBoxBusca.Name = "groupBoxBusca";
            this.groupBoxBusca.Size = new System.Drawing.Size(504, 112);
            this.groupBoxBusca.TabIndex = 37;
            this.groupBoxBusca.TabStop = false;
            this.groupBoxBusca.Text = "Buscar Fornecedor";
            // 
            // rbCpfCnpj
            // 
            this.rbCpfCnpj.AutoSize = true;
            this.rbCpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCpfCnpj.ForeColor = System.Drawing.Color.Black;
            this.rbCpfCnpj.Location = new System.Drawing.Point(182, 27);
            this.rbCpfCnpj.Name = "rbCpfCnpj";
            this.rbCpfCnpj.Size = new System.Drawing.Size(108, 22);
            this.rbCpfCnpj.TabIndex = 2;
            this.rbCpfCnpj.Text = "CPF / CNPJ";
            this.rbCpfCnpj.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.ForeColor = System.Drawing.Color.Black;
            this.rbNome.Location = new System.Drawing.Point(8, 27);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(168, 22);
            this.rbNome.TabIndex = 2;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome / Razão Social";
            this.rbNome.UseVisualStyleBackColor = true;
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
            this.chkSelecionarTodos.CheckedChanged += new System.EventHandler(this.chkSelecionarTodos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSelecionarTodos);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Location = new System.Drawing.Point(527, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 112);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // selecionar
            // 
            this.selecionar.HeaderText = "Selec.";
            this.selecionar.Name = "selecionar";
            this.selecionar.Width = 40;
            // 
            // id
            // 
            this.id.DataPropertyName = "IdEmpresa";
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.Width = 80;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "Nome";
            this.nome.HeaderText = "Nome / Razão Social";
            this.nome.Name = "nome";
            // 
            // CpfCnpj
            // 
            this.CpfCnpj.DataPropertyName = "CpfCnpj";
            this.CpfCnpj.HeaderText = "CPF / CNPJ";
            this.CpfCnpj.Name = "CpfCnpj";
            this.CpfCnpj.Width = 110;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::SysGestor.View.Properties.Resources.edit_16x16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Editar Cliente";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Excluir";
            this.dataGridViewImageColumn2.Image = global::SysGestor.View.Properties.Resources.excluir_16x16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ToolTipText = "Excluir Cliente";
            this.dataGridViewImageColumn2.Width = 50;
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
            this.btnSair.Location = new System.Drawing.Point(716, 47);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 39);
            this.btnSair.TabIndex = 40;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pcbCabecalho
            // 
            this.pcbCabecalho.Image = global::SysGestor.View.Properties.Resources.img_sistema;
            this.pcbCabecalho.Location = new System.Drawing.Point(-1, 0);
            this.pcbCabecalho.Name = "pcbCabecalho";
            this.pcbCabecalho.Size = new System.Drawing.Size(809, 92);
            this.pcbCabecalho.TabIndex = 39;
            this.pcbCabecalho.TabStop = false;
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
            this.btnLblNovo.Location = new System.Drawing.Point(708, 591);
            this.btnLblNovo.Name = "btnLblNovo";
            this.btnLblNovo.Size = new System.Drawing.Size(85, 39);
            this.btnLblNovo.TabIndex = 41;
            this.btnLblNovo.Text = "Novo";
            this.btnLblNovo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ttpPrincipal.SetToolTip(this.btnLblNovo, "Cadastro de empresa.");
            this.btnLblNovo.Click += new System.EventHandler(this.btnLblNovo_Click);
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
            // frmEmpresaGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 639);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pcbCabecalho);
            this.Controls.Add(this.dtgPrincipal);
            this.Controls.Add(this.groupBoxBusca);
            this.Controls.Add(this.btnLblNovo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpresaGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista - Empresa";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEmpresaGrid_FormClosed);
            this.Load += new System.EventHandler(this.frmEmpresaGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
            this.groupBoxBusca.ResumeLayout(false);
            this.groupBoxBusca.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCabecalho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip ttpPrincipal;
        private System.Windows.Forms.Label btnLblNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pcbCabecalho;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dtgPrincipal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxBusca;
        private System.Windows.Forms.RadioButton rbCpfCnpj;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.CheckBox chkSelecionarTodos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCnpj;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
    }
}