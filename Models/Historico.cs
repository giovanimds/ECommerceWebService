using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ECommerceWebService.Models
{
	public class Historico
	{
		[Key]
		public int HistoricoId { get; set; }
		public ICollection<Produto> Produtos { get; set; }
		public string Email { get; set; }
		
	}
}