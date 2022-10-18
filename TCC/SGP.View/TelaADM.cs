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
    public partial class TelaADM : Form
    {
        Thread nt;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        Color Goldenrod = Color.Goldenrod;
        Color DarkGray = Color.DarkGray;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public TelaADM(string Nome, int ID)
        {
            InitializeComponent();
            LblUsuario.Text = Nome;
            LblID.Text = ID.ToString();
           
        }

        private void FormPRD()
        {       
            Application.Run(new TelaProducao("Operador", 1));
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
                formulario = new Forms
                {
                    TopLevel = false
                };
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


        private void BtnColaborador_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CadastroColaborador>();
            panelCadastros.Visible = false;
            BtnMenuCadastros.BackColor = DarkGray;
        }

        private void BtnFrota_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CadastroFrota>();
            panelCadastros.Visible = false;
            BtnMenuCadastros.BackColor = DarkGray;
        }


        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CadastroCliente>();
            panelCadastros.Visible = false;
            BtnMenuCadastros.BackColor = DarkGray;

        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CadastroFornecedor>();
            panelCadastros.Visible = false;
            BtnMenuCadastros.BackColor = DarkGray;


        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(TelaLogin);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void BtnMenuCadastros_Click(object sender, EventArgs e)
        {
            LimpaTela();
            Point pt = new Point(0, 115);
            panelCadastros.Location = pt;
            panelCadastros.Visible = true;
            BtnMenuCadastros.BackColor = Goldenrod; 

        }

        public void LimpaMenus()
        {
            BtnMenuCadastros.BackColor = DarkGray;
            BtnMenuEstoque.BackColor = DarkGray;
            BtnMenuPedidos.BackColor = DarkGray;
            BtnMenuRelatorio.BackColor = DarkGray;
        }

        private void LimpaTela()
        {
            panelCadastros.Visible = false;
            panelEstoque.Visible = false;
            panelConsulta.Visible = false;
            panelRelatorios.Visible = false;
            BtnMenuConsultar.BackColor = DarkGray;
            BtnMenuCadastros.BackColor = DarkGray;
            BtnMenuEstoque.BackColor = DarkGray;
            BtnMenuPedidos.BackColor = DarkGray;
            BtnMenuRelatorio.BackColor = DarkGray;
            BtnMenuEstoque.BackColor = DarkGray;

            
        }

        private void verificaTela()
        {
                if (WindowState != FormWindowState.Normal)
                {
                   BtnMaximizar.Visible = true;
                }
        }

        private void PbxFundo_MouseClick(object sender, MouseEventArgs e)
        {
            LimpaTela();
        }

        private void BtnMenuEstoque_Click(object sender, EventArgs e)
        {
            LimpaTela();
            Point pt = new Point(0, 250);
            panelEstoque.Location = pt;
            panelEstoque.Visible = true;
            BtnMenuEstoque.BackColor = Goldenrod;
        }

        private void BtnEntrada_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormularioEntrada>();
            panelEstoque.Visible = false;
            BtnMenuEstoque.BackColor = DarkGray;

        }

        private void BtnConsultarEstoque_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<ConsultarEntrada>();
            panelEstoque.Visible = false;
            BtnMenuEstoque.BackColor = DarkGray;
        }


        private void BtnMenuPedidos_Click(object sender, EventArgs e)
        {
            LimpaTela();
            AbrirFormNoPanel<FormularioPedido>();
        }

        private void TelaADM_Load(object sender, EventArgs e)
        {
        
        }

        private void BtnMenuConsultar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            Point pt = new Point(0, 160);
            panelConsulta.Location = pt;
            panelConsulta.Visible = true;
            BtnMenuConsultar.BackColor = Goldenrod;
        }

        private void BtnConsultaColaborador_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<ConsultarColaborador>();
            panelConsulta.Visible = false;
            BtnMenuConsultar.BackColor = DarkGray;
        }

        private void BtnConsultaCliente_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<ConsultarCliente>();
            panelConsulta.Visible = false;
            BtnMenuConsultar.BackColor = DarkGray;
        }

        private void BtnConsultaFornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<ConsultarFornecedor>();
            panelConsulta.Visible = false;
            BtnMenuConsultar.BackColor = DarkGray;
        }

        private void BtnConsultaFrota_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<ConsultarFrota>();
            panelConsulta.Visible = false;
            BtnMenuConsultar.BackColor = DarkGray;
        }

        private void panelCabecalho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultarReceita_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<ConsultarReceita>();
            panelConsulta.Visible = false;
        }

        private void BtnRelProducao_Click(object sender, EventArgs e)
        {
            LimpaTela();
            AbrirFormNoPanel<RelatorioProducao>();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(FormPRD);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void BtnMenuRelatorio_Click(object sender, EventArgs e)
        {
            LimpaTela();
            Point pt = new Point(0, 206);
            panelRelatorios.Location = pt;
            panelRelatorios.Visible = true;
            BtnMenuRelatorio.BackColor = Goldenrod;
        }

        private void BtnRelFrota_Click(object sender, EventArgs e)
        {
            LimpaTela();
            AbrirFormNoPanel<RelatorioFrota>();
        }

        private void BtnRelColaborador_Click(object sender, EventArgs e)
        {
            LimpaTela();
            AbrirFormNoPanel<RelatorioColaborador>();
        }

        private void BtnRelCliente_Click(object sender, EventArgs e)
        {
            LimpaTela();
            AbrirFormNoPanel<RelatorioCliente>();
        }

        private void BtnRelFornecedor_Click(object sender, EventArgs e)
        {
            LimpaTela();
            AbrirFormNoPanel<RelatorioFornecedor>();
        }

        private void BtnRelReceita_Click(object sender, EventArgs e)
        {
            LimpaTela();
            AbrirFormNoPanel<RelatorioReceita>();
        }

        private void BtnRelEstoque_Click(object sender, EventArgs e)
        {
            LimpaTela();
            AbrirFormNoPanel<RelatorioEstoque>();
        }

        private void BtnRelPedido_Click(object sender, EventArgs e)
        {
            LimpaTela();
            AbrirFormNoPanel<RelatorioPedido>();
        }

        private void BtnReceita_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CadastroReceita>();
            panelCadastros.Visible = false;
            BtnMenuCadastros.BackColor = DarkGray;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void PanelCabecalho_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
