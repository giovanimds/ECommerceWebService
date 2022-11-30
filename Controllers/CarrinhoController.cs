using System.Linq;
using ECommerceWebService.Data;
using ECommerceWebService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceWebService.Controllers
{
    [ApiController]
    [Route("api/carrinho")]
    public class CarrinhoController : Controller
    {
        private DataContext _ctx;
        public CarrinhoController(DataContext ctx)
        {
            _ctx = ctx;
        }
        
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult CadastrarCarrinho([FromBody]Carrinho carrinho)
        {
            if (_ctx.Carrinhos.Where(x => x.Email.Equals(carrinho.Email)).ToList().Count > 0)
            {
                return Conflict();
            }
            _ctx.Carrinhos.Add(carrinho);
            _ctx.SaveChanges();
            return Created("", carrinho);
        }
        
        [HttpPost]
        [Route("adicionar/{produtoId:int}/{email}")]
        public IActionResult AdicionarAoCarrinho([FromRoute]int produtoId, string email)
        {
            Produto produto = _ctx.Produtos.Find(produtoId);
            Carrinho carrinho = _ctx.Carrinhos.Include(x => x.Produtos).Where(x => x.Email.Equals(email)).First(x => x.Email.Equals(email));
            carrinho.Produtos.Add(produto);
            _ctx.SaveChanges();
            return Ok(carrinho);
        }

    }
}