using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGP.Control;
using SGP.Model;

namespace SGP.View
{
    public partial class ConsultarColaborador : Form
    {
        private Control.CColaborador _Control = new CColaborador();
        public ConsultarColaborador()
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
        private void GrdUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            COLABORADOR oUsuario = ((COLABORADOR)GrdUsuario.Rows[e.RowIndex].DataBoundItem);
            if (GrdUsuario.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (GrdUsuario.Columns[e.ColumnIndex].Name == "BtnSelecionar")
                {
                    CadastroColaborador frmUsuario = new CadastroColaborador(oUsuario);
                    frmUsuario.MdiParent = this.MdiParent;
                    frmUsuario.Show();
                }
            }
        }

        private void TxtPesquisarUsuario_TextChanged(object sender, EventArgs e)
         {
            string procura = TxtPesquisarUsuario.Text;
            if (TxtPesquisarUsuario.Text != "")
            {
                GrdUsuario.DataSource = _Control.SelecionarPorNome(TxtPesquisarUsuario.Text);
                CarregaGrid(procura);
                if (GrdUsuario.Rows.Count == 0)
                {
                    Mensagens.MsgRegInexistente();
                }
            }
        }

        private void ConsultarColaborador_Load(object sender, EventArgs e)
        {

        }

        private void TxtPesquisarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            string procura = TxtPesquisarUsuario.Text;
            if (TxtPesquisarUsuario.Text == "")
            {
                if (e.KeyChar == 13)
                {
                    CarregaGrid("");

                    if (GrdUsuario.Rows.Count == 0)
                    {
                        Mensagens.MsgBdVazio();
                    }
                }
            }
        }
    }
}
