using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Senai.Desafio.Solution.Dominio
{
    [Table("Historicos")]
    public class HistoricoDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required]
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public UsuarioDominio Usuario { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataHora { get; set; }
    }
}
