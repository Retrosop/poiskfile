﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Poiskfile;

#nullable disable

namespace Poiskfile.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220728123902_Initial1")]
    partial class Initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Poiskfile.MeteoData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("aa11")
                        .HasColumnType("int");

                    b.Property<int?>("aa12")
                        .HasColumnType("int");

                    b.Property<string>("aa13")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("aa14")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("dew1")
                        .HasColumnType("int");

                    b.Property<string>("dew2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("station")
                        .HasColumnType("int");

                    b.Property<int>("tmp1")
                        .HasColumnType("int");

                    b.Property<string>("tmp2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("wnd1")
                        .HasColumnType("int");

                    b.Property<int>("wnd2")
                        .HasColumnType("int");

                    b.Property<string>("wnd3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("wnd4")
                        .HasColumnType("int");

                    b.Property<int>("wnd5")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MeteoDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
