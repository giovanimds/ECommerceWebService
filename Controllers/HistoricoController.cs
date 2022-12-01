using System.Collections.Generic;
using System.Linq;
using ECommerceWebService.Data;
using ECommerceWebService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceWebService.Controllers
{
    [ApiController]
    [Route("api/historico")]
    public class HistoricoController : Controller
    {
        private readonly DataContext _ctx;

        public HistoricoController(DataContext ctx)
        {
            _ctx = ctx;
        }
        
        [HttpPost]
        [Route("adicionar")]
        public IActionResult CadastrarHistorico([FromBody] Historico historico)
        {
            ICollection<Produto> produtos = new List<Produto>();
            foreach (var produto in historico.Produtos)
            {
                produtos.Add(_ctx.Produtos.Find(produto.ProdutoId));
            }

            historico.Produtos = produtos;
            _ctx.Historico.Add(historico);
            _ctx.SaveChanges();
            return Created("", historico);
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult listarHistorico([FromRoute] string email) => Ok(_ctx.Historico
            .Include(x => x.Produtos)
            .Where(x => x.Email.Equals(email)));

    }
}