using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMark2.Model.Repositories
{

    public class RepositoryMateria
    {
        private ClassMarkEntities odb;

        public RepositoryMateria()
        {
            odb = DATA.getContexto();
        }
        public RepositoryMateria(ClassMarkEntities _odb)
        {
            odb = _odb;

        }
        public Materia Selecionar(int Codigo)
        {
            return (from p in odb.Materia where p.ID == Codigo select p).FirstOrDefault();
        }
        public List<Materia> SelecionarTodos()
        {
            return (from p in odb.Materia orderby p.Nome select p).ToList();
        }
        public void Incluir(Materia oMateria)
        {
            odb.Entry(oMateria).State = System.Data.Entity.EntityState.Added;
            //odb.Cliente.Add(ocliente);
            odb.SaveChanges();
        }
        public void Alterar(Materia oMateria)
        {
            var local = odb.Set<Materia>().Local.FirstOrDefault(p => p.ID == oMateria.ID);
            odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(oMateria).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Excluir(Materia oMateria)
        {
            odb.Entry(oMateria).State = System.Data.Entity.EntityState.Deleted;
            //odb.Cliente.Remove(ocliente);
            odb.SaveChanges();
        }

    }
}




