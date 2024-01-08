﻿// <auto-generated />
using Agencia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Agencia.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240107011531_Migracao4")]
    partial class Migracao4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Agencia.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)")
                        .HasColumnName(" usuario_cpf");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("usuario_destino");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName(" usuario_email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName(" usuario_nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName(" usuario_senha");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName(" usuario_telefone");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = "12345678901",
                            Destino = "Rio de Janeiro",
                            Email = "john.doe@example.com",
                            Nome = "John Doe",
                            Senha = "password123",
                            Telefone = "123-456-7890"
                        },
                        new
                        {
                            Id = 2,
                            Cpf = "98765432101",
                            Destino = "São Paulo",
                            Email = "jane.doe@example.com",
                            Nome = "Jane Doe",
                            Senha = "password456",
                            Telefone = "987-654-3210"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
