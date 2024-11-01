﻿// <auto-generated />
using GreenHouseApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenHouseApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GreenHouseApi.Models.GreenHouseConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConfigName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MaxSoilMoisture")
                        .HasColumnType("float");

                    b.Property<double>("MaxTemp")
                        .HasColumnType("float");

                    b.Property<double>("MinSoilMoisture")
                        .HasColumnType("float");

                    b.Property<double>("MinTemp")
                        .HasColumnType("float");

                    b.Property<double>("MinWaterLevel")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("GreenHouseConfigs");
                });
#pragma warning restore 612, 618
        }
    }
}
