namespace SGP.View
{
    partial class CadastroColaborador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroColaborador));
            this.fUNCAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCAOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.LblNascimento = new System.Windows.Forms.Label();
            this.LblTipoLogradouro = new System.Windows.Forms.Label();
            this.LblNomeLogradouro = new System.Windows.Forms.Label();
            this.LblCidade = new System.Windows.Forms.Label();
            this.TxtNomeLogradouro = new System.Windows.Forms.TextBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.LblBairro = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.LblCEP = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.DteTimePickerNasc = new System.Windows.Forms.DateTimePicker();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.DteTimePickerCadastro = new System.Windows.Forms.DateTimePicker();
            this.LblFuncao = new System.Windows.Forms.Label();
            this.MskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.MskCelular = new System.Windows.Forms.MaskedTextBox();
            this.LblUF = new System.Windows.Forms.Label();
            this.CboTipoLogradouro = new System.Windows.Forms.ComboBox();
            this.LblPais = new System.Windows.Forms.Label();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.PbFoto = new System.Windows.Forms.PictureBox();
            this.BtnEscolherFoto = new System.Windows.Forms.Button();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.CboUF = new System.Windows.Forms.ComboBox();
            this.MskCEP = new System.Windows.Forms.MaskedTextBox();
            this.panelCadastroColaborador = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblCadastroColaborador = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.MskCPF = new System.Windows.Forms.MaskedTextBox();
            this.CBOFuncao = new System.Windows.Forms.ComboBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).BeginInit();
            this.panelCadastroColaborador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fUNCAOBindingSource1
            // 
            this.fUNCAOBindingSource1.DataMember = "FUNCAO";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.BackgroundImage")));
            this.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(816, 9);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(40, 35);
            this.BtnSalvar.TabIndex = 2;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // LblNascimento
            // 
            this.LblNascimento.AutoSize = true;
            this.LblNascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNascimento.Location = new System.Drawing.Point(78, 144);
            this.LblNascimento.Name = "LblNascimento";
            this.LblNascimento.Size = new System.Drawing.Size(91, 18);
            this.LblNascimento.TabIndex = 8;
            this.LblNascimento.Text = "Nascimento";
            // 
            // LblTipoLogradouro
            // 
            this.LblTipoLogradouro.AutoSize = true;
            this.LblTipoLogradouro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoLogradouro.Location = new System.Drawing.Point(75, 348);
            this.LblTipoLogradouro.Name = "LblTipoLogradouro";
            this.LblTipoLogradouro.Size = new System.Drawing.Size(93, 18);
            this.LblTipoLogradouro.TabIndex = 18;
            this.LblTipoLogradouro.Text = " Logradouro";
            // 
            // LblNomeLogradouro
            // 
            this.LblNomeLogradouro.AutoSize = true;
            this.LblNomeLogradouro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeLogradouro.Location = new System.Drawing.Point(12, 385);
            this.LblNomeLogradouro.Name = "LblNomeLogradouro";
            this.LblNomeLogradouro.Size = new System.Drawing.Size(157, 18);
            this.LblNomeLogradouro.TabIndex = 20;
            this.LblNomeLogradouro.Text = "Nome do Logradouro";
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCidade.Location = new System.Drawing.Point(109, 472);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(60, 18);
            this.LblCidade.TabIndex = 26;
            this.LblCidade.Text = "Cidade";
            // 
            // TxtNomeLogradouro
            // 
            this.TxtNomeLogradouro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeLogradouro.Location = new System.Drawing.Point(195, 382);
            this.TxtNomeLogradouro.MaxLength = 100;
            this.TxtNomeLogradouro.Name = "TxtNomeLogradouro";
            this.TxtNomeLogradouro.Size = new System.Drawing.Size(397, 26);
            this.TxtNomeLogradouro.TabIndex = 21;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCidade.Location = new System.Drawing.Point(195, 464);
            this.TxtCidade.MaxLength = 100;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(302, 26);
            this.TxtCidade.TabIndex = 27;
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBairro.Location = new System.Drawing.Point(118, 434);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(51, 18);
            this.LblBairro.TabIndex = 24;
            this.LblBairro.Text = "Bairro";
            // 
            // TxtBairro
            // 
            this.TxtBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBairro.Location = new System.Drawing.Point(195, 426);
            this.TxtBairro.MaxLength = 50;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(509, 26);
            this.TxtBairro.TabIndex = 25;
            // 
            // LblCEP
            // 
            this.LblCEP.AutoSize = true;
            this.LblCEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCEP.Location = new System.Drawing.Point(121, 302);
            this.LblCEP.Name = "LblCEP";
            this.LblCEP.Size = new System.Drawing.Size(42, 18);
            this.LblCEP.TabIndex = 16;
            this.LblCEP.Text = "CEP";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(121, 264);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(48, 18);
            this.LblEmail.TabIndex = 14;
            this.LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(195, 256);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(202, 26);
            this.TxtEmail.TabIndex = 15;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(119, 223);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(50, 18);
            this.LblNome.TabIndex = 12;
            this.LblNome.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(195, 215);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(509, 26);
            this.TxtNome.TabIndex = 13;
            // 
            // DteTimePickerNasc
            // 
            this.DteTimePickerNasc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DteTimePickerNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerNasc.Location = new System.Drawing.Point(195, 136);
            this.DteTimePickerNasc.Name = "DteTimePickerNasc";
            this.DteTimePickerNasc.Size = new System.Drawing.Size(125, 26);
            this.DteTimePickerNasc.TabIndex = 9;
            this.DteTimePickerNasc.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefone.Location = new System.Drawing.Point(102, 558);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(66, 18);
            this.LblTelefone.TabIndex = 32;
            this.LblTelefone.Text = "Telefone";
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCelular.Location = new System.Drawing.Point(348, 558);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(57, 18);
            this.LblCelular.TabIndex = 34;
            this.LblCelular.Text = "Celular";
            this.LblCelular.Click += new System.EventHandler(this.LblCelular_Click);
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero.Location = new System.Drawing.Point(614, 385);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(24, 18);
            this.LblNumero.TabIndex = 22;
            this.LblNumero.Text = "Nº";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(651, 382);
            this.TxtNumero.MaxLength = 5;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(53, 26);
            this.TxtNumero.TabIndex = 23;
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.Location = new System.Drawing.Point(92, 30);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(77, 18);
            this.LblCadastro.TabIndex = 0;
            this.LblCadastro.Text = " Cadastro";
            // 
            // DteTimePickerCadastro
            // 
            this.DteTimePickerCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DteTimePickerCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerCadastro.Location = new System.Drawing.Point(195, 22);
            this.DteTimePickerCadastro.Name = "DteTimePickerCadastro";
            this.DteTimePickerCadastro.Size = new System.Drawing.Size(100, 26);
            this.DteTimePickerCadastro.TabIndex = 1;
            this.DteTimePickerCadastro.Value = new System.DateTime(2019, 3, 21, 0, 0, 0, 0);
            // 
            // LblFuncao
            // 
            this.LblFuncao.AutoSize = true;
            this.LblFuncao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFuncao.Location = new System.Drawing.Point(109, 68);
            this.LblFuncao.Name = "LblFuncao";
            this.LblFuncao.Size = new System.Drawing.Size(60, 18);
            this.LblFuncao.TabIndex = 4;
            this.LblFuncao.Text = "Função";
            // 
            // MskTelefone
            // 
            this.MskTelefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTelefone.Location = new System.Drawing.Point(197, 550);
            this.MskTelefone.Mask = "(99)0000-0000";
            this.MskTelefone.Name = "MskTelefone";
            this.MskTelefone.Size = new System.Drawing.Size(112, 26);
            this.MskTelefone.TabIndex = 33;
            // 
            // MskCelular
            // 
            this.MskCelular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskCelular.Location = new System.Drawing.Point(441, 555);
            this.MskCelular.Mask = "(99)00000-0000";
            this.MskCelular.Name = "MskCelular";
            this.MskCelular.Size = new System.Drawing.Size(123, 26);
            this.MskCelular.TabIndex = 35;
            // 
            // LblUF
            // 
            this.LblUF.AutoSize = true;
            this.LblUF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUF.Location = new System.Drawing.Point(536, 467);
            this.LblUF.Name = "LblUF";
            this.LblUF.Size = new System.Drawing.Size(29, 18);
            this.LblUF.TabIndex = 28;
            this.LblUF.Text = "UF";
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
            this.CboTipoLogradouro.Location = new System.Drawing.Point(194, 340);
            this.CboTipoLogradouro.MaxLength = 50;
            this.CboTipoLogradouro.Name = "CboTipoLogradouro";
            this.CboTipoLogradouro.Size = new System.Drawing.Size(101, 26);
            this.CboTipoLogradouro.TabIndex = 19;
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPais.Location = new System.Drawing.Point(128, 520);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(40, 18);
            this.LblPais.TabIndex = 30;
            this.LblPais.Text = "Pais";
            // 
            // TxtPais
            // 
            this.TxtPais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPais.Location = new System.Drawing.Point(195, 512);
            this.TxtPais.MaxLength = 50;
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(302, 26);
            this.TxtPais.TabIndex = 31;
            // 
            // PbFoto
            // 
            this.PbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbFoto.Image = ((System.Drawing.Image)(resources.GetObject("PbFoto.Image")));
            this.PbFoto.Location = new System.Drawing.Point(721, 33);
            this.PbFoto.Name = "PbFoto";
            this.PbFoto.Size = new System.Drawing.Size(192, 153);
            this.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFoto.TabIndex = 383;
            this.PbFoto.TabStop = false;
            // 
            // BtnEscolherFoto
            // 
            this.BtnEscolherFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEscolherFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEscolherFoto.BackgroundImage")));
            this.BtnEscolherFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEscolherFoto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEscolherFoto.Location = new System.Drawing.Point(795, 192);
            this.BtnEscolherFoto.Name = "BtnEscolherFoto";
            this.BtnEscolherFoto.Size = new System.Drawing.Size(40, 35);
            this.BtnEscolherFoto.TabIndex = 36;
            this.BtnEscolherFoto.UseVisualStyleBackColor = true;
            this.BtnEscolherFoto.Click += new System.EventHandler(this.BtnEscolherFoto_Click);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(369, 30);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(23, 18);
            this.LblID.TabIndex = 2;
            this.LblID.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(408, 22);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 26);
            this.TxtID.TabIndex = 3;
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
            this.CboUF.Location = new System.Drawing.Point(591, 464);
            this.CboUF.Name = "CboUF";
            this.CboUF.Size = new System.Drawing.Size(47, 26);
            this.CboUF.TabIndex = 29;
            // 
            // MskCEP
            // 
            this.MskCEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskCEP.Location = new System.Drawing.Point(195, 299);
            this.MskCEP.Mask = "00000-000";
            this.MskCEP.Name = "MskCEP";
            this.MskCEP.Size = new System.Drawing.Size(85, 26);
            this.MskCEP.TabIndex = 17;
            this.MskCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskCEP_MaskInputRejected);
            this.MskCEP.Leave += new System.EventHandler(this.MskCEP_Leave);
            // 
            // panelCadastroColaborador
            // 
            this.panelCadastroColaborador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCadastroColaborador.Controls.Add(this.BtnSair);
            this.panelCadastroColaborador.Controls.Add(this.LblCadastroColaborador);
            this.panelCadastroColaborador.Controls.Add(this.BtnExcluir);
            this.panelCadastroColaborador.Controls.Add(this.groupBox1);
            this.panelCadastroColaborador.Controls.Add(this.BtnSalvar);
            this.panelCadastroColaborador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadastroColaborador.Location = new System.Drawing.Point(0, 0);
            this.panelCadastroColaborador.Name = "panelCadastroColaborador";
            this.panelCadastroColaborador.Size = new System.Drawing.Size(960, 681);
            this.panelCadastroColaborador.TabIndex = 0;
            this.panelCadastroColaborador.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCadastroColaborador_Paint);
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(908, 9);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(40, 35);
            this.BtnSair.TabIndex = 34;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblCadastroColaborador
            // 
            this.LblCadastroColaborador.AutoSize = true;
            this.LblCadastroColaborador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastroColaborador.Location = new System.Drawing.Point(12, 20);
            this.LblCadastroColaborador.Name = "LblCadastroColaborador";
            this.LblCadastroColaborador.Size = new System.Drawing.Size(252, 18);
            this.LblCadastroColaborador.TabIndex = 0;
            this.LblCadastroColaborador.Text = "CADASTRO DE COLABORADOR";
            this.LblCadastroColaborador.Click += new System.EventHandler(this.LblCadastroColaborador_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.BackgroundImage")));
            this.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(862, 9);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(40, 35);
            this.BtnExcluir.TabIndex = 3;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Controls.Add(this.MskCPF);
            this.groupBox1.Controls.Add(this.MskCEP);
            this.groupBox1.Controls.Add(this.CBOFuncao);
            this.groupBox1.Controls.Add(this.LblCadastro);
            this.groupBox1.Controls.Add(this.DteTimePickerCadastro);
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.LblSenha);
            this.groupBox1.Controls.Add(this.TxtSenha);
            this.groupBox1.Controls.Add(this.MskCelular);
            this.groupBox1.Controls.Add(this.LblID);
            this.groupBox1.Controls.Add(this.LblFuncao);
            this.groupBox1.Controls.Add(this.CboUF);
            this.groupBox1.Controls.Add(this.LblNascimento);
            this.groupBox1.Controls.Add(this.DteTimePickerNasc);
            this.groupBox1.Controls.Add(this.PbFoto);
            this.groupBox1.Controls.Add(this.BtnEscolherFoto);
            this.groupBox1.Controls.Add(this.LblPais);
            this.groupBox1.Controls.Add(this.CboTipoLogradouro);
            this.groupBox1.Controls.Add(this.TxtPais);
            this.groupBox1.Controls.Add(this.LblUF);
            this.groupBox1.Controls.Add(this.LblCelular);
            this.groupBox1.Controls.Add(this.MskTelefone);
            this.groupBox1.Controls.Add(this.LblNome);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.LblTelefone);
            this.groupBox1.Controls.Add(this.TxtCidade);
            this.groupBox1.Controls.Add(this.LblEmail);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.LblNumero);
            this.groupBox1.Controls.Add(this.TxtNumero);
            this.groupBox1.Controls.Add(this.LblCEP);
            this.groupBox1.Controls.Add(this.LblCidade);
            this.groupBox1.Controls.Add(this.TxtBairro);
            this.groupBox1.Controls.Add(this.LblBairro);
            this.groupBox1.Controls.Add(this.LblTipoLogradouro);
            this.groupBox1.Controls.Add(this.TxtNomeLogradouro);
            this.groupBox1.Controls.Add(this.LblNomeLogradouro);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 608);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(129, 192);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(41, 18);
            this.lblCpf.TabIndex = 384;
            this.lblCpf.Text = "CPF";
            // 
            // MskCPF
            // 
            this.MskCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskCPF.Location = new System.Drawing.Point(195, 179);
            this.MskCPF.Mask = "999.999.999-99";
            this.MskCPF.Name = "MskCPF";
            this.MskCPF.Size = new System.Drawing.Size(119, 26);
            this.MskCPF.TabIndex = 11;
            this.MskCPF.ValidatingType = typeof(System.DateTime);
            // 
            // CBOFuncao
            // 
            this.CBOFuncao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOFuncao.FormattingEnabled = true;
            this.CBOFuncao.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Secretaria",
            "Operador"});
            this.CBOFuncao.Location = new System.Drawing.Point(195, 60);
            this.CBOFuncao.Name = "CBOFuncao";
            this.CBOFuncao.Size = new System.Drawing.Size(121, 26);
            this.CBOFuncao.TabIndex = 5;
            this.CBOFuncao.SelectedIndexChanged += new System.EventHandler(this.CBOFuncao_SelectedIndexChanged);
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(116, 106);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(53, 18);
            this.LblSenha.TabIndex = 6;
            this.LblSenha.Text = "Senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(195, 98);
            this.TxtSenha.MaxLength = 8;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(139, 26);
            this.TxtSenha.TabIndex = 7;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // CadastroColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(960, 681);
            this.Controls.Add(this.panelCadastroColaborador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroColaborador";
            this.Text = "Cadastro de Colaborador";
            this.Load += new System.EventHandler(this.CadastroColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).EndInit();
            this.panelCadastroColaborador.ResumeLayout(false);
            this.panelCadastroColaborador.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource fUNCAOBindingSource;
        private System.Windows.Forms.BindingSource fUNCAOBindingSource1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label LblNascimento;
        private System.Windows.Forms.Label LblTipoLogradouro;
        private System.Windows.Forms.Label LblNomeLogradouro;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.TextBox TxtNomeLogradouro;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label LblCEP;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblNome;
        public System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.DateTimePicker DteTimePickerNasc;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.DateTimePicker DteTimePickerCadastro;
        private System.Windows.Forms.Label LblFuncao;
        private System.Windows.Forms.MaskedTextBox MskTelefone;
        private System.Windows.Forms.MaskedTextBox MskCelular;
        private System.Windows.Forms.Label LblUF;
        private System.Windows.Forms.ComboBox CboTipoLogradouro;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.PictureBox PbFoto;
        private System.Windows.Forms.Button BtnEscolherFoto;
        public System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.ComboBox CboUF;
        private System.Windows.Forms.MaskedTextBox MskCEP;
        private System.Windows.Forms.Panel panelCadastroColaborador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LblCadastroColaborador;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.ComboBox CBOFuncao;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.MaskedTextBox MskCPF;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Button BtnSair;
    }
}

