using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceWebService.Models
{
	public class Historico
	{
		[Key]
		public int HistoricoId { get; set; }
		public string Email { get; set; }
		
		
		
		//Navigation Properties
		[ForeignKey("ProdutoId")]
		public Produto Produto { get; set; }
		public int ProdutoId { get; set; }
		
		
	}
}