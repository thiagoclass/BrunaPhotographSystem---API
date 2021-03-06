﻿// <auto-generated />
using System;
using BrunaPhotographSystem.InfraStructure.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BrunaPhotographSystem.InfraStructure.DataAccess.Migrations
{
    [DbContext(typeof(FotografaContext))]
    [Migration("20191008112440_final")]
    partial class final
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<Guid?>("clienteId");

                    b.HasKey("Id");

                    b.HasIndex("clienteId");

                    b.ToTable("Albuns");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CPFNumero");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("CPFNumero");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Foto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AlbumId");

                    b.Property<string>("Descricao");

                    b.Property<string>("FotoUrl");

                    b.Property<string>("MiniFotoUrl");

                    b.Property<string>("Nome");

                    b.Property<int?>("Situacao");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Fotos");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.FotoProduto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("FotoId");

                    b.Property<Guid?>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("FotoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("FotoProdutos");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Pedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClienteId");

                    b.Property<DateTime>("DataPedido");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.PedidoFotoProduto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("FotoProdutoId");

                    b.Property<Guid?>("PedidoId");

                    b.HasKey("Id");

                    b.HasIndex("FotoProdutoId");

                    b.HasIndex("PedidoId");

                    b.ToTable("PedidoFotoProdutos");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.ValueObjects.CPF", b =>
                {
                    b.Property<int>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Numero");

                    b.ToTable("CPF");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Album", b =>
                {
                    b.HasOne("BrunaPhotographSystem.DomainModel.Entities.Cliente", "Cliente")
                        .WithMany("Albuns")
                        .HasForeignKey("clienteId");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Cliente", b =>
                {
                    b.HasOne("BrunaPhotographSystem.DomainModel.ValueObjects.CPF", "CPF")
                        .WithMany()
                        .HasForeignKey("CPFNumero");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Foto", b =>
                {
                    b.HasOne("BrunaPhotographSystem.DomainModel.Entities.Album", "Album")
                        .WithMany("Fotos")
                        .HasForeignKey("AlbumId");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.FotoProduto", b =>
                {
                    b.HasOne("BrunaPhotographSystem.DomainModel.Entities.Foto", "Foto")
                        .WithMany()
                        .HasForeignKey("FotoId");

                    b.HasOne("BrunaPhotographSystem.DomainModel.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Pedido", b =>
                {
                    b.HasOne("BrunaPhotographSystem.DomainModel.Entities.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.PedidoFotoProduto", b =>
                {
                    b.HasOne("BrunaPhotographSystem.DomainModel.Entities.FotoProduto", "FotoProduto")
                        .WithMany()
                        .HasForeignKey("FotoProdutoId");

                    b.HasOne("BrunaPhotographSystem.DomainModel.Entities.Pedido", "Pedido")
                        .WithMany("PedidoFotoProdutos")
                        .HasForeignKey("PedidoId");
                });
#pragma warning restore 612, 618
        }
    }
}
