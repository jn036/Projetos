namespace SGP.View
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.panelCadastroCliente = new System.Windows.Forms.Panel();
            this.LblCadastroCliente = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblCpf = new System.Windows.Forms.Label();
            this.MskCPF = new System.Windows.Forms.MaskedTextBox();
            this.MskCEP = new System.Windows.Forms.MaskedTextBox();
            this.PbFoto = new System.Windows.Forms.PictureBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblBairro = new System.Windows.Forms.Label();
            this.CboTipoLogradouro = new System.Windows.Forms.ComboBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.BtnEscolherFoto = new System.Windows.Forms.Button();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblTipoLogradouro = new System.Windows.Forms.Label();
            this.MskCelular = new System.Windows.Forms.MaskedTextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.LblCEP = new System.Windows.Forms.Label();
            this.LblNomeLogradouro = new System.Windows.Forms.Label();
            this.TxtNomeLogradouro = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.CboUF = new System.Windows.Forms.ComboBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.DteTimePickerNasc = new System.Windows.Forms.DateTimePicker();
            this.DteTimePickerCadastro = new System.Windows.Forms.DateTimePicker();
            this.LblPais = new System.Windows.Forms.Label();
            this.MskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.LblCelular = new System.Windows.Forms.Label();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.LblUF = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.LblNascimento = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.panelCadastroCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCadastroCliente
            // 
            this.panelCadastroCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCadastroCliente.Controls.Add(this.LblCadastroCliente);
            this.panelCadastroCliente.Controls.Add(this.BtnExcluir);
            this.panelCadastroCliente.Controls.Add(this.groupBox1);
            this.panelCadastroCliente.Controls.Add(this.BtnSalvar);
            this.panelCadastroCliente.Controls.Add(this.BtnSair);
            this.panelCadastroCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadastroCliente.Location = new System.Drawing.Point(0, 0);
            this.panelCadastroCliente.Name = "panelCadastroCliente";
            this.panelCadastroCliente.Size = new System.Drawing.Size(981, 614);
            this.panelCadastroCliente.TabIndex = 0;
            this.panelCadastroCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCadastroCliente_Paint);
            // 
            // LblCadastroCliente
            // 
            this.LblCadastroCliente.AutoSize = true;
            this.LblCadastroCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastroCliente.Location = new System.Drawing.Point(12, 21);
            this.LblCadastroCliente.Name = "LblCadastroCliente";
            this.LblCadastroCliente.Size = new System.Drawing.Size(194, 18);
            this.LblCadastroCliente.TabIndex = 0;
            this.LblCadastroCliente.Text = "CADASTRO DE CLIENTE";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.BackgroundImage")));
            this.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(869, 12);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(40, 35);
            this.BtnExcluir.TabIndex = 3;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.LblCpf);
            this.groupBox1.Controls.Add(this.MskCPF);
            this.groupBox1.Controls.Add(this.MskCEP);
            this.groupBox1.Controls.Add(this.PbFoto);
            this.groupBox1.Controls.Add(this.TxtNumero);
            this.groupBox1.Controls.Add(this.LblBairro);
            this.groupBox1.Controls.Add(this.CboTipoLogradouro);
            this.groupBox1.Controls.Add(this.LblNumero);
            this.groupBox1.Controls.Add(this.BtnEscolherFoto);
            this.groupBox1.Controls.Add(this.LblEmail);
            this.groupBox1.Controls.Add(this.LblTipoLogradouro);
            this.groupBox1.Controls.Add(this.MskCelular);
            this.groupBox1.Controls.Add(this.LblID);
            this.groupBox1.Controls.Add(this.LblCEP);
            this.groupBox1.Controls.Add(this.LblNomeLogradouro);
            this.groupBox1.Controls.Add(this.TxtNomeLogradouro);
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.CboUF);
            this.groupBox1.Controls.Add(this.LblNome);
            this.groupBox1.Controls.Add(this.LblTelefone);
            this.groupBox1.Controls.Add(this.LblCadastro);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.DteTimePickerNasc);
            this.groupBox1.Controls.Add(this.DteTimePickerCadastro);
            this.groupBox1.Controls.Add(this.LblPais);
            this.groupBox1.Controls.Add(this.MskTelefone);
            this.groupBox1.Controls.Add(this.LblCelular);
            this.groupBox1.Controls.Add(this.TxtPais);
            this.groupBox1.Controls.Add(this.LblUF);
            this.groupBox1.Controls.Add(this.TxtCidade);
            this.groupBox1.Controls.Add(this.LblCidade);
            this.groupBox1.Controls.Add(this.LblNascimento);
            this.groupBox1.Controls.Add(this.TxtBairro);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 536);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpf.Location = new System.Drawing.Point(148, 125);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(41, 18);
            this.LblCpf.TabIndex = 388;
            this.LblCpf.Text = "CPF";
            // 
            // MskCPF
            // 
            this.MskCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskCPF.Location = new System.Drawing.Point(216, 117);
            this.MskCPF.Mask = "999.999.999-99";
            this.MskCPF.Name = "MskCPF";
            this.MskCPF.Size = new System.Drawing.Size(122, 26);
            this.MskCPF.TabIndex = 387;
            this.MskCPF.ValidatingType = typeof(System.DateTime);
            // 
            // MskCEP
            // 
            this.MskCEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskCEP.Location = new System.Drawing.Point(216, 237);
            this.MskCEP.Mask = "00000-000";
            this.MskCEP.Name = "MskCEP";
            this.MskCEP.Size = new System.Drawing.Size(88, 26);
            this.MskCEP.TabIndex = 13;
            this.MskCEP.Leave += new System.EventHandler(this.MskCEP_Leave);
            // 
            // PbFoto
            // 
            this.PbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbFoto.Image = ((System.Drawing.Image)(resources.GetObject("PbFoto.Image")));
            this.PbFoto.Location = new System.Drawing.Point(746, 34);
            this.PbFoto.Name = "PbFoto";
            this.PbFoto.Size = new System.Drawing.Size(192, 153);
            this.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFoto.TabIndex = 377;
            this.PbFoto.TabStop = false;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(620, 317);
            this.TxtNumero.MaxLength = 5;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(49, 26);
            this.TxtNumero.TabIndex = 19;
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBairro.Location = new System.Drawing.Point(134, 365);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(51, 18);
            this.LblBairro.TabIndex = 20;
            this.LblBairro.Text = "Bairro";
            // 
            // CboTipoLogradouro
            // 
            this.CboTipoLogradouro.AutoCompleteCustomSource.AddRange(new string[] {
            "Vila ",
            "Largo ",
            "Travessa ",
            "Viela ",
            "Loteamento ",
            "Pátio",
            "Viaduto ",
            "Área",
            "Via ",
            "Aeroporto ",
            "Vereda",
            "Distrito ",
            "Vale ",
            "Núcleo ",
            "Trevo ",
            "Fazenda ",
            "Trecho ",
            "Estrada ",
            "Sítio",
            "Feira ",
            "Setor ",
            "Morro ",
            "Rua",
            "Chácara ",
            "Rodovia ",
            "Residencial ",
            "Avenida",
            "Colônia ",
            "Recanto ",
            "Quadra ",
            "Praça ",
            "Condomínio ",
            "Passarela ",
            "Parque ",
            "Esplanada ",
            "Lagoa",
            "Favela ",
            "Ladeira ",
            "Lago ",
            "Conjunto ",
            "Jardim",
            "Estação ",
            "Campo",
            "Alameda"});
            this.CboTipoLogradouro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboTipoLogradouro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboTipoLogradouro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoLogradouro.FormattingEnabled = true;
            this.CboTipoLogradouro.Items.AddRange(new object[] {
            "Vila ",
            "Largo ",
            "Travessa ",
            "Viela ",
            "Loteamento ",
            "Pátio",
            "Viaduto ",
            "Área",
            "Via ",
            "Aeroporto ",
            "Vereda",
            "Distrito ",
            "Vale ",
            "Núcleo ",
            "Trevo ",
            "Fazenda ",
            "Trecho ",
            "Estrada ",
            "Sítio",
            "Feira ",
            "Setor ",
            "Morro ",
            "Rua",
            "Chácara ",
            "Rodovia ",
            "Residencial ",
            "Avenida",
            "Colônia ",
            "Recanto ",
            "Quadra ",
            "Praça ",
            "Condomínio ",
            "Passarela ",
            "Parque ",
            "Esplanada ",
            "Lagoa",
            "Favela ",
            "Ladeira ",
            "Lago ",
            "Conjunto ",
            "Jardim",
            "Estação ",
            "Campo",
            "Alameda"});
            this.CboTipoLogradouro.Location = new System.Drawing.Point(216, 277);
            this.CboTipoLogradouro.MaxLength = 50;
            this.CboTipoLogradouro.Name = "CboTipoLogradouro";
            this.CboTipoLogradouro.Size = new System.Drawing.Size(101, 26);
            this.CboTipoLogradouro.TabIndex = 15;
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero.Location = new System.Drawing.Point(579, 325);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(24, 18);
            this.LblNumero.TabIndex = 18;
            this.LblNumero.Text = "Nº";
            // 
            // BtnEscolherFoto
            // 
            this.BtnEscolherFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEscolherFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEscolherFoto.BackgroundImage")));
            this.BtnEscolherFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEscolherFoto.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.BtnEscolherFoto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEscolherFoto.Location = new System.Drawing.Point(804, 193);
            this.BtnEscolherFoto.Name = "BtnEscolherFoto";
            this.BtnEscolherFoto.Size = new System.Drawing.Size(73, 62);
            this.BtnEscolherFoto.TabIndex = 32;
            this.BtnEscolherFoto.UseVisualStyleBackColor = true;
            this.BtnEscolherFoto.Click += new System.EventHandler(this.BtnEscolherFoto_Click);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(141, 207);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(48, 18);
            this.LblEmail.TabIndex = 10;
            this.LblEmail.Text = "Email";
            // 
            // LblTipoLogradouro
            // 
            this.LblTipoLogradouro.AutoSize = true;
            this.LblTipoLogradouro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoLogradouro.Location = new System.Drawing.Point(98, 285);
            this.LblTipoLogradouro.Name = "LblTipoLogradouro";
            this.LblTipoLogradouro.Size = new System.Drawing.Size(93, 18);
            this.LblTipoLogradouro.TabIndex = 14;
            this.LblTipoLogradouro.Text = " Logradouro";
            // 
            // MskCelular
            // 
            this.MskCelular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskCelular.Location = new System.Drawing.Point(436, 477);
            this.MskCelular.Mask = "(99)00000-0000";
            this.MskCelular.Name = "MskCelular";
            this.MskCelular.Size = new System.Drawing.Size(125, 26);
            this.MskCelular.TabIndex = 31;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(424, 42);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(23, 18);
            this.LblID.TabIndex = 2;
            this.LblID.Text = "ID";
            // 
            // LblCEP
            // 
            this.LblCEP.AutoSize = true;
            this.LblCEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCEP.Location = new System.Drawing.Point(145, 245);
            this.LblCEP.Name = "LblCEP";
            this.LblCEP.Size = new System.Drawing.Size(42, 18);
            this.LblCEP.TabIndex = 12;
            this.LblCEP.Text = "CEP";
            // 
            // LblNomeLogradouro
            // 
            this.LblNomeLogradouro.AutoSize = true;
            this.LblNomeLogradouro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeLogradouro.Location = new System.Drawing.Point(30, 325);
            this.LblNomeLogradouro.Name = "LblNomeLogradouro";
            this.LblNomeLogradouro.Size = new System.Drawing.Size(157, 18);
            this.LblNomeLogradouro.TabIndex = 16;
            this.LblNomeLogradouro.Text = "Nome do Logradouro";
            // 
            // TxtNomeLogradouro
            // 
            this.TxtNomeLogradouro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeLogradouro.Location = new System.Drawing.Point(213, 317);
            this.TxtNomeLogradouro.MaxLength = 100;
            this.TxtNomeLogradouro.Name = "TxtNomeLogradouro";
            this.TxtNomeLogradouro.Size = new System.Drawing.Size(343, 26);
            this.TxtNomeLogradouro.TabIndex = 17;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(469, 34);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 26);
            this.TxtID.TabIndex = 3;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(216, 197);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(509, 26);
            this.TxtEmail.TabIndex = 11;
            // 
            // CboUF
            // 
            this.CboUF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboUF.FormattingEnabled = true;
            this.CboUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.CboUF.Location = new System.Drawing.Point(592, 397);
            this.CboUF.Name = "CboUF";
            this.CboUF.Size = new System.Drawing.Size(47, 26);
            this.CboUF.TabIndex = 25;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(141, 165);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(50, 18);
            this.LblNome.TabIndex = 8;
            this.LblNome.Text = "Nome";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefone.Location = new System.Drawing.Point(117, 485);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(66, 18);
            this.LblTelefone.TabIndex = 28;
            this.LblTelefone.Text = "Telefone";
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.Location = new System.Drawing.Point(117, 44);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(77, 18);
            this.LblCadastro.TabIndex = 0;
            this.LblCadastro.Text = " Cadastro";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(216, 157);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(509, 26);
            this.TxtNome.TabIndex = 9;
            // 
            // DteTimePickerNasc
            // 
            this.DteTimePickerNasc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DteTimePickerNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerNasc.Location = new System.Drawing.Point(216, 77);
            this.DteTimePickerNasc.Name = "DteTimePickerNasc";
            this.DteTimePickerNasc.Size = new System.Drawing.Size(107, 26);
            this.DteTimePickerNasc.TabIndex = 5;
            this.DteTimePickerNasc.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // DteTimePickerCadastro
            // 
            this.DteTimePickerCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DteTimePickerCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerCadastro.Location = new System.Drawing.Point(214, 36);
            this.DteTimePickerCadastro.Name = "DteTimePickerCadastro";
            this.DteTimePickerCadastro.Size = new System.Drawing.Size(107, 26);
            this.DteTimePickerCadastro.TabIndex = 1;
            this.DteTimePickerCadastro.Value = new System.DateTime(2019, 3, 21, 0, 0, 0, 0);
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPais.Location = new System.Drawing.Point(145, 445);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(40, 18);
            this.LblPais.TabIndex = 26;
            this.LblPais.Text = "Pais";
            // 
            // MskTelefone
            // 
            this.MskTelefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTelefone.Location = new System.Drawing.Point(213, 477);
            this.MskTelefone.Mask = "(99)0000-0000";
            this.MskTelefone.Name = "MskTelefone";
            this.MskTelefone.Size = new System.Drawing.Size(109, 26);
            this.MskTelefone.TabIndex = 29;
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCelular.Location = new System.Drawing.Point(347, 483);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(57, 18);
            this.LblCelular.TabIndex = 30;
            this.LblCelular.Text = "Celular";
            // 
            // TxtPais
            // 
            this.TxtPais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPais.Location = new System.Drawing.Point(213, 437);
            this.TxtPais.MaxLength = 50;
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(302, 26);
            this.TxtPais.TabIndex = 27;
            // 
            // LblUF
            // 
            this.LblUF.AutoSize = true;
            this.LblUF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUF.Location = new System.Drawing.Point(540, 405);
            this.LblUF.Name = "LblUF";
            this.LblUF.Size = new System.Drawing.Size(29, 18);
            this.LblUF.TabIndex = 24;
            this.LblUF.Text = "UF";
            // 
            // TxtCidade
            // 
            this.TxtCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCidade.Location = new System.Drawing.Point(216, 397);
            this.TxtCidade.MaxLength = 100;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(302, 26);
            this.TxtCidade.TabIndex = 23;
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCidade.Location = new System.Drawing.Point(125, 405);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(60, 18);
            this.LblCidade.TabIndex = 22;
            this.LblCidade.Text = "Cidade";
            // 
            // LblNascimento
            // 
            this.LblNascimento.AutoSize = true;
            this.LblNascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNascimento.Location = new System.Drawing.Point(103, 83);
            this.LblNascimento.Name = "LblNascimento";
            this.LblNascimento.Size = new System.Drawing.Size(91, 18);
            this.LblNascimento.TabIndex = 4;
            this.LblNascimento.Text = "Nascimento";
            // 
            // TxtBairro
            // 
            this.TxtBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBairro.Location = new System.Drawing.Point(216, 357);
            this.TxtBairro.MaxLength = 50;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(509, 26);
            this.TxtBairro.TabIndex = 21;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.BackgroundImage")));
            this.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(813, 12);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(39, 35);
            this.BtnSalvar.TabIndex = 2;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(926, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(40, 35);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 614);
            this.Controls.Add(this.panelCadastroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.panelCadastroCliente.ResumeLayout(false);
            this.panelCadastroCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadastroCliente;
        private System.Windows.Forms.MaskedTextBox MskCEP;
        private System.Windows.Forms.Label LblCadastroCliente;
        private System.Windows.Forms.ComboBox CboUF;
        private System.Windows.Forms.TextBox TxtID;
        public System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Button BtnEscolherFoto;
        private System.Windows.Forms.PictureBox PbFoto;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.ComboBox CboTipoLogradouro;
        private System.Windows.Forms.Label LblUF;
        private System.Windows.Forms.MaskedTextBox MskCelular;
        private System.Windows.Forms.MaskedTextBox MskTelefone;
        private System.Windows.Forms.DateTimePicker DteTimePickerCadastro;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.DateTimePicker DteTimePickerNasc;
        public System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblCEP;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtNomeLogradouro;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.Label LblNomeLogradouro;
        private System.Windows.Forms.Label LblTipoLogradouro;
        private System.Windows.Forms.Label LblNascimento;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox MskCPF;
        private System.Windows.Forms.Label LblCpf;
    }
}