namespace SGP.View
{
    partial class TelaADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaADM));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.BtnMaximizar = new System.Windows.Forms.Button();
            this.LblID = new System.Windows.Forms.Label();
            this.LblUsuarioConectado = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnMenuConsultar = new System.Windows.Forms.Button();
            this.BtnMenuSair = new System.Windows.Forms.Button();
            this.BtnMenuPedidos = new System.Windows.Forms.Button();
            this.BtnMenuEstoque = new System.Windows.Forms.Button();
            this.BtnMenuCadastros = new System.Windows.Forms.Button();
            this.BtnMenuRelatorio = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.BtnConsultarReceita = new System.Windows.Forms.Button();
            this.BtnConsultaFornecedor = new System.Windows.Forms.Button();
            this.BtnConsultarCliente = new System.Windows.Forms.Button();
            this.BtnConsultaFrota = new System.Windows.Forms.Button();
            this.BtnConsultaColaborador = new System.Windows.Forms.Button();
            this.panelEstoque = new System.Windows.Forms.Panel();
            this.BtnConsultarEstoque = new System.Windows.Forms.Button();
            this.BtnEntrada = new System.Windows.Forms.Button();
            this.panelRelatorios = new System.Windows.Forms.Panel();
            this.BtnRelProducao = new System.Windows.Forms.Button();
            this.BtnRelPedido = new System.Windows.Forms.Button();
            this.BtnRelEstoque = new System.Windows.Forms.Button();
            this.BtnRelReceita = new System.Windows.Forms.Button();
            this.BtnRelFornecedor = new System.Windows.Forms.Button();
            this.BtnRelCliente = new System.Windows.Forms.Button();
            this.BtnRelFrota = new System.Windows.Forms.Button();
            this.BtnRelColaborador = new System.Windows.Forms.Button();
            this.panelCadastros = new System.Windows.Forms.Panel();
            this.BtnCadastroReceita = new System.Windows.Forms.Button();
            this.BtnCadastroFornecedor = new System.Windows.Forms.Button();
            this.BtnCadastroCliente = new System.Windows.Forms.Button();
            this.BtnCadastroFrota = new System.Windows.Forms.Button();
            this.BtnCadastroColaborador = new System.Windows.Forms.Button();
            this.PbxFundo = new System.Windows.Forms.PictureBox();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.panelConteudo.SuspendLayout();
            this.panelConsulta.SuspendLayout();
            this.panelEstoque.SuspendLayout();
            this.panelRelatorios.SuspendLayout();
            this.panelCadastros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.DarkGray;
            this.panelCabecalho.Controls.Add(this.BtnMaximizar);
            this.panelCabecalho.Controls.Add(this.LblID);
            this.panelCabecalho.Controls.Add(this.LblUsuarioConectado);
            this.panelCabecalho.Controls.Add(this.LblUsuario);
            this.panelCabecalho.Controls.Add(this.BtnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(800, 40);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCabecalho_Paint_1);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelCabecalho_MouseMove);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.BackgroundImage")));
            this.BtnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.Location = new System.Drawing.Point(721, 6);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(40, 34);
            this.BtnMaximizar.TabIndex = 16;
            this.BtnMaximizar.UseVisualStyleBackColor = true;
            this.BtnMaximizar.Visible = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(128, 9);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(18, 13);
            this.LblID.TabIndex = 15;
            this.LblID.Text = "ID";
            this.LblID.Visible = false;
            // 
            // LblUsuarioConectado
            // 
            this.LblUsuarioConectado.AutoSize = true;
            this.LblUsuarioConectado.Location = new System.Drawing.Point(176, 14);
            this.LblUsuarioConectado.Name = "LblUsuarioConectado";
            this.LblUsuarioConectado.Size = new System.Drawing.Size(101, 13);
            this.LblUsuarioConectado.TabIndex = 9;
            this.LblUsuarioConectado.Text = "Usuário Conectado:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(284, 14);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblUsuario.TabIndex = 8;
            this.LblUsuario.Text = "Usuário";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFechar.Image")));
            this.BtnFechar.Location = new System.Drawing.Point(760, 6);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(40, 34);
            this.BtnFechar.TabIndex = 1;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkGray;
            this.panelMenu.Controls.Add(this.PbxLogo);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.BtnMenuConsultar);
            this.panelMenu.Controls.Add(this.BtnMenuSair);
            this.panelMenu.Controls.Add(this.BtnMenuPedidos);
            this.panelMenu.Controls.Add(this.BtnMenuEstoque);
            this.panelMenu.Controls.Add(this.BtnMenuCadastros);
            this.panelMenu.Controls.Add(this.BtnMenuRelatorio);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(125, 610);
            this.panelMenu.TabIndex = 1;
            // 
            // PbxLogo
            // 
            this.PbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxLogo.BackgroundImage")));
            this.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbxLogo.ErrorImage = null;
            this.PbxLogo.Location = new System.Drawing.Point(27, 0);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(72, 51);
            this.PbxLogo.TabIndex = 7;
            this.PbxLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-1, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = " Produção";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnMenuConsultar
            // 
            this.BtnMenuConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMenuConsultar.BackgroundImage")));
            this.BtnMenuConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenuConsultar.FlatAppearance.BorderSize = 0;
            this.BtnMenuConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnMenuConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuConsultar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuConsultar.ForeColor = System.Drawing.Color.White;
            this.BtnMenuConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenuConsultar.Location = new System.Drawing.Point(27, 186);
            this.BtnMenuConsultar.Name = "BtnMenuConsultar";
            this.BtnMenuConsultar.Size = new System.Drawing.Size(60, 60);
            this.BtnMenuConsultar.TabIndex = 10;
            this.BtnMenuConsultar.UseVisualStyleBackColor = true;
            this.BtnMenuConsultar.Click += new System.EventHandler(this.BtnMenuConsultar_Click);
            // 
            // BtnMenuSair
            // 
            this.BtnMenuSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMenuSair.BackgroundImage")));
            this.BtnMenuSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenuSair.FlatAppearance.BorderSize = 0;
            this.BtnMenuSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnMenuSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuSair.ForeColor = System.Drawing.Color.White;
            this.BtnMenuSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenuSair.Location = new System.Drawing.Point(27, 458);
            this.BtnMenuSair.Name = "BtnMenuSair";
            this.BtnMenuSair.Size = new System.Drawing.Size(60, 60);
            this.BtnMenuSair.TabIndex = 6;
            this.BtnMenuSair.UseVisualStyleBackColor = true;
            this.BtnMenuSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnMenuPedidos
            // 
            this.BtnMenuPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMenuPedidos.BackgroundImage")));
            this.BtnMenuPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenuPedidos.FlatAppearance.BorderSize = 0;
            this.BtnMenuPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnMenuPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuPedidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuPedidos.ForeColor = System.Drawing.Color.White;
            this.BtnMenuPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenuPedidos.Location = new System.Drawing.Point(27, 390);
            this.BtnMenuPedidos.Name = "BtnMenuPedidos";
            this.BtnMenuPedidos.Size = new System.Drawing.Size(60, 60);
            this.BtnMenuPedidos.TabIndex = 5;
            this.BtnMenuPedidos.UseVisualStyleBackColor = true;
            this.BtnMenuPedidos.Click += new System.EventHandler(this.BtnMenuPedidos_Click);
            // 
            // BtnMenuEstoque
            // 
            this.BtnMenuEstoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMenuEstoque.BackgroundImage")));
            this.BtnMenuEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenuEstoque.FlatAppearance.BorderSize = 0;
            this.BtnMenuEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnMenuEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuEstoque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuEstoque.ForeColor = System.Drawing.Color.White;
            this.BtnMenuEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenuEstoque.Location = new System.Drawing.Point(27, 328);
            this.BtnMenuEstoque.Name = "BtnMenuEstoque";
            this.BtnMenuEstoque.Size = new System.Drawing.Size(60, 60);
            this.BtnMenuEstoque.TabIndex = 2;
            this.BtnMenuEstoque.UseVisualStyleBackColor = true;
            this.BtnMenuEstoque.Click += new System.EventHandler(this.BtnMenuEstoque_Click);
            // 
            // BtnMenuCadastros
            // 
            this.BtnMenuCadastros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMenuCadastros.BackgroundImage")));
            this.BtnMenuCadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenuCadastros.FlatAppearance.BorderSize = 0;
            this.BtnMenuCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnMenuCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuCadastros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuCadastros.ForeColor = System.Drawing.Color.White;
            this.BtnMenuCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenuCadastros.Location = new System.Drawing.Point(27, 120);
            this.BtnMenuCadastros.Name = "BtnMenuCadastros";
            this.BtnMenuCadastros.Size = new System.Drawing.Size(60, 60);
            this.BtnMenuCadastros.TabIndex = 1;
            this.BtnMenuCadastros.UseVisualStyleBackColor = true;
            this.BtnMenuCadastros.Click += new System.EventHandler(this.BtnMenuCadastros_Click);
            // 
            // BtnMenuRelatorio
            // 
            this.BtnMenuRelatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMenuRelatorio.BackgroundImage")));
            this.BtnMenuRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenuRelatorio.FlatAppearance.BorderSize = 0;
            this.BtnMenuRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnMenuRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuRelatorio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuRelatorio.ForeColor = System.Drawing.Color.White;
            this.BtnMenuRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenuRelatorio.Location = new System.Drawing.Point(27, 257);
            this.BtnMenuRelatorio.Name = "BtnMenuRelatorio";
            this.BtnMenuRelatorio.Size = new System.Drawing.Size(60, 60);
            this.BtnMenuRelatorio.TabIndex = 3;
            this.BtnMenuRelatorio.UseVisualStyleBackColor = true;
            this.BtnMenuRelatorio.Click += new System.EventHandler(this.BtnMenuRelatorio_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelConteudo.Controls.Add(this.panelConsulta);
            this.panelConteudo.Controls.Add(this.panelEstoque);
            this.panelConteudo.Controls.Add(this.panelRelatorios);
            this.panelConteudo.Controls.Add(this.panelCadastros);
            this.panelConteudo.Controls.Add(this.PbxFundo);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(125, 40);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(675, 610);
            this.panelConteudo.TabIndex = 3;
            // 
            // panelConsulta
            // 
            this.panelConsulta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelConsulta.Controls.Add(this.BtnConsultarReceita);
            this.panelConsulta.Controls.Add(this.BtnConsultaFornecedor);
            this.panelConsulta.Controls.Add(this.BtnConsultarCliente);
            this.panelConsulta.Controls.Add(this.BtnConsultaFrota);
            this.panelConsulta.Controls.Add(this.BtnConsultaColaborador);
            this.panelConsulta.Location = new System.Drawing.Point(220, 328);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(200, 245);
            this.panelConsulta.TabIndex = 3;
            this.panelConsulta.Visible = false;
            // 
            // BtnConsultarReceita
            // 
            this.BtnConsultarReceita.FlatAppearance.BorderSize = 0;
            this.BtnConsultarReceita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnConsultarReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarReceita.ForeColor = System.Drawing.Color.White;
            this.BtnConsultarReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarReceita.Location = new System.Drawing.Point(22, 197);
            this.BtnConsultarReceita.Name = "BtnConsultarReceita";
            this.BtnConsultarReceita.Size = new System.Drawing.Size(146, 39);
            this.BtnConsultarReceita.TabIndex = 11;
            this.BtnConsultarReceita.Text = "Receita";
            this.BtnConsultarReceita.UseVisualStyleBackColor = true;
            this.BtnConsultarReceita.Click += new System.EventHandler(this.BtnConsultarReceita_Click);
            // 
            // BtnConsultaFornecedor
            // 
            this.BtnConsultaFornecedor.FlatAppearance.BorderSize = 0;
            this.BtnConsultaFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnConsultaFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnConsultaFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaFornecedor.Location = new System.Drawing.Point(22, 152);
            this.BtnConsultaFornecedor.Name = "BtnConsultaFornecedor";
            this.BtnConsultaFornecedor.Size = new System.Drawing.Size(146, 39);
            this.BtnConsultaFornecedor.TabIndex = 10;
            this.BtnConsultaFornecedor.Text = "Fornecedor";
            this.BtnConsultaFornecedor.UseVisualStyleBackColor = true;
            this.BtnConsultaFornecedor.Click += new System.EventHandler(this.BtnConsultaFornecedor_Click);
            // 
            // BtnConsultarCliente
            // 
            this.BtnConsultarCliente.FlatAppearance.BorderSize = 0;
            this.BtnConsultarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnConsultarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarCliente.Location = new System.Drawing.Point(22, 107);
            this.BtnConsultarCliente.Name = "BtnConsultarCliente";
            this.BtnConsultarCliente.Size = new System.Drawing.Size(146, 39);
            this.BtnConsultarCliente.TabIndex = 9;
            this.BtnConsultarCliente.Text = "Cliente";
            this.BtnConsultarCliente.UseVisualStyleBackColor = true;
            this.BtnConsultarCliente.Click += new System.EventHandler(this.BtnConsultaCliente_Click);
            // 
            // BtnConsultaFrota
            // 
            this.BtnConsultaFrota.FlatAppearance.BorderSize = 0;
            this.BtnConsultaFrota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnConsultaFrota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaFrota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaFrota.ForeColor = System.Drawing.Color.White;
            this.BtnConsultaFrota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaFrota.Location = new System.Drawing.Point(22, 62);
            this.BtnConsultaFrota.Name = "BtnConsultaFrota";
            this.BtnConsultaFrota.Size = new System.Drawing.Size(146, 39);
            this.BtnConsultaFrota.TabIndex = 7;
            this.BtnConsultaFrota.Text = "Frota";
            this.BtnConsultaFrota.UseVisualStyleBackColor = true;
            this.BtnConsultaFrota.Click += new System.EventHandler(this.BtnConsultaFrota_Click);
            // 
            // BtnConsultaColaborador
            // 
            this.BtnConsultaColaborador.FlatAppearance.BorderSize = 0;
            this.BtnConsultaColaborador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnConsultaColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaColaborador.ForeColor = System.Drawing.Color.White;
            this.BtnConsultaColaborador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaColaborador.Location = new System.Drawing.Point(22, 17);
            this.BtnConsultaColaborador.Name = "BtnConsultaColaborador";
            this.BtnConsultaColaborador.Size = new System.Drawing.Size(146, 39);
            this.BtnConsultaColaborador.TabIndex = 6;
            this.BtnConsultaColaborador.Text = "Colaborador";
            this.BtnConsultaColaborador.UseVisualStyleBackColor = true;
            this.BtnConsultaColaborador.Click += new System.EventHandler(this.BtnConsultaColaborador_Click);
            // 
            // panelEstoque
            // 
            this.panelEstoque.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelEstoque.Controls.Add(this.BtnConsultarEstoque);
            this.panelEstoque.Controls.Add(this.BtnEntrada);
            this.panelEstoque.Location = new System.Drawing.Point(0, 206);
            this.panelEstoque.Name = "panelEstoque";
            this.panelEstoque.Size = new System.Drawing.Size(200, 129);
            this.panelEstoque.TabIndex = 2;
            this.panelEstoque.Visible = false;
            // 
            // BtnConsultarEstoque
            // 
            this.BtnConsultarEstoque.FlatAppearance.BorderSize = 0;
            this.BtnConsultarEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnConsultarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarEstoque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarEstoque.ForeColor = System.Drawing.Color.White;
            this.BtnConsultarEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarEstoque.Location = new System.Drawing.Point(22, 62);
            this.BtnConsultarEstoque.Name = "BtnConsultarEstoque";
            this.BtnConsultarEstoque.Size = new System.Drawing.Size(146, 39);
            this.BtnConsultarEstoque.TabIndex = 7;
            this.BtnConsultarEstoque.Text = "Consulta";
            this.BtnConsultarEstoque.UseVisualStyleBackColor = true;
            this.BtnConsultarEstoque.Click += new System.EventHandler(this.BtnConsultarEstoque_Click);
            // 
            // BtnEntrada
            // 
            this.BtnEntrada.FlatAppearance.BorderSize = 0;
            this.BtnEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrada.ForeColor = System.Drawing.Color.White;
            this.BtnEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEntrada.Location = new System.Drawing.Point(22, 17);
            this.BtnEntrada.Name = "BtnEntrada";
            this.BtnEntrada.Size = new System.Drawing.Size(146, 39);
            this.BtnEntrada.TabIndex = 6;
            this.BtnEntrada.Text = "Entrada";
            this.BtnEntrada.UseVisualStyleBackColor = true;
            this.BtnEntrada.Click += new System.EventHandler(this.BtnEntrada_Click);
            // 
            // panelRelatorios
            // 
            this.panelRelatorios.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelRelatorios.Controls.Add(this.BtnRelProducao);
            this.panelRelatorios.Controls.Add(this.BtnRelPedido);
            this.panelRelatorios.Controls.Add(this.BtnRelEstoque);
            this.panelRelatorios.Controls.Add(this.BtnRelReceita);
            this.panelRelatorios.Controls.Add(this.BtnRelFornecedor);
            this.panelRelatorios.Controls.Add(this.BtnRelCliente);
            this.panelRelatorios.Controls.Add(this.BtnRelFrota);
            this.panelRelatorios.Controls.Add(this.BtnRelColaborador);
            this.panelRelatorios.Location = new System.Drawing.Point(439, 100);
            this.panelRelatorios.Name = "panelRelatorios";
            this.panelRelatorios.Size = new System.Drawing.Size(197, 396);
            this.panelRelatorios.TabIndex = 1;
            this.panelRelatorios.Visible = false;
            // 
            // BtnRelProducao
            // 
            this.BtnRelProducao.FlatAppearance.BorderSize = 0;
            this.BtnRelProducao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnRelProducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelProducao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelProducao.ForeColor = System.Drawing.Color.White;
            this.BtnRelProducao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelProducao.Location = new System.Drawing.Point(22, 338);
            this.BtnRelProducao.Name = "BtnRelProducao";
            this.BtnRelProducao.Size = new System.Drawing.Size(146, 39);
            this.BtnRelProducao.TabIndex = 11;
            this.BtnRelProducao.Text = " Produção";
            this.BtnRelProducao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRelProducao.UseVisualStyleBackColor = true;
            this.BtnRelProducao.Click += new System.EventHandler(this.BtnRelProducao_Click);
            // 
            // BtnRelPedido
            // 
            this.BtnRelPedido.FlatAppearance.BorderSize = 0;
            this.BtnRelPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnRelPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelPedido.ForeColor = System.Drawing.Color.White;
            this.BtnRelPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelPedido.Location = new System.Drawing.Point(22, 293);
            this.BtnRelPedido.Name = "BtnRelPedido";
            this.BtnRelPedido.Size = new System.Drawing.Size(146, 39);
            this.BtnRelPedido.TabIndex = 11;
            this.BtnRelPedido.Text = "Pedido";
            this.BtnRelPedido.UseVisualStyleBackColor = true;
            this.BtnRelPedido.Click += new System.EventHandler(this.BtnRelPedido_Click);
            // 
            // BtnRelEstoque
            // 
            this.BtnRelEstoque.FlatAppearance.BorderSize = 0;
            this.BtnRelEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnRelEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelEstoque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelEstoque.ForeColor = System.Drawing.Color.White;
            this.BtnRelEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelEstoque.Location = new System.Drawing.Point(22, 242);
            this.BtnRelEstoque.Name = "BtnRelEstoque";
            this.BtnRelEstoque.Size = new System.Drawing.Size(146, 39);
            this.BtnRelEstoque.TabIndex = 11;
            this.BtnRelEstoque.Text = "Estoque";
            this.BtnRelEstoque.UseVisualStyleBackColor = true;
            this.BtnRelEstoque.Click += new System.EventHandler(this.BtnRelEstoque_Click);
            // 
            // BtnRelReceita
            // 
            this.BtnRelReceita.FlatAppearance.BorderSize = 0;
            this.BtnRelReceita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnRelReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelReceita.ForeColor = System.Drawing.Color.White;
            this.BtnRelReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelReceita.Location = new System.Drawing.Point(22, 197);
            this.BtnRelReceita.Name = "BtnRelReceita";
            this.BtnRelReceita.Size = new System.Drawing.Size(146, 39);
            this.BtnRelReceita.TabIndex = 11;
            this.BtnRelReceita.Text = "Receita";
            this.BtnRelReceita.UseVisualStyleBackColor = true;
            this.BtnRelReceita.Click += new System.EventHandler(this.BtnRelReceita_Click);
            // 
            // BtnRelFornecedor
            // 
            this.BtnRelFornecedor.FlatAppearance.BorderSize = 0;
            this.BtnRelFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnRelFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnRelFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelFornecedor.Location = new System.Drawing.Point(22, 152);
            this.BtnRelFornecedor.Name = "BtnRelFornecedor";
            this.BtnRelFornecedor.Size = new System.Drawing.Size(146, 39);
            this.BtnRelFornecedor.TabIndex = 10;
            this.BtnRelFornecedor.Text = "Fornecedor";
            this.BtnRelFornecedor.UseVisualStyleBackColor = true;
            this.BtnRelFornecedor.Click += new System.EventHandler(this.BtnRelFornecedor_Click);
            // 
            // BtnRelCliente
            // 
            this.BtnRelCliente.FlatAppearance.BorderSize = 0;
            this.BtnRelCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnRelCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelCliente.ForeColor = System.Drawing.Color.White;
            this.BtnRelCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelCliente.Location = new System.Drawing.Point(22, 107);
            this.BtnRelCliente.Name = "BtnRelCliente";
            this.BtnRelCliente.Size = new System.Drawing.Size(146, 39);
            this.BtnRelCliente.TabIndex = 9;
            this.BtnRelCliente.Text = "Cliente";
            this.BtnRelCliente.UseVisualStyleBackColor = true;
            this.BtnRelCliente.Click += new System.EventHandler(this.BtnRelCliente_Click);
            // 
            // BtnRelFrota
            // 
            this.BtnRelFrota.FlatAppearance.BorderSize = 0;
            this.BtnRelFrota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnRelFrota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelFrota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelFrota.ForeColor = System.Drawing.Color.White;
            this.BtnRelFrota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelFrota.Location = new System.Drawing.Point(22, 62);
            this.BtnRelFrota.Name = "BtnRelFrota";
            this.BtnRelFrota.Size = new System.Drawing.Size(146, 39);
            this.BtnRelFrota.TabIndex = 7;
            this.BtnRelFrota.Text = "Frota";
            this.BtnRelFrota.UseVisualStyleBackColor = true;
            this.BtnRelFrota.Click += new System.EventHandler(this.BtnRelFrota_Click);
            // 
            // BtnRelColaborador
            // 
            this.BtnRelColaborador.FlatAppearance.BorderSize = 0;
            this.BtnRelColaborador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnRelColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelColaborador.ForeColor = System.Drawing.Color.White;
            this.BtnRelColaborador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelColaborador.Location = new System.Drawing.Point(22, 17);
            this.BtnRelColaborador.Name = "BtnRelColaborador";
            this.BtnRelColaborador.Size = new System.Drawing.Size(146, 39);
            this.BtnRelColaborador.TabIndex = 6;
            this.BtnRelColaborador.Text = "Colaborador";
            this.BtnRelColaborador.UseVisualStyleBackColor = true;
            this.BtnRelColaborador.Click += new System.EventHandler(this.BtnRelColaborador_Click);
            // 
            // panelCadastros
            // 
            this.panelCadastros.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCadastros.Controls.Add(this.BtnCadastroReceita);
            this.panelCadastros.Controls.Add(this.BtnCadastroFornecedor);
            this.panelCadastros.Controls.Add(this.BtnCadastroCliente);
            this.panelCadastros.Controls.Add(this.BtnCadastroFrota);
            this.panelCadastros.Controls.Add(this.BtnCadastroColaborador);
            this.panelCadastros.Location = new System.Drawing.Point(220, 20);
            this.panelCadastros.Name = "panelCadastros";
            this.panelCadastros.Size = new System.Drawing.Size(200, 242);
            this.panelCadastros.TabIndex = 1;
            this.panelCadastros.Visible = false;
            // 
            // BtnCadastroReceita
            // 
            this.BtnCadastroReceita.FlatAppearance.BorderSize = 0;
            this.BtnCadastroReceita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnCadastroReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastroReceita.ForeColor = System.Drawing.Color.White;
            this.BtnCadastroReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastroReceita.Location = new System.Drawing.Point(22, 197);
            this.BtnCadastroReceita.Name = "BtnCadastroReceita";
            this.BtnCadastroReceita.Size = new System.Drawing.Size(146, 39);
            this.BtnCadastroReceita.TabIndex = 11;
            this.BtnCadastroReceita.Text = "Receita";
            this.BtnCadastroReceita.UseVisualStyleBackColor = true;
            this.BtnCadastroReceita.Click += new System.EventHandler(this.BtnReceita_Click);
            // 
            // BtnCadastroFornecedor
            // 
            this.BtnCadastroFornecedor.FlatAppearance.BorderSize = 0;
            this.BtnCadastroFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnCadastroFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastroFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnCadastroFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastroFornecedor.Location = new System.Drawing.Point(22, 152);
            this.BtnCadastroFornecedor.Name = "BtnCadastroFornecedor";
            this.BtnCadastroFornecedor.Size = new System.Drawing.Size(146, 39);
            this.BtnCadastroFornecedor.TabIndex = 10;
            this.BtnCadastroFornecedor.Text = "Fornecedor";
            this.BtnCadastroFornecedor.UseVisualStyleBackColor = true;
            this.BtnCadastroFornecedor.Click += new System.EventHandler(this.BtnFornecedor_Click);
            // 
            // BtnCadastroCliente
            // 
            this.BtnCadastroCliente.FlatAppearance.BorderSize = 0;
            this.BtnCadastroCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastroCliente.ForeColor = System.Drawing.Color.White;
            this.BtnCadastroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastroCliente.Location = new System.Drawing.Point(22, 107);
            this.BtnCadastroCliente.Name = "BtnCadastroCliente";
            this.BtnCadastroCliente.Size = new System.Drawing.Size(146, 39);
            this.BtnCadastroCliente.TabIndex = 9;
            this.BtnCadastroCliente.Text = "Cliente";
            this.BtnCadastroCliente.UseVisualStyleBackColor = true;
            this.BtnCadastroCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnCadastroFrota
            // 
            this.BtnCadastroFrota.FlatAppearance.BorderSize = 0;
            this.BtnCadastroFrota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnCadastroFrota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroFrota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastroFrota.ForeColor = System.Drawing.Color.White;
            this.BtnCadastroFrota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastroFrota.Location = new System.Drawing.Point(22, 62);
            this.BtnCadastroFrota.Name = "BtnCadastroFrota";
            this.BtnCadastroFrota.Size = new System.Drawing.Size(146, 39);
            this.BtnCadastroFrota.TabIndex = 7;
            this.BtnCadastroFrota.Text = "Frota";
            this.BtnCadastroFrota.UseVisualStyleBackColor = true;
            this.BtnCadastroFrota.Click += new System.EventHandler(this.BtnFrota_Click);
            // 
            // BtnCadastroColaborador
            // 
            this.BtnCadastroColaborador.FlatAppearance.BorderSize = 0;
            this.BtnCadastroColaborador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnCadastroColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastroColaborador.ForeColor = System.Drawing.Color.White;
            this.BtnCadastroColaborador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastroColaborador.Location = new System.Drawing.Point(22, 17);
            this.BtnCadastroColaborador.Name = "BtnCadastroColaborador";
            this.BtnCadastroColaborador.Size = new System.Drawing.Size(146, 39);
            this.BtnCadastroColaborador.TabIndex = 6;
            this.BtnCadastroColaborador.Text = "Colaborador";
            this.BtnCadastroColaborador.UseVisualStyleBackColor = true;
            this.BtnCadastroColaborador.Click += new System.EventHandler(this.BtnColaborador_Click);
            // 
            // PbxFundo
            // 
            this.PbxFundo.BackgroundImage = global::SGP.View.Properties.Resources.usina;
            this.PbxFundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxFundo.Location = new System.Drawing.Point(0, 0);
            this.PbxFundo.Name = "PbxFundo";
            this.PbxFundo.Size = new System.Drawing.Size(675, 610);
            this.PbxFundo.TabIndex = 0;
            this.PbxFundo.TabStop = false;
            this.PbxFundo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PbxFundo_MouseClick);
            // 
            // TelaADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "TelaADM";
            this.Text = "formCadastroClient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaADM_Load);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.panelConteudo.ResumeLayout(false);
            this.panelConsulta.ResumeLayout(false);
            this.panelEstoque.ResumeLayout(false);
            this.panelRelatorios.ResumeLayout(false);
            this.panelCadastros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxFundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BtnMenuCadastros;
        private System.Windows.Forms.Button BtnMenuEstoque;
        private System.Windows.Forms.Button BtnMenuRelatorio;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.PictureBox PbxFundo;
        private System.Windows.Forms.Button BtnMenuPedidos;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Label LblUsuarioConectado;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnMenuConsultar;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelConsulta;
        private System.Windows.Forms.Button BtnConsultarReceita;
        private System.Windows.Forms.Button BtnConsultaFornecedor;
        private System.Windows.Forms.Button BtnConsultarCliente;
        private System.Windows.Forms.Button BtnConsultaFrota;
        private System.Windows.Forms.Button BtnConsultaColaborador;
        private System.Windows.Forms.Panel panelEstoque;
        private System.Windows.Forms.Button BtnConsultarEstoque;
        private System.Windows.Forms.Button BtnEntrada;
        private System.Windows.Forms.Panel panelRelatorios;
        private System.Windows.Forms.Button BtnRelProducao;
        private System.Windows.Forms.Button BtnRelPedido;
        private System.Windows.Forms.Button BtnRelEstoque;
        private System.Windows.Forms.Button BtnRelReceita;
        private System.Windows.Forms.Button BtnRelFornecedor;
        private System.Windows.Forms.Button BtnRelCliente;
        private System.Windows.Forms.Button BtnRelFrota;
        private System.Windows.Forms.Button BtnRelColaborador;
        private System.Windows.Forms.Panel panelCadastros;
        private System.Windows.Forms.Button BtnCadastroReceita;
        private System.Windows.Forms.Button BtnCadastroFornecedor;
        private System.Windows.Forms.Button BtnCadastroCliente;
        private System.Windows.Forms.Button BtnCadastroFrota;
        private System.Windows.Forms.Button BtnCadastroColaborador;
        private System.Windows.Forms.Button BtnMenuSair;
        private System.Windows.Forms.Button BtnMaximizar;
    }
}