﻿namespace SysGestor.View.ClienteView
{
    partial class frmClienteNew
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
            this.lblNomeRazaoSocial = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBoxDados = new System.Windows.Forms.GroupBox();
            this.btnDebito = new System.Windows.Forms.Button();
            this.lblDebito = new System.Windows.Forms.Label();
            this.lblLimiteDisponivel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.mskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.txtRgIe = new System.Windows.Forms.TextBox();
            this.lblRgIe = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.groupBoxEndereco = new System.Windows.Forms.GroupBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxContato = new System.Windows.Forms.GroupBox();
            this.mskTelComercial = new System.Windows.Forms.MaskedTextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskTelFixo = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxDados.SuspendLayout();
            this.groupBoxTipoPessoa.SuspendLayout();
            this.groupBoxEndereco.SuspendLayout();
            this.groupBoxContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeRazaoSocial
            // 
            this.lblNomeRazaoSocial.AutoSize = true;
            this.lblNomeRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeRazaoSocial.Location = new System.Drawing.Point(16, 72);
            this.lblNomeRazaoSocial.Name = "lblNomeRazaoSocial";
            this.lblNomeRazaoSocial.Size = new System.Drawing.Size(60, 17);
            this.lblNomeRazaoSocial.TabIndex = 0;
            this.lblNomeRazaoSocial.Text = "Nome *";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtNome.Location = new System.Drawing.Point(19, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(370, 24);
            this.txtNome.TabIndex = 0;
            // 
            // groupBoxDados
            // 
            this.groupBoxDados.Controls.Add(this.btnDebito);
            this.groupBoxDados.Controls.Add(this.lblDebito);
            this.groupBoxDados.Controls.Add(this.lblLimiteDisponivel);
            this.groupBoxDados.Controls.Add(this.label5);
            this.groupBoxDados.Controls.Add(this.label4);
            this.groupBoxDados.Controls.Add(this.txtLimiteCredito);
            this.groupBoxDados.Controls.Add(this.label3);
            this.groupBoxDados.Controls.Add(this.mskCpfCnpj);
            this.groupBoxDados.Controls.Add(this.mskDataNasc);
            this.groupBoxDados.Controls.Add(this.groupBoxTipoPessoa);
            this.groupBoxDados.Controls.Add(this.txtRgIe);
            this.groupBoxDados.Controls.Add(this.txtNome);
            this.groupBoxDados.Controls.Add(this.lblRgIe);
            this.groupBoxDados.Controls.Add(this.lblCpfCnpj);
            this.groupBoxDados.Controls.Add(this.label2);
            this.groupBoxDados.Controls.Add(this.lblNomeRazaoSocial);
            this.groupBoxDados.Location = new System.Drawing.Point(12, 97);
            this.groupBoxDados.Name = "groupBoxDados";
            this.groupBoxDados.Size = new System.Drawing.Size(782, 185);
            this.groupBoxDados.TabIndex = 0;
            this.groupBoxDados.TabStop = false;
            this.groupBoxDados.Text = "Dados";
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(708, 127);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(66, 39);
            this.btnDebito.TabIndex = 7;
            this.btnDebito.Text = "Débitos";
            this.btnDebito.UseVisualStyleBackColor = true;
            // 
            // lblDebito
            // 
            this.lblDebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebito.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDebito.Location = new System.Drawing.Point(534, 140);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(167, 25);
            this.lblDebito.TabIndex = 6;
            this.lblDebito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLimiteDisponivel
            // 
            this.lblLimiteDisponivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLimiteDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteDisponivel.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLimiteDisponivel.Location = new System.Drawing.Point(348, 140);
            this.lblLimiteDisponivel.Name = "lblLimiteDisponivel";
            this.lblLimiteDisponivel.Size = new System.Drawing.Size(167, 25);
            this.lblLimiteDisponivel.TabIndex = 5;
            this.lblLimiteDisponivel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(532, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Débito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Limite Disponível";
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLimiteCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimiteCredito.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtLimiteCredito.Location = new System.Drawing.Point(163, 140);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(166, 24);
            this.txtLimiteCredito.TabIndex = 4;
            this.txtLimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Limite Crédito";
            // 
            // mskCpfCnpj
            // 
            this.mskCpfCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpfCnpj.ForeColor = System.Drawing.Color.DarkBlue;
            this.mskCpfCnpj.Location = new System.Drawing.Point(400, 90);
            this.mskCpfCnpj.Mask = "000,000,000-00";
            this.mskCpfCnpj.Name = "mskCpfCnpj";
            this.mskCpfCnpj.Size = new System.Drawing.Size(180, 24);
            this.mskCpfCnpj.TabIndex = 1;
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataNasc.ForeColor = System.Drawing.Color.DarkBlue;
            this.mskDataNasc.Location = new System.Drawing.Point(19, 140);
            this.mskDataNasc.Mask = "00/00/0000";
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(125, 24);
            this.mskDataNasc.TabIndex = 3;
            // 
            // groupBoxTipoPessoa
            // 
            this.groupBoxTipoPessoa.Controls.Add(this.rbJuridica);
            this.groupBoxTipoPessoa.Controls.Add(this.rbFisica);
            this.groupBoxTipoPessoa.Location = new System.Drawing.Point(19, 24);
            this.groupBoxTipoPessoa.Name = "groupBoxTipoPessoa";
            this.groupBoxTipoPessoa.Size = new System.Drawing.Size(234, 45);
            this.groupBoxTipoPessoa.TabIndex = 4;
            this.groupBoxTipoPessoa.TabStop = false;
            this.groupBoxTipoPessoa.Text = "Tipo Pessoa";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJuridica.ForeColor = System.Drawing.Color.DarkBlue;
            this.rbJuridica.Location = new System.Drawing.Point(132, 15);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(77, 22);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFisica.ForeColor = System.Drawing.Color.DarkBlue;
            this.rbFisica.Location = new System.Drawing.Point(29, 15);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(65, 22);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // txtRgIe
            // 
            this.txtRgIe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRgIe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgIe.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtRgIe.Location = new System.Drawing.Point(594, 90);
            this.txtRgIe.Name = "txtRgIe";
            this.txtRgIe.Size = new System.Drawing.Size(180, 24);
            this.txtRgIe.TabIndex = 2;
            this.txtRgIe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRgIe_KeyPress);
            // 
            // lblRgIe
            // 
            this.lblRgIe.AutoSize = true;
            this.lblRgIe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgIe.Location = new System.Drawing.Point(591, 72);
            this.lblRgIe.Name = "lblRgIe";
            this.lblRgIe.Size = new System.Drawing.Size(105, 17);
            this.lblRgIe.TabIndex = 0;
            this.lblRgIe.Text = "RG / Inc. Est.";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCnpj.Location = new System.Drawing.Point(397, 72);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(91, 17);
            this.lblCpfCnpj.TabIndex = 0;
            this.lblCpfCnpj.Text = "CPF / CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Nasc.";
            // 
            // txtUf
            // 
            this.txtUf.AutoCompleteCustomSource.AddRange(new string[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PR",
            "PB",
            "PA",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.txtUf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUf.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtUf.Location = new System.Drawing.Point(18, 139);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(74, 24);
            this.txtUf.TabIndex = 5;
            this.txtUf.Validated += new System.EventHandler(this.txtUf_Validated);
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCidade.Location = new System.Drawing.Point(110, 139);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(357, 24);
            this.txtCidade.TabIndex = 6;
            this.txtCidade.Text = " ";
            // 
            // groupBoxEndereco
            // 
            this.groupBoxEndereco.Controls.Add(this.txtUf);
            this.groupBoxEndereco.Controls.Add(this.txtComplemento);
            this.groupBoxEndereco.Controls.Add(this.label7);
            this.groupBoxEndereco.Controls.Add(this.txtNumero);
            this.groupBoxEndereco.Controls.Add(this.label8);
            this.groupBoxEndereco.Controls.Add(this.mskCep);
            this.groupBoxEndereco.Controls.Add(this.txtBairro);
            this.groupBoxEndereco.Controls.Add(this.txtLogradouro);
            this.groupBoxEndereco.Controls.Add(this.txtCidade);
            this.groupBoxEndereco.Controls.Add(this.label9);
            this.groupBoxEndereco.Controls.Add(this.label10);
            this.groupBoxEndereco.Controls.Add(this.label6);
            this.groupBoxEndereco.Controls.Add(this.label11);
            this.groupBoxEndereco.Controls.Add(this.label12);
            this.groupBoxEndereco.Location = new System.Drawing.Point(12, 288);
            this.groupBoxEndereco.Name = "groupBoxEndereco";
            this.groupBoxEndereco.Size = new System.Drawing.Size(782, 185);
            this.groupBoxEndereco.TabIndex = 1;
            this.groupBoxEndereco.TabStop = false;
            this.groupBoxEndereco.Text = "Endereço";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtComplemento.Location = new System.Drawing.Point(19, 88);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(234, 24);
            this.txtComplemento.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Complemento";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtNumero.Location = new System.Drawing.Point(595, 35);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(180, 24);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(591, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Número *";
            // 
            // mskCep
            // 
            this.mskCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCep.ForeColor = System.Drawing.Color.DarkBlue;
            this.mskCep.Location = new System.Drawing.Point(491, 139);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(125, 24);
            this.mskCep.TabIndex = 7;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtBairro.Location = new System.Drawing.Point(275, 88);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(499, 24);
            this.txtBairro.TabIndex = 4;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtLogradouro.Location = new System.Drawing.Point(19, 35);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(562, 24);
            this.txtLogradouro.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(272, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bairro *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Logradouro *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(488, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "CEP *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Estado";
            // 
            // groupBoxContato
            // 
            this.groupBoxContato.Controls.Add(this.mskTelComercial);
            this.groupBoxContato.Controls.Add(this.mskCelular);
            this.groupBoxContato.Controls.Add(this.mskTelFixo);
            this.groupBoxContato.Controls.Add(this.label15);
            this.groupBoxContato.Controls.Add(this.txtEmail);
            this.groupBoxContato.Controls.Add(this.label14);
            this.groupBoxContato.Controls.Add(this.label16);
            this.groupBoxContato.Controls.Add(this.label19);
            this.groupBoxContato.Location = new System.Drawing.Point(12, 480);
            this.groupBoxContato.Name = "groupBoxContato";
            this.groupBoxContato.Size = new System.Drawing.Size(782, 79);
            this.groupBoxContato.TabIndex = 2;
            this.groupBoxContato.TabStop = false;
            this.groupBoxContato.Text = "Contato";
            // 
            // mskTelComercial
            // 
            this.mskTelComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelComercial.ForeColor = System.Drawing.Color.DarkBlue;
            this.mskTelComercial.Location = new System.Drawing.Point(308, 42);
            this.mskTelComercial.Mask = "(00)0000-0000";
            this.mskTelComercial.Name = "mskTelComercial";
            this.mskTelComercial.Size = new System.Drawing.Size(125, 24);
            this.mskTelComercial.TabIndex = 2;
            // 
            // mskCelular
            // 
            this.mskCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCelular.ForeColor = System.Drawing.Color.DarkBlue;
            this.mskCelular.Location = new System.Drawing.Point(162, 42);
            this.mskCelular.Mask = "(00)00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(125, 24);
            this.mskCelular.TabIndex = 1;
            // 
            // mskTelFixo
            // 
            this.mskTelFixo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelFixo.ForeColor = System.Drawing.Color.DarkBlue;
            this.mskTelFixo.Location = new System.Drawing.Point(18, 42);
            this.mskTelFixo.Mask = "(00)0000-0000";
            this.mskTelFixo.Name = "mskTelFixo";
            this.mskTelFixo.Size = new System.Drawing.Size(125, 24);
            this.mskTelFixo.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(305, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Tel. Comercial";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtEmail.Location = new System.Drawing.Point(450, 42);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 24);
            this.txtEmail.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(159, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tel. Celular";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(447, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "E-Mail";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(15, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "Tel. Fixo";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtObservacao.Location = new System.Drawing.Point(12, 584);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(782, 45);
            this.txtObservacao.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 567);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Observações";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(336, 57);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(423, 57);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(607, 57);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(518, 57);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 92);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmClienteNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 639);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.groupBoxContato);
            this.Controls.Add(this.groupBoxEndereco);
            this.Controls.Add(this.groupBoxDados);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 677);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(822, 677);
            this.Name = "frmClienteNew";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar - Cliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmClienteNew_Load);
            this.groupBoxDados.ResumeLayout(false);
            this.groupBoxDados.PerformLayout();
            this.groupBoxTipoPessoa.ResumeLayout(false);
            this.groupBoxTipoPessoa.PerformLayout();
            this.groupBoxEndereco.ResumeLayout(false);
            this.groupBoxEndereco.PerformLayout();
            this.groupBoxContato.ResumeLayout(false);
            this.groupBoxContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeRazaoSocial;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBoxDados;
        private System.Windows.Forms.GroupBox groupBoxTipoPessoa;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.TextBox txtRgIe;
        private System.Windows.Forms.Label lblRgIe;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.MaskedTextBox mskDataNasc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLimiteDisponivel;
        private System.Windows.Forms.GroupBox groupBoxEndereco;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxContato;
        private System.Windows.Forms.MaskedTextBox mskTelComercial;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.MaskedTextBox mskTelFixo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblDebito;
        private System.Windows.Forms.MaskedTextBox mskCpfCnpj;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button btnCancelar;
    }
}