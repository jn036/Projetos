using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGP.Model;
using SGP.Model.Repositories;

namespace SGP.UnitTests
{
    [TestClass]
    public class UnitTestEstoque
    {
        RepositoryEntrada repositoryEntrada = new RepositoryEntrada();
        RepositoryColaborador repositoryCol = new RepositoryColaborador();
        RepositoryFornecedor repositoryForn = new RepositoryFornecedor();


        [TestMethod]
        public void TestCriar()
        {
            COLABORADOR UltimoColaborador = repositoryCol.UltimoCadastro();
            FORNECEDOR UltimoFornecedor = repositoryForn.UltimoCadastro();

            ENTRADA oEntrada = new ENTRADA();
            oEntrada.DataEntrada = DateTime.Now;
            oEntrada.IDColaborador = UltimoColaborador.ID;
            oEntrada.IDFornecedor = UltimoFornecedor.ID;
            oEntrada.Insumo = "Areia";
            oEntrada.NF = "NF012";
            oEntrada.QtdEntrada = Convert.ToDouble("1000");
            var Confere = repositoryEntrada.Incluir(oEntrada);
            Assert.AreEqual(true, Confere);
        }

        [TestMethod]
        public void TestListar()
        {
            List<ENTRADA> ListaEntradas = repositoryEntrada.SelecionarTodasEntradas();
            Assert.IsNotNull(ListaEntradas);
        }
    }
}
