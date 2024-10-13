using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoProdutos.API.Controllers.Common;

[ApiController]
[Route("api/[controller]")]
public class BaseApiController : ControllerBase
{
    private ISender _mediator = null!;
    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();

    public IActionResult GetResponse<T>(T response)
    {
        if (response is null)
        {
            return BadRequest();
        }
        else
        {
            return Ok(response);
        }
    }
}
