using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Senai.Desafio.Solution.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.Desafio.Solution.Contexto
{
    public class AppontoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS3TT;initial catalog=Apponto;user id=sa;password=sa132");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioDominio>().HasData(new ModelBuilder)
            {
                Id = 1,
            }
        }
    }
}
