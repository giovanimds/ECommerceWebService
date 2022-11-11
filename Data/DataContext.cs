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

			


		}

		public DbSet<Produto> Produtos { get; set; }
		public DbSet<Historico> Historico { get; set; }
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Carrinho> Carrinhos { get; set; }
	}
}