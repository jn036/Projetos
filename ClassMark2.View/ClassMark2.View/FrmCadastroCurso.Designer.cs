namespace ClassMark2.View
{
    partial class FrmCadastroCurso
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
            this.LblNome = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.LblCoordenador = new System.Windows.Forms.Label();
            this.LblAnos = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.TxtDuracao = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.GrdCurso = new System.Windows.Forms.DataGridView();
            this.CboCord = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coordenador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LbllD = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(44, 49);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Location = new System.Drawing.Point(21, 75);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(58, 13);
            this.LblData.TabIndex = 1;
            this.LblData.Text = "Data Inicio";
            // 
            // LblCoordenador
            // 
            this.LblCoordenador.AutoSize = true;
            this.LblCoordenador.Location = new System.Drawing.Point(289, 19);
            this.LblCoordenador.Name = "LblCoordenador";
            this.LblCoordenador.Size = new System.Drawing.Size(68, 13);
            this.LblCoordenador.TabIndex = 2;
            this.LblCoordenador.Text = "Coordenador";
            // 
            // LblAnos
            // 
            this.LblAnos.AutoSize = true;
            this.LblAnos.Location = new System.Drawing.Point(309, 52);
            this.LblAnos.Name = "LblAnos";
            this.LblAnos.Size = new System.Drawing.Size(48, 13);
            this.LblAnos.TabIndex = 3;
            this.LblAnos.Text = "Duração";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(299, 85);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(58, 13);
            this.LblTipo.TabIndex = 4;
            this.LblTipo.Text = "Tipo Curso";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(85, 49);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 5;
            // 
            // TxtData
            // 
            this.TxtData.Location = new System.Drawing.Point(85, 75);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(100, 20);
            this.TxtData.TabIndex = 6;
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(363, 78);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(100, 20);
            this.TxtTipo.TabIndex = 7;
            // 
            // TxtDuracao
            // 
            this.TxtDuracao.Location = new System.Drawing.Point(363, 49);
            this.TxtDuracao.Name = "TxtDuracao";
            this.TxtDuracao.Size = new System.Drawing.Size(100, 20);
            this.TxtDuracao.TabIndex = 8;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(469, 75);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 10;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(568, 75);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // GrdCurso
            // 
            this.GrdCurso.AllowUserToAddRows = false;
            this.GrdCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.DataInicio,
            this.TipoCurso,
            this.Coordenador,
            this.Duracao,
            this.BtnAlterar,
            this.BtnExcluir});
            this.GrdCurso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrdCurso.Location = new System.Drawing.Point(0, 118);
            this.GrdCurso.Name = "GrdCurso";
            this.GrdCurso.Size = new System.Drawing.Size(821, 150);
            this.GrdCurso.TabIndex = 12;
            this.GrdCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCurso_CellClick);
            // 
            // CboCord
            // 
            this.CboCord.FormattingEnabled = true;
            this.CboCord.Location = new System.Drawing.Point(363, 16);
            this.CboCord.Name = "CboCord";
            this.CboCord.Size = new System.Drawing.Size(121, 21);
            this.CboCord.TabIndex = 13;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // DataInicio
            // 
            this.DataInicio.DataPropertyName = "DataInicio";
            this.DataInicio.HeaderText = "Data Inicio";
            this.DataInicio.Name = "DataInicio";
            // 
            // TipoCurso
            // 
            this.TipoCurso.DataPropertyName = "TipoCurso";
            this.TipoCurso.HeaderText = "Tipo Curso";
            this.TipoCurso.Name = "TipoCurso";
            // 
            // Coordenador
            // 
            this.Coordenador.DataPropertyName = "IDCoordenador";
            this.Coordenador.HeaderText = "Coordenador";
            this.Coordenador.Name = "Coordenador";
            // 
            // Duracao
            // 
            this.Duracao.DataPropertyName = "Duracao";
            this.Duracao.HeaderText = "Duração";
            this.Duracao.Name = "Duracao";
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.HeaderText = "Alterar";
            this.BtnAlterar.Name = "BtnAlterar";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            // 
            // LbllD
            // 
            this.LbllD.AutoSize = true;
            this.LbllD.Location = new System.Drawing.Point(44, 16);
            this.LbllD.Name = "LbllD";
            this.LbllD.Size = new System.Drawing.Size(18, 13);
            this.LbllD.TabIndex = 14;
            this.LbllD.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(85, 16);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 15;
            // 
            // FrmCadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 268);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LbllD);
            this.Controls.Add(this.CboCord);
            this.Controls.Add(this.GrdCurso);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtDuracao);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblAnos);
            this.Controls.Add(this.LblCoordenador);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.LblNome);
            this.Name = "FrmCadastroCurso";
            this.Text = "Cadastro Curso";
            this.Load += new System.EventHandler(this.FrmCadastroCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label LblCoordenador;
        private System.Windows.Forms.Label LblAnos;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.TextBox TxtDuracao;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.DataGridView GrdCurso;


        private System.Windows.Forms.ComboBox CboCord;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coordenador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracao;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.Label LbllD;
        private System.Windows.Forms.TextBox TxtID;
    }
}