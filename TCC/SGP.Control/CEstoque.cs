using SGP.Model;
using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Control
{
    public class CEstoque : IDisposable
    {
        RepositoryEstoque _Repository;

        public CEstoque()
        {
            _Repository = new RepositoryEstoque();
        }

        public void Incluir(ESTOQUE oEstoque)
        {
            _Repository.Incluir(oEstoque);
        }

        public void Alterar(ESTOQUE oEstoque, bool attach = true)
        {
            _Repository.Alterar(oEstoque, attach);
        }

        public void Excluir(ESTOQUE oEstoque)
        {
            _Repository.Excluir(oEstoque);
        }

        public ESTOQUE SelecionarID(int id)
        {
            return _Repository.SelecionarID(id);
        }

        public ESTOQUE EstoqueAtual()
        {
            return _Repository.EstoqueAtual();
        }

        public List<ESTOQUE> VerificaTabelaVazia()
        {
            return _Repository.VerificaTabelaVazia();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
