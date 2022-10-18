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
    public partial class RelatorioProducao : Form
    {
        public RelatorioProducao()
        {
            InitializeComponent();
        }

        private void RelatorioProducao_Load(object sender, EventArgs e)
        {
            RelatorioProducao1.Refresh();
        }
    }
}
