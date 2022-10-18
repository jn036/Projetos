using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassMark2.Model.Repositories;
using ClassMark2.Model;
using ClassMark2.View.Control;

namespace ClassMark2.View
{
    public partial class FrmCadastroAluno : Form
    {
        private CAluno _Control = new CAluno();
        private bool Incluir = true;
        public FrmCadastroAluno()
        {
            InitializeComponent();
        }

        private void FrmCadastroAluno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'classMarkDataSet.NomeProfessor'. Você pode movê-la ou removê-la conforme necessário.
            // this.nomeProfessorTableAdapter.Fill(this.classMarkDataSet.NomeProfessor);
            // TODO: esta linha de código carrega dados na tabela 'classMarkDataSet1.NomeProfessor'. Você pode movê-la ou removê-la conforme necessário.
            CarregaGrid();


        }
        private void CarregaGrid()
        {
            GrdAluno.AutoGenerateColumns = false;
            GrdAluno.DataSource = _Control.SelecionarTodos();
        }
        private void LimpaCampos()
        {
            TxtNome.Text = "";
            TxtMatricula.Text = "";
            TxtData.Text = "";
            TxtEmail.Text = "";
            TxtID.Text = "";
            TxtCurso.Text = "";
        }
        private bool ValidaControles()
        {
            return true;
        }

       

        

        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                Aluno oAluno = new Aluno();

                oAluno.Nome = TxtNome.Text;
                oAluno.Matricula = TxtMatricula.Text;
                oAluno.DataIngresso = TxtData.Text;
                oAluno.Email = TxtEmail.Text;
                oAluno.ID = int.Parse(TxtID.Text);
                oAluno.IDCurso = int.Parse(TxtCurso.Text);
                if (Incluir == true)
                {

                    _Control.Incluir(oAluno);
                }
                else
                {
                    _Control.Alterar(oAluno);
                }
                LimpaCampos();
                CarregaGrid();


            }
        }

        private void GrdAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (GrdAluno.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Aluno oAluno = (Aluno)GrdAluno.Rows[e.RowIndex].DataBoundItem;
                    TxtNome.Text = oAluno.Nome.ToString();
                    TxtData.Text = oAluno.DataIngresso.ToString();
                    TxtMatricula.Text = oAluno.Matricula.ToString();
                    TxtEmail.Text = oAluno.Email.ToString();
                    TxtID.Text = oAluno.IDCurso.ToString();
                    TxtCurso.Text = oAluno.ID.ToString();

                    Incluir = false;
                }
                else if (GrdAluno.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Confirme a exclusão", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Aluno oAluno = (Aluno)GrdAluno.Rows[e.RowIndex].DataBoundItem;
                        _Control.Excluir(oAluno);
                        CarregaGrid();
                    }
                }
            }
        }
    }
}
