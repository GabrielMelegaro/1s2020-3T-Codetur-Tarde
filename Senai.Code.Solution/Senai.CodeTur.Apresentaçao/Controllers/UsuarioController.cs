using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Senai.CodeTur.Dominio.Interfaces.Repositorio;
using Senai.CodeTur.Servico;
using Senai.CodeTur.Servico.ViewModels.Usuario;

namespace Senai.CodeTur.Apresentaçao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel usuario)
        {
            try
            {
                var usuarioRetorno = _usuarioRepositorio.EfetuarLogin(usuario.Email, usuario.Senha);

                if(usuarioRetorno == null)
                {
                    return NotFound(new { mensagem = "Email ou senha Incorretos" });
                }

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, usuarioRetorno.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioRetorno.Id.ToString())
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("chave-codetur-apresentacao"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "CodeTur.WebApi",
                    audience: "CodeTur.WebApi",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds
                 );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch(Exception ex)
            {
                return BadRequest(new { Sucesso = false, mensagem = ex.Message });
            }
        }
    }
}