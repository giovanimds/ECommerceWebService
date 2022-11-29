using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceWebService.Models
{
	public class Carrinho
	{
		public int CarrinhoId { get; set; }
		public ICollection<Produto> Produtos { get; set; }
		
		
		public virtual int UsuarioId { get; set; }
		[ForeignKey("UsuarioId")]
		public virtual Usuario Usuario { get; set; }

	}
}