using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGP.Model;
using SGP.Model.Repositories;

namespace SGP.UnitTests
{
    [TestClass]
    public class UnitTestFornecedor
    {
        RepositoryFornecedor repository = new RepositoryFornecedor();


        [TestMethod]
        public void TestCriar()
        {
            FORNECEDOR oFornecedor = new FORNECEDOR();
            oFornecedor.Nome = "TestUnit";
            oFornecedor.DataCadastro = DateTime.Now;
            oFornecedor.DataNascimento = DateTime.Parse("08/10/1997");
            oFornecedor.Documento = "999.999.999-99";
            oFornecedor.Email = "teste@teste.com";
            oFornecedor.CEP = "99999-999";
            oFornecedor.Imagem = null;
            oFornecedor.Bairro = "TestUnit";
            oFornecedor.Cidade = "TestUnit";
            oFornecedor.Logradouro = "TestUnit";
            oFornecedor.NomeLogradouro = "TestUnit";
            oFornecedor.Numero = "00";
            oFornecedor.UF = "TX";
            oFornecedor.Pais = "Brasil";
            oFornecedor.Celular = "(99)99999-9999";
            oFornecedor.Telefone = "(99)9999-9999";
            var Confere = repository.Incluir(oFornecedor);
            Assert.AreEqual(true, Confere);
        }

        [TestMethod]
        public void TestAlterar()
        {
            FORNECEDOR Ultimo = repository.UltimoCadastro();
            Ultimo.Nome = "TestUnit2";
            var Confere = repository.Alterar(Ultimo);
            Assert.AreEqual(true, Confere);

        }

        [TestMethod]
        public void TestDeletar()
        {
            FORNECEDOR Ultimo = repository.UltimoCadastro();
            var Confere = repository.Excluir(Ultimo);
            Assert.AreEqual(true, Confere);
        }

        [TestMethod]
        public void TestListar()
        {
            List<FORNECEDOR> ListaFornecedores = repository.SelecionarTodosFornecedores();
            Assert.IsNotNull(ListaFornecedores);
        }
    }
}
