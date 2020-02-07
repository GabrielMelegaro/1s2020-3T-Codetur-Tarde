using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Infra.Data.Repositorio;

namespace Senai.CodeTur.Apresentaçao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacoteController : ControllerBase
    {
        PacotesRepositorio PacoteRepositorio = new PacotesRepositorio();

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(PacoteRepositorio.Listar());
        }

        [HttpPost]
        public IActionResult Cadastrar(PacoteDominio pacote)
        {
            try
            {
                PacoteRepositorio.Cadastrar(pacote);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            PacoteDominio pacote = PacoteRepositorio.BuscarPorId(id);
            if (pacote == null)
                return NotFound();
            return Ok(pacote);
        }
    }
}