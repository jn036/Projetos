using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Model.Repositories
{
    public class RepositoryFornecedor : IDisposable
    {
        private UsinaEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryFornecedor()
        {
            odb = SGP.Model.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryFornecedor(UsinaEntities obd)
        {
            obd = odb;
        }

        // ok
        public FORNECEDOR SelecionarNome(string Nome)
        {
            return (from p in odb.FORNECEDOR where p.Nome.Equals(Nome) select p).FirstOrDefault();
        }

        public FORNECEDOR SelecionarID(int ID)
        {
            return (from p in odb.FORNECEDOR where p.ID == ID select p).FirstOrDefault();
        }

        public FORNECEDOR Selecionar(int ID)
        {
            return (from p in odb.FORNECEDOR where p.ID == ID select p).FirstOrDefault();
        }

        public FORNECEDOR Selecionar(int? ID)
        {
            return (from p in odb.FORNECEDOR where p.ID == ID select p).FirstOrDefault();
        }
        public List<FORNECEDOR> SelecionarTodos(string Fornecedor)
        {
            if (Fornecedor.Trim() == "")
            {
                return (from p in odb.FORNECEDOR orderby p.Nome select p).ToList();
            }
            else
            {
                return (from p in odb.FORNECEDOR where p.Nome.Contains(Fornecedor) select p).ToList();
            }
        }

        public List<FORNECEDOR> SelecionarPorNome(string Fornecedor)
        {
            if (Fornecedor != null)
            {
                return (from p in odb.FORNECEDOR where p.Nome.Contains(Fornecedor) orderby p.Nome select p).ToList();
            }
            else
            {
                return (from p in odb.FORNECEDOR orderby p.Nome select p).ToList();
            }
        }

        public bool Incluir(FORNECEDOR oFornecedor)
        {
          if (oFornecedor != null)
            {
                odb.FORNECEDOR.Add(oFornecedor);
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public List<FORNECEDOR> SelecionarTodosFornecedores()
        {
            return odb.FORNECEDOR.OrderBy(p => p.Nome).ToList();
        }

        public bool Alterar(FORNECEDOR oFornecedor, bool attach = true)
        {
            if (oFornecedor !=null)
            {
                if (attach)
                {
                    odb.Entry(oFornecedor).State = System.Data.Entity.EntityState.Modified;
                }
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Excluir(FORNECEDOR oFornecedor)
        {
            if (oFornecedor != null)
            {
                odb.FORNECEDOR.Attach(oFornecedor);
                odb.FORNECEDOR.Remove(oFornecedor);
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public FORNECEDOR UltimoCadastro()
        {
            List<FORNECEDOR> Fornecedores = odb.FORNECEDOR.OrderBy(p => p.ID).ToList();
            return Fornecedores.Last();
        }

        public void Dispose()
        {
            if (LiberaContexto)
            {
                odb.Dispose();
            }
        }
    }
}
