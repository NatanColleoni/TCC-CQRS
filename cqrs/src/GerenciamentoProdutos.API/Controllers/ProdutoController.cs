using GerenciamentoProdutos.API.Controllers.Common;
using GerenciamentoProdutos.Application.Commands.Produtos;
using GerenciamentoProdutos.Application.Queries.Produtos;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoProdutos.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProdutoController : BaseApiController
{

    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] CriarProdutoCommand  request)
    {
        return GetResponse(await Mediator.Send(request));
    }

    [HttpGet]
    public async Task<IActionResult> Consultar([FromQuery] ConsultarProdutosQuery request)
    {
        return GetResponse(await Mediator.Send(request));
    }
}
