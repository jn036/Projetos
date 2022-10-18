using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using SGP.Model;
using SGP.Model.Repositories;
using SGP.Control;
using System.Threading;
namespace SGP.View
{
    public partial class FormularioProducao : Form
    {
        int id;
        int areiaR, brita0R, brita1R, cimentoR, aditivoR, aguaR;
        int areiaP, brita0P, brita1P, cimentoP, aditivoP, aguaP, totalP;
        int areiaE, brita0E, brita1E, cimentoE, aditivoE;
        int areiaM, brita0M, brita1M, cimentoM, aditivoM, aguaM;
        int areiaT, brita0T, brita1T, cimentoT, aditivoT, aguaT;
        int saida, retorNo;
        string porta, retorno ;
        double MaiorIngrediente;
        private CPedido _Control = new CPedido();
        private CReceita _ControlR = new CReceita();
        private CFrota _ControlF = new CFrota();
        private CUsuario _ControlU = new CUsuario();
        private CEstoque _ControlE = new CEstoque();
        private CProducao _ControlP = new CProducao();
        private CAjuste _ControlA = new CAjuste();
        ESTOQUE Estoque = new ESTOQUE();
        RECEITA Receita = new RECEITA();
        PRODUCAO oProducao = new PRODUCAO();
        AJUSTE oAjuste = new AJUSTE();

        private void btnLigarUsina_Click(object sender, EventArgs e)
        {

        }

        PEDIDO oPedido = new PEDIDO();
        private void LblProgBrita1_Click(object sender, EventArgs e)
        {
        }
       
        public FormularioProducao()
        {
            InitializeComponent();
        }
        public string PrimeiroNome(string Nome)
        {
            string[] Primeiro = Nome.Split(' ');
            return Primeiro[0];
        }
        private void FrmProducao_Load(object sender, EventArgs e)
        {
            btnLimpar.Enabled = false;
            btnConfirmar.Enabled = false;
            btnSalvar.Enabled = false;
            CboPlaca.Enabled = false;
            DteTimePickerData.Value = DateTime.Now;
            USUARIO UltimoUsuario = _ControlU.UltimoUsuario();
            string retorno = PrimeiroNome(UltimoUsuario.Nome);
            TxtOperador.Text = retorno;
            List<FROTA> Frotas = _ControlF.SelecionarTodasFrotas();
            foreach (var x in Frotas)
            {
                CboPlaca.Items.Add(x.Placa);
            }
            List<PEDIDO> Pedidos = _Control.SelecionarTodosPedidos();
            foreach (var x in Pedidos)
            {
                if(x.Controle == false)
                {
                    CboPedido.Items.Add(x.ID);
                } 
            }
            string[] ports = SerialPort.GetPortNames();
            cboportas.Sorted = true;
            foreach (var s in ports)
            {
                cboportas.Items.Add(s);
            }
            if (cboportas.Items.Count > 0)
            {
                cboportas.SelectedIndex = 0;
                porta =cboportas.Text;
            }
        }
        private void btnPorta_Click(object sender, EventArgs e)
        {
        }
        private void timer_Tick(object sender, EventArgs e)
        {
        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                TxtMensagens.AppendText(serialPort1.ReadExisting());
            }
        }
        private void CboPedido_TextChanged(object sender, EventArgs e)
        {
            List<RECEITA> Receitas = _ControlR.SelecionarTodasReceitas();
            List<PEDIDO> Pedidos = _Control.SelecionarTodosPedidos();
            List<FROTA> Frotas = _ControlF.SelecionarTodasFrotas();

            if (CboPedido.Text == "" && CboPedido.Items.Count > 0)
            {
                CboPedido.Items.Clear();
            }
            foreach (var x in Pedidos)
            {
                if (CboPedido.Text == "")
                {
                    if (x.Controle == false)
                    {
                        CboPedido.Items.Add(x.ID);
                    }
                }
                if (CboPedido.Text == x.ID.ToString())
                {
                    TxtReceita.Text = x.IDReceita.ToString();
                    TxtPlaca.Text = x.IDCaminhao.ToString();
                }
            }

            foreach (var i in Receitas)
            {
                if (TxtReceita.Text == i.ID.ToString())
                {
                    id = i.ID;
                    TxtReceita.Text = i.Nome;
                    TxtQuantidade.Text = i.Total.ToString();
                }
            }
            foreach(var i in Frotas)
            {
                if (TxtPlaca.Text == i.ID.ToString())
                {
                    TxtPlaca.Text = i.Placa;
                }
            }
            CboPlaca.Enabled = true;
            btnLimpar.Enabled = true;
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaDados();
            CboPlaca.Enabled = false;
            btnConfirmar.Enabled = false;
        }
        private void CboPlaca_TextChanged(object sender, EventArgs e)
        {
            List<FROTA> Frotas = _ControlF.SelecionarTodasFrotas();
            foreach (var x in Frotas)
            {

                if (CboPlaca.Text == x.Placa)
                {
                    LblTara.Text = x.Tara.ToString();
                }
            }
            if (CboPlaca.Text == TxtPlaca.Text)
            {
            btnConfirmar.Enabled = true;
            TxtMensagens.Text = "";
            }
            else
            {
                TxtMensagens.Text = "Placa Incorreta!";
            }
        }
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            RECEITA Receita = _ControlR.SelecionarID(id);
            Estoque = _ControlE.EstoqueAtual();
            if (TxtPlaca.Text == CboPlaca.Text)
            {
                LblEstAreia.Text = Estoque.Agr1Est.ToString();
                LblEstBrita0.Text = Estoque.Agr2Est.ToString();
                LblEstBrita1.Text = Estoque.Agr3Est.ToString();
                LblEstCimento.Text = Estoque.Cim1Est.ToString();
                LblEstAditivo.Text = Estoque.Adit1Est.ToString();
                LblProgAreia.Text = Receita.Agr1Prog.ToString();
                LblProgBrita0.Text = Receita.Agr2Prog.ToString();
                LblProgBrita1.Text = Receita.Agr3Prog.ToString();
                LblProgCimento.Text = Receita.Cim1Prog.ToString();
                LblProgAditivo.Text = Receita.Adit1Prog.ToString();
                LblProgAgua.Text = Receita.Agua1Prog.ToString();
                MaiorIngrediente = Convert.ToDouble(Receita.Agr1Prog);
                if(Receita.Agr2Prog>MaiorIngrediente)
                {
                    MaiorIngrediente = Convert.ToDouble(Receita.Agr2Prog);
                }
                else if(Receita.Agr3Prog>MaiorIngrediente)
                {
                    MaiorIngrediente = Convert.ToDouble(Receita.Agr3Prog);
                }
                else if(Receita.Cim1Prog>MaiorIngrediente)
                {
                    MaiorIngrediente = Convert.ToDouble(Receita.Cim1Prog);
                }
                else if(Receita.Adit1Prog>MaiorIngrediente)
                {
                    MaiorIngrediente = Convert.ToDouble(Receita.Adit1Prog);
                }
                else if(Receita.Agua1Prog>MaiorIngrediente)
                {
                    MaiorIngrediente = Convert.ToDouble(Receita.Agua1Prog);
                }
                btnSalvar.Enabled = true;
                btnConfirmar.Enabled = false;
            }
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            AJUSTE Ajuste = _ControlA.UltimoAjuste();
            areiaM = Convert.ToInt32(Ajuste.minimoAreia);
            areiaT = Convert.ToInt32(Ajuste.tempoAreia);
            brita0M = Convert.ToInt32(Ajuste.minimoBrita0);
            brita0T = Convert.ToInt32(Ajuste.tempoBrita0);
            brita1M = Convert.ToInt32(Ajuste.minimoBrita1);
            brita1T = Convert.ToInt32(Ajuste.tempoBrita1);
            cimentoM = Convert.ToInt32(Ajuste.minimoCimento);
            cimentoT = Convert.ToInt32(Ajuste.tempoCimento);
            aditivoM = Convert.ToInt32(Ajuste.minimoaditivo);
            aditivoT = Convert.ToInt32(Ajuste.tempoAditivo);
            aguaM = Convert.ToInt32(Ajuste.tempoAgua);

            areiaR = Convert.ToInt32(LblProgAreia.Text);
            areiaP = Convert.ToInt32(LblProdAreia.Text);
            areiaE = Convert.ToInt32(LblEstAreia.Text);
            brita0R = Convert.ToInt32(LblProgBrita0.Text);
            brita0P = Convert.ToInt32(LblProdBrita0.Text);
            brita0E = Convert.ToInt32(LblEstBrita0.Text);
            brita1R = Convert.ToInt32(LblProgBrita1.Text);
            brita1P = Convert.ToInt32(LblProdBrita1.Text);
            brita1E = Convert.ToInt32(LblEstBrita1.Text);
            cimentoR = Convert.ToInt32(LblProgCimento.Text);
            cimentoP = Convert.ToInt32(LblProdCimento.Text);
            cimentoE = Convert.ToInt32(LblEstCimento.Text);
            aditivoR = Convert.ToInt32(LblProgAditivo.Text);
            aditivoP = Convert.ToInt32(LblProdAditivo.Text);
            aditivoE = Convert.ToInt32(LblEstAditivo.Text);
            aguaR = Convert.ToInt32(LblProgAgua.Text);
            aguaP = Convert.ToInt32(LblProdAgua.Text);
            totalP = Convert.ToInt32(lblQuantidadaCaminhao.Text);
            btnSalvar.Enabled = false;

            serialPort1.PortName = porta;
            serialPort1.BaudRate = 9600;
            serialPort1.Open();

            serialPort1.WriteLine("q");
            // verifica se o caminhao esta posicionado
            do
            {
                int ret = 0 , ct=0;
                retorno = "";
                retorno = serialPort1.ReadLine();
                ct = retorno.Length;
                retorno = retorno.Substring(0, ct-1);
                ret = Convert.ToInt32(retorno);
                lblDistancia.Text = retorno;
                lblDistancia.Update();
                retorNo = Convert.ToInt32(lblDistancia.Text);

                if (ret < 30)
                {
                    // distancia menor que 30 cm
                    Thread.Sleep(1000);
                    saida = 1;
                }
                else
                {
                    // distancia maior que 30 cm
                    Thread.Sleep(1000);
                    saida = 0;
                    serialPort1.WriteLine("q");

                }

            } while (saida == 0);

            serialPort1.WriteLine("n");
            serialPort1.WriteLine("p");
            lblEsteiraOn.BackColor = Color.Yellow;
            lblEsteiraOn.Update();
            for (int i=0; i<= MaiorIngrediente; i++)
            {
                if ((areiaR > areiaP) && (areiaR > 0))
                {
                    if (areiaE <= areiaM)
                    {
                        // verifica se a areia esta no estoque minimo
                        TxtMensagens.Text = "Areia esta no estoque minimo !!!";
                        TxtMensagens.BackColor = Color.Red;
                        TxtMensagens.Update();
                    } 
                    // envia valor para o arduino descarregar o produto areia
                    serialPort1.WriteLine("a");
                    // acende botao de ligado mudando a cor 
                    lblareiaON.BackColor = Color.Yellow;
                    lblareiaON.Update();
                    areiaP = Convert.ToInt32(LblProdAreia.Text) + 1;
                    LblProdAreia.Text = Convert.ToString(areiaP);
                    LblProdAreia.Update();
                    areiaE = Convert.ToInt32(LblEstAreia.Text) - 1;
                    LblEstAreia.Text = Convert.ToString(areiaE);
                    LblEstAreia.Update();
                    Thread.Sleep(areiaT);
                    lblareiaON.BackColor = Color.Gainsboro;
                    lblareiaON.Update();
                    // soma a totalQ + 1 e mostra o resultado
                    totalP = totalP + 1;
                    lblQuantidadaCaminhao.Text = Convert.ToString(totalP);
                    lblQuantidadaCaminhao.Update();
                    // limpar mensagen
                    TxtMensagens.Text = "";
                    TxtMensagens.BackColor = Color.White;
                    TxtMensagens.Update();
                    serialPort1.WriteLine("b");
                }
                if ((brita0R > brita0P) && (brita0R > 0))
                {
                    if (brita0E <= brita0M)
                    {
                        // verificao se a brita tipo 0 esta no estoque minimo
                        TxtMensagens.Text = "Brita tipo 0 esta no estoque minimo !!!";
                        TxtMensagens.BackColor = Color.Red;
                        TxtMensagens.Update();
                    }
                    serialPort1.Write("c");
                    lblbrita0On.BackColor = Color.Yellow;
                    lblbrita0On.Update();
                    brita0P = Convert.ToInt32(LblProdBrita0.Text) + 1;
                    LblProdBrita0.Text = Convert.ToString(brita0P);
                    LblProdBrita0.Update();
                    brita0E = Convert.ToInt32(LblEstBrita0.Text) - 1;
                    LblEstBrita0.Text = Convert.ToString(brita0E);
                    LblEstBrita0.Update();
                    Thread.Sleep(brita0T);
                    lblbrita0On.BackColor = Color.Gainsboro;
                    lblbrita0On.Update();
                    // soma a totalQ + 1 e mostra o resultado
                    totalP = totalP + 1;
                    lblQuantidadaCaminhao.Text = Convert.ToString(totalP);
                    lblQuantidadaCaminhao.Update();
                    // limpar mensagen
                    TxtMensagens.BackColor = Color.White;
                    TxtMensagens.Text = "";
                    TxtMensagens.Update();
                    serialPort1.WriteLine("d");
                }
                if ((brita1R > brita1P) && (brita1R > 0))
                {
                    if (brita1E <= brita1M)
                    {
                        // verifica se a brita tipo 1  esta no estoque minimo
                        TxtMensagens.Text = "Brita tipo 1 esta no estoque minimo !!!";
                        TxtMensagens.BackColor = Color.Red;
                        TxtMensagens.Update();
                    }
                    serialPort1.Write("e");
                    lblBrita1On.BackColor = Color.Yellow;
                    lblBrita1On.Update();
                    brita1P = Convert.ToInt32(LblProdBrita1.Text) + 1;
                    LblProdBrita1.Text = Convert.ToString(brita1P);
                    LblProdBrita1.Update();
                    brita1E = Convert.ToInt32(LblEstBrita1.Text) - 1;
                    LblEstBrita1.Text = Convert.ToString(brita1E);
                    LblEstBrita1.Update();
                    Thread.Sleep(brita1T);
                    lblBrita1On.BackColor = Color.Gainsboro;
                    lblBrita1On.Update();
                    // soma a totalQ + 1 e mostra o resultado
                    totalP = totalP + 1;
                    lblQuantidadaCaminhao.Text = Convert.ToString(totalP);
                    lblQuantidadaCaminhao.Update();
                    // limpar mensagen
                    TxtMensagens.Text = "";
                    TxtMensagens.BackColor = Color.White;
                    TxtMensagens.Update();
                    serialPort1.WriteLine("f");
                }
                if ((cimentoR > cimentoP) && (cimentoR > 0))
                {
                    if (cimentoE <= cimentoM)
                    {
                        // verificao se  o cimento esta no estoque minimo
                        TxtMensagens.Text = "Cimento esta no estoque minimo !!!";
                        TxtMensagens.BackColor = Color.Red;
                    }
                    serialPort1.Write("g");
                    lblCimentoOn.BackColor = Color.Yellow;
                    lblCimentoOn.Update();
                    cimentoP = Convert.ToInt32(LblProdCimento.Text) + 1;
                    LblProdCimento.Text = Convert.ToString(cimentoP);
                    LblProdCimento.Update();
                    cimentoE = Convert.ToInt32(LblEstCimento.Text) - 1;
                    LblEstCimento.Text = Convert.ToString(cimentoE);
                    LblEstCimento.Update();
                    Thread.Sleep(cimentoT);
                    lblCimentoOn.BackColor = Color.Gainsboro;
                    lblCimentoOn.Update();
                    // soma a totalQ + 1 e mostra o resultado
                    totalP = totalP + 1;
                    lblQuantidadaCaminhao.Text = Convert.ToString(totalP);
                    lblQuantidadaCaminhao.Update();
                    // limpar mensagen
                    TxtMensagens.Text = "";
                    TxtMensagens.BackColor = Color.White;
                    TxtMensagens.Update();
                    serialPort1.WriteLine("h");
                }
                if ((aditivoR > aditivoP) && (aditivoR > 0))
                {
                    if (aditivoE <= aditivoM)
                    {
                        // verifica se o aditivo esta no estoque minimo
                        TxtMensagens.Text = "Aditivo esta no estoque minimo !!!";
                        TxtMensagens.BackColor = Color.Red;
                    }
                    serialPort1.Write("i");
                    lblAditivoOn.BackColor = Color.Yellow;
                    lblAditivoOn.Update();
                    aditivoP = Convert.ToInt32(LblProdAditivo.Text) + 1;
                    LblProdAditivo.Text = Convert.ToString(aditivoP);
                    LblProdAditivo.Update();
                    aditivoE = Convert.ToInt32(LblEstAditivo.Text) - 1;
                    LblEstAditivo.Text = Convert.ToString(aditivoE);
                    LblEstAditivo.Update();
                    Thread.Sleep(aditivoT);
                    lblAditivoOn.BackColor = Color.Gainsboro;
                    lblAditivoOn.Update();
                    // soma a totalQ + 1 e mostra o resultado
                    totalP = totalP + 1;
                    lblQuantidadaCaminhao.Text = Convert.ToString(totalP);
                    lblQuantidadaCaminhao.Update();
                    // limpar mensagen
                    TxtMensagens.Text = "";
                    TxtMensagens.BackColor = Color.White;
                    TxtMensagens.Update();
                    serialPort1.WriteLine("j");
                }
                if ((aguaR > aguaP) && (aguaR > 0))
                {
                    serialPort1.Write("l");
                    lblAguaOn.BackColor = Color.Yellow;
                    lblAguaOn.Update();
                    aguaP = Convert.ToInt32(LblProdAgua.Text) + 1;
                    LblProdAgua.Text = Convert.ToString(aguaP);
                    LblProdAgua.Update();
                    Thread.Sleep(aguaT);
                    lblAguaOn.BackColor = Color.Gainsboro;
                    lblAguaOn.Update();
                    // soma a totalQ + 1 e mostra o resultado
                    totalP = totalP + 1;
                    lblQuantidadaCaminhao.Text = Convert.ToString(totalP);
                    lblQuantidadaCaminhao.Update();
                    // limpar mensagen
                    serialPort1.WriteLine("m");
                }
            }
            serialPort1.WriteLine("o");
            serialPort1.WriteLine("q");
            lblEsteiraOn.BackColor = Color.Gainsboro;
            lblEsteiraOn.Update();
            serialPort1.Close();

            oProducao.Agr1Prog = float.Parse(LblProgAreia.Text);
            oProducao.Agr2Prog = float.Parse(LblProgBrita0.Text);
            oProducao.Agr3Prog = float.Parse(LblProgBrita1.Text);
            oProducao.CimProg = float.Parse(LblProgCimento.Text);
            oProducao.AditProg = float.Parse(LblProgAditivo.Text);
            oProducao.AguaProg = float.Parse(LblProgAgua.Text);
            oProducao.DataProducao = DteTimePickerData.Value;
            oProducao.Quantidade = float.Parse(TxtQuantidade.Text);
            oProducao.IDPedido = int.Parse(CboPedido.Text);
            oProducao.Agr1Real = oProducao.Agr1Prog;
            oProducao.Agr2Real = oProducao.Agr2Prog;
            oProducao.Agr3Real = oProducao.Agr3Prog;
            oProducao.CimReal = oProducao.CimProg;
            oProducao.AditReal = oProducao.AditProg;
            oProducao.AguaReal = oProducao.AguaProg;
            _ControlP.Incluir(oProducao);
            int id = oProducao.IDPedido;
            PEDIDO Pedido = _Control.SelecionarID(id);
            Pedido.Controle = true;
            _Control.Alterar(Pedido);
            LimpaDados();
            btnConfirmar.Enabled = false;
            btnLimpar.Enabled = false;
            CboPlaca.Enabled = false;
        }
        public void LimpaDados()
        {
            TxtPlaca.Text = "";
            TxtQuantidade.Text = "";
            TxtReceita.Text = "";
            CboPedido.Text = "";
            CboPlaca.Text = "";            
            LblEstAreia.Text = "0";
            LblEstBrita0.Text = "0";
            LblEstBrita1.Text = "0";
            LblEstCimento.Text = "0";
            LblEstAditivo.Text = "0";
            LblProgAreia.Text = "0";
            LblProgBrita0.Text = "0";
            LblProgBrita1.Text = "0";
            LblProgCimento.Text = "0";
            LblProgAditivo.Text = "0";
            LblProgAgua.Text = "0";
            LblProdAreia.Text = "0";
            LblProdBrita0.Text = "0";
            LblProdBrita1.Text = "0";
            LblProdCimento.Text = "0";
            LblProdAditivo.Text = "0";
            LblProdAgua.Text = "0";
            LblTara.Text = "0";
            lblDistancia.Text = "0";
        }
        private void panelProducao_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
