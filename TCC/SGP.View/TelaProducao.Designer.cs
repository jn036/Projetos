namespace SGP.View
{
    partial class TelaProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProducao));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.LblUsuarioConectado = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnMenuAjuste = new System.Windows.Forms.Button();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.BtnMenuSair = new System.Windows.Forms.Button();
            this.BtnMenuProducao = new System.Windows.Forms.Button();
            this.BtnMenuRelatorio = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.PbxFundo = new System.Windows.Forms.PictureBox();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Sienna;
            this.panelCabecalho.Controls.Add(this.LblUsuarioConectado);
            this.panelCabecalho.Controls.Add(this.LblUsuario);
            this.panelCabecalho.Controls.Add(this.LblID);
            this.panelCabecalho.Controls.Add(this.BtnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(800, 40);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCabecalho_Paint_1);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelCabecalho_MouseMove);
            // 
            // LblUsuarioConectado
            // 
            this.LblUsuarioConectado.AutoSize = true;
            this.LblUsuarioConectado.Location = new System.Drawing.Point(55, 9);
            this.LblUsuarioConectado.Name = "LblUsuarioConectado";
            this.LblUsuarioConectado.Size = new System.Drawing.Size(101, 13);
            this.LblUsuarioConectado.TabIndex = 1;
            this.LblUsuarioConectado.Text = "Usuário Conectado:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(162, 9);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Usuário";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(3, 3);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(18, 13);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID";
            this.LblID.Visible = false;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFechar.Image")));
            this.BtnFechar.Location = new System.Drawing.Point(757, 3);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(40, 34);
            this.BtnFechar.TabIndex = 1;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Sienna;
            this.panelMenu.Controls.Add(this.BtnMenuAjuste);
            this.panelMenu.Controls.Add(this.PbxLogo);
            this.panelMenu.Controls.Add(this.BtnMenuSair);
            this.panelMenu.Controls.Add(this.BtnMenuProducao);
            this.panelMenu.Controls.Add(this.BtnMenuRelatorio);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(108, 610);
            this.panelMenu.TabIndex = 1;
            // 
            // BtnMenuAjuste
            // 
            this.BtnMenuAjuste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMenuAjuste.BackgroundImage")));
            this.BtnMenuAjuste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenuAjuste.FlatAppearance.BorderSize = 0;
            this.BtnMenuAjuste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnMenuAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuAjuste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuAjuste.ForeColor = System.Drawing.Color.White;
            this.BtnMenuAjuste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenuAjuste.Location = new System.Drawing.Point(32, 303);
            this.BtnMenuAjuste.Name = "BtnMenuAjuste";
            this.BtnMenuAjuste.Size = new System.Drawing.Size(58, 58);
            this.BtnMenuAjuste.TabIndex = 2;
            this.BtnMenuAjuste.UseVisualStyleBackColor = true;
            this.BtnMenuAjuste.Click += new System.EventHandler(this.BtnMenuAjuste_Click);
            // 
            // PbxLogo
            // 
            this.PbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxLogo.BackgroundImage")));
            this.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbxLogo.ErrorImage = null;
            this.PbxLogo.Location = new System.Drawing.Point(12, 6);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(69, 70);
            this.PbxLogo.TabIndex = 7;
            this.PbxLogo.TabStop = false;
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
            this.BtnMenuSair.Location = new System.Drawing.Point(23, 386);
            this.BtnMenuSair.Name = "BtnMenuSair";
            this.BtnMenuSair.Size = new System.Drawing.Size(67, 60);
            this.BtnMenuSair.TabIndex = 3;
            this.BtnMenuSair.Text = " ";
            this.BtnMenuSair.UseVisualStyleBackColor = true;
            this.BtnMenuSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnMenuProducao
            // 
            this.BtnMenuProducao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMenuProducao.BackgroundImage")));
            this.BtnMenuProducao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenuProducao.FlatAppearance.BorderSize = 0;
            this.BtnMenuProducao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnMenuProducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuProducao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuProducao.ForeColor = System.Drawing.Color.White;
            this.BtnMenuProducao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenuProducao.Location = new System.Drawing.Point(18, 142);
            this.BtnMenuProducao.Name = "BtnMenuProducao";
            this.BtnMenuProducao.Size = new System.Drawing.Size(90, 58);
            this.BtnMenuProducao.TabIndex = 0;
            this.BtnMenuProducao.UseVisualStyleBackColor = true;
            this.BtnMenuProducao.Click += new System.EventHandler(this.BtnMenuProducao_Click);
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
            this.BtnMenuRelatorio.Location = new System.Drawing.Point(32, 222);
            this.BtnMenuRelatorio.Name = "BtnMenuRelatorio";
            this.BtnMenuRelatorio.Size = new System.Drawing.Size(58, 55);
            this.BtnMenuRelatorio.TabIndex = 1;
            this.BtnMenuRelatorio.UseVisualStyleBackColor = true;
            this.BtnMenuRelatorio.Click += new System.EventHandler(this.BtnMenuRelatorio_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelConteudo.Controls.Add(this.PbxFundo);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(108, 40);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(692, 610);
            this.panelConteudo.TabIndex = 2;
            // 
            // PbxFundo
            // 
            this.PbxFundo.BackgroundImage = global::SGP.View.Properties.Resources.usina_caminhao;
            this.PbxFundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxFundo.Location = new System.Drawing.Point(0, 0);
            this.PbxFundo.Name = "PbxFundo";
            this.PbxFundo.Size = new System.Drawing.Size(692, 610);
            this.PbxFundo.TabIndex = 0;
            this.PbxFundo.TabStop = false;
            this.PbxFundo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PbxFundo_MouseClick);
            // 
            // TelaProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "TelaProducao";
            this.Text = "formCadastroClient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.panelConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxFundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BtnMenuProducao;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.PictureBox PbxFundo;
        private System.Windows.Forms.Button BtnMenuSair;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblUsuarioConectado;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnMenuAjuste;
        private System.Windows.Forms.Button BtnMenuRelatorio;
    }
}