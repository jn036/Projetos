using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGP.Model;
using SGP.Model.Repositories;

namespace SGP.UnitTests
{
    [TestClass]
    public class UnitTestFrota
    {
        RepositoryFrota repository = new RepositoryFrota();


        [TestMethod]
        public void TestCriar()
        {
            FROTA oFrota = new FROTA();
            oFrota.Placa = "TXT0000";
            oFrota.Marca = "MarcaTeste";
            oFrota.Modelo = "T0101";
            oFrota.Tara = Convert.ToDouble("10000");
            oFrota.PesoBruto = Convert.ToDouble("20000");
            var Confere = repository.Incluir(oFrota);
            Assert.AreEqual(true, Confere);
        }

        [TestMethod]
        public void TestAlterar()
        {
            FROTA Ultimo = repository.UltimoCadastro();
            Ultimo.Placa = "TXT0001";
            var Confere = repository.Alterar(Ultimo);
            Assert.AreEqual(true, Confere);

        }

        [TestMethod]
        public void TestDeletar()
        {
            FROTA Ultimo = repository.UltimoCadastro();
            var Confere = repository.Excluir(Ultimo);
            Assert.AreEqual(true, Confere);
        }

        [TestMethod]
        public void TestListar()
        {
            List<FROTA> ListaFrotas = repository.SelecionarTodasFrotas();
            Assert.IsNotNull(ListaFrotas);
        }
    }
}
