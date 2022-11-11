using System.ComponentModel.DataAnnotations;

namespace ECommerceWebService.Models
{
	public class CarrinhoProduto
	{
		public int CarrinhoProdutoId { get; set; }
		public int CarrinhoId { get; set; }
		public int ProdutoId { get; set; }
	}
}