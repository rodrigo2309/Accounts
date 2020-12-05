﻿// <auto-generated />
using System;
using AccountWebMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccountWebMVC.Migrations
{
    [DbContext(typeof(AccountWebMVCContext))]
    [Migration("20201203143000_tabelasUsuarios")]
    partial class tabelasUsuarios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AccountWebMVC.Models.Local", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<int>("TipoID");

                    b.HasKey("Id");

                    b.HasIndex("TipoID");

                    b.ToTable("Local");
                });

            modelBuilder.Entity("AccountWebMVC.Models.Release", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int>("LocalID");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("LocalID");

                    b.ToTable("Release");
                });

            modelBuilder.Entity("AccountWebMVC.Models.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Tipo");
                });

            modelBuilder.Entity("AccountWebMVC.Models.Usuarios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ativo");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AccountWebMVC.Models.Local", b =>
                {
                    b.HasOne("AccountWebMVC.Models.Tipo", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AccountWebMVC.Models.Release", b =>
                {
                    b.HasOne("AccountWebMVC.Models.Local", "Local")
                        .WithMany("Releases")
                        .HasForeignKey("LocalID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}