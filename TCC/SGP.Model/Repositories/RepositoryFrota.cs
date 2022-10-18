using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Model.Repositories
{
    public class RepositoryFrota : IDisposable
    {
        private UsinaEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryFrota()
        {
            odb = Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryFrota(UsinaEntities _obd)
        {
            _obd = odb;
        }

        // ok
        public FROTA SelecionarPlaca(string Placa)
        {
            return (from p in odb.FROTA where p.Placa.Equals(Placa) select p).FirstOrDefault();
        }

        public FROTA SelecionarID(int ID)
        {
            return (from p in odb.FROTA where p.ID == ID select p).FirstOrDefault();
        }

        public FROTA Selecionar(int ID)
        {
            return (from p in odb.FROTA where p.ID == ID select p).FirstOrDefault();
        }

        public FROTA Selecionar(int? ID)
        {
            return (from p in odb.FROTA where p.ID == ID select p).FirstOrDefault();
        }
        public List<FROTA> SelecionarTodos(string frota)
        {
            if (frota.Trim() == "")
            {
                return (from p in odb.FROTA orderby p.Placa select p).ToList();
            }
            else
            {
                return (from p in odb.FROTA where p.Placa.Contains(frota) select p).ToList();
            }
        }

        public List<FROTA> SelecionarPorPlaca(string Frota)
        {
            if (Frota != null)
            {
                return (from p in odb.FROTA where p.Placa.Contains(Frota) orderby p.Placa select p).ToList();
            }
            else
            {
                return (from p in odb.FROTA orderby p.Placa select p).ToList();
            }
        }

        public List<FROTA> SelecionarTodasFrotas()
        {
            return odb.FROTA.OrderBy(p => p.Placa).ToList();
        }

        public FROTA UltimoCadastro()
        {
            List<FROTA> Frotas = odb.FROTA.OrderBy(p => p.ID).ToList();
            return Frotas.Last();
        }

        public bool Incluir(FROTA oFrota)
        {
            if (oFrota != null)
            {
                odb.FROTA.Add(oFrota);
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Alterar(FROTA oFrota, bool attach = true)
        {
            if (oFrota != null)
            {
                if (attach)
                {
                    odb.Entry(oFrota).State = System.Data.Entity.EntityState.Modified;
                }
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Excluir(FROTA oFrota)
        {
            if (oFrota != null)
            {
                odb.FROTA.Attach(oFrota);
                odb.FROTA.Remove(oFrota);
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
