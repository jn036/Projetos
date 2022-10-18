namespace ClassMark2.View
{
    partial class FrmConsultarProfessor
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
            this.LblMatricula = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.GrdConsultaP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdConsultaP)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(28, 21);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Location = new System.Drawing.Point(231, 21);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(50, 13);
            this.LblMatricula.TabIndex = 1;
            this.LblMatricula.Text = "Matricula";
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Location = new System.Drawing.Point(28, 61);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(30, 13);
            this.LblData.TabIndex = 2;
            this.LblData.Text = "Data";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(69, 21);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 3;
            // 
            // TxtData
            // 
            this.TxtData.Location = new System.Drawing.Point(69, 61);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(100, 20);
            this.TxtData.TabIndex = 4;
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(287, 21);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(100, 20);
            this.TxtMatricula.TabIndex = 5;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(234, 61);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(331, 61);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // GrdConsultaP
            // 
            this.GrdConsultaP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdConsultaP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrdConsultaP.Location = new System.Drawing.Point(0, 106);
            this.GrdConsultaP.Name = "GrdConsultaP";
            this.GrdConsultaP.Size = new System.Drawing.Size(584, 150);
            this.GrdConsultaP.TabIndex = 8;
            // 
            // FrmConsultarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 256);
            this.Controls.Add(this.GrdConsultaP);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.LblMatricula);
            this.Controls.Add(this.LblNome);
            this.Name = "FrmConsultarProfessor";
            this.Text = "Consulta de Professor";
            ((System.ComponentModel.ISupportInitialize)(this.GrdConsultaP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.DataGridView GrdConsultaP;
    }
}