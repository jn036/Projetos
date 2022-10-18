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
    public partial class CadastroCliente : Form
    {

        private CCliente _Control = new CCliente();
        CLIENTE _Cliente = null;
        CLIENTE oCliente = new CLIENTE();


        public CadastroCliente()
        {
            InitializeComponent();
        }

        public CadastroCliente(CLIENTE Cliente)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(125, 40);
            _Cliente = Cliente;
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
            MskCPF.Enabled = false;
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
                MessageBox.Show("o campo deve Celular ser preenchido", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MskCelular.Select();
                return false;
            }
            return true;
        }
        public void LiberaCampos()
        {
            BtnEscolherFoto.Enabled = true;
            DteTimePickerCadastro.Enabled = true;
            MskCPF.Enabled = true;
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
            MskCPF.Text = "";
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
            if (_Cliente.Imagem != null)
            {
                MemoryStream ms = new MemoryStream(_Cliente.Imagem);
                Image Imagem = Image.FromStream(ms);
                PbFoto.Image = Imagem;
            }
            else
            {
                PbFoto.Image = Properties.Resources.Caricatura;
            }
            MskCEP.Text = _Cliente.CEP.ToString();
            DteTimePickerCadastro.Text = _Cliente.DataCadastro.ToString();
            TxtID.Text = _Cliente.ID.ToString();
            TxtNome.Text = _Cliente.Nome;
            MskCEP.Text = _Cliente.CEP.ToString();
            MskCPF.Text = _Cliente.Documento;
            TxtEmail.Text = _Cliente.Email;
            CboTipoLogradouro.Text = _Cliente.Logradouro;
            TxtNomeLogradouro.Text = _Cliente.NomeLogradouro;
            TxtNumero.Text = _Cliente.Numero;
            TxtBairro.Text = _Cliente.Bairro;
            TxtCidade.Text = _Cliente.Cidade;
            TxtPais.Text =  _Cliente.Pais;
            CboUF.Text = _Cliente.UF;
            MskTelefone.Text = _Cliente.Telefone;
            MskCelular.Text = _Cliente.Celular;
            BtnExcluir.Enabled = true;
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelCadastroCliente.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms
                {
                    TopLevel = false
                };
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelCadastroCliente.Controls.Add(formulario);
                panelCadastroCliente.Tag = formulario;
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

        private void CadastroCliente_Load(object sender, EventArgs e)
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
                    if (_Cliente != null)
                    {
                        //Alterar Cliente
                        _Cliente.Nome = TxtNome.Text;
                        _Cliente.DataCadastro = DteTimePickerCadastro.Value;
                        _Cliente.DataNascimento = DteTimePickerNasc.Value;
                        _Cliente.Documento = MskCPF.Text;
                        _Cliente.Email = TxtEmail.Text;
                        _Cliente.CEP = MskCEP.Text;
                        _Cliente.Logradouro = CboTipoLogradouro.Text;
                        _Cliente.NomeLogradouro = TxtNomeLogradouro.Text;
                        _Cliente.Numero = TxtNumero.Text;
                        _Cliente.Bairro = TxtBairro.Text;
                        _Cliente.Cidade = TxtCidade.Text;
                        _Cliente.UF = CboUF.Text;
                        _Cliente.Pais = TxtPais.Text;
                        _Cliente.Telefone = MskTelefone.Text;
                        _Cliente.Celular = MskCelular.Text;


                        MemoryStream ms = new MemoryStream();
                        Bitmap BP = new Bitmap(PbFoto.Image);
                        BP.Save(ms, ImageFormat.Bmp);
                        byte[] imagem = ms.ToArray();
                        _Cliente.Imagem = imagem;
                        _Control.Alterar(_Cliente);
                        Mensagens.MsgAlterado();
                        this.Close();
                    }
                    else
                    {
                        //Incluir Cliente 

                        oCliente.Nome = TxtNome.Text;
                        oCliente.DataCadastro = DteTimePickerCadastro.Value;
                        oCliente.DataNascimento = DteTimePickerNasc.Value;
                        oCliente.Documento = MskCPF.Text;
                        oCliente.Email = TxtEmail.Text;
                        oCliente.CEP = MskCEP.Text;
                        oCliente.Logradouro = CboTipoLogradouro.Text;
                        oCliente.NomeLogradouro = TxtNomeLogradouro.Text;
                        oCliente.Numero = TxtNumero.Text;
                        oCliente.Bairro = TxtBairro.Text;
                        oCliente.Cidade = TxtCidade.Text;
                        oCliente.UF = CboUF.Text;
                        oCliente.Pais = TxtPais.Text;
                        oCliente.Telefone = MskTelefone.Text;
                        oCliente.Celular = MskCelular.Text;

                        MemoryStream ms = new MemoryStream();
                        Bitmap BP = new Bitmap(PbFoto.Image);
                        BP.Save(ms, ImageFormat.Bmp);

                        byte[] imagem = ms.ToArray();
                        oCliente.Imagem = imagem;

                        _Control.Incluir(oCliente);
                        Mensagens.MsgIncluido();
                        LimpaDados();
                    }
                }
            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            CLIENTE oCliente;
            oCliente = _Control.SelecionarID(Convert.ToInt32(TxtID.Text));
            if (Mensagens.MsgPerguntaExclusao() == DialogResult.Yes)
            {
                _Control.Excluir(oCliente);
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

        private void MskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void PanelCadastroCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblCPF_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
