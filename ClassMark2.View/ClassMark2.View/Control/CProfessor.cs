using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMark2.Model;
using ClassMark2.Model.Repositories;


namespace ClassMark2.View.Control
{
    public class CProfessor
    {
        RepositoryProfessor _Repository;
        public CProfessor()
        {
            _Repository = new RepositoryProfessor();
        }

        public void Incluir(Professor oProfessor)
        {
            _Repository.Incluir(oProfessor);
        }
        public Professor Selecionar(int Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }
        public void Alterar(Professor oProfessor, bool attach = false)
        {
            _Repository.Alterar(oProfessor);
        }
        public void Excluir(Professor oProfessor)
        {
            _Repository.Excluir(oProfessor);
        }
        public List<Professor> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}

