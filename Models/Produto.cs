using System.Collections.Generic;

namespace ECommerceWebService.Models
{
	public class Produto
	{
		public int ProdutoId { get; set; }
		public string Rotulo { get; set; }
		public string Marca { get; set; }
		public double Preco { get; set; }
        public int Quantidade { get; set; }
		
		public ICollection<Carrinho> Carrinhos { get; set; }
		public Historico Historico { get; set; }
	}
}