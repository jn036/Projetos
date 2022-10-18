using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Model.Repositories
{
    public class RepositoryEntrada : IDisposable
    {
        private UsinaEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryEntrada()
        {
            odb = Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryEntrada(UsinaEntities obd)
        {
            obd = odb;
        }
        public ENTRADA SelecionarFornecedor(Int32 Fornecedor)
        {
            return (from p in odb.ENTRADA where p.IDFornecedor.Equals(Fornecedor) select p).FirstOrDefault();
        }

        public ENTRADA SelecionarID(int ID)
        {
            return (from p in odb.ENTRADA where p.ID == ID select p).FirstOrDefault();
        }
        public List<ENTRADA> ListarID(int ID)
        {
            if (ID == 0)
            {
                return (from p in odb.ENTRADA orderby p.ID select p).ToList();
            }
            else
            {
                return (from p in odb.ENTRADA where p.ID == ID select p).ToList();
            }
        }

        public ENTRADA Selecionar(int ID)
        {
            return (from p in odb.ENTRADA where p.ID == ID select p).FirstOrDefault();
        }

        public ENTRADA Selecionar(int? ID)
        {
            return (from p in odb.ENTRADA where p.ID == ID select p).FirstOrDefault();
        }
        // ok


        public bool Incluir(ENTRADA oEntrada)
        {
            if (oEntrada != null)
            {
                odb.ENTRADA.Add(oEntrada);
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ENTRADA> SelecionarTodasEntradas()
        {
            return odb.ENTRADA.OrderBy(p => p.ID).ToList();
        }

        public void Alterar(ENTRADA oEntrada, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(oEntrada).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(ENTRADA oEntrada)
        {
            odb.ENTRADA.Attach(oEntrada);
            odb.ENTRADA.Remove(oEntrada);
            odb.SaveChanges();
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
