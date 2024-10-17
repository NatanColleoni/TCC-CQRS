using GerenciamentoProdutos.API.Controllers.Common;
using GerenciamentoProdutos.Application.Commands.Pedidos;
using GerenciamentoProdutos.Application.Queries.Pedidos;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoProdutos.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PedidoController : BaseApiController
{
    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] CriarPedidoCommand request)
    {
        return GetResponse(await Mediator.Send(request));
    }

    [HttpGet]
    public async Task<IActionResult> Consultar([FromQuery] ConsultarPedidosQuery request)
    {
        return GetResponse(await Mediator.Send(request));
    }
}
