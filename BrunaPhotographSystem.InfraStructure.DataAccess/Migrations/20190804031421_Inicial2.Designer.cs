﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using BrunaPhotographSystem.InfraStructure.DataAccess.Context;

namespace BrunaPhotographSystem.InfraStructure.DataAccess.Migrations
{
    [DbContext(typeof(FotografaContext))]
    [Migration("20190804031421_Inicial2")]
    partial class Inicial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClienteId");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Albuns");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Administrador");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Pedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClienteId");

                    b.Property<DateTime>("DataPedido");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Album", b =>
                {
                    b.HasOne("BrunaPhotographSystem.DomainModel.Entities.Cliente", "Cliente")
                        .WithMany("Albuns")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Pedido", b =>
                {
                    b.HasOne("BrunaPhotographSystem.DomainModel.Entities.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId");
                });
#pragma warning restore 612, 618
        }
    }
}
