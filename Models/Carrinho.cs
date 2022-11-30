using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceWebService.Models
{
	public class Carrinho
	{
		
		public int CarrinhoId { get; set; }
		
		public string Email { get; set; }
		public ICollection<Produto> Produtos { get; set; }
		
		
	}
}