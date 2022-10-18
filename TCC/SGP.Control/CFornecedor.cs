using SGP.Model;
using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Control
{
    public class CFornecedor
    {
        RepositoryFornecedor _Repository;

        public CFornecedor()
        {
            _Repository = new RepositoryFornecedor();
        }

        public void Incluir(FORNECEDOR oFornecedor)
        {
            _Repository.Incluir(oFornecedor);
        }

        public void Alterar(FORNECEDOR oFornecedor, bool attach = true)
        {
            _Repository.Alterar(oFornecedor, attach);
        }

        public void Excluir(FORNECEDOR oFornecedor)
        {
            _Repository.Excluir(oFornecedor);
        }
        public List<FORNECEDOR> SelecionarTodos(string oUsuario)
        {
            return _Repository.SelecionarTodos(oUsuario);
        }

        public List<FORNECEDOR> SelecionarPorNome(string oUsuario)
        {
            return _Repository.SelecionarPorNome(oUsuario);
        }

        public List<FORNECEDOR> SelecionarTodosFornecedores()
        {
            return _Repository.SelecionarTodosFornecedores();
        }

        public FORNECEDOR Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }

        public FORNECEDOR SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }

        public FORNECEDOR SelecionarNome(string Nome)
        {
            return _Repository.SelecionarNome(Nome);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}