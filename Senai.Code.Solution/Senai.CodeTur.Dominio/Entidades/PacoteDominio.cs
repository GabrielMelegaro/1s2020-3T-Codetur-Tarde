using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace Senai.CodeTur.Dominio.Entidades
{
    [Table("Pacotes")]
    public class PacoteDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Titulo", TypeName ="varchar(150)")]
        public string Titulo { get; set; }

        [Required]
        [Column("Imagem", TypeName = "varchar(150)")]
        public string Imagem { get; set; }

        [Required]
        [Column("Descricao", TypeName = "varchar(400)")]
        public string Descricao { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DataType DataInicio { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DataType DataFim { get; set; }

        [Required]
        [Column("País", TypeName = "varchar(150)")]
        public string País { get; set; }

        [Required]
        [Column("Ativo", TypeName = "varchar(150)")]
        public bool Ativo { get; set; }

        [Required]
        [Column("Oferta", TypeName = "varchar(150)")]
        public bool Oferta { get; set; }
    }
}