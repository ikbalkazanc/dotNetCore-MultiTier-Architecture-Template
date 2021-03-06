﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201101140903_personfield")]
    partial class personfield
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActived")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActived = false,
                            IsDeleted = false,
                            Name = "Elektronik"
                        },
                        new
                        {
                            Id = 2,
                            IsActived = false,
                            IsDeleted = false,
                            Name = "Ev"
                        },
                        new
                        {
                            Id = 3,
                            IsActived = false,
                            IsDeleted = false,
                            Name = "İnşaat"
                        });
                });

            modelBuilder.Entity("Core.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ahmet",
                            Surname = "Deliyürek"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Handan",
                            Surname = "Dert"
                        });
                });

            modelBuilder.Entity("Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CategoryId")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("CategoryId1")
                        .HasColumnType("int");

                    b.Property<string>("InnerBarcode")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId1");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1m,
                            Name = "Monitör",
                            Price = 2000.50m,
                            Stock = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1m,
                            Name = "Fare",
                            Price = 50m,
                            Stock = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2m,
                            Name = "Sandalye",
                            Price = 1000.10m,
                            Stock = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3m,
                            Name = "Fayans",
                            Price = 150.20m,
                            Stock = 0,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("Core.Models.Product", b =>
                {
                    b.HasOne("Core.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId1");
                });
#pragma warning restore 612, 618
        }
    }
}
