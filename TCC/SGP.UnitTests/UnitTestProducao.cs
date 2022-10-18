using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGP.Model;
using SGP.Model.Repositories;

namespace SGP.UnitTests
{
    [TestClass]
    public class UnitTestProducao
    {
        RepositoryProducao repository = new RepositoryProducao();
        RepositoryPedido repositoryPedido = new RepositoryPedido();
        RepositoryReceita repositoryReceita = new RepositoryReceita();
        RepositoryEstoque repositoryEst = new RepositoryEstoque();
 

        [TestMethod]
        public void TestCriar()
        {
            PEDIDO UltimoPedidoDisponivel = repositoryPedido.UltimoPedidoDisponivel();
            List<RECEITA> Receitas = repositoryReceita.SelecionarTodasReceitas();
            ESTOQUE Estoque = repositoryEst.EstoqueAtual();

            PRODUCAO oProducao = new PRODUCAO();
            oProducao.IDPedido = UltimoPedidoDisponivel.ID;
            oProducao.DataProducao = DateTime.Now;

            foreach (var x in Receitas)
            {
                if (UltimoPedidoDisponivel.IDReceita == x.ID)
                {
                    oProducao.AditProg = x.Adit1Prog;
                    oProducao.Agr1Prog = x.Agr1Prog;
                    oProducao.Agr2Prog = x.Agr2Prog;
                    oProducao.Agr3Prog = x.Agr3Prog;
                    oProducao.AguaProg = x.Agua1Prog;
                    oProducao.CimProg = x.Cim1Prog;
                    oProducao.Quantidade = x.Total;
                }
            }
            oProducao.AditReal = oProducao.AditProg;
            oProducao.Agr1Real = oProducao.Agr1Prog;
            oProducao.Agr2Real = oProducao.Agr2Prog;
            oProducao.Agr3Real = oProducao.Agr3Prog;
            oProducao.CimReal = oProducao.CimProg;
            oProducao.AguaReal = oProducao.AguaProg;
           
            UltimoPedidoDisponivel.Controle = true;
            repositoryPedido.Alterar(UltimoPedidoDisponivel);
            var Confere = repository.Incluir(oProducao);
            Assert.AreEqual(true, Confere);
        }

    }
}
