﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleManagementSystemWebAPI.Models;

namespace VehicleManagementSystemWebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210119021058_Added fields to Cars")]
    partial class AddedfieldstoCars
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("VehicleManagementSystemWebAPI.Models.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Doors")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Engine")
                        .HasColumnType("TEXT");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VehicleType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("adType")
                        .HasColumnType("TEXT");

                    b.Property<string>("bodyType")
                        .HasColumnType("TEXT");

                    b.Property<int>("wheels")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("VehicleManagementSystemWebAPI.Models.Vehicle", b =>
                {
                    b.Property<string>("VehicleType")
                        .HasColumnType("TEXT");

                    b.HasKey("VehicleType");

                    b.ToTable("VehicleType");
                });
#pragma warning restore 612, 618
        }
    }
}