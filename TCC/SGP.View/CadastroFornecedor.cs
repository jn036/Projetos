using SGP.Control;
using SGP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.View
{
    public partial class CadastroFornecedor : Form
    {
        private CFornecedor _Control = new CFornecedor();
        FORNECEDOR _Fornecedor = null;
        FORNECEDOR oFornecedor = new FORNECEDOR();


        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        public CadastroFornecedor(FORNECEDOR Fornecedor)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(125, 40);
            _Fornecedor = Fornecedor;
            PopulaCampos();
        }

        private void LocalizarCEP()
        {
            try
            {
                Correios.AtendeClienteClient consulta = new Correios.AtendeClienteClient("AtendeClientePort");

                var resultado = consulta.consultaCEP(MskCEP.Text);

                if (resultado != null)
                {
                    CboUF.Text = resultado.uf;
                    TxtCidade.Text = resultado.cidade;
                    TxtBairro.Text = resultado.bairro;
                    TxtNomeLogradouro.Text = resultado.end;

                }
            }
            catch
            {
                Mensagens.CEPInvalido();
            }
        }

        private void DesabilitaCampos()
        {

            BtnEscolherFoto.Enabled = false;
            TxtBairro.Enabled = false;
            DteTimePickerCadastro.Enabled = false;
            DteTimePickerNasc.Enabled = false;
            MskCelular.Enabled = false;
            MskCEP.Enabled = false;
            MskCNPJ.Enabled = false;
            MskTelefone.Enabled = false;
            TxtEmail.Enabled = false;
            TxtCidade.Enabled = false;
            CboTipoLogradouro.Enabled = false;
            TxtNome.Enabled = false;
            TxtNumero.Enabled = false;
            CboUF.Enabled = false;
            BtnSalvar.Enabled = false;
        }
        private bool ValidaCampos()
        {
            if (TxtNome.Text == string.Empty)
            {
                MessageBox.Show("o campo Nome deve ser preenchido", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Select();
                return false;
            }
            if (TxtEmail.Text == string.Empty)
            {
                MessageBox.Show("o campo Email deve ser preenchido", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEmail.Select();
                return false;
            }
            if (MskCelular.Text == string.Empty)
            {
                MessageBox.Show("o campo Celular deve ser preenchido", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MskCelular.Select();
                return false;
            }
            return true;
        }
        public void LiberaCampos()
        {
            BtnEscolherFoto.Enabled = true;
            DteTimePickerCadastro.Enabled = true;
            MskCNPJ.Enabled = true;
            DteTimePickerNasc.Enabled = true;
            TxtNome.Enabled = true;
            TxtEmail.Enabled = true;
            MskCEP.Enabled = true;
            CboTipoLogradouro.Enabled = true;
            TxtNomeLogradouro.Enabled = true;
            TxtNumero.Enabled = true;
            TxtBairro.Enabled = true;
            TxtCidade.Enabled = true;
            CboUF.Enabled = true;
            MskTelefone.Enabled = true;
            MskCelular.Enabled = true;
            BtnSalvar.Enabled = true;
        }

        private void LimpaDados()
        {
            TxtNome.Text = "";
            MskCEP.Text = "";
            MskCNPJ.Text = "";
            TxtEmail.Text = "";
            MskCEP.Text = "";
            CboTipoLogradouro.Text = "";
            TxtNomeLogradouro.Text = "";
            TxtNumero.Text = "";
            TxtBairro.Text = "";
            TxtCidade.Text = "";
            CboUF.Text = "";
            TxtPais.Text = "";
            MskTelefone.Text = "";
            MskCelular.Text = "";
            PbFoto.Image = Properties.Resources.Caricatura;
        }
        private bool ValidaControles()
        {
            return true;
        }
        private void PopulaCampos()
        {
            if (_Fornecedor.Imagem != null)
            {
                MemoryStream ms = new MemoryStream(_Fornecedor.Imagem);
                Image Imagem = Image.FromStream(ms);
                PbFoto.Image = Imagem;
            }
            else
            {
                PbFoto.Image = Properties.Resources.Caricatura;
            }
            MskCEP.Text = _Fornecedor.CEP.ToString();
            DteTimePickerCadastro.Text = _Fornecedor.DataCadastro.ToString();
            DteTimePickerNasc.Text = _Fornecedor.DataNascimento.ToString();
            TxtID.Text = _Fornecedor.ID.ToString();
            TxtNome.Text = _Fornecedor.Nome;
            MskCEP.Text = _Fornecedor.CEP.ToString();
            MskCNPJ.Text = _Fornecedor.Documento;
            TxtEmail.Text = _Fornecedor.Email;
            CboTipoLogradouro.Text = _Fornecedor.Logradouro;
            TxtNomeLogradouro.Text = _Fornecedor.NomeLogradouro;
            TxtNumero.Text = _Fornecedor.Numero;
            TxtBairro.Text = _Fornecedor.Bairro;
            TxtCidade.Text = _Fornecedor.Cidade;
            CboUF.Text = _Fornecedor.UF;
            TxtPais.Text = _Fornecedor.Pais;
            MskTelefone.Text = _Fornecedor.Telefone;
            MskCelular.Text = _Fornecedor.Celular;
            BtnExcluir.Enabled = true;
        }

        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {
            DteTimePickerCadastro.Value = DateTime.Now;
            LblID.Visible = false;
            TxtID.Visible = false;
        }

  
        private void MskCEP_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (ValidaControles())
                {
                    if (_Fornecedor != null)
                    {
                        //Alterar Fornecedor
                        _Fornecedor.Nome = TxtNome.Text;
                        _Fornecedor.DataCadastro = DteTimePickerCadastro.Value;
                        _Fornecedor.DataNascimento = DteTimePickerNasc.Value;
                        _Fornecedor.Documento = MskCNPJ.Text;
                        _Fornecedor.Email = TxtEmail.Text;
                        _Fornecedor.CEP = MskCEP.Text;
                        _Fornecedor.Logradouro = CboTipoLogradouro.Text;
                        _Fornecedor.NomeLogradouro = TxtNomeLogradouro.Text;
                        _Fornecedor.Numero = TxtNumero.Text;
                        _Fornecedor.Bairro = TxtBairro.Text;
                        _Fornecedor.Cidade = TxtCidade.Text;
                        _Fornecedor.UF = CboUF.Text;
                        _Fornecedor.Pais = TxtPais.Text;
                        _Fornecedor.Telefone = MskTelefone.Text;
                        _Fornecedor.Celular = MskCelular.Text;


                        MemoryStream ms = new MemoryStream();
                        Bitmap BP = new Bitmap(PbFoto.Image);
                        BP.Save(ms, ImageFormat.Bmp);
                        byte[] imagem = ms.ToArray();
                        _Fornecedor.Imagem = imagem;
                        _Control.Alterar(_Fornecedor);
                        Mensagens.MsgAlterado();
                        this.Close();
                    }
                    else
                    {
                        //Incluir Fornecedor 

                        oFornecedor.Nome = TxtNome.Text;
                        oFornecedor.DataCadastro = DteTimePickerCadastro.Value;
                        oFornecedor.DataNascimento = DteTimePickerNasc.Value;
                        oFornecedor.Documento = MskCNPJ.Text;
                        oFornecedor.Email = TxtEmail.Text;
                        oFornecedor.CEP = MskCEP.Text;
                        oFornecedor.Logradouro = CboTipoLogradouro.Text;
                        oFornecedor.NomeLogradouro = TxtNomeLogradouro.Text;
                        oFornecedor.Numero = TxtNumero.Text;
                        oFornecedor.Bairro = TxtBairro.Text;
                        oFornecedor.Cidade = TxtCidade.Text;
                        oFornecedor.UF = CboUF.Text;
                        oFornecedor.Pais = TxtPais.Text;
                        oFornecedor.Telefone = MskTelefone.Text;
                        oFornecedor.Celular = MskCelular.Text;

                        MemoryStream ms = new MemoryStream();
                        Bitmap BP = new Bitmap(PbFoto.Image);
                        BP.Save(ms, ImageFormat.Bmp);

                        byte[] imagem = ms.ToArray();
                        oFornecedor.Imagem = imagem;

                        _Control.Incluir(oFornecedor);
                        Mensagens.MsgIncluido();
                        LimpaDados();
                    }
                }
            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            FORNECEDOR oFornecedor;
            oFornecedor = _Control.SelecionarID(Convert.ToInt32(TxtID.Text));
            if (Mensagens.MsgPerguntaExclusao() == DialogResult.Yes)
            {
                _Control.Excluir(oFornecedor);
                LimpaDados();
                Mensagens.MsgExcluido();
                this.Close();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEscolherFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string nome = ofd.FileName;
                    PbFoto.Load(nome);
                }
            }
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelCadastroFornecedor.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms
                {
                    TopLevel = false
                };
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelCadastroFornecedor.Controls.Add(formulario);
                panelCadastroFornecedor.Tag = formulario;
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
            AbrirFormNoPanel<ConsultarFornecedor>();
        }

        private void PanelCadastroFornecedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblPais_Click(object sender, EventArgs e)
        {

        }

        private void TxtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblCidade_Click(object sender, EventArgs e)
        {

        }

        private void LblUF_Click(object sender, EventArgs e)
        {

        }

        private void TxtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblBairro_Click(object sender, EventArgs e)
        {

        }

        private void CboUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
