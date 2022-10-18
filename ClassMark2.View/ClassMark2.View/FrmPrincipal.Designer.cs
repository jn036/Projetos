namespace ClassMark2.View
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeCursoToolStripMenuItem,
            this.cadastroDeAlunoToolStripMenuItem,
            this.cadastroDeProfessorToolStripMenuItem,
            this.cadastroDeMateriaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeCursoToolStripMenuItem
            // 
            this.cadastroDeCursoToolStripMenuItem.Name = "cadastroDeCursoToolStripMenuItem";
            this.cadastroDeCursoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastroDeCursoToolStripMenuItem.Text = "Cadastro de Curso";
            this.cadastroDeCursoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCursoToolStripMenuItem_Click);
            // 
            // cadastroDeAlunoToolStripMenuItem
            // 
            this.cadastroDeAlunoToolStripMenuItem.Name = "cadastroDeAlunoToolStripMenuItem";
            this.cadastroDeAlunoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastroDeAlunoToolStripMenuItem.Text = "Cadastro de Aluno";
            this.cadastroDeAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAlunoToolStripMenuItem_Click);
            // 
            // cadastroDeProfessorToolStripMenuItem
            // 
            this.cadastroDeProfessorToolStripMenuItem.Name = "cadastroDeProfessorToolStripMenuItem";
            this.cadastroDeProfessorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastroDeProfessorToolStripMenuItem.Text = "Cadastro de Professor";
            this.cadastroDeProfessorToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProfessorToolStripMenuItem_Click);
            // 
            // cadastroDeMateriaToolStripMenuItem
            // 
            this.cadastroDeMateriaToolStripMenuItem.Name = "cadastroDeMateriaToolStripMenuItem";
            this.cadastroDeMateriaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastroDeMateriaToolStripMenuItem.Text = "Cadastro de Materia";
            this.cadastroDeMateriaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeMateriaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "ClassMark";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
    }
}

