using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGP;
using SGP.Model;
using SGP.Model.Repositories;

namespace SGP.Control
{
    public class CColaborador : IDisposable

    {
        RepositoryColaborador _Repository;

        public CColaborador()
        {
            _Repository = new RepositoryColaborador();
        }

        public void Incluir(COLABORADOR oColaborador)
        {
            _Repository.Incluir(oColaborador);
        }

        public void Alterar(COLABORADOR oColaborador, bool attach = true)
        {
            _Repository.Alterar(oColaborador, attach);
        }

        public void Excluir(COLABORADOR oColaborador)
        {
            _Repository.Excluir(oColaborador);
        }

        public List<COLABORADOR> SelecionarTodos(string oUsuario)
        {
            return _Repository.SelecionarTodos(oUsuario);
        }

        public List<COLABORADOR> SelecionarPorNome(string oUsuario)
        {
            return _Repository.SelecionarPorNome(oUsuario);
        }

        public List<COLABORADOR> SelecionarTodosColaboradores()
        {
            return _Repository.SelecionarTodosColaboradores();
        }

        public COLABORADOR Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }

        public COLABORADOR SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }

        public COLABORADOR SelecionarNome(string Nome)
        {
            return _Repository.SelecionarNome(Nome);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
