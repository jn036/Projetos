using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Model.Repositories
{
    public class RepositoryReceita : IDisposable
    {
        private UsinaEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryReceita()
        {
            odb = SGP.Model.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryReceita(UsinaEntities obd)
        {
            obd = odb;
        }

        public RECEITA UltimoCadastro()
        {
            List<RECEITA> Receitas = odb.RECEITA.OrderBy(p => p.ID).ToList();
            return Receitas.Last();
        }


        public bool Incluir(RECEITA oReceita)
        {
            if (oReceita != null)
            {
                odb.RECEITA.Add(oReceita);
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Alterar(RECEITA oReceita, bool attach = true)
        {
            if (oReceita != null)
            {
                if (attach)
                {
                    odb.Entry(oReceita).State = System.Data.Entity.EntityState.Modified;
                }
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Excluir(RECEITA oReceita)
        {
            if (oReceita != null)
            {
                odb.RECEITA.Attach(oReceita);
                odb.RECEITA.Remove(oReceita);
                odb.SaveChanges();
                return true;
            }
            return false;
        }


        public RECEITA SelecionarID(int ID)
        {
            return (from p in odb.RECEITA where p.ID == ID select p).FirstOrDefault();
        }

        public List<RECEITA> SelecionarPorNome(string Nome)
        {
            if (Nome != null)
            {
                return (from p in odb.RECEITA where p.Nome.Contains(Nome) orderby p.Nome select p).ToList();
            }
            else
            {
                return (from p in odb.RECEITA orderby p.Nome select p).ToList();
            }
        }

        public List<RECEITA> SelecionarTodasReceitas()
        {
            return odb.RECEITA.OrderBy(p => p.Nome).ToList();
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
