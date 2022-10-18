using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassMark2.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCurso ofrm = new FrmCadastroCurso();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void cadastroDeAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroAluno ofrm = new FrmCadastroAluno();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void cadastroDeProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroProfessor ofrm = new FrmCadastroProfessor();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void cadastroDeMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroMateria ofrm = new FrmCadastroMateria();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
