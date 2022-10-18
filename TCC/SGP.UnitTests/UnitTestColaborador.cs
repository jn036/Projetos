using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGP.Model;
using SGP.Control;
using SGP.Model.Repositories;
using System.Collections.Generic;

namespace SGP.UnitTests
{
    [TestClass]
    public class UnitTestColaborador
    {
        RepositoryColaborador repository = new RepositoryColaborador();
       

        [TestMethod]
        public void TestCriar()
        {
            COLABORADOR oColaborador = new COLABORADOR();
            oColaborador.Nome = "TestUnit";
            oColaborador.Funcao = "TestUnit";
            oColaborador.Senha = "12345678";
            oColaborador.DataCadastro = DateTime.Now;
            oColaborador.DataNascimento = DateTime.Parse("08/10/1997");
            oColaborador.Documento = "999.999.999-99";
            oColaborador.Email = "teste@teste.com";
            oColaborador.CEP = "99999-999";
            oColaborador.Imagem = null;
            oColaborador.Bairro = "TestUnit";
            oColaborador.Cidade = "TestUnit";
            oColaborador.Logradouro = "TestUnit";
            oColaborador.NomeLogradouro = "TestUnit";
            oColaborador.Numero = "00";
            oColaborador.UF = "TX";
            oColaborador.Pais = "Brasil";
            oColaborador.Celular = "(99)99999-9999";
            oColaborador.Telefone = "(99)9999-9999";
            var Confere = repository.Incluir(oColaborador);
            Assert.AreEqual(true, Confere);
        }

        [TestMethod]
        public void TestAlterar()
        {
            COLABORADOR Ultimo = repository.UltimoCadastro();
            Ultimo.Nome = "TestUnit2";
            var Confere = repository.Alterar(Ultimo);
            Assert.AreEqual(true, Confere);

        }

        [TestMethod]
        public void TestDeletar()
        {
            COLABORADOR Ultimo = repository.UltimoCadastro();
            var Confere = repository.Excluir(Ultimo);
            Assert.AreEqual(true, Confere);
        }

        [TestMethod]
        public void TestListar()
        {
            List<COLABORADOR> ListaColaboradores = repository.SelecionarTodosColaboradores();
            Assert.IsNotNull(ListaColaboradores);
        }
    }
}
