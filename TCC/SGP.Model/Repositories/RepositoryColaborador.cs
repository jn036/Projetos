using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Model.Repositories
{
    public class RepositoryColaborador : IDisposable
    {
        private UsinaEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryColaborador()
        {
            odb = SGP.Model.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryColaborador(UsinaEntities obd)
        {
            obd = odb;
        }

        public COLABORADOR VerificaLogin(string Email, string Senha)
        {
            return (from p in odb.COLABORADOR where p.Email.Equals(Email) && p.Senha.Equals(Senha) select p).FirstOrDefault();
        }

        public COLABORADOR TrocarSenha(string Email, DateTime Data)
        {
            return (from p in odb.COLABORADOR where p.Email.Equals(Email) && p.DataNascimento.Equals(Data) select p).FirstOrDefault();
        }

        public COLABORADOR SelecionarNome(string Nome)
        {
            return (from p in odb.COLABORADOR where p.Nome.Equals(Nome) select p).FirstOrDefault();
        }

        public COLABORADOR SelecionarID(int ID)
        {
            return (from p in odb.COLABORADOR where p.ID == ID select p).FirstOrDefault();
        }

        public COLABORADOR Selecionar(int ID)
        {
            return (from p in odb.COLABORADOR where p.ID == ID select p).FirstOrDefault();
        }

        public COLABORADOR Selecionar(int? ID)
        {
            return (from p in odb.COLABORADOR where p.ID == ID select p).FirstOrDefault();
        }
        // ok
        public List<COLABORADOR> SelecionarTodos(string Colaborador)
        {
            if (Colaborador.Trim() == "")
            {
                return (from p in odb.COLABORADOR orderby p.Nome select p).ToList();
            }
            else
            {
                return (from p in odb.COLABORADOR where p.Nome.Contains(Colaborador) select p).ToList();
            }
        }

        public List<COLABORADOR> SelecionarPorNome(string Colaborador)
        {
            if (Colaborador != null)
            {
                return (from p in odb.COLABORADOR where p.Nome.Contains(Colaborador) orderby p.Nome select p).ToList();
            }
            else
            {
                return (from p in odb.COLABORADOR orderby p.Nome select p).ToList();
            }
        }

        public bool Incluir(COLABORADOR oColaborador)
        {
            if (oColaborador != null)
            {
                odb.COLABORADOR.Add(oColaborador);
                odb.SaveChanges();
                return true;
            }

            return false;
        }

        public COLABORADOR UltimoCadastro()
        {
            List<COLABORADOR> Colaboradores = odb.COLABORADOR.OrderBy(p => p.ID).ToList();
            return Colaboradores.Last();
        }

        public bool Alterar(COLABORADOR oColaborador, bool attach = true)
        {
            if (oColaborador != null)
            {
                if(attach)
                {
                    odb.Entry(oColaborador).State = System.Data.Entity.EntityState.Modified;
                }
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Excluir(COLABORADOR oColaborador)
        {
            if (oColaborador != null)
            {
                odb.COLABORADOR.Attach(oColaborador);
                odb.COLABORADOR.Remove(oColaborador);
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public List<COLABORADOR> SelecionarTodosColaboradores()
        {
            return odb.COLABORADOR.OrderBy(p => p.Nome).ToList();
        }

        public void Dispose()
        {
            if (LiberaContexto)
            {
                odb.Dispose();
            }
        }
    }
}
