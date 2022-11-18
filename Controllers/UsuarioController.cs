using System.Linq;
using ECommerceWebService.Data;
using ECommerceWebService.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceWebService.Controllers
{
	public class UsuarioController : Controller
	{
		private DataContext _ctx;
		public UsuarioController(DataContext ctx)
		{
			_ctx = ctx;
		}

		public IActionResult CadastrarUsuario([FromBody]Usuario usuario)
		{
			_ctx.Usuarios.Add(usuario);
			_ctx.SaveChanges();
			return Created("OK", usuario);
		}

		public IActionResult AlterarUsuario([FromBody]Usuario usuario)
		{
			_ctx.Usuarios.Update(usuario);
			_ctx.SaveChanges();
			return Ok(usuario);
		}

		public IActionResult DeletarUsuario([FromBody] Usuario usuario)
		{
			_ctx.Usuarios.Remove(usuario);
			_ctx.SaveChanges();
			return Ok();
		}

		public IActionResult ListarUsuarios() => Ok(_ctx.Usuarios.ToList());
		public IActionResult BuscarUsuarioPorId([FromRoute]int id) => Ok(_ctx.Usuarios.Find(id));
	}
}