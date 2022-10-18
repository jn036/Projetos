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
    public partial class RelatorioPedido : Form
    {
        public RelatorioPedido()
        {
            InitializeComponent();
        }

        private void RelatorioPedido_Load(object sender, EventArgs e)
        {
            RelatorioPedido1.Refresh();
        }
    }
}
