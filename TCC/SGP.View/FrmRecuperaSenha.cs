using SGP.Model;
using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.View
{
    public partial class FrmRecuperaSenha : Form
    {
        string Email;
        DateTime Data;
        COLABORADOR oColaborador;
        RepositoryColaborador repository = new RepositoryColaborador();

        public FrmRecuperaSenha()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            Data = DteTimePickerNascimento.Value;
            Email = TxtEmail.Text;
            oColaborador = repository.TrocarSenha(Email, Data);
            if (oColaborador != null)
            {
                GrdSenhaNova.Enabled = true;
            }
            else
            {
                MessageBox.Show("Dados não inválidos! Por favor, tente novamente.", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TxtNovaSenha.Text == TxtConfirmarSenha.Text)
            {
                oColaborador.Senha = TxtNovaSenha.Text;
                repository.Alterar(oColaborador);
                MessageBox.Show("Senha alterada com sucesso!", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Senhas não coincidem ! Por favor, tente novamente.", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtConfirmarSenha.Focus();
            }
        }
    }
}
