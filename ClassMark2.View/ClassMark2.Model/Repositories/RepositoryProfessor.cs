using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMark2.Model.Repositories
{

    public class RepositoryProfessor
    {
        private ClassMarkEntities odb;

        public RepositoryProfessor()
        {
            odb = DATA.getContexto();
        }
        public RepositoryProfessor(ClassMarkEntities _odb)
        {
            odb = _odb;

        }
        public Professor Selecionar(int Codigo)
        {
            return (from p in odb.Professor where p.ID == Codigo select p).FirstOrDefault();
        }
        public List<Professor> SelecionarTodos()
        {
            return (from p in odb.Professor orderby p.Nome select p).ToList();
        }
        public void Incluir(Professor oProfessor)
        {
            odb.Entry(oProfessor).State = System.Data.Entity.EntityState.Added;
            //odb.Cliente.Add(ocliente);
            odb.SaveChanges();
        }
        public void Alterar(Professor oProfessor)
        {
            var local = odb.Set<Professor>().Local.FirstOrDefault(p => p.ID == oProfessor.ID);
            odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(oProfessor).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Excluir(Professor oProfessor)
        {
            odb.Entry(oProfessor).State = System.Data.Entity.EntityState.Deleted;
            //odb.Cliente.Remove(ocliente);
            odb.SaveChanges();
        }

    }
}




