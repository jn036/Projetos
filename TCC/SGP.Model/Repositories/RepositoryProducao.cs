using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Model.Repositories
{
    public class RepositoryProducao : IDisposable
    {
        private UsinaEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryProducao()
        {
            odb = SGP.Model.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryProducao(UsinaEntities obd)
        {
            obd = odb;
        }

        public bool Incluir(PRODUCAO oProducao)
        {
            if (oProducao != null)
            {
                odb.PRODUCAO.Add(oProducao);
                odb.SaveChanges();
                return true;
            }
            return false;
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