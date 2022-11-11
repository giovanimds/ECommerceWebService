using ECommerceWebService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ECommerceWebService.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
	
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Usuario>().HasOne<Carrinho>().WithOne(carrinho => carrinho.Usuario);

			modelBuilder.Entity<Usuario>().HasMany<Historico>().WithOne(historico => historico.Usuario);

			modelBuilder.Entity<Historico>()
				.HasOne<Produto>()
				.WithOne()
				.HasForeignKey<Produto>();

			modelBuilder.Entity<Carrinho>()
				.HasMany(x => x.Produtos)
				.WithMany(x => x.Carrinhos);

		}

		public DbSet<Produto> Produtos { get; set; }
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Historico> Historico { get; set; }
		public DbSet<Carrinho> Carrinhos { get; set; }
	}
}