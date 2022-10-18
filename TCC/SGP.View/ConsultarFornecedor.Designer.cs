namespace SGP.View
{
    partial class ConsultarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarFornecedor));
            this.GrdUsuario = new System.Windows.Forms.DataGridView();
            this.fORNECEDORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnSair = new System.Windows.Forms.Button();
            this.TxtPesquisarUsuario = new System.Windows.Forms.TextBox();
            this.LblFornecedor = new System.Windows.Forms.Label();
            this.LblCadastroFornecedor = new System.Windows.Forms.Label();
            this.usinaDataSetFornecedor = new SGP.View.UsinaDataSetFornecedor();
            this.fORNECEDORBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fORNECEDORTableAdapter = new SGP.View.UsinaDataSetFornecedorTableAdapters.FORNECEDORTableAdapter();
            this.BtnSelecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLogradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usinaDataSetFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdUsuario
            // 
            this.GrdUsuario.AllowUserToAddRows = false;
            this.GrdUsuario.AllowUserToDeleteRows = false;
            this.GrdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdUsuario.AutoGenerateColumns = false;
            this.GrdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSelecionar,
            this.dataGridViewTextBoxColumn3,
            this.documentoDataGridViewTextBoxColumn,
            this.Email,
            this.nomeLogradouroDataGridViewTextBoxColumn});
            this.GrdUsuario.DataSource = this.fORNECEDORBindingSource2;
            this.GrdUsuario.Location = new System.Drawing.Point(13, 108);
            this.GrdUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.GrdUsuario.Name = "GrdUsuario";
            this.GrdUsuario.ReadOnly = true;
            this.GrdUsuario.RowHeadersVisible = false;
            this.GrdUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GrdUsuario.Size = new System.Drawing.Size(909, 532);
            this.GrdUsuario.TabIndex = 9;
            this.GrdUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdUsuario_CellContentClick);
            // 
            // fORNECEDORBindingSource1
            // 
            this.fORNECEDORBindingSource1.DataMember = "FORNECEDOR";
            // 
            // fORNECEDORBindingSource
            // 
            this.fORNECEDORBindingSource.DataMember = "FORNECEDOR";
            // 
            // BtnSair
            // 
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.Location = new System.Drawing.Point(870, 56);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(52, 44);
            this.BtnSair.TabIndex = 2;
            this.BtnSair.Text = " ";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TxtPesquisarUsuario
            // 
            this.TxtPesquisarUsuario.Location = new System.Drawing.Point(123, 74);
            this.TxtPesquisarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPesquisarUsuario.Name = "TxtPesquisarUsuario";
            this.TxtPesquisarUsuario.Size = new System.Drawing.Size(215, 26);
            this.TxtPesquisarUsuario.TabIndex = 1;
            this.TxtPesquisarUsuario.TextChanged += new System.EventHandler(this.TxtPesquisarUsuario_TextChanged);
            this.TxtPesquisarUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPesquisarUsuario_KeyPress);
            // 
            // LblFornecedor
            // 
            this.LblFornecedor.AutoSize = true;
            this.LblFornecedor.Location = new System.Drawing.Point(26, 77);
            this.LblFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFornecedor.Name = "LblFornecedor";
            this.LblFornecedor.Size = new System.Drawing.Size(89, 18);
            this.LblFornecedor.TabIndex = 0;
            this.LblFornecedor.Text = "Fornecedor";
            // 
            // LblCadastroFornecedor
            // 
            this.LblCadastroFornecedor.AutoSize = true;
            this.LblCadastroFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastroFornecedor.Location = new System.Drawing.Point(13, 25);
            this.LblCadastroFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCadastroFornecedor.Name = "LblCadastroFornecedor";
            this.LblCadastroFornecedor.Size = new System.Drawing.Size(224, 18);
            this.LblCadastroFornecedor.TabIndex = 390;
            this.LblCadastroFornecedor.Text = "CONSULTAR  FORNECEDOR";
            // 
            // usinaDataSetFornecedor
            // 
            this.usinaDataSetFornecedor.DataSetName = "UsinaDataSetFornecedor";
            this.usinaDataSetFornecedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fORNECEDORBindingSource2
            // 
            this.fORNECEDORBindingSource2.DataMember = "FORNECEDOR";
            this.fORNECEDORBindingSource2.DataSource = this.usinaDataSetFornecedor;
            // 
            // fORNECEDORTableAdapter
            // 
            this.fORNECEDORTableAdapter.ClearBeforeFill = true;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.HeaderText = "Selecionar";
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // nomeLogradouroDataGridViewTextBoxColumn
            // 
            this.nomeLogradouroDataGridViewTextBoxColumn.DataPropertyName = "NomeLogradouro";
            this.nomeLogradouroDataGridViewTextBoxColumn.HeaderText = "Nome do Logradouro";
            this.nomeLogradouroDataGridViewTextBoxColumn.Name = "nomeLogradouroDataGridViewTextBoxColumn";
            this.nomeLogradouroDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeLogradouroDataGridViewTextBoxColumn.Width = 250;
            // 
            // ConsultarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 653);
            this.Controls.Add(this.LblCadastroFornecedor);
            this.Controls.Add(this.GrdUsuario);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TxtPesquisarUsuario);
            this.Controls.Add(this.LblFornecedor);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarFornecedor";
            this.Text = "ConsultarFornecedor";
            this.Load += new System.EventHandler(this.ConsultarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usinaDataSetFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdUsuario;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox TxtPesquisarUsuario;
        private System.Windows.Forms.Label LblFornecedor;
        private System.Windows.Forms.Label LblCadastroFornecedor;
        private System.Windows.Forms.BindingSource fORNECEDORBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fORNECEDORBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private UsinaDataSetFornecedor usinaDataSetFornecedor;
        private System.Windows.Forms.BindingSource fORNECEDORBindingSource2;
        private UsinaDataSetFornecedorTableAdapters.FORNECEDORTableAdapter fORNECEDORTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLogradouroDataGridViewTextBoxColumn;
    }
}