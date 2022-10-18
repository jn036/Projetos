using SGP.Model;
using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Control
{
    public class CAjuste : IDisposable
    {
        RepositoryAjuste _Repository;

        public CAjuste()
        {
            _Repository = new RepositoryAjuste();
        }

        public void Incluir(AJUSTE oAjuste)
        {
            _Repository.Incluir(oAjuste);
        }

        public void Excluir(AJUSTE oAjuste)
        {
            _Repository.Excluir(oAjuste);
        }

 

        public AJUSTE Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }

        public AJUSTE UltimoAjuste ()
        {
            return _Repository.UltimoAjuste();
        }

        public AJUSTE SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
