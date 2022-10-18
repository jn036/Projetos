namespace SGP.View
{
    partial class ConsultarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCliente));
            this.panelConsultaCliente = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblCadastroCliente = new System.Windows.Forms.Label();
            this.GrdUsuario = new System.Windows.Forms.DataGridView();
            this.cLIENTEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usinaDataSetCliente = new SGP.View.UsinaDataSetCliente();
            this.TxtPesquisarUsuario = new System.Windows.Forms.TextBox();
            this.LblColaborador = new System.Windows.Forms.Label();
            this.cLIENTETableAdapter = new SGP.View.UsinaDataSetClienteTableAdapters.CLIENTETableAdapter();
            this.dataSetClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnSelecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLogradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelConsultaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usinaDataSetCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultaCliente
            // 
            this.panelConsultaCliente.Controls.Add(this.BtnSair);
            this.panelConsultaCliente.Controls.Add(this.LblCadastroCliente);
            this.panelConsultaCliente.Controls.Add(this.GrdUsuario);
            this.panelConsultaCliente.Controls.Add(this.TxtPesquisarUsuario);
            this.panelConsultaCliente.Controls.Add(this.LblColaborador);
            this.panelConsultaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsultaCliente.Location = new System.Drawing.Point(0, 0);
            this.panelConsultaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.panelConsultaCliente.Name = "panelConsultaCliente";
            this.panelConsultaCliente.Size = new System.Drawing.Size(942, 579);
            this.panelConsultaCliente.TabIndex = 0;
            this.panelConsultaCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelConsultaCliente_Paint);
            // 
            // BtnSair
            // 
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.Location = new System.Drawing.Point(877, 55);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(52, 44);
            this.BtnSair.TabIndex = 402;
            this.BtnSair.Text = " ";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblCadastroCliente
            // 
            this.LblCadastroCliente.AutoSize = true;
            this.LblCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastroCliente.Location = new System.Drawing.Point(6, 22);
            this.LblCadastroCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCadastroCliente.Name = "LblCadastroCliente";
            this.LblCadastroCliente.Size = new System.Drawing.Size(178, 20);
            this.LblCadastroCliente.TabIndex = 401;
            this.LblCadastroCliente.Text = "CONSULTAR CLIENTE";
            // 
            // GrdUsuario
            // 
            this.GrdUsuario.AllowUserToAddRows = false;
            this.GrdUsuario.AllowUserToDeleteRows = false;
            this.GrdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdUsuario.AutoGenerateColumns = false;
            this.GrdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSelecionar,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.nomeLogradouroDataGridViewTextBoxColumn});
            this.GrdUsuario.DataSource = this.cLIENTEBindingSource1;
            this.GrdUsuario.Location = new System.Drawing.Point(8, 109);
            this.GrdUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.GrdUsuario.Name = "GrdUsuario";
            this.GrdUsuario.ReadOnly = true;
            this.GrdUsuario.RowHeadersVisible = false;
            this.GrdUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GrdUsuario.Size = new System.Drawing.Size(927, 455);
            this.GrdUsuario.TabIndex = 400;
            this.GrdUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdUsuario_CellContentClick);
            // 
            // cLIENTEBindingSource1
            // 
            this.cLIENTEBindingSource1.DataMember = "CLIENTE";
            this.cLIENTEBindingSource1.DataSource = this.usinaDataSetCliente;
            // 
            // usinaDataSetCliente
            // 
            this.usinaDataSetCliente.DataSetName = "UsinaDataSetCliente";
            this.usinaDataSetCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtPesquisarUsuario
            // 
            this.TxtPesquisarUsuario.Location = new System.Drawing.Point(90, 71);
            this.TxtPesquisarUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.TxtPesquisarUsuario.Name = "TxtPesquisarUsuario";
            this.TxtPesquisarUsuario.Size = new System.Drawing.Size(215, 26);
            this.TxtPesquisarUsuario.TabIndex = 398;
            this.TxtPesquisarUsuario.TextChanged += new System.EventHandler(this.TxtPesquisarUsuario_TextChanged);
            this.TxtPesquisarUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPesquisarUsuario_KeyPress);
            // 
            // LblColaborador
            // 
            this.LblColaborador.AutoSize = true;
            this.LblColaborador.Location = new System.Drawing.Point(18, 74);
            this.LblColaborador.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblColaborador.Name = "LblColaborador";
            this.LblColaborador.Size = new System.Drawing.Size(60, 18);
            this.LblColaborador.TabIndex = 397;
            this.LblColaborador.Text = "Clliente";
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.HeaderText = "Selecionar";
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Documento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // nomeLogradouroDataGridViewTextBoxColumn
            // 
            this.nomeLogradouroDataGridViewTextBoxColumn.DataPropertyName = "NomeLogradouro";
            this.nomeLogradouroDataGridViewTextBoxColumn.HeaderText = "Nome do Logradouro";
            this.nomeLogradouroDataGridViewTextBoxColumn.Name = "nomeLogradouroDataGridViewTextBoxColumn";
            this.nomeLogradouroDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeLogradouroDataGridViewTextBoxColumn.Width = 250;
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 579);
            this.Controls.Add(this.panelConsultaCliente);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            this.panelConsultaCliente.ResumeLayout(false);
            this.panelConsultaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usinaDataSetCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultaCliente;
        private System.Windows.Forms.Label LblCadastroCliente;
        private System.Windows.Forms.DataGridView GrdUsuario;
        private System.Windows.Forms.TextBox TxtPesquisarUsuario;
        private System.Windows.Forms.Label LblColaborador;
        private System.Windows.Forms.BindingSource dataSetClienteBindingSource;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private UsinaDataSetCliente usinaDataSetCliente;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource1;
        private UsinaDataSetClienteTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLogradouroDataGridViewTextBoxColumn;
    }
}