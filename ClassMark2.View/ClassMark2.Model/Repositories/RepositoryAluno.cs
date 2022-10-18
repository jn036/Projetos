using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMark2.Model.Repositories
{

    public class RepositoryAluno
    {
        private ClassMarkEntities odb;

        public RepositoryAluno()
        {
            odb = DATA.getContexto();
        }
        public RepositoryAluno(ClassMarkEntities _odb)
        {
            odb = _odb;

        }
        public Aluno Selecionar(int Codigo)
        {
            return (from p in odb.Aluno where p.ID == Codigo select p).FirstOrDefault();
        }
        public List<Aluno> SelecionarTodos()
        {
            return (from p in odb.Aluno orderby p.Nome select p).ToList();
        }
        public void Incluir(Aluno oAluno)
        {
            odb.Entry(oAluno).State = System.Data.Entity.EntityState.Added;
            //odb.Cliente.Add(ocliente);
            odb.SaveChanges();
        }
        public void Alterar(Aluno oAluno)
        {
            var local = odb.Set<Aluno>().Local.FirstOrDefault(p => p.ID == oAluno.ID);
            odb.Entry(local).State = System.Data.Entity.EntityState.Detached;
            odb.Entry(oAluno).State = System.Data.Entity.EntityState.Modified;
            odb.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Excluir(Aluno oAluno)
        {
            odb.Entry(oAluno).State = System.Data.Entity.EntityState.Deleted;
            //odb.Cliente.Remove(ocliente);
            odb.SaveChanges();
        }

    }
}




