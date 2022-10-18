using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Model.Repositories
{
    public class RepositoryCliente : IDisposable
    {
        private UsinaEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryCliente()
        {
            odb = SGP.Model.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryCliente(UsinaEntities obd)
        {
            obd = odb;
        }

        // ok
        public CLIENTE SelecionarNome(string Nome)
        {
            return (from p in odb.CLIENTE where p.Nome.Equals(Nome) select p).FirstOrDefault();
        }

        public CLIENTE SelecionarID(int ID)
        {
            return (from p in odb.CLIENTE where p.ID == ID select p).FirstOrDefault();
        }

        public CLIENTE Selecionar(int ID)
        {
            return (from p in odb.CLIENTE where p.ID == ID select p).FirstOrDefault();
        }

        public CLIENTE Selecionar(int? ID)
        {
            return (from p in odb.CLIENTE where p.ID == ID select p).FirstOrDefault();
        }
        public List<CLIENTE> SelecionarTodosClientes()
        {
            return odb.CLIENTE.OrderBy(p => p.Nome).ToList();
        }

        public List<CLIENTE> SelecionarPorNome(string Cliente)
        {
            if (Cliente != null)
            {
                return (from p in odb.CLIENTE where p.Nome.Contains(Cliente) orderby p.Nome select p).ToList();
            }
            else
            {
                return (from p in odb.CLIENTE orderby p.Nome select p).ToList();
            }
        }

        public bool Incluir(CLIENTE oCliente)
        {
            if (oCliente != null)
            {
                odb.CLIENTE.Add(oCliente);
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public CLIENTE UltimoCadastro()
        {
            List<CLIENTE> Clientes = odb.CLIENTE.OrderBy(p => p.ID).ToList();
            return Clientes.Last();
        }

        public bool Alterar(CLIENTE oCliente, bool attach = true)
        {
            if (oCliente != null)
            {
                if (attach)
                {
                    odb.Entry(oCliente).State = System.Data.Entity.EntityState.Modified;
                }
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Excluir(CLIENTE oCliente)
        {
            if (oCliente != null)
            {
                odb.CLIENTE.Attach(oCliente);
                odb.CLIENTE.Remove(oCliente);
                odb.SaveChanges();
                return true;
            }
            return false;
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
