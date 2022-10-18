using SGP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace SGP.View
{
    public partial class RelatorioFrota : Form
    {
        public RelatorioFrota()
        {
            InitializeComponent();
        }

        private void RelatorioFrota_Load(object sender, EventArgs e)
        {
            RelatorioFrota1.Refresh();
         
        }
    }
}
