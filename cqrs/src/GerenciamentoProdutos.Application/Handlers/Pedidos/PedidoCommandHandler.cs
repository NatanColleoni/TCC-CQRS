using GerenciamentoProdutos.Application.Commands.Pedidos;
using GerenciamentoProdutos.Application.Services.Pedidos;
using GerenciamentoProdutos.Domain.Entities.Write.Pedidos;
using MediatR;

namespace GerenciamentoProdutos.Application.Handlers.Pedidos;

public class PedidoCommandHandler : IRequestHandler<CriarPedidoCommand, Pedido?>                                    
{
    private readonly IPedidoService _service;

    public PedidoCommandHandler(IPedidoService service)
    {
        _service = service;
    }

    public async Task<Pedido?> Handle(CriarPedidoCommand request, CancellationToken cancellationToken)
    {
        return await _service.CriarPedido(request, cancellationToken);
    }
}
