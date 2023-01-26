﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistraPessoa.Api.Model.Context;

#nullable disable

namespace RegistraPessoa.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230126022605_Dataset3")]
    partial class Dataset3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("PessoaVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RegistraPessoa.Api.Model.Base.PessoaBase.Pessoa", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned")
                        .HasColumnName("ID");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("CPF");

                    b.Property<DateTime?>("DataDeCriacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATA_DA_CRIACAO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("E-MAIL");

                    b.Property<uint>("Idade")
                        .HasColumnType("int unsigned")
                        .HasColumnName("IDADE");

                    b.Property<string>("ImageUrlPerfil")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("URL_IMAGEM_PERFIL");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NOME_COMPLETO");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("TELEFONE");

                    b.HasKey("Id");

                    b.ToTable("Tabela_Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
