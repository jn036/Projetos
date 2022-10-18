using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMark2.Model;
using ClassMark2.Model.Repositories;


namespace ClassMark2.View.Control
{
    public class CCurso
    {
        RepositoryCurso _Repository;
        public CCurso()
        {
            _Repository = new RepositoryCurso();
        }

        public void Incluir(Curso oCurso)
        {
            _Repository.Incluir(oCurso);
        }
        public Curso Selecionar(int Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }
        public void Alterar(Curso oCurso, bool attach = false)
        {
            _Repository.Alterar(oCurso);
        }
        public void Excluir(Curso oCurso)
        {
            _Repository.Excluir(oCurso);
        }
        public List<Curso> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}

