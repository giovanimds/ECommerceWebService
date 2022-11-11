﻿// <auto-generated />
using ECommerceWebService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerceWebService.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221111201225_CarrinhoBuilder")]
    partial class CarrinhoBuilder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("CarrinhoProduto", b =>
                {
                    b.Property<int>("CarrinhosCarrinhoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProdutosProdutoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CarrinhosCarrinhoId", "ProdutosProdutoId");

                    b.HasIndex("ProdutosProdutoId");

                    b.ToTable("CarrinhoProduto");
                });

            modelBuilder.Entity("ECommerceWebService.Models.Carrinho", b =>
                {
                    b.Property<int>("CarrinhoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CarrinhoId");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Carrinhos");
                });

            modelBuilder.Entity("ECommerceWebService.Models.Historico", b =>
                {
                    b.Property<int>("HistoricoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("HistoricoId");

                    b.HasIndex("ProdutoId")
                        .IsUnique();

                    b.HasIndex("UsuarioId");

                    b.ToTable("Historico");
                });

            modelBuilder.Entity("ECommerceWebService.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Marca")
                        .HasColumnType("TEXT");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rotulo")
                        .HasColumnType("TEXT");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ECommerceWebService.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Funcao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CarrinhoProduto", b =>
                {
                    b.HasOne("ECommerceWebService.Models.Carrinho", null)
                        .WithMany()
                        .HasForeignKey("CarrinhosCarrinhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerceWebService.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutosProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerceWebService.Models.Carrinho", b =>
                {
                    b.HasOne("ECommerceWebService.Models.Usuario", "Usuario")
                        .WithOne()
                        .HasForeignKey("ECommerceWebService.Models.Carrinho", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ECommerceWebService.Models.Historico", b =>
                {
                    b.HasOne("ECommerceWebService.Models.Produto", "Produto")
                        .WithOne("Historico")
                        .HasForeignKey("ECommerceWebService.Models.Historico", "ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerceWebService.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ECommerceWebService.Models.Produto", b =>
                {
                    b.HasOne("ECommerceWebService.Models.Historico", null)
                        .WithOne()
                        .HasForeignKey("ECommerceWebService.Models.Produto", "ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerceWebService.Models.Produto", b =>
                {
                    b.Navigation("Historico");
                });
#pragma warning restore 612, 618
        }
    }
}