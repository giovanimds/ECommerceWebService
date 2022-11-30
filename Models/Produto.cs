using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ECommerceWebService.Models
{
	public class Produto
	{
		[Key]
		public int ProdutoId { get; set; }
		public string Rotulo { get; set; }
		public string Marca { get; set; }
		public double Preco { get; set; }
        public int Quantidade { get; set; }
        
        [JsonIgnore]
		public ICollection<Carrinho> Carrinhos { get; set; }
		[JsonIgnore]
		public Historico Historico { get; set; }
	}
}