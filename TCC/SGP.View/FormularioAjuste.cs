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
    public partial class FormularioAjuste : Form
    {
        private CAjuste _Control = new CAjuste();
        private readonly AJUSTE oAjuste = new AJUSTE();

        public FormularioAjuste()
        {
            InitializeComponent();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpaDados()
        {
            TxtEstMinAreia.Text = "";
            TxtEstMinBrita0.Text = "";
            TxtEstMinBrita1.Text = "";
            TxtEstMinCimento.Text = "";
            TxtEstMinAditivo.Text = "";
            TxtTempoAreia.Text = "";
            TxtTempoBrita0.Text = "";
            TxtTempoBrita1.Text = "";
            TxtTempoCimento.Text = "";
            TxtTempoAditivo.Text = "";
            TxtTempoAgua.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            oAjuste.dataAjuste = DteTimePickerData.Value;
            oAjuste.minimoAreia = int.Parse(TxtEstMinAreia.Text);
            oAjuste.minimoBrita0 = int.Parse(TxtEstMinBrita0.Text);
            oAjuste.minimoBrita1 = int.Parse(TxtEstMinBrita1.Text);
            oAjuste.minimoCimento = int.Parse(TxtEstMinCimento.Text);
            oAjuste.minimoaditivo = int.Parse(TxtEstMinAditivo.Text);
            oAjuste.tempoAreia = int.Parse(TxtTempoAreia.Text);
            oAjuste.tempoBrita0 = int.Parse(TxtTempoBrita0.Text);
            oAjuste.tempoBrita1 = int.Parse(TxtTempoBrita1.Text);
            oAjuste.tempoCimento = int.Parse(TxtTempoCimento.Text);
            oAjuste.tempoAditivo = int.Parse(TxtTempoAditivo.Text);
            oAjuste.tempoAgua = int.Parse(TxtTempoAgua.Text);
            _Control.Incluir(oAjuste);
            Mensagens.MsgIncluido();
            LimpaDados();
        }
    }
}
