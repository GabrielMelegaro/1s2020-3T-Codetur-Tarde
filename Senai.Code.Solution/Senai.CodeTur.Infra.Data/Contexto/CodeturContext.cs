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
        public DbSet<PacoteDominio> Pacote { get; set; }

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
        
            modelBuilder.Entity<PacoteDominio>().HasData(new PacoteDominio()
            {
                Id = 1,
                Titulo = "Pacote Especial : Texas",
                País = "EUA",
                Imagem = "https://a.travel-assets.com/findyours-php/viewfinder/images/res10/332000/332960-Dallas.jpg",
                Descricao = "O Texas, é uma dos estados bmais quentes do Estados Unidos, Terra do Bacon",
                Status = true,
                Oferta = true,
                DataInicio = DateTime.Now.AddDays(-12),
                DataFim = DateTime.Now.AddDays(-9),
            });
        }
    }
}
