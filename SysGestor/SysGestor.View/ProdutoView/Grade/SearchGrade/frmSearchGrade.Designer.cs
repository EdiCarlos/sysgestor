namespace SysGestor.View.ProdutoView.Grade.SearchGrade
{
    partial class frmSearchGrade
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
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.rbDescrição = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgPrincipal = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxComando = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.toolTipPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBoxPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
            this.groupBoxComando.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Controls.Add(this.rbDescrição);
            this.groupBoxPesquisa.Controls.Add(this.rbCodigo);
            this.groupBoxPesquisa.Controls.Add(this.txtPesquisa);
            this.groupBoxPesquisa.Controls.Add(this.label10);
            this.groupBoxPesquisa.Location = new System.Drawing.Point(11, 12);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(423, 112);
            this.groupBoxPesquisa.TabIndex = 16;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Dados para Pesquisa";
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
            this.txtPesquisa.Size = new System.Drawing.Size(401, 24);
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
            // dtgPrincipal
            // 
            this.dtgPrincipal.AllowUserToAddRows = false;
            this.dtgPrincipal.AllowUserToDeleteRows = false;
            this.dtgPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPrincipal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPrincipal.ColumnHeadersHeight = 30;
            this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nome});
            this.dtgPrincipal.Location = new System.Drawing.Point(11, 130);
            this.dtgPrincipal.Name = "dtgPrincipal";
            this.dtgPrincipal.ReadOnly = true;
            this.dtgPrincipal.Size = new System.Drawing.Size(603, 274);
            this.dtgPrincipal.TabIndex = 15;
            this.dtgPrincipal.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellContentDoubleClick);
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "Id";
            this.idCliente.HeaderText = "Código";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Width = 80;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "Descricao";
            this.nome.HeaderText = "Descrição";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // groupBoxComando
            // 
            this.groupBoxComando.Controls.Add(this.btnNovo);
            this.groupBoxComando.Controls.Add(this.btnSair);
            this.groupBoxComando.Location = new System.Drawing.Point(439, 12);
            this.groupBoxComando.Name = "groupBoxComando";
            this.groupBoxComando.Size = new System.Drawing.Size(175, 112);
            this.groupBoxComando.TabIndex = 17;
            this.groupBoxComando.TabStop = false;
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
            this.btnNovo.Location = new System.Drawing.Point(14, 55);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(69, 39);
            this.btnNovo.TabIndex = 39;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTipPrincipal.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
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
            this.btnSair.Location = new System.Drawing.Point(89, 55);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(69, 39);
            this.btnSair.TabIndex = 38;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTipPrincipal.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::SysGestor.View.Properties.Resources.edit_16x16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Editar Cliente";
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Excluir";
            this.dataGridViewImageColumn2.Image = global::SysGestor.View.Properties.Resources.lixeira_16x16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ToolTipText = "Excluir Cliente";
            this.dataGridViewImageColumn2.Width = 40;
            // 
            // frmSearchGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 416);
            this.Controls.Add(this.groupBoxPesquisa);
            this.Controls.Add(this.dtgPrincipal);
            this.Controls.Add(this.groupBoxComando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Grade";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchGrade_FormClosing);
            this.Load += new System.EventHandler(this.frmSearchGrade_Load);
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
            this.groupBoxComando.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.RadioButton rbDescrição;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.GroupBox groupBoxComando;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ToolTip toolTipPrincipal;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.TextBox txtPesquisa;
    }
}