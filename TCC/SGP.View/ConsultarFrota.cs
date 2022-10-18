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
    public partial class ConsultarFrota : Form
    {
        private Control.CFrota _Control = new CFrota();
        public ConsultarFrota()
        {
            InitializeComponent();
        }
        private void CarregaGrid(string Placa)
        {
            GrdFrota.DataSource = _Control.SelecionarTodos(Placa);
        }
        private void TxtPesquisarFrota_SelectedIndexChanged(object sender, EventArgs e) { }


        private void MnuConsultarFrota_Load(object sender, EventArgs e)
        {

        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GrdFrota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FROTA oFrota = ((FROTA)GrdFrota.Rows[e.RowIndex].DataBoundItem);
            if (GrdFrota.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (GrdFrota.Columns[e.ColumnIndex].Name == "BtnSelecionar")
                {
                    CadastroFrota frmFrota = new CadastroFrota(oFrota);
                    frmFrota.MdiParent = this.MdiParent;
                    frmFrota.Show();
                }
            }
        }

        private void TxtPesquisarFrota_TextChanged(object sender, EventArgs e)
        {
            string procura = TxtPesquisarFrota.Text;
            if (TxtPesquisarFrota.Text != "")
            {
                GrdFrota.DataSource = _Control.SelecionarPorPlaca(TxtPesquisarFrota.Text);
                CarregaGrid(procura);
                if (GrdFrota.Rows.Count == 0)
                {
                    Mensagens.MsgRegInexistente();
                }
            }
        }

        private void TxtPesquisarFrota_KeyPress(object sender, KeyPressEventArgs e)
        {
            string procura = TxtPesquisarFrota.Text;
            if (TxtPesquisarFrota.Text == "")
            {
                if (e.KeyChar == 13)
                {
                    CarregaGrid("");

                    if (GrdFrota.Rows.Count == 0)
                    {
                        Mensagens.MsgBdVazio();
                    }
                }
            }
        }

        private void LblFrota_Click(object sender, EventArgs e)
        {

        }
    }
}
