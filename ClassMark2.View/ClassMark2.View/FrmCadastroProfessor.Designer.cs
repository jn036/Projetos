namespace ClassMark2.View
{
    partial class FrmCadastroProfessor
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
            this.LblNomeProfessor = new System.Windows.Forms.Label();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.GrdProfessor = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataIngresso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNomeProfessor
            // 
            this.LblNomeProfessor.AutoSize = true;
            this.LblNomeProfessor.Location = new System.Drawing.Point(39, 37);
            this.LblNomeProfessor.Name = "LblNomeProfessor";
            this.LblNomeProfessor.Size = new System.Drawing.Size(35, 13);
            this.LblNomeProfessor.TabIndex = 0;
            this.LblNomeProfessor.Text = "Nome";
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Location = new System.Drawing.Point(39, 61);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(50, 13);
            this.LblMatricula.TabIndex = 1;
            this.LblMatricula.Text = "Matricula";
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Location = new System.Drawing.Point(352, 13);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(73, 13);
            this.LblData.TabIndex = 2;
            this.LblData.Text = "Data Ingresso";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(390, 37);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 3;
            this.LblEmail.Text = "E-mail";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(95, 34);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 4;
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(95, 63);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(100, 20);
            this.TxtMatricula.TabIndex = 5;
            // 
            // TxtData
            // 
            this.TxtData.Location = new System.Drawing.Point(449, 12);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(100, 20);
            this.TxtData.TabIndex = 6;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(449, 37);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 7;
            // 
            // GrdProfessor
            // 
            this.GrdProfessor.AllowUserToAddRows = false;
            this.GrdProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Matricula,
            this.Email,
            this.DataIngresso,
            this.BtnAlterar,
            this.BtnExcluir});
            this.GrdProfessor.Location = new System.Drawing.Point(12, 107);
            this.GrdProfessor.Name = "GrdProfessor";
            this.GrdProfessor.Size = new System.Drawing.Size(742, 181);
            this.GrdProfessor.TabIndex = 8;
            this.GrdProfessor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdProfessor_CellContentClick);
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
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(393, 61);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 9;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(474, 61);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 25);
            this.BtnLimpar.TabIndex = 10;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(39, 9);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(18, 13);
            this.LblID.TabIndex = 11;
            this.LblID.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(95, 6);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 12;
            // 
            // FrmCadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.GrdProfessor);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.LblMatricula);
            this.Controls.Add(this.LblNomeProfessor);
            this.Name = "FrmCadastroProfessor";
            this.Text = "FrmCadastroProfessor";
            this.Load += new System.EventHandler(this.FrmCadastroProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNomeProfessor;
        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.DataGridView GrdProfessor;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataIngresso;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtID;
    }
}