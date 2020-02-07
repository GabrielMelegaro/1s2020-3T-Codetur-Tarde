using Microsoft.EntityFrameworkCore;
using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Infra.Data.Contexto;
using Senai.CodeTur.Infra.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Senai.CodeTur.Teste.XUnit.Repositorios
{
    public class TestePacote
    {
        [Theory]
        [InlineData(1)]
        public void TestePacoteBuscarPorIdNaoExiste(int id)
        {
            //var options = new DbContextOptionsBuilder<CodeturContext>()
            //.UseInMemoryDatabase(databaseName: "BuscaPorIdNaoExiste")
            //.Options;

            // Use a clean instance of the context to run the test
            using (CodeturContext ctx  = new CodeturContext())
            {
                var repositorio = new PacotesRepositorio();
                var resultado = repositorio.BuscarPorId(1);
                Assert.NotNull(resultado);
            }
        }

        [Fact]
        public void TestePacoteCadastrar()
        {

            //var options = new DbContextOptionsBuilder<CodeturContext>()
            //UseInMemoryDatabase(databaseName: "PacoteCadastrar")
            //.Options;

            PacoteDominio pacote = new PacoteDominio()
            {
                Id = 1,
                Titulo = "Pacote Especial : Texas",
                País = "EUA",
                Imagem = "https://a.travel-assets.com/findyours-php/viewfinder/images/res10/332000/332960-Dallas.jpg",
                Descricao = "O Texas, é um dos estados mais quentes do Estados Unidos, Terra do Bacon",
                Status = true,
                Oferta = true,
                DataInicio = DateTime.Now.AddDays(-12),
                DataFim = DateTime.Now.AddDays(-9),
            };

            // Use a clean instance of the context to run the test
            using (CodeturContext ctx = new CodeturContext())
            {
                var service = new PacotesRepositorio();
                var result = service.Cadastrar(pacote);
                Assert.NotNull(result);
                Assert.Equal("Pacote Especial : Texas", result.Titulo);
            }

        }

        [Fact]
        public void BuscarPacotePorIdExisteTeste()
        {

            //var options = new DbContextOptionsBuilder<CodeturContext>()
                //UseInMemoryDatabase(databaseName: "PacoteCadastrar")
                //.Options;

            PacoteDominio pacote = new PacoteDominio()
            {
                Id = 1,
                Titulo = "Pacote Especial : Texas",
                País = "EUA",
                Imagem = "https://a.travel-assets.com/findyours-php/viewfinder/images/res10/332000/332960-Dallas.jpg",
                Descricao = "O Texas, é uma dos estados bmais quentes do Estados Unidos, Terra do Bacon",
                Status = true,
                Oferta = true,
                DataInicio = DateTime.Now.AddDays(-12),
                DataFim = DateTime.Now.AddDays(-9),
            };

            // Use a clean instance of the context to run the test
            using (CodeturContext ctx = new CodeturContext())
            {
                var repositorio = new PacotesRepositorio();

                repositorio.Cadastrar(pacote);

                var resultado = repositorio.BuscarPorId(1);
                Assert.NotNull(resultado);
                Assert.Equal(1, resultado.Id);
            }

        }
    }
}
