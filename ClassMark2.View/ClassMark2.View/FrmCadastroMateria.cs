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
    public partial class FrmCadastroMateria : Form
    {
        private CMateria _Control = new CMateria();
        private bool Incluir = true;
        public FrmCadastroMateria()
        {
            InitializeComponent();
        }

        private void FrmCadastroMateria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'classMarkDataSet.NomeMateria'. Você pode movê-la ou removê-la conforme necessário.
            // this.nomeMateriaTableAdapter.Fill(this.classMarkDataSet.NomeMateria);
            // TODO: esta linha de código carrega dados na tabela 'classMarkDataSet1.NomeMateria'. Você pode movê-la ou removê-la conforme necessário.
            CarregaGrid();


        }
        private void CarregaGrid()
        {
            GrdMateria.AutoGenerateColumns = false;
            GrdMateria.DataSource = _Control.SelecionarTodos();
        }
        private void LimpaCampos()
        {
            TxtNome.Text = "";
            TxtIdCurso.Text = "";
            TxtAno.Text = "";
            TxtIdProfessor.Text = "";
            TxtDescricao.Text = "";
            TxtId.Text = "";
        }
        private bool ValidaControles()
        {

            if (TxtNome.Text == "" || TxtIdCurso.Text == "" || TxtAno.Text == "" || TxtIdProfessor.Text == "" || TxtId.Text == "")
            {
                return false;
            }
            else
            { return true; }
        }





        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            if (ValidaControles()==true)
            {
                Materia oMateria = new Materia();

                oMateria.Nome = TxtNome.Text;
                oMateria.IDCurso = int.Parse(TxtIdCurso.Text);
                oMateria.AnoCurso = int.Parse(TxtAno.Text);
                oMateria.IDProfessor = int.Parse(TxtIdProfessor.Text);
                oMateria.Descricao = TxtDescricao.Text;
                oMateria.ID = int.Parse(TxtId.Text);
                if (Incluir == true)
                {

                    _Control.Incluir(oMateria);
                }
                else
                {
                    _Control.Alterar(oMateria);
                }
                LimpaCampos();
                CarregaGrid();

            }
        }

        private void GrdMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdMateria.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (GrdMateria.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Materia oMateria = (Materia)GrdMateria.Rows[e.RowIndex].DataBoundItem;
                    TxtNome.Text = oMateria.Nome.ToString();
                    TxtIdCurso.Text = oMateria.IDCurso.ToString();
                    TxtAno.Text = oMateria.AnoCurso.ToString();
                    TxtIdProfessor.Text = oMateria.IDProfessor.ToString();
                    TxtDescricao.Text = oMateria.Descricao.ToString();
                    TxtId.Text = oMateria.ID.ToString();

                    Incluir = false;
                }
                else if (GrdMateria.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Confirme a exclusão", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Materia oMateria = (Materia)GrdMateria.Rows[e.RowIndex].DataBoundItem;
                        _Control.Excluir(oMateria);
                        CarregaGrid();
                    }
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}