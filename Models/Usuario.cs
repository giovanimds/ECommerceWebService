using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceWebService.Models
{
	public class Usuario
	{
		[Key]
		public int UsuarioId { get; set; }
		
		public string Nome { get; set; }
		public string Cpf { get; set; }
		public string Email { get; set; }
		public string Funcao { get; set; }
		
	}
}