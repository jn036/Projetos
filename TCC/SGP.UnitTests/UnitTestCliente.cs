using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGP.Model;
using SGP.Model.Repositories;

namespace SGP.UnitTests
{
    [TestClass]
    public class UnitTestCliente
    {
        RepositoryCliente repository = new RepositoryCliente();


        [TestMethod]
        public void TestCriar()
        {
            CLIENTE oCliente = new CLIENTE();
            oCliente.Nome = "TestUnit";
            oCliente.DataCadastro = DateTime.Now;
            oCliente.DataNascimento = DateTime.Parse("08/10/1997");
            oCliente.Documento = "999.999.999-99";
            oCliente.Email = "teste@teste.com";
            oCliente.CEP = "99999-999";
            oCliente.Imagem = null;
            oCliente.Bairro = "TestUnit";
            oCliente.Cidade = "TestUnit";
            oCliente.Logradouro = "TestUnit";
            oCliente.NomeLogradouro = "TestUnit";
            oCliente.Numero = "00";
            oCliente.UF = "TX";
            oCliente.Pais = "Brasil";
            oCliente.Celular = "(99)99999-9999";
            oCliente.Telefone = "(99)9999-9999";
            var Confere = repository.Incluir(oCliente);
            Assert.AreEqual(true, Confere);
        }

        [TestMethod]
        public void TestAlterar()
        {
            CLIENTE Ultimo = repository.UltimoCadastro();
            Ultimo.Nome = "TestUnit2";
            var Confere = repository.Alterar(Ultimo);
            Assert.AreEqual(true, Confere);

        }

        [TestMethod]
        public void TestDeletar()
        {
            CLIENTE Ultimo = repository.UltimoCadastro();
            var Confere = repository.Excluir(Ultimo);
            Assert.AreEqual(true, Confere);
        }

        [TestMethod]
        public void TestListar()
        {
            List<CLIENTE> ListaClientes = repository.SelecionarTodosClientes();
            Assert.IsNotNull(ListaClientes);
        }
    }
}