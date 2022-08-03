﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoEmcartago.Server.Data;

#nullable disable

namespace ProyectoEmcartago.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("ProyectoEmcartago.Shared.Entidades.Entidad_Uso_Epp.Imagen_UsoEpp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InspeccionUsoEppId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InspeccionUsoEppId");

                    b.ToTable("Imagenes_UsoEpp");
                });

            modelBuilder.Entity("ProyectoEmcartago.Shared.Entidades.Entidad_Uso_Epp.InspeccionUsoEpp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Actividad_Mayor_O_Igual_A_15_Dias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Botas_De_Caucho_Con_Puntera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Botas_De_Seguridad_Con_Puntera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Botas_De_Seguridad_Sin_Puntera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Camisa_Con_Reflectivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Careta_De_Seguridad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carnet_De_Contratista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Casco_De_Seguridad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Chaleco_Reflectivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Curso_Trabajo_En_Alturas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Disposicion_De_Los_Epps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Epps_De_Acuerdo_A_La_Actividad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gafas_De_Seguridad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gafas_De_Seguridad_lente_Oscuro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gorra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guantes_Carnaza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guantes_De_Caucho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guantes_Tipo_Ingeniero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Impermeable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Mascarilla_Con_Filtros")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Coordinador_En_Alturas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Actividad_Mayor_O_Igual_A_15_Dias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Botas_De_Caucho_Con_Puntera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Botas_De_Seguridad_Con_Puntera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Botas_De_Seguridad_Sin_Puntera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Camisa_Con_Reflectivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Careta_De_Seguridad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Carnet_De_Contratista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Casco_De_Seguridad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Chaleco_Reflectivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Disposicion_De_Los_Epps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Epps_De_Acuerdo_A_La_Actividad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Gafas_De_Seguridad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Gafas_De_Seguridad_lente_Oscuro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Gorra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Guantes_Carnaza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Guantes_De_Caucho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Guantes_Tipo_Ingeniero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Impermeable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Mascarilla_Con_Filtros")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Otros")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Pantalon_Reflectivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Protector_Auditivo_De_Copa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Protector_Auditivo_Insercion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Seguridad_Social")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Sitio_Coordinador_Para_Trabajo_En_Alturas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Tapa_Bocas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion_Trabajo_En_Alturas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opcion_Disposicion_De_Los_Epps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Otro_Elemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Otros")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pantalon_Reflectivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Protector_Auditivo_De_Copa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Protector_Auditivo_Insercion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsable_Inspeccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seguridad_Social")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sitio_Coordinador_Para_Trabajo_En_Alturas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tapa_Bocas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trabajo_En_Alturas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("inspeccionUsoEpp");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Actividad_Mayor_O_Igual_A_15_Dias = "No Aplica",
                            Botas_De_Caucho_Con_Puntera = "No Cumple",
                            Botas_De_Seguridad_Con_Puntera = "No Cumple",
                            Botas_De_Seguridad_Sin_Puntera = "No Cumple",
                            Camisa_Con_Reflectivo = "No Cumple",
                            Careta_De_Seguridad = "Cumple",
                            Cargo = "Funcionario",
                            Carnet_De_Contratista = "No Aplica",
                            Casco_De_Seguridad = "Cumple",
                            Chaleco_Reflectivo = "Cumple",
                            Curso_Trabajo_En_Alturas = "Avanzado",
                            Disposicion_De_Los_Epps = "No Aplica",
                            Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista = "No Aplica",
                            Epps_De_Acuerdo_A_La_Actividad = "No Aplica",
                            Fecha = new DateTime(2022, 8, 3, 10, 7, 41, 102, DateTimeKind.Local).AddTicks(3409),
                            Gafas_De_Seguridad = "Cumple",
                            Gafas_De_Seguridad_lente_Oscuro = "Cumple",
                            Gorra = "No Cumple",
                            Guantes_Carnaza = "Cumple",
                            Guantes_De_Caucho = "Cumple",
                            Guantes_Tipo_Ingeniero = "Cumple",
                            ImageUrl = "",
                            Impermeable = "Cumple",
                            IsDelete = false,
                            Mascarilla_Con_Filtros = "Cumple",
                            Nombre = "Juan Manuel Ramirez Hernandez",
                            Nombre_Coordinador_En_Alturas = "Javier Boneti",
                            Observacion_Actividad_Mayor_O_Igual_A_15_Dias = "Funcionario Cumplidor con esta medida",
                            Observacion_Botas_De_Caucho_Con_Puntera = "Funcionario Cumplidor con esta medida",
                            Observacion_Botas_De_Seguridad_Con_Puntera = "Funcionario Cumplidor con esta medida",
                            Observacion_Botas_De_Seguridad_Sin_Puntera = "Funcionario Cumplidor con esta medida",
                            Observacion_Camisa_Con_Reflectivo = "Funcionario Cumplidor con esta medida",
                            Observacion_Careta_De_Seguridad = "Funcionario Cumplidor con esta medida",
                            Observacion_Carnet_De_Contratista = "Funcionario Cumplidor con esta medida",
                            Observacion_Casco_De_Seguridad = "Funcionario Cumplidor con esta medida",
                            Observacion_Chaleco_Reflectivo = "Funcionario Cumplidor con esta medida",
                            Observacion_Disposicion_De_Los_Epps = "Funcionario Cumplidor con esta medida",
                            Observacion_Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista = "Funcionario Cumplidor con esta medida",
                            Observacion_Epps_De_Acuerdo_A_La_Actividad = "Funcionario Cumplidor con esta medida",
                            Observacion_Gafas_De_Seguridad = "Funcionario Cumplidor con esta medida",
                            Observacion_Gafas_De_Seguridad_lente_Oscuro = "Funcionario Cumplidor con esta medida",
                            Observacion_Gorra = "Funcionario Cumplidor con esta medida",
                            Observacion_Guantes_Carnaza = "Funcionario Cumplidor con esta medida",
                            Observacion_Guantes_De_Caucho = "Funcionario Cumplidor con esta medida",
                            Observacion_Guantes_Tipo_Ingeniero = "Funcionario Cumplidor con esta medida",
                            Observacion_Impermeable = "Funcionario Cumplidor con esta medida",
                            Observacion_Mascarilla_Con_Filtros = "Funcionario Cumplidor con esta medida",
                            Observacion_Otros = "Funcionario Cumplidor con esta medida",
                            Observacion_Pantalon_Reflectivo = "Funcionario Cumplidor con esta medida",
                            Observacion_Protector_Auditivo_De_Copa = "Funcionario Cumplidor con esta medida",
                            Observacion_Protector_Auditivo_Insercion = "Funcionario Cumplidor con esta medida",
                            Observacion_Seguridad_Social = "Funcionario Cumplidor con esta medida",
                            Observacion_Sitio_Coordinador_Para_Trabajo_En_Alturas = "Funcionario Cumplidor con esta medida",
                            Observacion_Tapa_Bocas = "Funcionario Cumplidor con esta medida",
                            Observacion_Trabajo_En_Alturas = "Funcionario Cumplidor con esta medida",
                            Opcion_Disposicion_De_Los_Epps = "Proteccion Contra Caidas",
                            Otro_Elemento = "Casco de tres dimensiones",
                            Otros = "Cumple",
                            Pantalon_Reflectivo = "No Cumple",
                            Protector_Auditivo_De_Copa = "Cumple",
                            Protector_Auditivo_Insercion = "Cumple",
                            Responsable_Inspeccion = "Luis Alfredo Bolívar González",
                            Seguridad_Social = "No Aplica",
                            Sitio_Coordinador_Para_Trabajo_En_Alturas = "No Aplica",
                            Tapa_Bocas = "Cumple",
                            Trabajo_En_Alturas = "No Aplica"
                        });
                });

            modelBuilder.Entity("ProyectoEmcartago.Shared.Entidades.Entidad_Uso_Epp.Imagen_UsoEpp", b =>
                {
                    b.HasOne("ProyectoEmcartago.Shared.Entidades.Entidad_Uso_Epp.InspeccionUsoEpp", null)
                        .WithMany("Imagenes_UsoEpp")
                        .HasForeignKey("InspeccionUsoEppId");
                });

            modelBuilder.Entity("ProyectoEmcartago.Shared.Entidades.Entidad_Uso_Epp.InspeccionUsoEpp", b =>
                {
                    b.Navigation("Imagenes_UsoEpp");
                });
#pragma warning restore 612, 618
        }
    }
}
