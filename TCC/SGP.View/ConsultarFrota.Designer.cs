namespace SGP.View
{
    partial class ConsultarFrota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarFrota));
            this.LblFrota = new System.Windows.Forms.Label();
            this.TxtPesquisarFrota = new System.Windows.Forms.TextBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.GrdFrota = new System.Windows.Forms.DataGridView();
            this.fROTABindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fROTABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fROTABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fROTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblCadastroFornecedor = new System.Windows.Forms.Label();
            this.usinaDataSetFrota = new SGP.View.UsinaDataSetFrota();
            this.fROTABindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.fROTATableAdapter = new SGP.View.UsinaDataSetFrotaTableAdapters.FROTATableAdapter();
            this.BtnSelecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFrota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fROTABindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fROTABindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fROTABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fROTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usinaDataSetFrota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fROTABindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFrota
            // 
            this.LblFrota.AutoSize = true;
            this.LblFrota.Location = new System.Drawing.Point(24, 73);
            this.LblFrota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFrota.Name = "LblFrota";
            this.LblFrota.Size = new System.Drawing.Size(48, 18);
            this.LblFrota.TabIndex = 0;
            this.LblFrota.Text = "Placa";
            this.LblFrota.Click += new System.EventHandler(this.LblFrota_Click);
            // 
            // TxtPesquisarFrota
            // 
            this.TxtPesquisarFrota.Location = new System.Drawing.Point(80, 70);
            this.TxtPesquisarFrota.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPesquisarFrota.Name = "TxtPesquisarFrota";
            this.TxtPesquisarFrota.Size = new System.Drawing.Size(70, 26);
            this.TxtPesquisarFrota.TabIndex = 1;
            this.TxtPesquisarFrota.TextChanged += new System.EventHandler(this.TxtPesquisarFrota_TextChanged);
            this.TxtPesquisarFrota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPesquisarFrota_KeyPress);
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.Location = new System.Drawing.Point(665, 52);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(47, 44);
            this.BtnSair.TabIndex = 2;
            this.BtnSair.Text = " ";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // GrdFrota
            // 
            this.GrdFrota.AllowUserToAddRows = false;
            this.GrdFrota.AllowUserToDeleteRows = false;
            this.GrdFrota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GrdFrota.AutoGenerateColumns = false;
            this.GrdFrota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdFrota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSelecionar,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.GrdFrota.DataSource = this.fROTABindingSource4;
            this.GrdFrota.Location = new System.Drawing.Point(13, 104);
            this.GrdFrota.Margin = new System.Windows.Forms.Padding(4);
            this.GrdFrota.Name = "GrdFrota";
            this.GrdFrota.ReadOnly = true;
            this.GrdFrota.RowHeadersVisible = false;
            this.GrdFrota.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GrdFrota.Size = new System.Drawing.Size(702, 496);
            this.GrdFrota.TabIndex = 4;
            this.GrdFrota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdFrota_CellContentClick);
            // 
            // fROTABindingSource3
            // 
            this.fROTABindingSource3.DataMember = "FROTA";
            // 
            // fROTABindingSource2
            // 
            this.fROTABindingSource2.DataMember = "FROTA";
            // 
            // LblCadastroFornecedor
            // 
            this.LblCadastroFornecedor.AutoSize = true;
            this.LblCadastroFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastroFornecedor.Location = new System.Drawing.Point(13, 21);
            this.LblCadastroFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCadastroFornecedor.Name = "LblCadastroFornecedor";
            this.LblCadastroFornecedor.Size = new System.Drawing.Size(165, 20);
            this.LblCadastroFornecedor.TabIndex = 391;
            this.LblCadastroFornecedor.Text = "CONSULTAR FROTA";
            // 
            // usinaDataSetFrota
            // 
            this.usinaDataSetFrota.DataSetName = "UsinaDataSetFrota";
            this.usinaDataSetFrota.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fROTABindingSource4
            // 
            this.fROTABindingSource4.DataMember = "FROTA";
            this.fROTABindingSource4.DataSource = this.usinaDataSetFrota;
            // 
            // fROTATableAdapter
            // 
            this.fROTATableAdapter.ClearBeforeFill = true;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.HeaderText = "Selecionar";
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Placa";
            this.dataGridViewTextBoxColumn12.HeaderText = "Placa";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn13.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn14.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Tara";
            this.dataGridViewTextBoxColumn15.HeaderText = "Tara";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "PesoBruto";
            this.dataGridViewTextBoxColumn16.HeaderText = "PesoBruto";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // ConsultarFrota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(729, 613);
            this.Controls.Add(this.LblCadastroFornecedor);
            this.Controls.Add(this.GrdFrota);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TxtPesquisarFrota);
            this.Controls.Add(this.LblFrota);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarFrota";
            this.Text = "ConsultarFrota";
            this.Load += new System.EventHandler(this.MnuConsultarFrota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdFrota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fROTABindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fROTABindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fROTABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fROTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usinaDataSetFrota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fROTABindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFrota;
        private System.Windows.Forms.TextBox TxtPesquisarFrota;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView GrdFrota;
        private System.Windows.Forms.BindingSource fROTABindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LblCadastroFornecedor;
        private System.Windows.Forms.BindingSource fROTABindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoBrutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fROTABindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource fROTABindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private UsinaDataSetFrota usinaDataSetFrota;
        private System.Windows.Forms.BindingSource fROTABindingSource4;
        private UsinaDataSetFrotaTableAdapters.FROTATableAdapter fROTATableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}