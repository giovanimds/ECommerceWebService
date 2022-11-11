using System.Collections.Generic;

namespace ECommerceWebService.Models
{
	public class Carrinho
	{
		public int CarrinhoId { get; set; }
		public ICollection<Produto> Produtos { get; set; }



		public int UsuarioId { get; set; }
		public Usuario Usuario { get; set; }

	}
}