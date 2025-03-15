﻿// <auto-generated />
using System;
using Examen2POO.API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen2POO.API.Migrations
{
    [DbContext(typeof(EmpleadosDBContext))]
    partial class EmpleadosDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("Examen2POO.API.Database.Entities.EmpleadosEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER")
                        .HasColumnName("active");

                    b.Property<decimal>("BaseSalary")
                        .HasColumnType("TEXT")
                        .HasColumnName("base_salary");

                    b.Property<string>("Departament")
                        .HasColumnType("TEXT")
                        .HasColumnName("departament");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("dni");

                    b.Property<string>("Document")
                        .HasColumnType("TEXT")
                        .HasColumnName("document");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("hiring_date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Last_name");

                    b.Property<string>("PuestoTrabajo")
                        .HasColumnType("TEXT")
                        .HasColumnName("puesto_trabajo");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Examen2POO.API.Database.Entities.PlanillaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT")
                        .HasColumnName("Estado");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("TEXT")
                        .HasColumnName("fecha_pago");

                    b.Property<string>("Periodo")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("periodo");

                    b.HasKey("Id");

                    b.ToTable("Planillas");
                });
#pragma warning restore 612, 618
        }
    }
}
