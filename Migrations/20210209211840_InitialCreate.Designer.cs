﻿// <auto-generated />
using System;
using CadastroCliente.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CadastroCliente.Migrations
{
    [DbContext(typeof(ClienteContext))]
    [Migration("20210209211840_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("CadastroCliente.Models.Cliente", b =>
                {
                    b.Property<double>("ID")
                        .HasColumnType("double");

                    b.Property<string>("Bairro")
                        .HasColumnType("text");

                    b.Property<double>("Cep")
                        .HasColumnType("double");

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime");

                    b.Property<string>("Endereco")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Sexo")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
