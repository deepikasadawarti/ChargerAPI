﻿// <auto-generated />
using System;
using ChargerInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChargerInfo.API.Migrations
{
    [DbContext(typeof(ChargerInfoContext))]
    [Migration("20190528133742_ChargerInfoDB_V0.1")]
    partial class ChargerInfoDB_V01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChargerInfo.API.Entities.Charger", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("chargerStationType")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("powerInVolt")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("chargers");
                });

            modelBuilder.Entity("ChargerInfo.API.Entities.Session", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("sessionStartTime");

                    b.Property<DateTime>("sessionStopTime");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(7);

                    b.HasKey("id");

                    b.ToTable("sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
