using SGP.Model;
using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Control
{
    public class CReceita : IDisposable
    {
        RepositoryReceita _Repository;

        public CReceita()
        {
            _Repository = new RepositoryReceita();
        }

        public void Incluir(RECEITA oReceita)
        {
            _Repository.Incluir(oReceita);
        }

        public void Alterar(RECEITA oReceita, bool attach = true)
        {
            _Repository.Alterar(oReceita, attach);
        }

        public void Excluir(RECEITA oReceita)
        {
            _Repository.Excluir(oReceita);
        }

        public List<RECEITA> SelecionarPorNome(string Nome)
        {
            return _Repository.SelecionarPorNome(Nome);
        }

        public List<RECEITA> SelecionarTodasReceitas()
        {
            return _Repository.SelecionarTodasReceitas();
        }

        public RECEITA SelecionarID(int id)
        {
            return _Repository.SelecionarID(id);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
