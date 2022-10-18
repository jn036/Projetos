using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMark2.Model;
using ClassMark2.Model.Repositories;


namespace ClassMark2.View.Control
{
    public class CAluno
    {
        RepositoryAluno _Repository;
        public CAluno()
        {
            _Repository = new RepositoryAluno();
        }

        public void Incluir(Aluno oAluno)
        {
            _Repository.Incluir(oAluno);
        }
        public Aluno Selecionar(int Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }
        public void Alterar(Aluno oAluno, bool attach = false)
        {
            _Repository.Alterar(oAluno);
        }
        public void Excluir(Aluno oAluno)
        {
            _Repository.Excluir(oAluno);
        }
        public List<Aluno> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}

