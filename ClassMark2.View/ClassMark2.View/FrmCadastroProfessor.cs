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
    public partial class FrmCadastroProfessor : Form
    {
        private CProfessor _Control = new CProfessor();
        private bool Incluir = true;
        public FrmCadastroProfessor()
        {
            InitializeComponent();
        }

        private void FrmCadastroProfessor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'classMarkDataSet.NomeProfessor'. Você pode movê-la ou removê-la conforme necessário.
            //this.nomeProfessorTableAdapter.Fill(this.classMarkDataSet.NomeProfessor);
            CarregaGrid();
            // TODO: esta linha de código carrega dados na tabela 'classMarkDataSet1.NomeProfessor'. Você pode movê-la ou removê-la conforme necessário.



        }
        private void CarregaGrid()
        {
            GrdProfessor.AutoGenerateColumns = false;
            GrdProfessor.DataSource = _Control.SelecionarTodos();
        }
        private void LimpaCampos()
        {
            TxtNome.Text = "";
            TxtMatricula.Text = "";
            TxtData.Text = "";
            TxtEmail.Text = "";
            TxtID.Text = "";


        }
        private bool ValidaControles()
        {
            if (TxtNome.Text == "" || TxtMatricula.Text == "" || TxtData.Text == "" || TxtEmail.Text == "" )
            {
                return false;
            }
            else
            { return true; }
        }

        

       

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            if (ValidaControles() == true)
            {
                Professor oProfessor = new Professor();


                oProfessor.Nome = TxtNome.Text;
                oProfessor.Matricula = TxtMatricula.Text;
                oProfessor.DataIngresso = DateTime.Parse(TxtData.Text);
                oProfessor.Email = TxtEmail.Text;
                oProfessor.ID = int.Parse(TxtID.Text);

                if (Incluir == true)
                {

                    _Control.Incluir(oProfessor);
                }
                else
                {
                    _Control.Alterar(oProfessor);
                }
                LimpaCampos();
                CarregaGrid();


            }
            else
            { MessageBox.Show("Preencha os Campos Corretamente", ProductName); }
        }

        private void GrdProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (GrdProfessor.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Professor oProfessor = (Professor)GrdProfessor.Rows[e.RowIndex].DataBoundItem;
                    TxtNome.Text = oProfessor.Nome.ToString();
                    TxtData.Text = oProfessor.DataIngresso.ToString();
                    TxtMatricula.Text = oProfessor.Matricula.ToString();
                    TxtEmail.Text = oProfessor.Email.ToString();
                    TxtID.Text = oProfessor.ID.ToString();


                    Incluir = false;
                }
                else if (GrdProfessor.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Confirme a exclusão", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                         Professor oProfessor = (Professor)GrdProfessor.Rows[e.RowIndex].DataBoundItem;
                        if(oProfessor.Coordenador== false)
                        { _Control.Excluir(oProfessor);
                            CarregaGrid();
                        }
                        else
                        { MessageBox.Show("Impossivel Excluir pois esse Professor é Coordenador de um curso", ProductName); }
                    }
                }
            }
        }
    }
}