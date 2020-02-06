using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interfaces.Repositorio;
using Senai.CodeTur.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Repositorio
{
    public class PacotesRepositorio : IPacoteRepositorio
    {
        private CodeturContext _ctx;

        public PacotesRepositorio(CodeturContext ctx)
        {
            _ctx = ctx;
        }

        public PacoteDominio Cadastrar(PacoteDominio pacote)
        {
            try
            {
                using (CodeturContext ctx = new CodeturContext())
                {
                    ctx.Pacote.Add(pacote);
                    ctx.SaveChanges();
                    return pacote;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public PacoteDominio BuscarPorId(int id)
        {
            try
            {
                using (CodeturContext ctx = new CodeturContext())
                {
                    return ctx.Pacote.Find(id);
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<PacoteDominio> Listar ()
        {
            using (CodeturContext ctx = new CodeturContext())
            {
                return ctx.Pacote.ToList();
            }
        }
    }
}