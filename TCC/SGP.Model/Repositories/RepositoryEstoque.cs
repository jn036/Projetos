using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Model.Repositories
{
    public class RepositoryEstoque : IDisposable 
    {
        private UsinaEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryEstoque()
        {
            odb = SGP.Model.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryEstoque(UsinaEntities obd)
        {
            obd = odb;
        }

        public void Incluir(ESTOQUE oEstoque)
        {
            odb.ESTOQUE.Add(oEstoque);
            odb.SaveChanges();
        }


        public void Alterar(ESTOQUE oEstoque, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(oEstoque).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(ESTOQUE oEstoque)
        {
            odb.ESTOQUE.Attach(oEstoque);
            odb.ESTOQUE.Remove(oEstoque);
            odb.SaveChanges();
        }

        public List<ESTOQUE> VerificaTabelaVazia()
        {
            return odb.ESTOQUE.OrderBy(p => p.ID).ToList();
        }

        public ESTOQUE SelecionarID(int ID)
        {
            return (from p in odb.ESTOQUE where p.ID == ID select p).FirstOrDefault();
        }

        public ESTOQUE EstoqueAtual()
        {
            return odb.ESTOQUE.OrderBy(p => p.ID).FirstOrDefault();
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
