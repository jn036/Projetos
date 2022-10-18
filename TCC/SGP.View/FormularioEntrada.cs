using SGP.Control;
using SGP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.View
{
    public partial class FormularioEntrada : Form
    {
        private CEntrada _Control = new CEntrada();
        private CColaborador _ControlC = new CColaborador();
        private CFornecedor _ControlF = new CFornecedor();
        private CEstoque _ControlE = new CEstoque();
        private CUsuario _ControlU = new CUsuario();
        public double valorretonardo;
        ENTRADA oEntrada = new ENTRADA();
        ESTOQUE Estoque = new ESTOQUE();
        ESTOQUE oEstoque = new ESTOQUE();
        public byte[] Imagem;

         public FormularioEntrada()
        {
            InitializeComponent();
        
        }


        private void LimpaDados()
        {
            TxtFunçao.Text = "";
            CboFornecedor.Text = "";
            TxtCidade.Text = "";
            MskCelular.Text = "";
            MskTelefone.Text = "";
            TxtQtd.Text = "";
            TxtNF.Text = "";
            CboProduto.Text = "";
            PbFornecedor.Image = Properties.Resources.Caricatura;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            List<FORNECEDOR> Fornecedores = _ControlF.SelecionarTodosFornecedores();
            foreach (var x in Fornecedores)
            {
                if (CboFornecedor.Text == x.Nome)
                {
                    oEntrada.IDFornecedor = x.ID;
                }
            }

            List<COLABORADOR> Colaboradores = _ControlC.SelecionarTodosColaboradores();
            foreach (var x in Colaboradores)
            {
                if (TxtColaborador.Text == x.Nome)
                {
                    oEntrada.IDColaborador = x.ID;
                }
            }
            oEntrada.DataEntrada = DteTimePickerDataEntrada.Value;
            oEntrada.Insumo = CboProduto.Text;
            oEntrada.NF = TxtNF.Text;
            oEntrada.QtdEntrada = double.Parse(TxtQtd.Text);





            _Control.Incluir(oEntrada);
            Mensagens.MsgIncluido();
            LimpaDados();
            
        }

        private void FormularioEntrada_Load(object sender, EventArgs e)
        {
            LblID.Visible = false;
            TxtID.Visible = false;
            DteTimePickerDataEntrada.Value = DateTime.Now;
            Estoque = _ControlE.EstoqueAtual();
            List<ESTOQUE> EstoqueVazio = _ControlE.VerificaTabelaVazia();

            if (EstoqueVazio.Count == 0)
            {
                oEstoque.ID = 1;
                oEstoque.Agr1Est = 0;
                oEstoque.Agr2Est = 0;
                oEstoque.Agr3Est = 0;
                oEstoque.Cim1Est = 0;
                oEstoque.Adit1Est = 0;
                _ControlE.Incluir(oEstoque);
            }
            else
            {
                LblQtdAreia.Text = Estoque.Agr1Est.ToString();
                LblQtdBrita0.Text = Estoque.Agr2Est.ToString();
                LblQtdBrita1.Text = Estoque.Agr3Est.ToString();
                LblQtdCimento.Text = Estoque.Cim1Est.ToString();
                LblQtdAditivo.Text = Estoque.Adit1Est.ToString();
            }

            USUARIO UltimoUsuario = _ControlU.UltimoUsuario();
            TxtColaborador.Text = UltimoUsuario.Nome;

            List<COLABORADOR> Colaboradores = _ControlC.SelecionarTodosColaboradores();
            foreach (var x in Colaboradores)
            {
                if (TxtColaborador.Text == x.Nome)
                {
                    TxtFunçao.Text = x.Funcao;
                }
            }

            List<FORNECEDOR> Fornecedores = _ControlF.SelecionarTodosFornecedores();
            foreach (var x in Fornecedores)
            {
                CboFornecedor.Items.Add(x.Nome);
            }

            CboFornecedor.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void CboFornecedor_TextChanged(object sender, EventArgs e)
        {
           
            List<FORNECEDOR> Fornecedores = _ControlF.SelecionarTodosFornecedores();
            foreach (var x in Fornecedores)
            {
                if (CboFornecedor.Text == x.Nome)
                {
                    PbFornecedor.Image = byteArrayToImage(x.Imagem);
                    TxtCidade.Text = x.Cidade;
                    MskTelefone.Text = x.Telefone;
                    MskCelular.Text = x.Celular;

                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panelEntrada_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
