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
    public partial class RelatorioColaborador : Form
    {
        public RelatorioColaborador()
        {
            InitializeComponent();
        }


        private void RelatorioColaborador_Load(object sender, EventArgs e)
        {
            RelatorioColaborador1.Refresh();
        }
    }
}
