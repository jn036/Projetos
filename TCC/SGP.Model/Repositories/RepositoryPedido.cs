using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Model.Repositories
{
    public class RepositoryPedido : IDisposable
    {
        private UsinaEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryPedido()
        {
            odb = SGP.Model.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryPedido(UsinaEntities obd)
        {
            obd = odb;
        }

        public PEDIDO SelecionarID(int ID)
        {
            return (from p in odb.PEDIDO where p.ID == ID select p).FirstOrDefault();
        }

        public PEDIDO Selecionar(int ID)
        {
            return (from p in odb.PEDIDO where p.ID == ID select p).FirstOrDefault();
        }

        public PEDIDO UltimoPedidoDisponivel()
        {
            List<PEDIDO> PedidosDisponiveis = odb.PEDIDO.OrderBy(p => p.ID).Where(p => p.Controle == false).ToList();
            return PedidosDisponiveis.Last();
        }

        public bool Incluir(PEDIDO oPedido)
        {
            if (oPedido != null)
            {
                odb.PEDIDO.Add(oPedido);
                odb.SaveChanges();
                return true;
            }
            return false;
        }

        public List<PEDIDO> SelecionarTodosPedidos()
        {
            return odb.PEDIDO.OrderBy(p => p.ID).ToList();
        }

        public void Alterar(PEDIDO oPedido, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(oPedido).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(PEDIDO oPedido)
        {
            odb.PEDIDO.Attach(oPedido);
            odb.PEDIDO.Remove(oPedido);
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

