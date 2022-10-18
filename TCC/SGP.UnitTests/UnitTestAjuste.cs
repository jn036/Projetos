using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGP.Model;
using SGP.Model.Repositories;

namespace SGP.UnitTests
{
    [TestClass]
    public class UnitTestAjuste
    {
        RepositoryAjuste repository = new RepositoryAjuste();

        [TestMethod]
        public void TestCriar()
        {
            AJUSTE oAjuste = new AJUSTE();
            oAjuste.dataAjuste = DateTime.Now;
            oAjuste.minimoAreia = int.Parse("3000");
            oAjuste.minimoBrita0 = int.Parse("3000");
            oAjuste.minimoBrita1 = int.Parse("3000");
            oAjuste.minimoCimento = int.Parse("3000");
            oAjuste.minimoaditivo = int.Parse("3000");
            oAjuste.tempoAreia = int.Parse("3000");
            oAjuste.tempoBrita0 = int.Parse("3000");
            oAjuste.tempoBrita1 = int.Parse("3000");
            oAjuste.tempoCimento = int.Parse("3000");
            oAjuste.tempoAditivo = int.Parse("3000");
            oAjuste.tempoAgua = int.Parse("3000");
            var Confere = repository.Incluir(oAjuste);
            Assert.AreEqual(true, Confere);
        }
    }
}
