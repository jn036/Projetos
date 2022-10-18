using SGP.Model;
using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Control
{
    public class CPedido
    {
        RepositoryPedido _Repository;

        public CPedido()
        {
            _Repository = new RepositoryPedido();
        }

        public void Incluir(PEDIDO oPedido)
        {
            _Repository.Incluir(oPedido);
        }

        public void Alterar(PEDIDO oPedido, bool attach = true)
        {
            _Repository.Alterar(oPedido, attach);
        }

        public void Excluir(PEDIDO oPedido)
        {
            _Repository.Excluir(oPedido);
        }

        public List<PEDIDO> SelecionarTodosPedidos()
        {
            return _Repository.SelecionarTodosPedidos();
        }

        public PEDIDO Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }

        public PEDIDO SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
