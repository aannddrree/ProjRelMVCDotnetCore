﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Models;

namespace ProjRelMVCDotnetCore.Migrations
{
    [DbContext(typeof(ProjRelMVCDotNetCoreContext))]
    [Migration("20181105221613_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("ProjRelMVCDotnetCore.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<int?>("QuartoID");

                    b.HasKey("ID");

                    b.HasIndex("QuartoID");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("ProjRelMVCDotnetCore.Models.Quarto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("ID");

                    b.ToTable("Quarto");
                });

            modelBuilder.Entity("ProjRelMVCDotnetCore.Models.Hotel", b =>
                {
                    b.HasOne("ProjRelMVCDotnetCore.Models.Quarto", "Quarto")
                        .WithMany()
                        .HasForeignKey("QuartoID");
                });
#pragma warning restore 612, 618
        }
    }
}