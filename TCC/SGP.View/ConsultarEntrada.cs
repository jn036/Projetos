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
    public partial class ConsultarEntrada : Form
    {
        int ID;
        private Control.CEntrada _Control = new CEntrada();

        public ConsultarEntrada()
        {
            InitializeComponent();
        }

        private void ConsultarEntrada_Load(object sender, EventArgs e)
        {

        }

        private void CarregaGrid(int ID)
        {
            GrdUsuario.DataSource = _Control.ListarID(ID);
        }

        private void TxtPesquisarUsuario_TextChanged(object sender, EventArgs e)
        {
            string procura = TxtPesquisarUsuario.Text;
            if (TxtPesquisarUsuario.Text != "")
            {
                GrdUsuario.DataSource = _Control.ListarID(int.Parse(TxtPesquisarUsuario.Text));
                CarregaGrid(int.Parse(procura));
                if (GrdUsuario.Rows.Count == 0)
                {
                    Mensagens.MsgRegInexistente();
                }
            }
        }

        private void TxtPesquisarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            string procura = TxtPesquisarUsuario.Text;
            if (TxtPesquisarUsuario.Text == "")
            {
                if (e.KeyChar == 13)
                {
                    CarregaGrid(0);

                    if (GrdUsuario.Rows.Count == 0)
                    {
                        Mensagens.MsgBdVazio();
                    }
                }
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrdUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ENTRADA oEntrada = ((ENTRADA)GrdUsuario.Rows[e.RowIndex].DataBoundItem);
            if (GrdUsuario.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (GrdUsuario.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (Mensagens.MsgPerguntaExclusao() == DialogResult.Yes)
                    {
                        _Control.Excluir(oEntrada);
                        Mensagens.MsgExcluido();
                        this.Close();
                    }
                }
            }
        }
    }
}
