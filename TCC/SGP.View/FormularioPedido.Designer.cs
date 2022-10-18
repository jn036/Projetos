namespace SGP.View
{
    partial class FormularioPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPedido));
            this.panelPedido = new System.Windows.Forms.Panel();
            this.LblFormularioPedidos = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CboReceita = new System.Windows.Forms.ComboBox();
            this.LblIDReceita = new System.Windows.Forms.Label();
            this.TxtIDReceita = new System.Windows.Forms.TextBox();
            this.LblReceita = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CboPlaca = new System.Windows.Forms.ComboBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.LblModelo = new System.Windows.Forms.Label();
            this.LblIDCaminhao = new System.Windows.Forms.Label();
            this.TxtIDCaminhao = new System.Windows.Forms.TextBox();
            this.LblPlaca = new System.Windows.Forms.Label();
            this.DteTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblIDCliente = new System.Windows.Forms.Label();
            this.TxtIDCliente = new System.Windows.Forms.TextBox();
            this.LblData = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblColaborador = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtIDColaborador = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.LblIDColaborador = new System.Windows.Forms.Label();
            this.TxtColaborador = new System.Windows.Forms.TextBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.panelPedido.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPedido
            // 
            this.panelPedido.Controls.Add(this.LblFormularioPedidos);
            this.panelPedido.Controls.Add(this.groupBox5);
            this.panelPedido.Controls.Add(this.groupBox3);
            this.panelPedido.Controls.Add(this.DteTimePickerData);
            this.panelPedido.Controls.Add(this.groupBox2);
            this.panelPedido.Controls.Add(this.LblData);
            this.panelPedido.Controls.Add(this.groupBox1);
            this.panelPedido.Controls.Add(this.BtnSair);
            this.panelPedido.Controls.Add(this.BtnExcluir);
            this.panelPedido.Controls.Add(this.BtnSalvar);
            this.panelPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPedido.Location = new System.Drawing.Point(0, 0);
            this.panelPedido.Margin = new System.Windows.Forms.Padding(4);
            this.panelPedido.Name = "panelPedido";
            this.panelPedido.Size = new System.Drawing.Size(839, 788);
            this.panelPedido.TabIndex = 0;
            this.panelPedido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPedido_Paint);
            // 
            // LblFormularioPedidos
            // 
            this.LblFormularioPedidos.AutoSize = true;
            this.LblFormularioPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormularioPedidos.Location = new System.Drawing.Point(23, 20);
            this.LblFormularioPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFormularioPedidos.Name = "LblFormularioPedidos";
            this.LblFormularioPedidos.Size = new System.Drawing.Size(221, 20);
            this.LblFormularioPedidos.TabIndex = 389;
            this.LblFormularioPedidos.Text = "FORMULÁRIO DE PEDIDOS";
            this.LblFormularioPedidos.Click += new System.EventHandler(this.LblFormularioPedidos_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox5.Controls.Add(this.CboReceita);
            this.groupBox5.Controls.Add(this.LblIDReceita);
            this.groupBox5.Controls.Add(this.TxtIDReceita);
            this.groupBox5.Controls.Add(this.LblReceita);
            this.groupBox5.Location = new System.Drawing.Point(22, 575);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(799, 142);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // CboReceita
            // 
            this.CboReceita.FormattingEnabled = true;
            this.CboReceita.Location = new System.Drawing.Point(169, 86);
            this.CboReceita.Margin = new System.Windows.Forms.Padding(4);
            this.CboReceita.Name = "CboReceita";
            this.CboReceita.Size = new System.Drawing.Size(276, 26);
            this.CboReceita.TabIndex = 8;
            this.CboReceita.TextChanged += new System.EventHandler(this.CboReceita_TextChanged);
            // 
            // LblIDReceita
            // 
            this.LblIDReceita.AutoSize = true;
            this.LblIDReceita.Location = new System.Drawing.Point(62, 45);
            this.LblIDReceita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIDReceita.Name = "LblIDReceita";
            this.LblIDReceita.Size = new System.Drawing.Size(81, 18);
            this.LblIDReceita.TabIndex = 1;
            this.LblIDReceita.Text = "ID Receita";
            // 
            // TxtIDReceita
            // 
            this.TxtIDReceita.Location = new System.Drawing.Point(172, 42);
            this.TxtIDReceita.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIDReceita.Name = "TxtIDReceita";
            this.TxtIDReceita.Size = new System.Drawing.Size(148, 26);
            this.TxtIDReceita.TabIndex = 2;
            // 
            // LblReceita
            // 
            this.LblReceita.AutoSize = true;
            this.LblReceita.Location = new System.Drawing.Point(74, 89);
            this.LblReceita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblReceita.Name = "LblReceita";
            this.LblReceita.Size = new System.Drawing.Size(62, 18);
            this.LblReceita.TabIndex = 3;
            this.LblReceita.Text = "Receita";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Controls.Add(this.CboPlaca);
            this.groupBox3.Controls.Add(this.TxtModelo);
            this.groupBox3.Controls.Add(this.LblModelo);
            this.groupBox3.Controls.Add(this.LblIDCaminhao);
            this.groupBox3.Controls.Add(this.TxtIDCaminhao);
            this.groupBox3.Controls.Add(this.LblPlaca);
            this.groupBox3.Location = new System.Drawing.Point(22, 403);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(799, 149);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // CboPlaca
            // 
            this.CboPlaca.FormattingEnabled = true;
            this.CboPlaca.Location = new System.Drawing.Point(174, 65);
            this.CboPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.CboPlaca.Name = "CboPlaca";
            this.CboPlaca.Size = new System.Drawing.Size(148, 26);
            this.CboPlaca.TabIndex = 8;
            this.CboPlaca.TextChanged += new System.EventHandler(this.CboPlaca_TextChanged);
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(174, 102);
            this.TxtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(276, 26);
            this.TxtModelo.TabIndex = 5;
            // 
            // LblModelo
            // 
            this.LblModelo.AutoSize = true;
            this.LblModelo.Location = new System.Drawing.Point(78, 110);
            this.LblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(60, 18);
            this.LblModelo.TabIndex = 5;
            this.LblModelo.Text = "Modelo";
            // 
            // LblIDCaminhao
            // 
            this.LblIDCaminhao.AutoSize = true;
            this.LblIDCaminhao.Location = new System.Drawing.Point(49, 32);
            this.LblIDCaminhao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIDCaminhao.Name = "LblIDCaminhao";
            this.LblIDCaminhao.Size = new System.Drawing.Size(99, 18);
            this.LblIDCaminhao.TabIndex = 1;
            this.LblIDCaminhao.Text = "ID Caminhão";
            // 
            // TxtIDCaminhao
            // 
            this.TxtIDCaminhao.Location = new System.Drawing.Point(174, 24);
            this.TxtIDCaminhao.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIDCaminhao.Name = "TxtIDCaminhao";
            this.TxtIDCaminhao.Size = new System.Drawing.Size(148, 26);
            this.TxtIDCaminhao.TabIndex = 2;
            // 
            // LblPlaca
            // 
            this.LblPlaca.AutoSize = true;
            this.LblPlaca.Location = new System.Drawing.Point(88, 73);
            this.LblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPlaca.Name = "LblPlaca";
            this.LblPlaca.Size = new System.Drawing.Size(48, 18);
            this.LblPlaca.TabIndex = 3;
            this.LblPlaca.Text = "Placa";
            // 
            // DteTimePickerData
            // 
            this.DteTimePickerData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DteTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteTimePickerData.Location = new System.Drawing.Point(684, 15);
            this.DteTimePickerData.Margin = new System.Windows.Forms.Padding(4);
            this.DteTimePickerData.Name = "DteTimePickerData";
            this.DteTimePickerData.Size = new System.Drawing.Size(126, 26);
            this.DteTimePickerData.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.CboCliente);
            this.groupBox2.Controls.Add(this.LblCliente);
            this.groupBox2.Controls.Add(this.LblIDCliente);
            this.groupBox2.Controls.Add(this.TxtIDCliente);
            this.groupBox2.Location = new System.Drawing.Point(22, 261);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(799, 120);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // CboCliente
            // 
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(174, 72);
            this.CboCliente.Margin = new System.Windows.Forms.Padding(4);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(390, 26);
            this.CboCliente.TabIndex = 8;
            this.CboCliente.TextChanged += new System.EventHandler(this.CboCliente_TextChanged);
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(88, 77);
            this.LblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(50, 18);
            this.LblCliente.TabIndex = 7;
            this.LblCliente.Text = "Nome";
            // 
            // LblIDCliente
            // 
            this.LblIDCliente.AutoSize = true;
            this.LblIDCliente.Location = new System.Drawing.Point(62, 27);
            this.LblIDCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIDCliente.Name = "LblIDCliente";
            this.LblIDCliente.Size = new System.Drawing.Size(76, 18);
            this.LblIDCliente.TabIndex = 5;
            this.LblIDCliente.Text = "ID Cliente";
            // 
            // TxtIDCliente
            // 
            this.TxtIDCliente.Location = new System.Drawing.Point(174, 27);
            this.TxtIDCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIDCliente.Name = "TxtIDCliente";
            this.TxtIDCliente.Size = new System.Drawing.Size(113, 26);
            this.TxtIDCliente.TabIndex = 6;
            // 
            // LblData
            // 
            this.LblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblData.AutoSize = true;
            this.LblData.Location = new System.Drawing.Point(624, 20);
            this.LblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(42, 18);
            this.LblData.TabIndex = 3;
            this.LblData.Text = "Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.LblColaborador);
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.TxtIDColaborador);
            this.groupBox1.Controls.Add(this.LblID);
            this.groupBox1.Controls.Add(this.LblIDColaborador);
            this.groupBox1.Controls.Add(this.TxtColaborador);
            this.groupBox1.Location = new System.Drawing.Point(22, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(799, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblColaborador
            // 
            this.LblColaborador.AutoSize = true;
            this.LblColaborador.Location = new System.Drawing.Point(90, 91);
            this.LblColaborador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblColaborador.Name = "LblColaborador";
            this.LblColaborador.Size = new System.Drawing.Size(50, 18);
            this.LblColaborador.TabIndex = 7;
            this.LblColaborador.Text = "Nome";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(397, 37);
            this.TxtID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(148, 26);
            this.TxtID.TabIndex = 2;
            // 
            // TxtIDColaborador
            // 
            this.TxtIDColaborador.Location = new System.Drawing.Point(174, 40);
            this.TxtIDColaborador.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIDColaborador.Name = "TxtIDColaborador";
            this.TxtIDColaborador.Size = new System.Drawing.Size(113, 26);
            this.TxtIDColaborador.TabIndex = 6;
            this.TxtIDColaborador.TextChanged += new System.EventHandler(this.TxtIDColaborador_TextChanged);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(340, 40);
            this.LblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(23, 18);
            this.LblID.TabIndex = 1;
            this.LblID.Text = "ID";
            // 
            // LblIDColaborador
            // 
            this.LblIDColaborador.AutoSize = true;
            this.LblIDColaborador.Location = new System.Drawing.Point(33, 48);
            this.LblIDColaborador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIDColaborador.Name = "LblIDColaborador";
            this.LblIDColaborador.Size = new System.Drawing.Size(115, 18);
            this.LblIDColaborador.TabIndex = 5;
            this.LblIDColaborador.Text = "ID Colaborador";
            // 
            // TxtColaborador
            // 
            this.TxtColaborador.Location = new System.Drawing.Point(174, 91);
            this.TxtColaborador.Name = "TxtColaborador";
            this.TxtColaborador.Size = new System.Drawing.Size(390, 26);
            this.TxtColaborador.TabIndex = 9;
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.Location = new System.Drawing.Point(770, 49);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(40, 35);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.BackgroundImage")));
            this.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExcluir.Location = new System.Drawing.Point(722, 49);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(40, 35);
            this.BtnExcluir.TabIndex = 5;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.BackgroundImage")));
            this.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalvar.Location = new System.Drawing.Point(674, 49);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(40, 35);
            this.BtnSalvar.TabIndex = 3;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // FormularioPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(839, 788);
            this.Controls.Add(this.panelPedido);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioPedido";
            this.Text = "CadastroPedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastroPedido_Load);
            this.panelPedido.ResumeLayout(false);
            this.panelPedido.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPedido;
        private System.Windows.Forms.DateTimePicker DteTimePickerData;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.Label LblPlaca;
        private System.Windows.Forms.TextBox TxtIDColaborador;
        private System.Windows.Forms.Label LblIDColaborador;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.TextBox TxtIDCaminhao;
        private System.Windows.Forms.Label LblIDCaminhao;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblReceita;
        private System.Windows.Forms.Label LblIDReceita;
        private System.Windows.Forms.Label LblColaborador;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label LblFormularioPedidos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label LblIDCliente;
        private System.Windows.Forms.TextBox TxtIDCliente;
        private System.Windows.Forms.ComboBox CboReceita;
        private System.Windows.Forms.TextBox TxtIDReceita;
        private System.Windows.Forms.ComboBox CboPlaca;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.TextBox TxtColaborador;
    }
}