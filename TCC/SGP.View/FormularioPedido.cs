using SGP.Control;
using SGP.Model;
using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.View
{
    public partial class FormularioPedido : Form
    {
        private CPedido _Control = new CPedido();
        private CReceita _ControlR = new CReceita();
        private CColaborador _ControlC = new CColaborador();
        private CFrota _ControlF = new CFrota();
        private CCliente _ControlCli = new CCliente();
        private CUsuario _ControlU = new CUsuario();
        PEDIDO _Pedido = null;
        PEDIDO oPedido = new PEDIDO();
        RECEITA oReceita = new RECEITA();
        FROTA oFrota = new FROTA();
        CLIENTE oCliente = new CLIENTE();
        COLABORADOR oColaborador = new COLABORADOR();


        public FormularioPedido()
        {
            InitializeComponent();
        }

        public FormularioPedido(PEDIDO Pedido)
        {
            InitializeComponent();
            _Pedido = Pedido;
            PopulaCampos();
        }
        private void DesabilitaCampos()
        {
            TxtIDCliente.Enabled = false;
            TxtIDCaminhao.Enabled = false;
            DteTimePickerData.Enabled = false;
        }
        private bool ValidaCampos()
        {
            return true;
        }
        public void LiberaCampos()
        {
            TxtIDCliente.Enabled = false;
            TxtIDCaminhao.Enabled = false;
            DteTimePickerData.Enabled = false;

            BtnSalvar.Enabled = true;
        }

        private void LimpaDados()
        {
            TxtIDCliente.Text = "";
            TxtIDCaminhao.Text = "";
            TxtModelo.Text = "";
            CboPlaca.Text = "";
            TxtIDReceita.Text = "";
            CboReceita.Text = "";
            CboCliente.Text = "";


        }
        private bool ValidaControles()
        {
            return true;
        }
        private void PopulaCampos()
        {
            TxtIDCliente.Text = _Pedido.ToString();
            TxtIDCaminhao.Text = _Pedido.ToString();
            DteTimePickerData.Text = _Pedido.ToString();
            BtnExcluir.Enabled = true;
        }

        private void CadastroPedido_Load(object sender, EventArgs e)
        {
            DteTimePickerData.Value = DateTime.Now;
            LblID.Visible = false;
            TxtID.Visible = false;

            USUARIO UltimoUsuario = _ControlU.UltimoUsuario();
            TxtColaborador.Text = UltimoUsuario.Nome;

            List<COLABORADOR> Colaboradores = _ControlC.SelecionarTodosColaboradores();
            foreach (var x in Colaboradores)
            {
                if (TxtColaborador.Text == x.Nome)
                {
                    TxtIDColaborador.Text = x.ID.ToString();
                }
            }

            List<CLIENTE> Clientes = _ControlCli.SelecionarTodosClientes();
            foreach (var x in Clientes)
            {
                CboCliente.Items.Add(x.Nome);
            }


            List<FROTA> Frotas = _ControlF.SelecionarTodasFrotas();
            foreach (var x in Frotas)
            {
                CboPlaca.Items.Add(x.Placa);
            }


            List<RECEITA> Receitas = _ControlR.SelecionarTodasReceitas();
            foreach (var x in Receitas)
            {
                CboReceita.Items.Add(x.Nome);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            oPedido.IDColaborador = int.Parse(TxtIDColaborador.Text);
            oPedido.IDCliente = int.Parse(TxtIDCliente.Text);
            oPedido.IDCaminhao = int.Parse(TxtIDCaminhao.Text);
            oPedido.IDReceita = int.Parse(TxtIDReceita.Text);
            oPedido.Data = DteTimePickerData.Value;
            oPedido.Controle = false;
            _Control.Incluir(oPedido);
            Mensagens.MsgIncluido();
            LimpaDados();
        }


        private void CboPlaca_TextChanged(object sender, EventArgs e)
        {
            List<FROTA> Frotas = _ControlF.SelecionarTodasFrotas();
            foreach (var x in Frotas)
            {
                if (CboPlaca.Text == x.Placa)
                {
                    TxtIDCaminhao.Text = x.ID.ToString();
                    TxtModelo.Text = x.Modelo;
                }
            }
        }

        private void CboReceita_TextChanged(object sender, EventArgs e)
        {
            List<RECEITA> Receitas = _ControlR.SelecionarTodasReceitas();
            foreach (var x in Receitas)
            {
                if (CboReceita.Text == x.Nome)
                {
                    TxtIDReceita.Text = x.ID.ToString();
                }
            }
        }

        private void CboCliente_TextChanged(object sender, EventArgs e)
        {
            List<CLIENTE> Clientes = _ControlCli.SelecionarTodosClientes();
            foreach (var x in Clientes)
            {
                if (CboCliente.Text == x.Nome)
                {
                    TxtIDCliente.Text = x.ID.ToString();
                }
            }
        }

        private void LblFormularioPedidos_Click(object sender, EventArgs e)
        {

        }

        private void TxtIDColaborador_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void panelPedido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}