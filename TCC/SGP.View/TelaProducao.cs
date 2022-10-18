using SGP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.View
{
    public partial class TelaProducao : Form
    {
        Thread nt;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        Color Goldenrod = Color.Goldenrod;
        Color Sienna = Color.Sienna;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public TelaProducao(string Nome, int ID)
        {
            InitializeComponent();
            LblUsuario.Text = Nome;
            LblID.Text = ID.ToString();
        }

        private void TelaLogin()
        {
            Application.Run(new TelaLogin());
        }


        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }




        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(TelaLogin);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        public void LimpaMenus()
        {
            BtnMenuProducao.BackColor = Sienna;
            BtnMenuRelatorio.BackColor = Sienna;
        }

        private void LimpaTela()
        {
            BtnMenuProducao.BackColor = Sienna;
            BtnMenuRelatorio.BackColor = Sienna;
            BtnMenuAjuste.BackColor = Sienna;

        }

        private void PbxFundo_MouseClick(object sender, MouseEventArgs e)
        {
            LimpaTela();
        }


        private void PanelCabecalho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEntrada_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormularioEntrada>();

        }

        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMenuProducao_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormularioProducao>();

        }

        private void panelCabecalho_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BtnMenuRelatorio_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<RelatorioProducao>();
        }

        private void BtnMenuAjuste_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormularioAjuste>();
        }
    }
}
