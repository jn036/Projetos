using SGP.Model;
using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Control
{
    public class CFrota : IDisposable
    {
        RepositoryFrota _Repository;
        public CFrota()
        {
            _Repository = new RepositoryFrota();
        }
        public void Incluir(FROTA oFrota)
        {
            _Repository.Incluir(oFrota);
        }
        public void Alterar(FROTA oFrota, bool attach = true)
        {
            _Repository.Alterar(oFrota, attach);
        }
        public void Excluir(FROTA oFrota)
        {
            _Repository.Excluir(oFrota);
        }
        public List<FROTA> SelecionarTodos(string oFrota)
        {
            return _Repository.SelecionarTodos(oFrota);
        }

        public List<FROTA> SelecionarTodasFrotas()
        {
            return _Repository.SelecionarTodasFrotas();
        }

        public List<FROTA> SelecionarPorPlaca(string oFrota)
        {
            return _Repository.SelecionarPorPlaca(oFrota);
        }

        public FROTA SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }
        public FROTA SelecionarPlaca(string Placa)
        {
            return _Repository.SelecionarPlaca(Placa);
        }
        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
