using SGP.Control;
using SGP.Model;
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
    public partial class CadastroReceita : Form
    {

        float Areia, Brita0, Brita1, Cimento, Aditivo, Agua, Total;
        private CReceita _Control = new CReceita();
        RECEITA oReceita = new RECEITA();
        RECEITA _Receita = null;
        public CadastroReceita()
        {
            InitializeComponent();
        }

        public CadastroReceita(RECEITA Receita)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(125, 40);
            _Receita = Receita;
            PopulaCampos();
        }

        public void PopulaCampos()
        {
            TxtID.Text = _Receita.ID.ToString();
            TxtNome.Text = _Receita.Nome;
            TxtAreia.Text = _Receita.Agr1Prog.ToString();
            TxtBrita0.Text = _Receita.Agr2Prog.ToString();
            TxtBrita1.Text = _Receita.Agr3Prog.ToString();
            TxtCimento.Text = _Receita.Cim1Prog.ToString();
            TxtAditivo.Text = _Receita.Adit1Prog.ToString();
            TxtAgua.Text = _Receita.Agua1Prog.ToString();
            TxtTotal.Text = _Receita.Total.ToString();
            BtnExcluir.Enabled = true;
        }

        private void panelCadastroReceita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LblSenha_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CadastroReceita_Load(object sender, EventArgs e)
        {
            LblID.Visible = false;
            TxtID.Visible = false;

            if (_Receita == null)
            {

            TxtAreia.Text = "0";
            TxtBrita0.Text = "0";
            TxtBrita1.Text = "0";
            TxtCimento.Text = "0";
            TxtAditivo.Text = "0";
            TxtAgua.Text = "0";
            TxtTotal.Text = "0";

            }
            else
            {

            }
           
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            RECEITA oReceita;
            oReceita = _Control.SelecionarID(Convert.ToInt32(TxtID.Text));
            if (Mensagens.MsgPerguntaExclusao() == DialogResult.Yes)
            {
                _Control.Excluir(oReceita);
                LimpaDados();
                Mensagens.MsgExcluido();
                this.Close();
            }
        }
        public void LimpaDados()
        {
            TxtNome.Text = "";
            TxtAreia.Text = "0";
            TxtBrita0.Text = "0";
            TxtBrita1.Text = "0";
            TxtCimento.Text = "0";
            TxtAditivo.Text = "0";
            TxtAgua.Text = "0";
            TxtTotal.Text = "0";

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (_Receita != null)
            {
                _Receita.Nome = TxtNome.Text;
                _Receita.Agr1Prog = float.Parse(TxtAreia.Text);
                _Receita.Agr2Prog = float.Parse(TxtBrita0.Text);
                _Receita.Agr3Prog = float.Parse(TxtBrita1.Text);
                _Receita.Cim1Prog = float.Parse(TxtCimento.Text);
                _Receita.Agua1Prog = float.Parse(TxtAgua.Text);
                _Receita.Adit1Prog = float.Parse(TxtAditivo.Text);
                _Receita.Total = float.Parse(TxtTotal.Text);
                _Control.Alterar(_Receita);
                Mensagens.MsgAlterado();
                this.Close();
            }
            else
            {
                oReceita.Nome = TxtNome.Text;
                oReceita.Agr1Prog = float.Parse(TxtAreia.Text);
                oReceita.Agr2Prog = float.Parse(TxtBrita0.Text);
                oReceita.Agr3Prog = float.Parse(TxtBrita1.Text);
                oReceita.Cim1Prog = float.Parse(TxtCimento.Text);
                oReceita.Agua1Prog = float.Parse(TxtAgua.Text);
                oReceita.Adit1Prog = float.Parse(TxtAditivo.Text);
                oReceita.Total = float.Parse(TxtTotal.Text);

                _Control.Incluir(oReceita);
                Mensagens.MsgIncluido();
                LimpaDados();
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtAgua_Leave(object sender, EventArgs e)
        {
            Areia = float.Parse(TxtAreia.Text);
            Brita0 = float.Parse(TxtBrita0.Text);
            Brita1 = float.Parse(TxtBrita1.Text);
            Cimento = float.Parse(TxtCimento.Text);
            Aditivo = float.Parse(TxtAditivo.Text);
            Agua = float.Parse(TxtAgua.Text);


            Total = Areia + Brita0 + Brita1 + Cimento + Aditivo + Agua;
            

            TxtTotal.Text = Total.ToString();
        }
    }
}
