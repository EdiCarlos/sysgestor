namespace SysGestor.View.EmpresaView
{
    partial class frmEmpresaNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresaNew));
            this.groupBoxDados = new System.Windows.Forms.GroupBox();
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRgIe = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeRazaoSocial = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxContato = new System.Windows.Forms.GroupBox();
            this.mskTelComercial = new System.Windows.Forms.MaskedTextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskTelFixo = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxEndereco = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscaImagem = new System.Windows.Forms.Button();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pcbCabecalho = new System.Windows.Forms.PictureBox();
            this.groupBoxDados.SuspendLayout();
            this.groupBoxContato.SuspendLayout();
            this.groupBoxEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCabecalho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDados
            // 
            this.groupBoxDados.Controls.Add(this.btnBuscaImagem);
            this.groupBoxDados.Controls.Add(this.pcbLogo);
            this.groupBoxDados.Controls.Add(this.mskCnpj);
            this.groupBoxDados.Controls.Add(this.txtIe);
            this.groupBoxDados.Controls.Add(this.txtNomeFantasia);
            this.groupBoxDados.Controls.Add(this.txtRazaoSocial);
            this.groupBoxDados.Controls.Add(this.lblRgIe);
            this.groupBoxDados.Controls.Add(this.lblCpfCnpj);
            this.groupBoxDados.Controls.Add(this.label1);
            this.groupBoxDados.Controls.Add(this.lblNomeRazaoSocial);
            this.groupBoxDados.Location = new System.Drawing.Point(14, 97);
            this.groupBoxDados.Name = "groupBoxDados";
            this.groupBoxDados.Size = new System.Drawing.Size(782, 240);
            this.groupBoxDados.TabIndex = 19;
            this.groupBoxDados.TabStop = false;
            this.groupBoxDados.Text = "Dados";
            // 
            // mskCnpj
            // 
            this.mskCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCnpj.ForeColor = System.Drawing.Color.DarkBlue;
            this.mskCnpj.Location = new System.Drawing.Point(19, 97);
            this.mskCnpj.Mask = "000,000,000-00";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(180, 24);
            this.mskCnpj.TabIndex = 1;
            // 
            // txtIe
            // 
            this.txtIe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIe.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtIe.Location = new System.Drawing.Point(237, 97);
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(180, 24);
            this.txtIe.TabIndex = 2;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtNomeFantasia.Location = new System.Drawing.Point(18, 45);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(370, 24);
            this.txtNomeFantasia.TabIndex = 0;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtRazaoSocial.Location = new System.Drawing.Point(404, 45);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(370, 24);
            this.txtRazaoSocial.TabIndex = 0;
            // 
            // lblRgIe
            // 
            this.lblRgIe.AutoSize = true;
            this.lblRgIe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgIe.Location = new System.Drawing.Point(234, 79);
            this.lblRgIe.Name = "lblRgIe";
            this.lblRgIe.Size = new System.Drawing.Size(67, 17);
            this.lblRgIe.TabIndex = 0;
            this.lblRgIe.Text = "Inc. Est.";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCnpj.Location = new System.Drawing.Point(16, 79);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(47, 17);
            this.lblCpfCnpj.TabIndex = 0;
            this.lblCpfCnpj.Text = "CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Fantasia *";
            // 
            // lblNomeRazaoSocial
            // 
            this.lblNomeRazaoSocial.AutoSize = true;
            this.lblNomeRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeRazaoSocial.Location = new System.Drawing.Point(401, 27);
            this.lblNomeRazaoSocial.Name = "lblNomeRazaoSocial";
            this.lblNomeRazaoSocial.Size = new System.Drawing.Size(114, 17);
            this.lblNomeRazaoSocial.TabIndex = 0;
            this.lblNomeRazaoSocial.Text = "Razão Social *";
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
            this.groupBoxContato.Location = new System.Drawing.Point(14, 546);
            this.groupBoxContato.Name = "groupBoxContato";
            this.groupBoxContato.Size = new System.Drawing.Size(782, 79);
            this.groupBoxContato.TabIndex = 21;
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
            this.groupBoxEndereco.Location = new System.Drawing.Point(14, 343);
            this.groupBoxEndereco.Name = "groupBoxEndereco";
            this.groupBoxEndereco.Size = new System.Drawing.Size(782, 185);
            this.groupBoxEndereco.TabIndex = 20;
            this.groupBoxEndereco.TabStop = false;
            this.groupBoxEndereco.Text = "Endereço";
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
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            this.ofdFoto.Filter = " \"Images (*.JPG;*.PNG;)|;*.JPG;*.PNG;|\" + \"All files (*.*)|*.*\"";
            this.ofdFoto.InitialDirectory = "C:\\Bibliotecas\\Imagens";
            this.ofdFoto.ReadOnlyChecked = true;
            this.ofdFoto.RestoreDirectory = true;
            this.ofdFoto.ShowReadOnly = true;
            this.ofdFoto.Title = "Selecionar Foto";
            // 
            // btnBuscaImagem
            // 
            this.btnBuscaImagem.Image = global::SysGestor.View.Properties.Resources.search26x26;
            this.btnBuscaImagem.Location = new System.Drawing.Point(571, 195);
            this.btnBuscaImagem.Name = "btnBuscaImagem";
            this.btnBuscaImagem.Size = new System.Drawing.Size(45, 34);
            this.btnBuscaImagem.TabIndex = 4;
            this.btnBuscaImagem.UseVisualStyleBackColor = true;
            this.btnBuscaImagem.Click += new System.EventHandler(this.btnBuscaImagem_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.White;
            this.pcbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbLogo.Location = new System.Drawing.Point(624, 79);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(150, 150);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 3;
            this.pcbLogo.TabStop = false;
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
            this.btnNovo.Location = new System.Drawing.Point(402, 48);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(87, 39);
            this.btnNovo.TabIndex = 25;
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
            this.btnCancelar.Location = new System.Drawing.Point(601, 48);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 39);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnSair.Location = new System.Drawing.Point(719, 47);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 39);
            this.btnSair.TabIndex = 27;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.btnGravar.Location = new System.Drawing.Point(496, 48);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(98, 39);
            this.btnGravar.TabIndex = 28;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // pcbCabecalho
            // 
            this.pcbCabecalho.Image = global::SysGestor.View.Properties.Resources.img_sistema;
            this.pcbCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pcbCabecalho.Name = "pcbCabecalho";
            this.pcbCabecalho.Size = new System.Drawing.Size(809, 92);
            this.pcbCabecalho.TabIndex = 24;
            this.pcbCabecalho.TabStop = false;
            // 
            // frmEmpresaNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 633);
            this.Controls.Add(this.groupBoxDados);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.pcbCabecalho);
            this.Controls.Add(this.groupBoxContato);
            this.Controls.Add(this.groupBoxEndereco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpresaNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro - Empresa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmpresaNew_FormClosing);
            this.Load += new System.EventHandler(this.frmEmpresaNew_Load);
            this.groupBoxDados.ResumeLayout(false);
            this.groupBoxDados.PerformLayout();
            this.groupBoxContato.ResumeLayout(false);
            this.groupBoxContato.PerformLayout();
            this.groupBoxEndereco.ResumeLayout(false);
            this.groupBoxEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCabecalho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDados;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.MaskedTextBox mskCnpj;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblRgIe;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeRazaoSocial;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.PictureBox pcbCabecalho;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxContato;
        private System.Windows.Forms.MaskedTextBox mskTelComercial;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.MaskedTextBox mskTelFixo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.GroupBox groupBoxEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBuscaImagem;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}