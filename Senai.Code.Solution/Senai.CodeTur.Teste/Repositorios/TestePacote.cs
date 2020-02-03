using Senai.CodeTur.Dominio.Interfaces.Repositorio;
using Senai.CodeTur.Infra.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace Senai.CodeTur.Teste.XUnit.Repositorios
{
    public class TestePacote
    {
        private IPacoteRepositorio _pacoteRepositorio;

        public TestePacote()
        {
            _pacoteRepositorio = new PacotesRepositorio();
        }

        [Fact]
        public void PacoteBuscarPorIdInvalido()
        {
            var pacotes = _pacoteRepositorio.BuscarPorId()
        }
    }
}