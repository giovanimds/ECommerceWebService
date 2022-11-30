using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceWebService.Models
{
	public class CarrinhoProduto
	{
		[Key]
		public int CarrinhoProdutoId { get; set; }
		[ForeignKey("CarrinhoId")]
		public int CarrinhoId { get; set; }
		[ForeignKey("ProdutoId")]
		public int ProdutoId { get; set; }
	}
}