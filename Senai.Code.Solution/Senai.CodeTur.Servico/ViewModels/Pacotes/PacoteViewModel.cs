using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Senai.CodeTur.Servico.ViewModels.Pacotes
{
    public class PacoteViewModel
    {
        [Required(ErrorMessage = "Coloque o titulo do pacote")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Coloque a descrição do pacote")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Coloque o País do pacote")]
        public string Pais { get; set; }
        [Required(ErrorMessage = "Coloque o Data Inicio do pacote")]
        public DateTime DataInicio { get; set; }
        [Required(ErrorMessage = "Coloque o Data Fim do pacote")]
        public DateTime DataFim { get; set; }
        [Required(ErrorMessage = "Informe se o status do pacote e ativo ou nao")]
        public bool Status { get; set; }
        [Required(ErrorMessage = "Coloque o Imagem do pacote")]
        public string Imagem { get; set; }
    }
}
