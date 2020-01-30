using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace Senai.Desafio.Solution.Dominio
{

    [Table("Usuarios")]
    public class UsuarioDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Nome", TypeName ="varchar(150)")]
        public string Nome { get; set; }
        
        [Required]
        [Column("Email", TypeName ="varchar(150)")]
        public string Email { get; set; }

        [Required]
        [Column("Senha", TypeName ="varchar(20)")]
        public string Senha { get; set; }
    }
}