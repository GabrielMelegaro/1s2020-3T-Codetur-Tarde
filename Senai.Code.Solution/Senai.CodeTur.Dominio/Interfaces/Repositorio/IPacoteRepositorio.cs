using Senai.CodeTur.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Dominio.Interfaces.Repositorio
{
    public interface IPacoteRepositorio
    {
        PacoteDominio Cadastrar(PacoteDominio pacote);
        PacoteDominio BuscarPorId(int id);
        List<PacoteDominio> Listar();
    }
}
