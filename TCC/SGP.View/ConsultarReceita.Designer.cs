namespace SGP.View
{
    partial class ConsultarReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarReceita));
            this.GrdUsuario = new System.Windows.Forms.DataGridView();
            this.rECEITABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.LblCadastroColaborador = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblReceita = new System.Windows.Forms.Label();
            this.TxtPesquisar = new System.Windows.Forms.TextBox();
            this.rECEITABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usinaDataSetReceita = new SGP.View.UsinaDataSetReceita();
            this.rECEITABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rECEITATableAdapter = new SGP.View.UsinaDataSetReceitaTableAdapters.RECEITATableAdapter();
            this.BtnSelecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECEITABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECEITABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usinaDataSetReceita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECEITABindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdUsuario
            // 
            this.GrdUsuario.AllowUserToAddRows = false;
            this.GrdUsuario.AllowUserToDeleteRows = false;
            this.GrdUsuario.AutoGenerateColumns = false;
            this.GrdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSelecionar,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.GrdUsuario.DataSource = this.rECEITABindingSource2;
            this.GrdUsuario.Location = new System.Drawing.Point(12, 84);
            this.GrdUsuario.Name = "GrdUsuario";
            this.GrdUsuario.ReadOnly = true;
            this.GrdUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.GrdUsuario.Size = new System.Drawing.Size(813, 513);
            this.GrdUsuario.TabIndex = 417;
            this.GrdUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdUsuario_CellContentClick);
            // 
            // LblCadastroColaborador
            // 
            this.LblCadastroColaborador.AutoSize = true;
            this.LblCadastroColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastroColaborador.Location = new System.Drawing.Point(12, 9);
            this.LblCadastroColaborador.Name = "LblCadastroColaborador";
            this.LblCadastroColaborador.Size = new System.Drawing.Size(181, 20);
            this.LblCadastroColaborador.TabIndex = 418;
            this.LblCadastroColaborador.Text = "CONSULTAR RECEITA";
            // 
            // BtnSair
            // 
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.Font = new System.Drawing.Font("Arial", 12F);
            this.BtnSair.Location = new System.Drawing.Point(774, 35);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(51, 44);
            this.BtnSair.TabIndex = 416;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblReceita
            // 
            this.LblReceita.AutoSize = true;
            this.LblReceita.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReceita.Location = new System.Drawing.Point(43, 55);
            this.LblReceita.Name = "LblReceita";
            this.LblReceita.Size = new System.Drawing.Size(62, 18);
            this.LblReceita.TabIndex = 414;
            this.LblReceita.Text = "Receita";
            // 
            // TxtPesquisar
            // 
            this.TxtPesquisar.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtPesquisar.Location = new System.Drawing.Point(111, 52);
            this.TxtPesquisar.Name = "TxtPesquisar";
            this.TxtPesquisar.Size = new System.Drawing.Size(215, 26);
            this.TxtPesquisar.TabIndex = 419;
            this.TxtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            this.TxtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPesquisar_KeyPress);
            // 
            // usinaDataSetReceita
            // 
            this.usinaDataSetReceita.DataSetName = "UsinaDataSetReceita";
            this.usinaDataSetReceita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECEITABindingSource2
            // 
            this.rECEITABindingSource2.DataMember = "RECEITA";
            this.rECEITABindingSource2.DataSource = this.usinaDataSetReceita;
            // 
            // rECEITATableAdapter
            // 
            this.rECEITATableAdapter.ClearBeforeFill = true;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.HeaderText = "Selecionar";
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.ReadOnly = true;
            this.BtnSelecionar.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Agr1Prog";
            this.dataGridViewTextBoxColumn3.HeaderText = "Agr1Prog";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Agr2Prog";
            this.dataGridViewTextBoxColumn4.HeaderText = "Agr2Prog";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Agr3Prog";
            this.dataGridViewTextBoxColumn5.HeaderText = "Agr3Prog";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cim1Prog";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cim1Prog";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Agua1Prog";
            this.dataGridViewTextBoxColumn7.HeaderText = "Agua1Prog";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Adit1Prog";
            this.dataGridViewTextBoxColumn8.HeaderText = "Adit1Prog";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn9.HeaderText = "Total";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // ConsultarReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 613);
            this.Controls.Add(this.TxtPesquisar);
            this.Controls.Add(this.GrdUsuario);
            this.Controls.Add(this.LblCadastroColaborador);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblReceita);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarReceita";
            this.Text = "ConsultarReceita";
            this.Load += new System.EventHandler(this.ConsultarReceita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECEITABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECEITABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usinaDataSetReceita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECEITABindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdUsuario;
        private System.Windows.Forms.Label LblCadastroColaborador;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblReceita;
        private System.Windows.Forms.TextBox TxtPesquisar;
        private System.Windows.Forms.BindingSource rECEITABindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rECEITABindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn agr1ProgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agr2ProgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agr3ProgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cim1ProgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agua1ProgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adit1ProgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private UsinaDataSetReceita usinaDataSetReceita;
        private System.Windows.Forms.BindingSource rECEITABindingSource2;
        private UsinaDataSetReceitaTableAdapters.RECEITATableAdapter rECEITATableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}