﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Proyectoef;

#nullable disable

namespace Api_CRUD_Entity_Framework.Migrations
{
    [DbContext(typeof(TareasContex))]
    [Migration("20220811224136_noNull2")]
    partial class noNull2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Api_CRUD_Entity_Framework.Models.Categoria", b =>
                {
                    b.Property<Guid>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<int>("Peso")
                        .HasColumnType("integer");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            CategoriaId = new Guid("fe2de405-c38e-4c90-ac52-da0540dfb4ef"),
                            Nombre = "Actividades pendientes",
                            Peso = 20
                        },
                        new
                        {
                            CategoriaId = new Guid("fe2de405-c38e-4c90-ac52-da0540dfb402"),
                            Nombre = "Actividades personales",
                            Peso = 50
                        });
                });

            modelBuilder.Entity("Api_CRUD_Entity_Framework.Models.Tarea", b =>
                {
                    b.Property<Guid>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uuid");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2022, 8, 11, 17, 41, 36, 247, DateTimeKind.Local).AddTicks(2170));

                    b.Property<int>("HorasOcupadas")
                        .HasColumnType("integer");

                    b.Property<int>("PrioridadTarea")
                        .HasColumnType("integer");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("TareaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Tarea", (string)null);

                    b.HasData(
                        new
                        {
                            TareaId = new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d421"),
                            CategoriaId = new Guid("fe2de405-c38e-4c90-ac52-da0540dfb4ef"),
                            Descripcion = "Resumir con Cuadros Sipnoticos",
                            FechaCreacion = new DateTime(2022, 8, 11, 17, 41, 36, 246, DateTimeKind.Local).AddTicks(5840),
                            HorasOcupadas = 0,
                            PrioridadTarea = 2,
                            Titulo = "Lenguaje Resumen pg:50"
                        },
                        new
                        {
                            TareaId = new Guid("c707c5a6-b9ac-4992-b1f4-d01294f3d422"),
                            CategoriaId = new Guid("fe2de405-c38e-4c90-ac52-da0540dfb402"),
                            Descripcion = "Realizarlas con una hoja de papel Bom",
                            FechaCreacion = new DateTime(2022, 8, 11, 17, 41, 36, 246, DateTimeKind.Local).AddTicks(5880),
                            HorasOcupadas = 0,
                            PrioridadTarea = 0,
                            Titulo = "Matematicas Operaciones pg:90"
                        });
                });

            modelBuilder.Entity("Api_CRUD_Entity_Framework.Models.Tarea", b =>
                {
                    b.HasOne("Api_CRUD_Entity_Framework.Models.Categoria", "Categoria")
                        .WithMany("Tareas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Api_CRUD_Entity_Framework.Models.Categoria", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
