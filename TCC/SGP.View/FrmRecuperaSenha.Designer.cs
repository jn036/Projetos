namespace SGP.View
{
    partial class FrmRecuperaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecuperaSenha));
            this.GrdSenhaNova = new System.Windows.Forms.GroupBox();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.TxtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.TxtNovaSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DteTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.GrdSenhaNova.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdSenhaNova
            // 
            this.GrdSenhaNova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdSenhaNova.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GrdSenhaNova.Controls.Add(this.BtnAlterar);
            this.GrdSenhaNova.Controls.Add(this.TxtConfirmarSenha);
            this.GrdSenhaNova.Controls.Add(this.TxtNovaSenha);
            this.GrdSenhaNova.Controls.Add(this.label4);
            this.GrdSenhaNova.Controls.Add(this.label3);
            this.GrdSenhaNova.Enabled = false;
            this.GrdSenhaNova.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrdSenhaNova.Location = new System.Drawing.Point(24, 274);
            this.GrdSenhaNova.Margin = new System.Windows.Forms.Padding(4);
            this.GrdSenhaNova.Name = "GrdSenhaNova";
            this.GrdSenhaNova.Padding = new System.Windows.Forms.Padding(4);
            this.GrdSenhaNova.Size = new System.Drawing.Size(1060, 219);
            this.GrdSenhaNova.TabIndex = 5;
            this.GrdSenhaNova.TabStop = false;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAlterar.BackgroundImage")));
            this.BtnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAlterar.Location = new System.Drawing.Point(632, 91);
            this.BtnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(65, 58);
            this.BtnAlterar.TabIndex = 10;
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // TxtConfirmarSenha
            // 
            this.TxtConfirmarSenha.Location = new System.Drawing.Point(230, 123);
            this.TxtConfirmarSenha.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConfirmarSenha.Name = "TxtConfirmarSenha";
            this.TxtConfirmarSenha.PasswordChar = '*';
            this.TxtConfirmarSenha.Size = new System.Drawing.Size(368, 26);
            this.TxtConfirmarSenha.TabIndex = 9;
            // 
            // TxtNovaSenha
            // 
            this.TxtNovaSenha.Location = new System.Drawing.Point(230, 57);
            this.TxtNovaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNovaSenha.Name = "TxtNovaSenha";
            this.TxtNovaSenha.PasswordChar = '*';
            this.TxtNovaSenha.Size = new System.Drawing.Size(368, 26);
            this.TxtNovaSenha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nova Senha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirmar Senha";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVoltar.BackgroundImage")));
            this.BtnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVoltar.Location = new System.Drawing.Point(1009, 7);
            this.BtnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(65, 58);
            this.BtnVoltar.TabIndex = 7;
            this.BtnVoltar.Text = " ";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(112, 98);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(612, 26);
            this.TxtEmail.TabIndex = 2;
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVerificar.BackgroundImage")));
            this.BtnVerificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVerificar.Location = new System.Drawing.Point(743, 84);
            this.BtnVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(65, 58);
            this.BtnVerificar.TabIndex = 6;
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.DteTimePickerNascimento);
            this.groupBox1.Controls.Add(this.BtnVerificar);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1060, 192);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // DteTimePickerNascimento
            // 
            this.DteTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerNascimento.Location = new System.Drawing.Point(267, 44);
            this.DteTimePickerNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.DteTimePickerNascimento.Name = "DteTimePickerNascimento";
            this.DteTimePickerNascimento.Size = new System.Drawing.Size(148, 26);
            this.DteTimePickerNascimento.TabIndex = 7;
            this.DteTimePickerNascimento.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Por favor, digite sua Data de Nascimento e seu Email.";
            // 
            // FrmRecuperaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 504);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GrdSenhaNova);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRecuperaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmRecuperraSenha";
            this.GrdSenhaNova.ResumeLayout(false);
            this.GrdSenhaNova.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GrdSenhaNova;
        private System.Windows.Forms.TextBox TxtConfirmarSenha;
        private System.Windows.Forms.TextBox TxtNovaSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DteTimePickerNascimento;
        private System.Windows.Forms.Label label5;
    }
}