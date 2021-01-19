﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleManagementSystemWebAPI.Models;

namespace VehicleManagementSystemWebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("VehicleManagementSystemWebAPI.Models.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("VehicleType")
                        .HasColumnType("TEXT");

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