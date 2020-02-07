using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Senai.CodeTur.Servico.ViewModels.Usuario
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail")]
        [StringLength(120, MinimumLength = 7, ErrorMessage = "Deve ser contido no email pelo menos 7 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a Senha")]
        [StringLength(40, ErrorMessage = "Digite uma senhga que contenha de 5 a 40 caracteres.", MinimumLength = 5)]
        public string Senha { get; set; }
    }
}
