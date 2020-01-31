using Microsoft.EntityFrameworkCore;
using Senai.CodeTur.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Contexto
{
    public class CodeturContext : DbContext
    {
        public DbSet<UsuarioDominio> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS3TT;initial catalog=CodeTur;user id=sa;password=sa132");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioDominio>().HasData(new UsuarioDominio()
            {
                Id = 1,
                Email = "fernando.guerra@sp.senai.br",
                Senha = "senai132",
                Tipo = "Administrador"
            });
        }
    }
}
