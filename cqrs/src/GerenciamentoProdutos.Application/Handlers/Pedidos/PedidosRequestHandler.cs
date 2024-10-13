using GerenciamentoProdutos.Application.Requests.Pedidos;
using GerenciamentoProdutos.Application.Services.Pedidos;
using GerenciamentoProdutos.Domain.Entities.Pedidos;
using MediatR;

namespace GerenciamentoProdutos.Application.Handlers.Pedidos;

public class PedidosRequestHandler : IRequestHandler<CriarPedidoRequest, Pedido?>,
                                     IRequestHandler<ConsultarPedidosRequest, IEnumerable<Pedido>>
{
    private readonly IPedidoService _service;

    public PedidosRequestHandler(IPedidoService service)
    {
        _service = service;
    }

    public async Task<Pedido?> Handle(CriarPedidoRequest request, CancellationToken cancellationToken)
    {
        return await _service.CriarPedido(request, cancellationToken);
    }

    public async Task<IEnumerable<Pedido>> Handle(ConsultarPedidosRequest request, CancellationToken cancellationToken)
    {
        return await _service.ConsultarPedidos(request, cancellationToken);
    }

    
}
