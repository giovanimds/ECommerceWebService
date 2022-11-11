namespace ECommerceWebService.Models
{
	public class Produto
	{
		public int ProdutoId { get; set; }
		public string Rotulo { get; set; }
		public double Preco { get; set; }
		public string Marca { get; set; }
		
		
		public Historico Historico { get; set; }
		
	}
}