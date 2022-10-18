namespace SGP.View
{
    partial class FormularioEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEntrada));
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblEntrada = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtFunçao = new System.Windows.Forms.TextBox();
            this.LblFunçao = new System.Windows.Forms.Label();
            this.LblColaborador = new System.Windows.Forms.Label();
            this.TxtColaborador = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PbFornecedor = new System.Windows.Forms.PictureBox();
            this.CboFornecedor = new System.Windows.Forms.ComboBox();
            this.MskCelular = new System.Windows.Forms.MaskedTextBox();
            this.MskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.LblFornecedor = new System.Windows.Forms.Label();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LblQtdAditivo = new System.Windows.Forms.Label();
            this.LblQtdCimento = new System.Windows.Forms.Label();
            this.LblQtdBrita1 = new System.Windows.Forms.Label();
            this.LblQtdBrita0 = new System.Windows.Forms.Label();
            this.LblQtdAreia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAreia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelEntrada = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtQtd = new System.Windows.Forms.TextBox();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.CboProduto = new System.Windows.Forms.ComboBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtNF = new System.Windows.Forms.TextBox();
            this.LblDataEntrada = new System.Windows.Forms.Label();
            this.DteTimePickerDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.LblNF = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFornecedor)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panelEntrada.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.BackgroundImage")));
            this.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalvar.Font = new System.Drawing.Font("Arial", 12F);
            this.BtnSalvar.Location = new System.Drawing.Point(860, 6);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(40, 35);
            this.BtnSalvar.TabIndex = 3;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.Font = new System.Drawing.Font("Arial", 12F);
            this.BtnSair.Location = new System.Drawing.Point(906, 6);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(40, 35);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblEntrada
            // 
            this.LblEntrada.AutoSize = true;
            this.LblEntrada.Font = new System.Drawing.Font("Arial", 12F);
            this.LblEntrada.Location = new System.Drawing.Point(14, 16);
            this.LblEntrada.Name = "LblEntrada";
            this.LblEntrada.Size = new System.Drawing.Size(218, 18);
            this.LblEntrada.TabIndex = 383;
            this.LblEntrada.Text = "FORMULÁRIO DE ENTRADA";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.TxtFunçao);
            this.groupBox1.Controls.Add(this.LblFunçao);
            this.groupBox1.Controls.Add(this.LblColaborador);
            this.groupBox1.Controls.Add(this.TxtColaborador);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox1.Location = new System.Drawing.Point(17, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TxtFunçao
            // 
            this.TxtFunçao.Location = new System.Drawing.Point(160, 72);
            this.TxtFunçao.Name = "TxtFunçao";
            this.TxtFunçao.Size = new System.Drawing.Size(123, 26);
            this.TxtFunçao.TabIndex = 3;
            // 
            // LblFunçao
            // 
            this.LblFunçao.AutoSize = true;
            this.LblFunçao.Location = new System.Drawing.Point(60, 72);
            this.LblFunçao.Name = "LblFunçao";
            this.LblFunçao.Size = new System.Drawing.Size(60, 18);
            this.LblFunçao.TabIndex = 2;
            this.LblFunçao.Text = "Função";
            // 
            // LblColaborador
            // 
            this.LblColaborador.AutoSize = true;
            this.LblColaborador.Font = new System.Drawing.Font("Arial", 12F);
            this.LblColaborador.Location = new System.Drawing.Point(39, 38);
            this.LblColaborador.Name = "LblColaborador";
            this.LblColaborador.Size = new System.Drawing.Size(96, 18);
            this.LblColaborador.TabIndex = 0;
            this.LblColaborador.Text = "Coladorador";
            // 
            // TxtColaborador
            // 
            this.TxtColaborador.Location = new System.Drawing.Point(160, 35);
            this.TxtColaborador.Name = "TxtColaborador";
            this.TxtColaborador.Size = new System.Drawing.Size(484, 26);
            this.TxtColaborador.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.PbFornecedor);
            this.groupBox2.Controls.Add(this.CboFornecedor);
            this.groupBox2.Controls.Add(this.MskCelular);
            this.groupBox2.Controls.Add(this.MskTelefone);
            this.groupBox2.Controls.Add(this.LblFornecedor);
            this.groupBox2.Controls.Add(this.LblCelular);
            this.groupBox2.Controls.Add(this.LblTelefone);
            this.groupBox2.Controls.Add(this.TxtCidade);
            this.groupBox2.Controls.Add(this.LblCidade);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox2.Location = new System.Drawing.Point(16, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(941, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // PbFornecedor
            // 
            this.PbFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("PbFornecedor.Image")));
            this.PbFornecedor.Location = new System.Drawing.Point(786, 25);
            this.PbFornecedor.Name = "PbFornecedor";
            this.PbFornecedor.Size = new System.Drawing.Size(123, 103);
            this.PbFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFornecedor.TabIndex = 388;
            this.PbFornecedor.TabStop = false;
            // 
            // CboFornecedor
            // 
            this.CboFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboFornecedor.DisplayMember = "Funcao";
            this.CboFornecedor.FormattingEnabled = true;
            this.CboFornecedor.Location = new System.Drawing.Point(160, 30);
            this.CboFornecedor.Name = "CboFornecedor";
            this.CboFornecedor.Size = new System.Drawing.Size(579, 26);
            this.CboFornecedor.TabIndex = 2;
            this.CboFornecedor.TextChanged += new System.EventHandler(this.CboFornecedor_TextChanged);
            // 
            // MskCelular
            // 
            this.MskCelular.Location = new System.Drawing.Point(394, 105);
            this.MskCelular.Mask = "(99)00000-0000";
            this.MskCelular.Name = "MskCelular";
            this.MskCelular.Size = new System.Drawing.Size(130, 26);
            this.MskCelular.TabIndex = 7;
            // 
            // MskTelefone
            // 
            this.MskTelefone.Location = new System.Drawing.Point(160, 110);
            this.MskTelefone.Mask = "(99)0000-0000";
            this.MskTelefone.Name = "MskTelefone";
            this.MskTelefone.Size = new System.Drawing.Size(114, 26);
            this.MskTelefone.TabIndex = 6;
            // 
            // LblFornecedor
            // 
            this.LblFornecedor.AutoSize = true;
            this.LblFornecedor.Location = new System.Drawing.Point(32, 33);
            this.LblFornecedor.Name = "LblFornecedor";
            this.LblFornecedor.Size = new System.Drawing.Size(89, 18);
            this.LblFornecedor.TabIndex = 1;
            this.LblFornecedor.Text = "Fornecedor";
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Location = new System.Drawing.Point(310, 113);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(57, 18);
            this.LblCelular.TabIndex = 7;
            this.LblCelular.Text = "Celular";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(51, 113);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(66, 18);
            this.LblTelefone.TabIndex = 5;
            this.LblTelefone.Text = "Telefone";
            // 
            // TxtCidade
            // 
            this.TxtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCidade.Location = new System.Drawing.Point(160, 70);
            this.TxtCidade.MaxLength = 100;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(579, 26);
            this.TxtCidade.TabIndex = 4;
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Location = new System.Drawing.Point(57, 73);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(60, 18);
            this.LblCidade.TabIndex = 3;
            this.LblCidade.Text = "Cidade";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox4.Controls.Add(this.LblQtdAditivo);
            this.groupBox4.Controls.Add(this.LblQtdCimento);
            this.groupBox4.Controls.Add(this.LblQtdBrita1);
            this.groupBox4.Controls.Add(this.LblQtdBrita0);
            this.groupBox4.Controls.Add(this.LblQtdAreia);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.LblAreia);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox4.Location = new System.Drawing.Point(16, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(941, 130);
            this.groupBox4.TabIndex = 384;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estoque Real";
            // 
            // LblQtdAditivo
            // 
            this.LblQtdAditivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblQtdAditivo.AutoSize = true;
            this.LblQtdAditivo.BackColor = System.Drawing.Color.White;
            this.LblQtdAditivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblQtdAditivo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtdAditivo.Location = new System.Drawing.Point(755, 74);
            this.LblQtdAditivo.Name = "LblQtdAditivo";
            this.LblQtdAditivo.Size = new System.Drawing.Size(89, 24);
            this.LblQtdAditivo.TabIndex = 21;
            this.LblQtdAditivo.Text = "0000000";
            // 
            // LblQtdCimento
            // 
            this.LblQtdCimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblQtdCimento.AutoSize = true;
            this.LblQtdCimento.BackColor = System.Drawing.Color.White;
            this.LblQtdCimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblQtdCimento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtdCimento.Location = new System.Drawing.Point(567, 74);
            this.LblQtdCimento.Name = "LblQtdCimento";
            this.LblQtdCimento.Size = new System.Drawing.Size(89, 24);
            this.LblQtdCimento.TabIndex = 21;
            this.LblQtdCimento.Text = "0000000";
            // 
            // LblQtdBrita1
            // 
            this.LblQtdBrita1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblQtdBrita1.AutoSize = true;
            this.LblQtdBrita1.BackColor = System.Drawing.Color.White;
            this.LblQtdBrita1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblQtdBrita1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtdBrita1.Location = new System.Drawing.Point(400, 74);
            this.LblQtdBrita1.Name = "LblQtdBrita1";
            this.LblQtdBrita1.Size = new System.Drawing.Size(89, 24);
            this.LblQtdBrita1.TabIndex = 21;
            this.LblQtdBrita1.Text = "0000000";
            // 
            // LblQtdBrita0
            // 
            this.LblQtdBrita0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblQtdBrita0.AutoSize = true;
            this.LblQtdBrita0.BackColor = System.Drawing.Color.White;
            this.LblQtdBrita0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblQtdBrita0.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtdBrita0.Location = new System.Drawing.Point(243, 74);
            this.LblQtdBrita0.Name = "LblQtdBrita0";
            this.LblQtdBrita0.Size = new System.Drawing.Size(89, 24);
            this.LblQtdBrita0.TabIndex = 21;
            this.LblQtdBrita0.Text = "0000000";
            // 
            // LblQtdAreia
            // 
            this.LblQtdAreia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblQtdAreia.AutoSize = true;
            this.LblQtdAreia.BackColor = System.Drawing.Color.White;
            this.LblQtdAreia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblQtdAreia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtdAreia.Location = new System.Drawing.Point(63, 74);
            this.LblQtdAreia.Name = "LblQtdAreia";
            this.LblQtdAreia.Size = new System.Drawing.Size(89, 24);
            this.LblQtdAreia.TabIndex = 20;
            this.LblQtdAreia.Text = "0000000";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(751, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Aditivo - KG";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cimento - KG";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Brita 0 - KG";
            // 
            // LblAreia
            // 
            this.LblAreia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblAreia.AutoSize = true;
            this.LblAreia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAreia.Location = new System.Drawing.Point(60, 47);
            this.LblAreia.Name = "LblAreia";
            this.LblAreia.Size = new System.Drawing.Size(98, 22);
            this.LblAreia.TabIndex = 18;
            this.LblAreia.Text = "Areia - KG";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Brita 1 - KG";
            // 
            // panelEntrada
            // 
            this.panelEntrada.Controls.Add(this.groupBox4);
            this.panelEntrada.Controls.Add(this.groupBox3);
            this.panelEntrada.Controls.Add(this.groupBox2);
            this.panelEntrada.Controls.Add(this.groupBox1);
            this.panelEntrada.Controls.Add(this.LblEntrada);
            this.panelEntrada.Controls.Add(this.BtnSair);
            this.panelEntrada.Controls.Add(this.BtnSalvar);
            this.panelEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEntrada.Location = new System.Drawing.Point(0, 0);
            this.panelEntrada.Name = "panelEntrada";
            this.panelEntrada.Size = new System.Drawing.Size(972, 788);
            this.panelEntrada.TabIndex = 0;
            this.panelEntrada.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEntrada_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtQtd);
            this.groupBox3.Controls.Add(this.LblQuantidade);
            this.groupBox3.Controls.Add(this.CboProduto);
            this.groupBox3.Controls.Add(this.LblSenha);
            this.groupBox3.Controls.Add(this.LblID);
            this.groupBox3.Controls.Add(this.TxtID);
            this.groupBox3.Controls.Add(this.TxtNF);
            this.groupBox3.Controls.Add(this.LblDataEntrada);
            this.groupBox3.Controls.Add(this.DteTimePickerDataEntrada);
            this.groupBox3.Controls.Add(this.LblNF);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox3.Location = new System.Drawing.Point(17, 571);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(943, 136);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(858, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "KG";
            // 
            // TxtQtd
            // 
            this.TxtQtd.Location = new System.Drawing.Point(626, 68);
            this.TxtQtd.MaxLength = 50;
            this.TxtQtd.Name = "TxtQtd";
            this.TxtQtd.Size = new System.Drawing.Size(226, 26);
            this.TxtQtd.TabIndex = 10;
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Location = new System.Drawing.Point(531, 71);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(89, 18);
            this.LblQuantidade.TabIndex = 9;
            this.LblQuantidade.Text = "Quantidade";
            // 
            // CboProduto
            // 
            this.CboProduto.DisplayMember = "Funcao";
            this.CboProduto.FormattingEnabled = true;
            this.CboProduto.Items.AddRange(new object[] {
            "Areia",
            "Brita 0",
            "Brita 1",
            "Cimento",
            "Aditivo"});
            this.CboProduto.Location = new System.Drawing.Point(626, 25);
            this.CboProduto.Name = "CboProduto";
            this.CboProduto.Size = new System.Drawing.Size(226, 26);
            this.CboProduto.TabIndex = 6;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(557, 28);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(63, 18);
            this.LblSenha.TabIndex = 5;
            this.LblSenha.Text = "Produto";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(304, 31);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(23, 18);
            this.LblID.TabIndex = 1;
            this.LblID.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(366, 25);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 26);
            this.TxtID.TabIndex = 2;
            // 
            // TxtNF
            // 
            this.TxtNF.Location = new System.Drawing.Point(160, 65);
            this.TxtNF.MaxLength = 50;
            this.TxtNF.Name = "TxtNF";
            this.TxtNF.Size = new System.Drawing.Size(147, 26);
            this.TxtNF.TabIndex = 8;
            // 
            // LblDataEntrada
            // 
            this.LblDataEntrada.AutoSize = true;
            this.LblDataEntrada.Location = new System.Drawing.Point(79, 35);
            this.LblDataEntrada.Name = "LblDataEntrada";
            this.LblDataEntrada.Size = new System.Drawing.Size(42, 18);
            this.LblDataEntrada.TabIndex = 11;
            this.LblDataEntrada.Text = "Data";
            // 
            // DteTimePickerDataEntrada
            // 
            this.DteTimePickerDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerDataEntrada.Location = new System.Drawing.Point(160, 25);
            this.DteTimePickerDataEntrada.Name = "DteTimePickerDataEntrada";
            this.DteTimePickerDataEntrada.Size = new System.Drawing.Size(100, 26);
            this.DteTimePickerDataEntrada.TabIndex = 11;
            this.DteTimePickerDataEntrada.Value = new System.DateTime(2019, 3, 21, 0, 0, 0, 0);
            // 
            // LblNF
            // 
            this.LblNF.AutoSize = true;
            this.LblNF.Location = new System.Drawing.Point(34, 71);
            this.LblNF.Name = "LblNF";
            this.LblNF.Size = new System.Drawing.Size(87, 18);
            this.LblNF.TabIndex = 7;
            this.LblNF.Text = "Nota Fiscal";
            // 
            // FormularioEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 788);
            this.Controls.Add(this.panelEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioEntrada";
            this.Text = "Entrada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioEntrada_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFornecedor)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelEntrada.ResumeLayout(false);
            this.panelEntrada.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblEntrada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtFunçao;
        public System.Windows.Forms.Label LblFunçao;
        private System.Windows.Forms.Label LblColaborador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox PbFornecedor;
        private System.Windows.Forms.ComboBox CboFornecedor;
        private System.Windows.Forms.MaskedTextBox MskCelular;
        private System.Windows.Forms.MaskedTextBox MskTelefone;
        private System.Windows.Forms.Label LblFornecedor;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label LblQtdAditivo;
        private System.Windows.Forms.Label LblQtdCimento;
        private System.Windows.Forms.Label LblQtdBrita1;
        private System.Windows.Forms.Label LblQtdBrita0;
        private System.Windows.Forms.Label LblQtdAreia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAreia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelEntrada;
        private System.Windows.Forms.TextBox TxtColaborador;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtQtd;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.ComboBox CboProduto;
        private System.Windows.Forms.Label LblSenha;
        public System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtID;
        public System.Windows.Forms.TextBox TxtNF;
        private System.Windows.Forms.Label LblDataEntrada;
        private System.Windows.Forms.DateTimePicker DteTimePickerDataEntrada;
        private System.Windows.Forms.Label LblNF;
    }
}