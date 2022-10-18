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
    public partial class RelatorioFornecedor : Form
    {
        public RelatorioFornecedor()
        {
            InitializeComponent();
        }

        private void RelatorioFornecedor_Load(object sender, EventArgs e)
        {
            RelatorioFornecedor1.Refresh();
        }
    }
}
