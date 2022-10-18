using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.Model
{
    public partial class Mensagens
    {
        public static void MsgExcluido()
        {
            MessageBox.Show(Constantes.MsgExcluido, "SGP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MsgAlterado()
        {
            MessageBox.Show(Constantes.MsgAlteracao, "SGP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MsgIncluido()
        {
            MessageBox.Show(Constantes.MsgInclusao, "SGP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MsgLoginInvalidos()
        {
            MessageBox.Show("Login ou Senha invalidos ! Por favor, tente novamente.", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult MsgPerguntaExclusao()
        {
            return MessageBox.Show(Constantes.MsgExclusao, "SGP", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void MsgRegInexistente()
        {
            MessageBox.Show("Registro Inexistente!", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MsgBdVazio()
        {
            MessageBox.Show("Banco de Dados Vazio!", "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MsgSGPNomeDigitado()
        {
            MessageBox.Show(Constantes.MsgNomeDigitado, "SGP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void CEPInvalido()
        {
            MessageBox.Show(Constantes.CEPInvalido, "SGP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
