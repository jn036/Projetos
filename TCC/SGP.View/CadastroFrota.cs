using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGP.Control;
using SGP.Model;
using SGP.Model.Repositories;
using SGP.View;

namespace SGP.Model
{
    public partial class CadastroFrota : Form
    {
        private Control.CFrota _Control = new CFrota();
        FROTA _Frota = null;
        FROTA oFrota = new FROTA();

        public CadastroFrota()
        {
            InitializeComponent();
        }

        public CadastroFrota(FROTA Frota)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(125, 40);
            _Frota = Frota;
            PopulaCampos();
        }
        private void DesabilitaCampos()
        {
            TxtPlaca.Enabled = false;
            TxtMarca.Enabled = false;
            TxtTara.Enabled = false;
            TxtPesoBruto.Enabled = false;
            TxtModelo.Enabled = false;
        }

        private bool ValidaCampos()
        {
            if (TxtPlaca.Text == string.Empty)
            {
                MessageBox.Show("o campo Placa deve ser preenchido", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPlaca.Select();
                return false;
            }
            if (TxtMarca.Text == string.Empty)
            {
                MessageBox.Show("o campo Marca deve ser preenchido", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtMarca.Select();
                return false;
            }
            if (TxtTara.Text == string.Empty)
            {
                MessageBox.Show("o campo Tara deve ser preenchido", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTara.Select();
                return false;
            }
            if (TxtPesoBruto.Text == string.Empty)
            {
                MessageBox.Show("o campo PesoBruto deve ser preenchido", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPesoBruto.Select();
                return false;
            }
            if (TxtModelo.Text == string.Empty)
            {
                MessageBox.Show("o campo Modelo deve ser preenchido", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtModelo.Select();
                return false;
            }
            return true;
        }

        public void LiberaCampos()
        {

            TxtPlaca.Enabled = true;
            TxtMarca.Enabled = true;
            TxtTara.Enabled = true;
            TxtPesoBruto.Enabled = true;
            TxtModelo.Enabled = true;

            BtnSalvar.Enabled = true;
        }

        private void LimpaDados()
        {
            TxtPlaca.Text = "";
            TxtMarca.Text = "";
            TxtTara.Text = "";
            TxtPesoBruto.Text = "";
            TxtModelo.Text = "";

        }
        private bool ValidaControles()
        {
            return true;
        }
        private void PopulaCampos()
        {
            TxtID.Text = _Frota.ID.ToString();
            TxtPlaca.Text = _Frota.Placa.ToString();
            TxtMarca.Text = _Frota.Marca.ToString();
            TxtTara.Text = _Frota.Tara.ToString();
            TxtPesoBruto.Text = _Frota.PesoBruto.ToString();
            TxtModelo.Text = _Frota.Modelo.ToString();
            BtnExcluir.Enabled = true;
        

        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelCadastroFrota.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms
                {
                    TopLevel = false
                };
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelCadastroFrota.Controls.Add(formulario);
                panelCadastroFrota.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }



        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<ConsultarFrota>();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (ValidaControles())
                {
                    if (_Frota != null)
                    {
                        //Alterar Frota
                        _Frota.Placa = TxtPlaca.Text;
                        _Frota.Marca = TxtMarca.Text;
                        _Frota.Tara = float.Parse(TxtTara.Text);
                        _Frota.PesoBruto = float.Parse(TxtPesoBruto.Text);
                        _Frota.Modelo = TxtModelo.Text;

                        _Control.Alterar(_Frota);
                        Mensagens.MsgAlterado();
                        LimpaDados();
                        this.Close();
                    }
                    else
                    {
                        //Incluir Frota 

                        oFrota.Placa = TxtPlaca.Text;
                        oFrota.Marca = TxtMarca.Text;
                        oFrota.Tara = double.Parse(TxtTara.Text);
                        oFrota.PesoBruto = double.Parse(TxtPesoBruto.Text);
                        oFrota.Modelo = TxtModelo.Text;


                        _Control.Incluir(oFrota);
                        Mensagens.MsgIncluido();
                        LimpaDados();
                        this.Close();
                    }
                }
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            FROTA oFrota;
            oFrota = _Control.SelecionarID(Convert.ToInt32(TxtID.Text));
            if (Mensagens.MsgPerguntaExclusao() == DialogResult.Yes)
            {
                _Control.Excluir(oFrota);
                LimpaDados();
                Mensagens.MsgExcluido();
                this.Close();
            }
        }

        private void CadastroFrota_Load(object sender, EventArgs e)
        {
            LblID.Visible = false;
            TxtID.Visible = false;
            BtnExcluir.Enabled = false;

        }

        private void TxtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panelCadastroFrota_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
