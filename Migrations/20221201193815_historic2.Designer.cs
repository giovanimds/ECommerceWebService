﻿// <auto-generated />
using ECommerceWebService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerceWebService.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221201193815_historic2")]
    partial class historic2
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

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CarrinhoId");

                    b.HasAlternateKey("Email");

                    b.ToTable("Carrinhos");
                });

            modelBuilder.Entity("ECommerceWebService.Models.Historico", b =>
                {
                    b.Property<int>("HistoricoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.HasKey("HistoricoId");

                    b.ToTable("Historico");
                });

            modelBuilder.Entity("ECommerceWebService.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
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

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("HistoricoProduto", b =>
                {
                    b.Property<int>("HistoricosHistoricoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProdutosProdutoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("HistoricosHistoricoId", "ProdutosProdutoId");

                    b.HasIndex("ProdutosProdutoId");

                    b.ToTable("HistoricoProduto");
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

            modelBuilder.Entity("HistoricoProduto", b =>
                {
                    b.HasOne("ECommerceWebService.Models.Historico", null)
                        .WithMany()
                        .HasForeignKey("HistoricosHistoricoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerceWebService.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutosProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
