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
    [Migration("20190824231030_inicial9")]
    partial class inicial9
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

                    b.Property<bool>("Administrador");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Password");

                    b.HasKey("Id");

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

            modelBuilder.Entity("BrunaPhotographSystem.DomainModel.Entities.Album", b =>
                {
                    b.HasOne("BrunaPhotographSystem.DomainModel.Entities.Cliente", "Cliente")
                        .WithMany("Albuns")
                        .HasForeignKey("clienteId");
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
