using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGP.Model;
using SGP.Model.Repositories;

namespace SGP.UnitTests
{
    [TestClass]
    public class UnitTestReceita
    {
        RepositoryReceita repository = new RepositoryReceita();

        [TestMethod]
        public void TestCriar()
        {
            RECEITA oReceita = new RECEITA();
            oReceita.Nome = "ReceitaTeste";
            oReceita.Adit1Prog = Convert.ToDouble("10");
            oReceita.Agr1Prog = Convert.ToDouble("5");
            oReceita.Agr2Prog = Convert.ToDouble("0");
            oReceita.Agr3Prog = Convert.ToDouble("5");
            oReceita.Agua1Prog = Convert.ToDouble("15");
            oReceita.Cim1Prog = Convert.ToDouble("10");
            oReceita.Total = Convert.ToDouble(oReceita.Adit1Prog + oReceita.Agr1Prog + oReceita.Agr2Prog + oReceita.Agr3Prog + oReceita.Agua1Prog + oReceita.Cim1Prog);
            var Confere = repository.Incluir(oReceita);
            Assert.AreEqual(true, Confere);
        }

        [TestMethod]
        public void TestAlterar()
        {
            RECEITA Ultimo = repository.UltimoCadastro();
            Ultimo.Nome = "ReceitaTeste2";
            var Confere = repository.Alterar(Ultimo);
            Assert.AreEqual(true, Confere);

        }

        [TestMethod]
        public void TestDeletar()
        {
            RECEITA Ultimo = repository.UltimoCadastro();
            var Confere = repository.Excluir(Ultimo);
            Assert.AreEqual(true, Confere);
        }

        [TestMethod]
        public void TestListar()
        {
            List<RECEITA> ListaReceitas = repository.SelecionarTodasReceitas();
            Assert.IsNotNull(ListaReceitas);
        }
    }
}
