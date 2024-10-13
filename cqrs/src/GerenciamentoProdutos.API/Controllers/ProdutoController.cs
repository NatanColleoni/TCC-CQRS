using GerenciamentoProdutos.API.Controllers.Common;
using GerenciamentoProdutos.Application.Requests.Produtos;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoProdutos.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProdutoController : BaseApiController
{

    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] CriarProdutoRequest  request)
    {
        return GetResponse(await Mediator.Send(request));
    }

    [HttpGet]
    public async Task<IActionResult> Consultar([FromQuery] ConsultarProdutosRequest request)
    {
        return GetResponse(await Mediator.Send(request));
    }
}
