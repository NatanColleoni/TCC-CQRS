using GerenciamentoProdutos.API.Controllers.Common;
using GerenciamentoProdutos.Application.Requests.Pedidos;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoProdutos.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PedidoController : BaseApiController
{
    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] CriarPedidoRequest request)
    {
        return GetResponse(await Mediator.Send(request));
    }

    [HttpGet]
    public async Task<IActionResult> Consultar([FromQuery] ConsultarPedidosRequest request)
    {
        return GetResponse(await Mediator.Send(request));
    }
}
