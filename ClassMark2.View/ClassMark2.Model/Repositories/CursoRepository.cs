using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMark2.Model;


namespace ClassMark2.Model.Repositories
{


    public class RepositoryCurso
    { 
        private ClassMarkEntities odb;

        public RepositoryCurso()
        {
            odb = DATA.getContexto();
        }
        public RepositoryCurso(ClassMarkEntities _odb)
        {
            odb = _odb;

        }
        public Curso Selecionar(int Codigo)
        {
            return (from p in odb.Curso where p.ID == Codigo select p).FirstOrDefault();
        }
        public List<Curso> SelecionarTodos()
        {
            return (from p in odb.Curso orderby p.Nome select p).ToList();
            
         }
            public void Incluir(Curso oCurso)
            {
                odb.Entry(oCurso).State = System.Data.Entity.EntityState.Added;
                //odb.Cliente.Add(ocliente);
                odb.SaveChanges();
            }
       // public static List<Curso> getcursoss ()
         //  using (ClassMarkEntities odb =  )

            public void Alterar(Curso oCurso)
            {
            var local = odb.Set<Curso>().Local.FirstOrDefault(p => p.ID == oCurso.ID);
                odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
                odb.Entry(oCurso).State = System.Data.Entity.EntityState.Modified;
                odb.SaveChanges();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public void Excluir(Curso oCurso)
            {
                odb.Entry(oCurso).State = System.Data.Entity.EntityState.Deleted;
                //odb.Cliente.Remove(ocliente);
                odb.SaveChanges();
            }
       
    }
    }




