using SGP.Model;
using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Control
{
    public class CEntrada : IDisposable

    {
        RepositoryEntrada _Repository;
        RepositoryColaborador _RepositoryColaborador;
        RepositoryFornecedor _RepositoryFornecedor;

        public CEntrada()
        {
            _Repository = new RepositoryEntrada();
            _RepositoryColaborador = new RepositoryColaborador();
            _RepositoryFornecedor = new RepositoryFornecedor();
        }

        public void Incluir(ENTRADA oEntrada)
        {
            _Repository.Incluir(oEntrada);
        }

        public void Alterar(ENTRADA oEntrada, bool attach = true)
        {
            _Repository.Alterar(oEntrada, attach);
        }

        public void Excluir(ENTRADA oEntrada)
        {
            _Repository.Excluir(oEntrada);
        }

        public ENTRADA SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }

        public List<ENTRADA> ListarID(int ID)
        {
            return _Repository.ListarID(ID);
        }

        public List<COLABORADOR> Colaboradores()
        {
            return _RepositoryColaborador.SelecionarTodosColaboradores();

        }

        public List<FORNECEDOR> Fornecedores()
        {
            return _RepositoryFornecedor.SelecionarTodosFornecedores();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
