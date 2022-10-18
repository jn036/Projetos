namespace SGP.View
{
    partial class RelatorioFrota
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
            this.CrvFrota = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RelatorioFrota1 = new SGP.View.Relatorios.RelatorioFrota();
            this.SuspendLayout();
            // 
            // CrvFrota
            // 
            this.CrvFrota.ActiveViewIndex = 0;
            this.CrvFrota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvFrota.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvFrota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvFrota.Location = new System.Drawing.Point(0, 0);
            this.CrvFrota.Name = "CrvFrota";
            this.CrvFrota.ReportSource = this.RelatorioFrota1;
            this.CrvFrota.Size = new System.Drawing.Size(831, 561);
            this.CrvFrota.TabIndex = 0;
            this.CrvFrota.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // RelatorioFrota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 561);
            this.Controls.Add(this.CrvFrota);
            this.Name = "RelatorioFrota";
            this.Text = "Relatório de Frota";
            this.Load += new System.EventHandler(this.RelatorioFrota_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvFrota;
        private Relatorios.RelatorioFrota RelatorioFrota1;
    }
}