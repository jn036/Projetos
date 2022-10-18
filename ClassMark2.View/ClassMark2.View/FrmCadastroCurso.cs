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
    public partial class FrmCadastroCurso : Form
    {
        private CCurso _Control = new CCurso();
        private bool Incluir = true;
        public FrmCadastroCurso()
        {
            InitializeComponent();
        }

        private void FrmCadastroCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'classMarkDataSet.NomeProfessor'. Você pode movê-la ou removê-la conforme necessário.
            //this.nomeProfessorTableAdapter.Fill(this.classMarkDataSet.NomeProfessor);
            CarregaGrid();
            // TODO: esta linha de código carrega dados na tabela 'classMarkDataSet1.NomeProfessor'. Você pode movê-la ou removê-la conforme necessário.



        }
        private void CarregaGrid()
        {
            GrdCurso.AutoGenerateColumns = false;
            GrdCurso.DataSource = _Control.SelecionarTodos();
            
        }
        private void LimpaCampos()
        {
            TxtNome.Text = "";
            TxtData.Text = "";
            CboCord.Text = "";
            TxtDuracao.Text = "";
            TxtTipo.Text = "";
            TxtID.Text = "";


        }
        private bool ValidaControles()
        {
            if (TxtNome.Text == "" || TxtData.Text == "" || CboCord.Text == "" || TxtDuracao.Text =="" || TxtTipo.Text=="")
            { return false;
                 }
            else
            { return true; }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles()==true)
            {
                Curso oCurso = new Curso();
                NomeProfessor nome = new NomeProfessor();

                oCurso.Nome = TxtNome.Text;
                oCurso.DataInicio = DateTime.Parse(TxtData.Text);
                oCurso.IDCoordenador = int.Parse(CboCord.Text);
                oCurso.Duracao = int.Parse(TxtDuracao.Text);
                oCurso.TipoCurso = TxtTipo.Text;
                oCurso.ID = int.Parse(TxtID.Text);
                if (Incluir == true)
                {

                    _Control.Incluir(oCurso);
                }
                else
                {
                    _Control.Alterar(oCurso);
                }
                LimpaCampos();
                CarregaGrid();


            }
            else
            { MessageBox.Show("Preencha os Campos Corretamente",ProductName); }
        }

        private void GrdCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (GrdCurso.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {   
                    Curso oCurso = (Curso)GrdCurso.Rows[e.RowIndex].DataBoundItem;
                    TxtNome.Text = oCurso.Nome.ToString();
                    TxtData.Text = oCurso.DataInicio.ToString();
                    TxtDuracao.Text = oCurso.Duracao.ToString();
                    CboCord.Text = oCurso.IDCoordenador.ToString();
                    TxtTipo.Text = oCurso.TipoCurso.ToString();
                    TxtID.Text = oCurso.ID.ToString();

                    Incluir = false;
                }
                else if (GrdCurso.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Confirme a exclusão", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Curso oCurso = (Curso)GrdCurso.Rows[e.RowIndex].DataBoundItem;
                        _Control.Excluir(oCurso);
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