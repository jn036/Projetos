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
    public partial class ConsultarReceita : Form
    {
        private Control.CReceita _Control = new CReceita();

        public ConsultarReceita()
        {
            InitializeComponent();
        }
        private void CarregaGrid(string Nome)
        {
            GrdUsuario.DataSource = _Control.SelecionarPorNome(Nome);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
       {
            string procura = TxtPesquisar.Text;
            if (TxtPesquisar.Text != "")
            {
                GrdUsuario.ColumnHeadersVisible = true;
                GrdUsuario.DataSource = _Control.SelecionarPorNome(TxtPesquisar.Text);
                CarregaGrid(procura);
                if (GrdUsuario.Rows.Count == 0)
                {
                    Mensagens.MsgRegInexistente();
                }
            }
        }

        private void GrdUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RECEITA oUsuario = ((RECEITA)GrdUsuario.Rows[e.RowIndex].DataBoundItem);
            if (GrdUsuario.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (GrdUsuario.Columns[e.ColumnIndex].Name == "BtnSelecionar")
                {

                    CadastroReceita frmUsuario = new CadastroReceita(oUsuario);
                    frmUsuario.MdiParent = this.MdiParent;
                    frmUsuario.Show();
                }
            }
        }

        private void ConsultarReceita_Load(object sender, EventArgs e)
        {

        }

        private void TxtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string procura = TxtPesquisar.Text;
            if (TxtPesquisar.Text == "")
            {
                if (e.KeyChar == 13)
                {
                    CarregaGrid("");
                    GrdUsuario.ColumnHeadersVisible = true;

                    if (GrdUsuario.Rows.Count == 0)
                    {
                        Mensagens.MsgBdVazio();
                    }
                }
            }
        }
    }
}
