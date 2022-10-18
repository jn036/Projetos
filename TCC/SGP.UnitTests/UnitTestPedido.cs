using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGP.Model;
using SGP.Model.Repositories;

namespace SGP.UnitTests
{
    [TestClass]
    public class UnitTestPedido
    {
        RepositoryPedido repository = new RepositoryPedido();
        RepositoryCliente repositoryCli = new RepositoryCliente();
        RepositoryColaborador repositoryCol = new RepositoryColaborador();
        RepositoryReceita repositoryRec = new RepositoryReceita();
        RepositoryFrota repositoryFrota = new RepositoryFrota();

        [TestMethod]
        public void TestCriar()
        {
            CLIENTE UltimoCliente = repositoryCli.UltimoCadastro();
            COLABORADOR UltimoColaborador = repositoryCol.UltimoCadastro();
            RECEITA UltimaReceita = repositoryRec.UltimoCadastro();
            FROTA UltimaFrota = repositoryFrota.UltimoCadastro();


            PEDIDO oPedido = new PEDIDO();

            oPedido.IDCaminhao = UltimaFrota.ID;
            oPedido.IDCliente = UltimoCliente.ID;
            oPedido.IDColaborador = UltimoColaborador.ID;
            oPedido.IDReceita = UltimaReceita.ID;
            oPedido.Data = DateTime.Now;
            oPedido.PesagemCaminhao = null;
            oPedido.Quantidade = null;
            oPedido.Controle = false;
            oPedido.IDOperaçao = null;
            var Confere = repository.Incluir(oPedido);
            Assert.AreEqual(true, Confere);
        }

        [TestMethod]
        public void TestListar()
        {
            List<PEDIDO> ListaPedidos = repository.SelecionarTodosPedidos();
            Assert.IsNotNull(ListaPedidos);
        }
    }
}
