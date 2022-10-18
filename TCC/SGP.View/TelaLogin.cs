using SGP.Model;
using SGP.Model.Repositories;
using Supervisorio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.View
{
    public partial class TelaLogin : Form
    {
        Thread nt;
        RepositoryColaborador repository = new RepositoryColaborador();
        RepositoryUsuario repositoryU = new RepositoryUsuario();
        USUARIO oUsuario = new USUARIO();
        string Nome;
        int id;

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        public string PrimeiroNome(string Nome)
        {
            string [] Primeiro = Nome.Split(' ');
            return Primeiro[0];
        }

        private void FormADM()
        {
            COLABORADOR oColaborador = repository.SelecionarID(id);
            if (oColaborador == null)
            {
                Application.Run(new TelaADM("Adm", id));
            }
            else
            {
                string retorno = PrimeiroNome(oColaborador.Nome);
                Application.Run(new TelaADM(retorno, id));
            }

        }

        private void FormPRD()
        {
            COLABORADOR oColaborador = repository.SelecionarID(id);
            string retorno = PrimeiroNome(oColaborador.Nome);
            Application.Run(new TelaProducao(retorno, id));
        }

        public void RealizaLogin(string Email, string Senha)
        {
            COLABORADOR oColaborador = VerificaLogin(Email, Senha);
            if (oColaborador!=null)
            {
                 
                Nome = oColaborador.Nome;
                id = oColaborador.ID;
                oUsuario.Nome = Nome;
                oUsuario.Funcao = oColaborador.Funcao;
                repositoryU.Incluir(oUsuario);
                

                if (oColaborador.Funcao== "Operador")
                {
                    this.Close();
                    nt = new Thread(FormPRD);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();
                
                }
                else
                {
                    
                    this.Close();
                    nt = new Thread(FormADM);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();
                }
                
            }
            else
            {
                Mensagens.MsgLoginInvalidos();
                TxtEmail.Text = "";
                TxtSenha.Text = "";
                TxtEmail.Focus();
            }
        }

        public COLABORADOR VerificaLogin(string Email, string Senha)
        {
            COLABORADOR oColaborador = repository.VerificaLogin(Email, Senha);
            return oColaborador;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //{
            //    StreamWriter Writer = new StreamWriter("Email.txt");

            //}
            List<COLABORADOR> Colaboradores = repository.SelecionarTodosColaboradores();
            if(Colaboradores.Count==0)
            {
                if ((TxtEmail.Text == "Adm" && TxtSenha.Text == "1234"))
                {
                    //Nome = "Administrador";
                    this.Close();
                    nt = new Thread(FormADM);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();
                }
                else
                {
                    Mensagens.MsgLoginInvalidos();
                    TxtEmail.Text = "";
                    TxtSenha.Text = "";
                    TxtEmail.Focus();
                }
            }
            else
            {
                RealizaLogin(TxtEmail.Text, TxtSenha.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EsqueciSenha_Click(object sender, EventArgs e)
        {
            FrmRecuperaSenha frm = new FrmRecuperaSenha();
            frm.Show();
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                List<COLABORADOR> Colaboradores = repository.SelecionarTodosColaboradores();
                if (Colaboradores.Count == 0)
                {
                    if ((TxtEmail.Text == "Adm" && TxtSenha.Text == "1234"))
                    {
                        //Nome = "Administrador";
                        this.Close();
                        nt = new Thread(FormADM);
                        nt.SetApartmentState(ApartmentState.STA);
                        nt.Start();
                    }
                    else
                    {
                        Mensagens.MsgLoginInvalidos();
                        TxtEmail.Text = "";
                        TxtSenha.Text = "";
                        TxtEmail.Focus();
                    }
                }
                else
                {
                    RealizaLogin(TxtEmail.Text, TxtSenha.Text);
                }
            }
        }
    }
}
