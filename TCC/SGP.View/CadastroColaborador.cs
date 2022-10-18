using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SGP.Model.Repositories;
using SGP.View;
using SGP.Model;
using SGP.Control;

namespace SGP.View
{
    public partial class CadastroColaborador : Form
    {
        private CColaborador _Control = new CColaborador();
        COLABORADOR _Colaborador = null;
        COLABORADOR oColaborador = new COLABORADOR();

        public CadastroColaborador()
        {
            InitializeComponent();
        }

        public CadastroColaborador(COLABORADOR Usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(125, 40);
            _Colaborador = Usuario;
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
                MskCEP.Text = "";
                MskCEP.Focus();
            }
        }
        private bool ValidaCampos()
        {
            if (CBOFuncao.Text == string.Empty)
            {
                MessageBox.Show("o campo Funcao deve ser preenchido", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBOFuncao.Select();
                return false;
            }
            if (TxtSenha.Text == string.Empty)
            {
                MessageBox.Show("o campo Senha deve ser preenchido", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtSenha.Select();
                return false;
            }
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
            CBOFuncao.Enabled = true;
            MskCPF.Enabled = true;
            TxtSenha.Enabled = true;
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
            CBOFuncao.Text = "";
            TxtSenha.Text = "";
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
            if (_Colaborador.Imagem != null)
            {
                MemoryStream ms = new MemoryStream(_Colaborador.Imagem);
                Image Imagem = Image.FromStream(ms);
                PbFoto.Image = Imagem;
            }
            else
            {
                PbFoto.Image = Properties.Resources.Caricatura;
            }
            TxtID.Text = _Colaborador.ID.ToString();
            TxtNome.Text = _Colaborador.Nome;
            CBOFuncao.Text = _Colaborador.Funcao.ToString();
            TxtSenha.Text = _Colaborador.Senha;
            MskCEP.Text = _Colaborador.CEP.ToString();
            DteTimePickerCadastro.Text = _Colaborador.DataCadastro.ToString();
            DteTimePickerNasc.Text = _Colaborador.DataNascimento.ToString();
            MskCPF.Text = _Colaborador.Documento;
            TxtEmail.Text = _Colaborador.Email;
            CboTipoLogradouro.Text = _Colaborador.Logradouro;
            TxtNomeLogradouro.Text = _Colaborador.NomeLogradouro;
            TxtNumero.Text = _Colaborador.Numero;
            TxtBairro.Text = _Colaborador.Bairro;
            TxtCidade.Text = _Colaborador.Cidade;
            TxtPais.Text = _Colaborador.Pais;
            CboUF.Text = _Colaborador.UF;
            MskTelefone.Text = _Colaborador.Telefone;
            MskCelular.Text = _Colaborador.Celular;
            BtnExcluir.Enabled = true;
        }

        private void CadastroColaborador_Load(object sender, EventArgs e)
        {
            //this.fUNCAOTableAdapter1.Fill(this.sGPbdDataSet5.FUNCAO);
            DteTimePickerCadastro.Value = DateTime.Now;
            LblID.Visible = false;
            TxtID.Visible = false;
        }


        private void MskCEP_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }


    

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelCadastroColaborador.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms
                {
                    TopLevel = false
                };
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelCadastroColaborador.Controls.Add(formulario);
                panelCadastroColaborador.Tag = formulario;
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (ValidaControles())
                {
                    if (_Colaborador != null)
                    {
                        //Alterar Colaborador
                        _Colaborador.Nome = TxtNome.Text;
                        _Colaborador.Funcao = CBOFuncao.Text;
                        _Colaborador.DataCadastro = DteTimePickerCadastro.Value;
                        _Colaborador.Senha = TxtSenha.Text;
                        _Colaborador.DataNascimento = DteTimePickerNasc.Value;
                        _Colaborador.Documento = MskCPF.Text;
                        _Colaborador.Email = TxtEmail.Text;
                        _Colaborador.CEP = MskCEP.Text;
                        _Colaborador.Logradouro = CboTipoLogradouro.Text;
                        _Colaborador.NomeLogradouro = TxtNomeLogradouro.Text;
                        _Colaborador.Numero = TxtNumero.Text;
                        _Colaborador.Bairro = TxtBairro.Text;
                        _Colaborador.Cidade = TxtCidade.Text;
                        _Colaborador.UF = CboUF.Text;
                        _Colaborador.Pais = TxtPais.Text;
                        _Colaborador.Telefone = MskTelefone.Text;
                        _Colaborador.Celular = MskCelular.Text;


                        MemoryStream ms = new MemoryStream();
                        Bitmap BP = new Bitmap(PbFoto.Image);
                        BP.Save(ms, ImageFormat.Jpeg);
                        byte[] imagem = ms.ToArray();
                        _Colaborador.Imagem = imagem;
                        _Control.Alterar(_Colaborador);
                        Mensagens.MsgAlterado();
                        this.Close();
                    }
                    else
                    {
                        //Incluir Colaborador 

                        oColaborador.Nome = TxtNome.Text;
                        oColaborador.Funcao = CBOFuncao.Text;
                        oColaborador.DataCadastro = DteTimePickerCadastro.Value;
                        oColaborador.Senha = TxtSenha.Text;
                        oColaborador.DataNascimento = DteTimePickerNasc.Value;
                        oColaborador.Documento = MskCPF.Text;
                        oColaborador.Email = TxtEmail.Text;
                        oColaborador.CEP = MskCEP.Text;
                        oColaborador.Logradouro = CboTipoLogradouro.Text;
                        oColaborador.NomeLogradouro = TxtNomeLogradouro.Text;
                        oColaborador.Numero = TxtNumero.Text;
                        oColaborador.Bairro = TxtBairro.Text;
                        oColaborador.Cidade = TxtCidade.Text;
                        oColaborador.UF = CboUF.Text;
                        oColaborador.Pais = TxtPais.Text;
                        oColaborador.Telefone = MskTelefone.Text;
                        oColaborador.Celular = MskCelular.Text;


                        MemoryStream ms = new MemoryStream();
                        Bitmap BP = new Bitmap(PbFoto.Image);
                        BP.Save(ms, ImageFormat.Bmp);

                        byte[] imagem = ms.ToArray();
                        oColaborador.Imagem = imagem;

                        _Control.Incluir(oColaborador);
                        Mensagens.MsgIncluido();
                        LimpaDados();
                    }
                }
            }
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {           
            COLABORADOR oColaborador;
            oColaborador = _Control.SelecionarID(Convert.ToInt32(TxtID.Text));
           if (Mensagens.MsgPerguntaExclusao() == DialogResult.Yes)
            {
                _Control.Excluir(oColaborador);
                LimpaDados();
                Mensagens.MsgExcluido();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<ConsultarColaborador>();
        }

        private void CBOFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelCadastroColaborador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LblCelular_Click(object sender, EventArgs e)
        {

        }

        private void MskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LblCadastroColaborador_Click(object sender, EventArgs e)
        {

        }
    }
}

