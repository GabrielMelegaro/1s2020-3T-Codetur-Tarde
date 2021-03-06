﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Senai.CodeTur.Infra.Data.Contexto;

namespace Senai.CodeTur.Infra.Data.Migrations
{
    [DbContext(typeof(CodeturContext))]
    partial class CodeturContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Senai.CodeTur.Dominio.Entidades.PacoteDominio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasColumnType("varchar(400)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnName("Imagem")
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("Oferta")
                        .HasColumnName("Oferta")
                        .HasColumnType("bit");

                    b.Property<string>("País")
                        .IsRequired()
                        .HasColumnName("País")
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("Status")
                        .HasColumnName("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("Titulo")
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Pacotes");

                    b.HasData(
                        new { Id = 1, DataFim = new DateTime(2020, 1, 25, 17, 6, 59, 383, DateTimeKind.Local), DataInicio = new DateTime(2020, 1, 22, 17, 6, 59, 382, DateTimeKind.Local), Descricao = "O Texas, é uma dos estados mais quentes do Estados Unidos, Terra do Bacon", Imagem = "https://a.travel-assets.com/findyours-php/viewfinder/images/res10/332000/332960-Dallas.jpg", Oferta = true, País = "EUA", Status = true, Titulo = "Pacote Especial : Texas" }
                    );
                });

            modelBuilder.Entity("Senai.CodeTur.Dominio.Entidades.UsuarioDominio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("Senha")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnName("Tipo")
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new { Id = 1, Email = "fernando.guerra@sp.senai.br", Senha = "senai132", Tipo = "Administrador" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
