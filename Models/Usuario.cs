using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceWebService.Models
{
	public class Usuario
	{
		public int UsuarioId { get; set; }
		public string Nome { get; set; }
		public string Cpf { get; set; }
		public string Senha { get; set; }
		public string Email { get; set; }
		public string Funcao { get; set; }
		
		
		public virtual int CarrinhoId { get; set; }
		[ForeignKey("CarrinhoId")]
		public virtual Carrinho Carrinho { get; set; }
		
	}
}