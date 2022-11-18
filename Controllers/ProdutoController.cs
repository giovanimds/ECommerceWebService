using System.Linq;
using ECommerceWebService.Data;
using ECommerceWebService.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceWebService.Controllers
{
	public class ProdutoController : Controller
	{
		private readonly DataContext _ctx;

		public ProdutoController(DataContext ctx)
		{
			_ctx = ctx;
		}

		public IActionResult CadastrarProduto([FromBody] Produto produto)
		{
			_ctx.Produtos.Add(produto);
			_ctx.SaveChanges();
			return Created("", produto);
		}

		public IActionResult AlterarProduto([FromBody] Produto produto)
		{
			_ctx.Produtos.Update(produto);
			_ctx.SaveChanges();
			return Ok(produto);
		}

		public IActionResult DeletarProduto([FromBody] Produto produto)
		{
			_ctx.Produtos.Remove(produto);
			_ctx.SaveChanges();
			return Ok(produto);
		}

		public IActionResult ListarProdutos() => Ok(_ctx.Produtos.ToList());
		public IActionResult BuscarProdutoPorId([FromBody] int id) => Ok(_ctx.Produtos.Find(id));
	}
}