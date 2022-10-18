using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMark2.Model;
using ClassMark2.Model.Repositories;


namespace ClassMark2.View.Control
{
    public class CMateria
    {
        RepositoryMateria _Repository;
        public CMateria()
        {
            _Repository = new RepositoryMateria();
        }

        public void Incluir(Materia oMateria)
        {
            _Repository.Incluir(oMateria);
        }
        public Materia Selecionar(int Codigo)
        {
            return _Repository.Selecionar(Codigo);
        }
        public void Alterar(Materia oMateria, bool attach = false)
        {
            _Repository.Alterar(oMateria);
        }
        public void Excluir(Materia oMateria)
        {
            _Repository.Excluir(oMateria);
        }
        public List<Materia> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}

