﻿// <auto-generated />
using System;
using LojaVirtual.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LojaVirtual.Migrations
{
    [DbContext(typeof(LojaVirtualContext))]
    [Migration("20200402153443_Newsletter")]
    partial class Newsletter
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("LojaVirtual.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("CPF")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .HasColumnName("email");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnName("nascimento");

                    b.Property<string>("Nome")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .HasColumnName("senha");

                    b.Property<string>("Sexo")
                        .HasColumnName("sexo");

                    b.Property<int>("Telefone")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("LojaVirtual.Models.NewsletterEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .HasColumnName("email");

                    b.HasKey("Id");

                    b.ToTable("newsletter_email");
                });
#pragma warning restore 612, 618
        }
    }
}
