namespace SGP.View
{
    partial class ConsultarColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarColaborador));
            this.panelConsultaColaborador = new System.Windows.Forms.Panel();
            this.LblCadastroColaborador = new System.Windows.Forms.Label();
            this.GrdUsuario = new System.Windows.Forms.DataGridView();
            this.BtnSelecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLogradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOLABORADORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usinaDataSetColaborador = new SGP.View.UsinaDataSetColaborador();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TxtPesquisarUsuario = new System.Windows.Forms.TextBox();
            this.LblColaborador = new System.Windows.Forms.Label();
            this.cOLABORADORTableAdapter = new SGP.View.UsinaDataSetColaboradorTableAdapters.COLABORADORTableAdapter();
            this.panelConsultaColaborador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOLABORADORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usinaDataSetColaborador)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultaColaborador
            // 
            this.panelConsultaColaborador.Controls.Add(this.LblCadastroColaborador);
            this.panelConsultaColaborador.Controls.Add(this.GrdUsuario);
            this.panelConsultaColaborador.Controls.Add(this.BtnSair);
            this.panelConsultaColaborador.Controls.Add(this.TxtPesquisarUsuario);
            this.panelConsultaColaborador.Controls.Add(this.LblColaborador);
            this.panelConsultaColaborador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsultaColaborador.Location = new System.Drawing.Point(0, 0);
            this.panelConsultaColaborador.Name = "panelConsultaColaborador";
            this.panelConsultaColaborador.Size = new System.Drawing.Size(942, 632);
            this.panelConsultaColaborador.TabIndex = 0;
            // 
            // LblCadastroColaborador
            // 
            this.LblCadastroColaborador.AutoSize = true;
            this.LblCadastroColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastroColaborador.Location = new System.Drawing.Point(13, 26);
            this.LblCadastroColaborador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCadastroColaborador.Name = "LblCadastroColaborador";
            this.LblCadastroColaborador.Size = new System.Drawing.Size(236, 20);
            this.LblCadastroColaborador.TabIndex = 396;
            this.LblCadastroColaborador.Text = "CONSULTAR COLABORADOR";
            // 
            // GrdUsuario
            // 
            this.GrdUsuario.AllowUserToAddRows = false;
            this.GrdUsuario.AllowUserToDeleteRows = false;
            this.GrdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdUsuario.AutoGenerateColumns = false;
            this.GrdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSelecionar,
            this.nomeDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.nomeLogradouroDataGridViewTextBoxColumn});
            this.GrdUsuario.DataSource = this.cOLABORADORBindingSource;
            this.GrdUsuario.Location = new System.Drawing.Point(13, 106);
            this.GrdUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.GrdUsuario.Name = "GrdUsuario";
            this.GrdUsuario.ReadOnly = true;
            this.GrdUsuario.RowHeadersVisible = false;
            this.GrdUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GrdUsuario.Size = new System.Drawing.Size(916, 515);
            this.GrdUsuario.TabIndex = 395;
            this.GrdUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdUsuario_CellContentClick);
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.HeaderText = "Selecionar";
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 250;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // nomeLogradouroDataGridViewTextBoxColumn
            // 
            this.nomeLogradouroDataGridViewTextBoxColumn.DataPropertyName = "NomeLogradouro";
            this.nomeLogradouroDataGridViewTextBoxColumn.HeaderText = "Nome do Logradouro";
            this.nomeLogradouroDataGridViewTextBoxColumn.Name = "nomeLogradouroDataGridViewTextBoxColumn";
            this.nomeLogradouroDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeLogradouroDataGridViewTextBoxColumn.Width = 250;
            // 
            // cOLABORADORBindingSource
            // 
            this.cOLABORADORBindingSource.DataMember = "COLABORADOR";
            this.cOLABORADORBindingSource.DataSource = this.usinaDataSetColaborador;
            // 
            // usinaDataSetColaborador
            // 
            this.usinaDataSetColaborador.DataSetName = "UsinaDataSetColaborador";
            this.usinaDataSetColaborador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnSair
            // 
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.Location = new System.Drawing.Point(876, 54);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(52, 44);
            this.BtnSair.TabIndex = 394;
            this.BtnSair.Text = " ";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TxtPesquisarUsuario
            // 
            this.TxtPesquisarUsuario.Location = new System.Drawing.Point(129, 72);
            this.TxtPesquisarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPesquisarUsuario.Name = "TxtPesquisarUsuario";
            this.TxtPesquisarUsuario.Size = new System.Drawing.Size(215, 26);
            this.TxtPesquisarUsuario.TabIndex = 393;
            this.TxtPesquisarUsuario.TextChanged += new System.EventHandler(this.TxtPesquisarUsuario_TextChanged);
            this.TxtPesquisarUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPesquisarUsuario_KeyPress);
            // 
            // LblColaborador
            // 
            this.LblColaborador.AutoSize = true;
            this.LblColaborador.Location = new System.Drawing.Point(25, 75);
            this.LblColaborador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblColaborador.Name = "LblColaborador";
            this.LblColaborador.Size = new System.Drawing.Size(96, 18);
            this.LblColaborador.TabIndex = 392;
            this.LblColaborador.Text = "Colaborador";
            // 
            // cOLABORADORTableAdapter
            // 
            this.cOLABORADORTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultarColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 632);
            this.Controls.Add(this.panelConsultaColaborador);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Colaborador";
            this.Load += new System.EventHandler(this.ConsultarColaborador_Load);
            this.panelConsultaColaborador.ResumeLayout(false);
            this.panelConsultaColaborador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOLABORADORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usinaDataSetColaborador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultaColaborador;
        private System.Windows.Forms.Label LblCadastroColaborador;
        private System.Windows.Forms.DataGridView GrdUsuario;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox TxtPesquisarUsuario;
        private System.Windows.Forms.Label LblColaborador;
        private UsinaDataSetColaborador usinaDataSetColaborador;
        private System.Windows.Forms.BindingSource cOLABORADORBindingSource;
        private UsinaDataSetColaboradorTableAdapters.COLABORADORTableAdapter cOLABORADORTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLogradouroDataGridViewTextBoxColumn;
    }
}