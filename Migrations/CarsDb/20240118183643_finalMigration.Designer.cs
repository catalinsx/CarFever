﻿// <auto-generated />
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations.CarsDb
{
    [DbContext(typeof(CarsDbContext))]
    [Migration("20240118183643_finalMigration")]
    partial class finalMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalProject.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("engineCapacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fuelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gearBox")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horsePower")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("newtonMetters")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("yearProduction")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
