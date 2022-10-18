using SGP.Model;
using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Control
{
    public class CProducao : IDisposable
    {
        RepositoryProducao _Repository;

        public CProducao()
        {
            _Repository = new RepositoryProducao();
        }

        public void Incluir(PRODUCAO oProducao)
        {
            _Repository.Incluir(oProducao);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
