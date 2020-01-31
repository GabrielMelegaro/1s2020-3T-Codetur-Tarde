using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interfaces.Repositorio;
using Senai.CodeTur.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        /// <summary>
        /// Verifica se um usuario existe
        /// </summary>
        /// <param name="email">email do usuario</param>
        /// <param name="senha">senha do usuario</param>
        /// <returns>Retorna um objeto UsuarioDominio</returns>


        public UsuarioDominio EfetuarLogin(string email, string senha)
        {
            try
            {
                using(CodeturContext ctx = new CodeturContext())
                {
                    return ctx.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
                }
            }
            catch(System.Exception ex)
            {
                throw new Exception(ex.Message);  
            }
        }
    }
}
