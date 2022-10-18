using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Model.Repositories
{
    public class RepositoryAjuste : IDisposable
    {
        private UsinaEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryAjuste()
        {
            odb = SGP.Model.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryAjuste(UsinaEntities obd)
        {
            obd = odb;
        }

        public AJUSTE SelecionarID(int ID)
        {
            return (from p in odb.AJUSTE where p.id == ID select p).FirstOrDefault();
        }

        public AJUSTE Selecionar(int ID)
        {
            return (from p in odb.AJUSTE where p.id == ID select p).FirstOrDefault();
        }

        public AJUSTE Selecionar(int? ID)
        {
            return (from p in odb.AJUSTE where p.id == ID select p).FirstOrDefault();
        }

        public List<AJUSTE> SelecionarTodosAjustes()
        {
            return odb.AJUSTE.OrderBy(p => p.id).ToList();
        }

        public bool Incluir(AJUSTE oAjuste)
        {
           if (oAjuste != null)
            {
                odb.AJUSTE.Add(oAjuste);
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public AJUSTE UltimoAjuste()
        {
            List<AJUSTE> Ajustes = odb.AJUSTE.OrderBy(p => p.id).ToList();
            return Ajustes.Last();
        }

        public void Alterar(AJUSTE oAjuste, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(oAjuste).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(AJUSTE oAjuste)
        {
            odb.AJUSTE.Attach(oAjuste);
            odb.AJUSTE.Remove(oAjuste);
            odb.SaveChanges();
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
