namespace SGP.View
{
    partial class ConsultarEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarEntrada));
            this.panelConsultaEntrada = new System.Windows.Forms.Panel();
            this.LblCadastroColaborador = new System.Windows.Forms.Label();
            this.TxtPesquisarUsuario = new System.Windows.Forms.TextBox();
            this.LblColaborador = new System.Windows.Forms.Label();
            this.GrdUsuario = new System.Windows.Forms.DataGridView();
            this.usinaDataSetEntrada = new SGP.View.UsinaDataSetEntrada();
            this.eNTRADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNTRADATableAdapter = new SGP.View.UsinaDataSetEntradaTableAdapters.ENTRADATableAdapter();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDColaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelConsultaEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usinaDataSetEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTRADABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultaEntrada
            // 
            this.panelConsultaEntrada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelConsultaEntrada.Controls.Add(this.BtnSair);
            this.panelConsultaEntrada.Controls.Add(this.GrdUsuario);
            this.panelConsultaEntrada.Controls.Add(this.LblCadastroColaborador);
            this.panelConsultaEntrada.Controls.Add(this.TxtPesquisarUsuario);
            this.panelConsultaEntrada.Controls.Add(this.LblColaborador);
            this.panelConsultaEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsultaEntrada.Location = new System.Drawing.Point(0, 0);
            this.panelConsultaEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelConsultaEntrada.Name = "panelConsultaEntrada";
            this.panelConsultaEntrada.Size = new System.Drawing.Size(837, 585);
            this.panelConsultaEntrada.TabIndex = 0;
            // 
            // LblCadastroColaborador
            // 
            this.LblCadastroColaborador.AutoSize = true;
            this.LblCadastroColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastroColaborador.Location = new System.Drawing.Point(15, 19);
            this.LblCadastroColaborador.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCadastroColaborador.Name = "LblCadastroColaborador";
            this.LblCadastroColaborador.Size = new System.Drawing.Size(188, 20);
            this.LblCadastroColaborador.TabIndex = 399;
            this.LblCadastroColaborador.Text = "CONSULTAR ENTRADA";
            // 
            // TxtPesquisarUsuario
            // 
            this.TxtPesquisarUsuario.Location = new System.Drawing.Point(91, 68);
            this.TxtPesquisarUsuario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtPesquisarUsuario.Name = "TxtPesquisarUsuario";
            this.TxtPesquisarUsuario.Size = new System.Drawing.Size(112, 26);
            this.TxtPesquisarUsuario.TabIndex = 398;
            this.TxtPesquisarUsuario.TextChanged += new System.EventHandler(this.TxtPesquisarUsuario_TextChanged);
            this.TxtPesquisarUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPesquisarUsuario_KeyPress);
            // 
            // LblColaborador
            // 
            this.LblColaborador.AutoSize = true;
            this.LblColaborador.Location = new System.Drawing.Point(16, 71);
            this.LblColaborador.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblColaborador.Name = "LblColaborador";
            this.LblColaborador.Size = new System.Drawing.Size(63, 18);
            this.LblColaborador.TabIndex = 397;
            this.LblColaborador.Text = "Entrada";
            // 
            // GrdUsuario
            // 
            this.GrdUsuario.AllowUserToAddRows = false;
            this.GrdUsuario.AllowUserToDeleteRows = false;
            this.GrdUsuario.AutoGenerateColumns = false;
            this.GrdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnExcluir,
            this.iDFornecedorDataGridViewTextBoxColumn,
            this.iDColaboradorDataGridViewTextBoxColumn,
            this.insumoDataGridViewTextBoxColumn,
            this.dataEntradaDataGridViewTextBoxColumn,
            this.nFDataGridViewTextBoxColumn,
            this.qtdEntradaDataGridViewTextBoxColumn});
            this.GrdUsuario.DataSource = this.eNTRADABindingSource;
            this.GrdUsuario.Location = new System.Drawing.Point(19, 106);
            this.GrdUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.GrdUsuario.Name = "GrdUsuario";
            this.GrdUsuario.ReadOnly = true;
            this.GrdUsuario.RowHeadersVisible = false;
            this.GrdUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GrdUsuario.Size = new System.Drawing.Size(803, 455);
            this.GrdUsuario.TabIndex = 401;
            this.GrdUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdUsuario_CellContentClick);
            // 
            // usinaDataSetEntrada
            // 
            this.usinaDataSetEntrada.DataSetName = "UsinaDataSetEntrada";
            this.usinaDataSetEntrada.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eNTRADABindingSource
            // 
            this.eNTRADABindingSource.DataMember = "ENTRADA";
            this.eNTRADABindingSource.DataSource = this.usinaDataSetEntrada;
            // 
            // eNTRADATableAdapter
            // 
            this.eNTRADATableAdapter.ClearBeforeFill = true;
            // 
            // BtnSair
            // 
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.Location = new System.Drawing.Point(771, 51);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(51, 43);
            this.BtnSair.TabIndex = 403;
            this.BtnSair.Text = " ";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.ReadOnly = true;
            // 
            // iDFornecedorDataGridViewTextBoxColumn
            // 
            this.iDFornecedorDataGridViewTextBoxColumn.DataPropertyName = "IDFornecedor";
            this.iDFornecedorDataGridViewTextBoxColumn.HeaderText = "IDFornecedor";
            this.iDFornecedorDataGridViewTextBoxColumn.Name = "iDFornecedorDataGridViewTextBoxColumn";
            this.iDFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFornecedorDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDColaboradorDataGridViewTextBoxColumn
            // 
            this.iDColaboradorDataGridViewTextBoxColumn.DataPropertyName = "IDColaborador";
            this.iDColaboradorDataGridViewTextBoxColumn.HeaderText = "IDColaborador";
            this.iDColaboradorDataGridViewTextBoxColumn.Name = "iDColaboradorDataGridViewTextBoxColumn";
            this.iDColaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDColaboradorDataGridViewTextBoxColumn.Width = 150;
            // 
            // insumoDataGridViewTextBoxColumn
            // 
            this.insumoDataGridViewTextBoxColumn.DataPropertyName = "Insumo";
            this.insumoDataGridViewTextBoxColumn.HeaderText = "Insumo";
            this.insumoDataGridViewTextBoxColumn.Name = "insumoDataGridViewTextBoxColumn";
            this.insumoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEntradaDataGridViewTextBoxColumn
            // 
            this.dataEntradaDataGridViewTextBoxColumn.DataPropertyName = "DataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.HeaderText = "DataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.Name = "dataEntradaDataGridViewTextBoxColumn";
            this.dataEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nFDataGridViewTextBoxColumn
            // 
            this.nFDataGridViewTextBoxColumn.DataPropertyName = "NF";
            this.nFDataGridViewTextBoxColumn.HeaderText = "NF";
            this.nFDataGridViewTextBoxColumn.Name = "nFDataGridViewTextBoxColumn";
            this.nFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdEntradaDataGridViewTextBoxColumn
            // 
            this.qtdEntradaDataGridViewTextBoxColumn.DataPropertyName = "QtdEntrada";
            this.qtdEntradaDataGridViewTextBoxColumn.HeaderText = "QtdEntrada";
            this.qtdEntradaDataGridViewTextBoxColumn.Name = "qtdEntradaDataGridViewTextBoxColumn";
            this.qtdEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConsultarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 585);
            this.Controls.Add(this.panelConsultaEntrada);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConsultarEntrada";
            this.Text = "ConsultarEntrada";
            this.Load += new System.EventHandler(this.ConsultarEntrada_Load);
            this.panelConsultaEntrada.ResumeLayout(false);
            this.panelConsultaEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usinaDataSetEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNTRADABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultaEntrada;
        private System.Windows.Forms.Label LblCadastroColaborador;
        private System.Windows.Forms.TextBox TxtPesquisarUsuario;
        private System.Windows.Forms.Label LblColaborador;
        private System.Windows.Forms.DataGridView GrdUsuario;
        private UsinaDataSetEntrada usinaDataSetEntrada;
        private System.Windows.Forms.BindingSource eNTRADABindingSource;
        private UsinaDataSetEntradaTableAdapters.ENTRADATableAdapter eNTRADATableAdapter;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDColaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdEntradaDataGridViewTextBoxColumn;
    }
}