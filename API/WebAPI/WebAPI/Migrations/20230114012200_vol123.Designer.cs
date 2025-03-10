﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230114012200_vol123")]
    partial class vol123
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.Araclar", b =>
                {
                    b.Property<int>("AraclarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AraclarDurum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarHiz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarRenk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarSeri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarYakit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AraclarYil")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AraclarID");

                    b.ToTable("araclars");
                });

            modelBuilder.Entity("WebAPI.Models.Urunler", b =>
                {
                    b.Property<int>("UrunlerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UrunlerImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunlerKisaAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunlerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunlerUzunAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UrunlerID");

                    b.ToTable("urunlers");
                });

            modelBuilder.Entity("WebAPI.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
