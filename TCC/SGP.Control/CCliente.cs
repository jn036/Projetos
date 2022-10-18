using SGP.Model;
using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Control
{
    public class CCliente : IDisposable
    {
        RepositoryCliente _Repository;

        public CCliente()
        {
            _Repository = new RepositoryCliente();
        }

        public void Incluir(CLIENTE oCliente)
        {
            _Repository.Incluir(oCliente);
        }

        public void Alterar(CLIENTE oCliente, bool attach = true)
        {
            _Repository.Alterar(oCliente, attach);
        }

        public void Excluir(CLIENTE oCliente)
        {
            _Repository.Excluir(oCliente);
        }

        public List<CLIENTE> SelecionarTodosClientes()
        {
            return _Repository.SelecionarTodosClientes();
        }

        public CLIENTE Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }

        public CLIENTE SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }

        public List<CLIENTE> SelecionarPorNome(string Nome)
        {
            return _Repository.SelecionarPorNome(Nome);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
