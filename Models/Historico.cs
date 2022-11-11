using System.Collections.Generic;

namespace ECommerceWebService.Models
{
	public class Historico
	{
		public int HistoricoId { get; set; }
		public int UsuarioId { get; set; }
		public int ProdutoId { get; set; }
		
		
		//Navigation Properties
		public Produto Produto { get; set; }
		public Usuario Usuario { get; set; }
		
		
	}
}