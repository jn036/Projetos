namespace ClassMark2.View
{
    partial class FrmCadastroMateria
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
            this.LblIdCurso = new System.Windows.Forms.Label();
            this.LblAno = new System.Windows.Forms.Label();
            this.LblIdProfessor = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtIdCurso = new System.Windows.Forms.TextBox();
            this.TxtAno = new System.Windows.Forms.TextBox();
            this.TxtIdProfessor = new System.Windows.Forms.TextBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.GrdMateria = new System.Windows.Forms.DataGridView();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(50, 46);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // LblIdCurso
            // 
            this.LblIdCurso.AutoSize = true;
            this.LblIdCurso.Location = new System.Drawing.Point(311, 25);
            this.LblIdCurso.Name = "LblIdCurso";
            this.LblIdCurso.Size = new System.Drawing.Size(48, 13);
            this.LblIdCurso.TabIndex = 1;
            this.LblIdCurso.Text = "ID Curso";
            // 
            // LblAno
            // 
            this.LblAno.AutoSize = true;
            this.LblAno.Location = new System.Drawing.Point(29, 72);
            this.LblAno.Name = "LblAno";
            this.LblAno.Size = new System.Drawing.Size(56, 13);
            this.LblAno.TabIndex = 2;
            this.LblAno.Text = "Ano Curso";
            // 
            // LblIdProfessor
            // 
            this.LblIdProfessor.AutoSize = true;
            this.LblIdProfessor.Location = new System.Drawing.Point(294, 58);
            this.LblIdProfessor.Name = "LblIdProfessor";
            this.LblIdProfessor.Size = new System.Drawing.Size(65, 13);
            this.LblIdProfessor.TabIndex = 3;
            this.LblIdProfessor.Text = "ID Professor";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(304, 87);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(55, 13);
            this.LblDescricao.TabIndex = 4;
            this.LblDescricao.Text = "Descrição";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(91, 43);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 5;
            // 
            // TxtIdCurso
            // 
            this.TxtIdCurso.Location = new System.Drawing.Point(365, 25);
            this.TxtIdCurso.Name = "TxtIdCurso";
            this.TxtIdCurso.Size = new System.Drawing.Size(100, 20);
            this.TxtIdCurso.TabIndex = 6;
            // 
            // TxtAno
            // 
            this.TxtAno.Location = new System.Drawing.Point(91, 69);
            this.TxtAno.Name = "TxtAno";
            this.TxtAno.Size = new System.Drawing.Size(100, 20);
            this.TxtAno.TabIndex = 7;
            // 
            // TxtIdProfessor
            // 
            this.TxtIdProfessor.Location = new System.Drawing.Point(365, 58);
            this.TxtIdProfessor.Name = "TxtIdProfessor";
            this.TxtIdProfessor.Size = new System.Drawing.Size(100, 20);
            this.TxtIdProfessor.TabIndex = 8;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(365, 87);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(100, 20);
            this.TxtDescricao.TabIndex = 9;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(500, 87);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 10;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(593, 87);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // GrdMateria
            // 
            this.GrdMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.AnoCurso,
            this.IDProfessor,
            this.Curso,
            this.BtnAlterar,
            this.BtnExcluir});
            this.GrdMateria.Location = new System.Drawing.Point(12, 126);
            this.GrdMateria.Name = "GrdMateria";
            this.GrdMateria.Size = new System.Drawing.Size(776, 155);
            this.GrdMateria.TabIndex = 12;
            this.GrdMateria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdMateria_CellContentClick);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(50, 20);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(18, 13);
            this.LblID.TabIndex = 13;
            this.LblID.Text = "ID";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(91, 17);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // AnoCurso
            // 
            this.AnoCurso.HeaderText = "Ano";
            this.AnoCurso.Name = "AnoCurso";
            // 
            // IDProfessor
            // 
            this.IDProfessor.HeaderText = "Professor";
            this.IDProfessor.Name = "IDProfessor";
            // 
            // Curso
            // 
            this.Curso.HeaderText = "IDCurso";
            this.Curso.Name = "Curso";
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
            // FrmCadastroMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 293);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.GrdMateria);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.TxtIdProfessor);
            this.Controls.Add(this.TxtAno);
            this.Controls.Add(this.TxtIdCurso);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblDescricao);
            this.Controls.Add(this.LblIdProfessor);
            this.Controls.Add(this.LblAno);
            this.Controls.Add(this.LblIdCurso);
            this.Controls.Add(this.LblNome);
            this.Name = "FrmCadastroMateria";
            this.Text = "FrmCadastroMateria";
            ((System.ComponentModel.ISupportInitialize)(this.GrdMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblIdCurso;
        private System.Windows.Forms.Label LblAno;
        private System.Windows.Forms.Label LblIdProfessor;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtIdCurso;
        private System.Windows.Forms.TextBox TxtAno;
        private System.Windows.Forms.TextBox TxtIdProfessor;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.DataGridView GrdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnoCurso;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
    }
}