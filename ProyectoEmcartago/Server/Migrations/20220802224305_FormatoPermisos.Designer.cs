﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoEmcartago.Server.Data;

#nullable disable

namespace ProyectoEmcartago.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220802224305_FormatoPermisos")]
    partial class FormatoPermisos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProyectoEmcartago.Shared.Entidades.Entidad_Formato_De_Permisos.FormatoPermisos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Autoriza_Jefe_Inmediato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Autoriza_SubGerentes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Causa_Del_Permiso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Causa_Del_Permiso_Otros")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Fecha_Desde")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Fecha_Formato")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Fecha_Hasta")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oficina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("formatoPermisos");
                });
#pragma warning restore 612, 618
        }
    }
}
