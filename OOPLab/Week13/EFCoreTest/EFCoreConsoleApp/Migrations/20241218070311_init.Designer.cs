﻿// <auto-generated />
using EFCoreConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreConsoleApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241218070311_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("EFCoreConsoleApp.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mouse",
                            Price = 150m,
                            Stock = 25
                        },
                        new
                        {
                            Id = 2,
                            Name = "Keyboard",
                            Price = 300m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 3,
                            Name = "Monitor",
                            Price = 2500m,
                            Stock = 10
                        });
                });
#pragma warning restore 612, 618
        }
    }
}