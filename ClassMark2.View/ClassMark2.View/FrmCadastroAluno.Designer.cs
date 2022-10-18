namespace ClassMark2.View
{
    partial class FrmCadastroAluno
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.LblNomeAluno = new System.Windows.Forms.Label();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.GrdAluno = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataIngresso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblID = new System.Windows.Forms.Label();
            this.LblCurso = new System.Windows.Forms.Label();
            this.TxtCurso = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(84, 45);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 0;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(359, 38);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 1;
            // 
            // TxtData
            // 
            this.TxtData.Location = new System.Drawing.Point(359, 15);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(100, 20);
            this.TxtData.TabIndex = 2;
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(84, 77);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(100, 20);
            this.TxtMatricula.TabIndex = 3;
            // 
            // LblNomeAluno
            // 
            this.LblNomeAluno.AutoSize = true;
            this.LblNomeAluno.Location = new System.Drawing.Point(43, 45);
            this.LblNomeAluno.Name = "LblNomeAluno";
            this.LblNomeAluno.Size = new System.Drawing.Size(35, 13);
            this.LblNomeAluno.TabIndex = 4;
            this.LblNomeAluno.Text = "Nome";
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Location = new System.Drawing.Point(26, 77);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(52, 13);
            this.LblMatricula.TabIndex = 5;
            this.LblMatricula.Text = "Matrícula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Ingresso";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(300, 41);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 7;
            this.LblEmail.Text = "E-mail";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(303, 67);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 8;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(384, 67);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 9;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // GrdAluno
            // 
            this.GrdAluno.AllowUserToAddRows = false;
            this.GrdAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Matricula,
            this.Email,
            this.DataIngresso,
            this.Curso,
            this.BtnAlterar,
            this.BtnExcluir});
            this.GrdAluno.Location = new System.Drawing.Point(12, 125);
            this.GrdAluno.Name = "GrdAluno";
            this.GrdAluno.Size = new System.Drawing.Size(846, 168);
            this.GrdAluno.TabIndex = 10;
            this.GrdAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdAluno_CellContentClick);
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
            // Matricula
            // 
            this.Matricula.DataPropertyName = "Matricula";
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            // 
            // DataIngresso
            // 
            this.DataIngresso.DataPropertyName = "DataIngresso";
            this.DataIngresso.HeaderText = "Data Ingresso";
            this.DataIngresso.Name = "DataIngresso";
            // 
            // Curso
            // 
            this.Curso.DataPropertyName = "IDCurso";
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.HeaderText = "Alterar";
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnAlterar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(43, 15);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(18, 13);
            this.LblID.TabIndex = 11;
            this.LblID.Text = "ID";
            // 
            // LblCurso
            // 
            this.LblCurso.AutoSize = true;
            this.LblCurso.Location = new System.Drawing.Point(508, 18);
            this.LblCurso.Name = "LblCurso";
            this.LblCurso.Size = new System.Drawing.Size(34, 13);
            this.LblCurso.TabIndex = 12;
            this.LblCurso.Text = "Curso";
            // 
            // TxtCurso
            // 
            this.TxtCurso.Location = new System.Drawing.Point(549, 15);
            this.TxtCurso.Name = "TxtCurso";
            this.TxtCurso.Size = new System.Drawing.Size(100, 20);
            this.TxtCurso.TabIndex = 13;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(84, 15);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 14;
            // 
            // FrmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 305);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtCurso);
            this.Controls.Add(this.LblCurso);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.GrdAluno);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblMatricula);
            this.Controls.Add(this.LblNomeAluno);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNome);
            this.Name = "FrmCadastroAluno";
            this.Text = "Cadastro Aluno";
            this.Load += new System.EventHandler(this.FrmCadastroAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.Label LblNomeAluno;
        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.DataGridView GrdAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataIngresso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblCurso;
        private System.Windows.Forms.TextBox TxtCurso;
        private System.Windows.Forms.TextBox TxtID;
    }
}