using GerenciamentoProdutos.Application.Persistence;
using GerenciamentoProdutos.Application.Queries.Pedidos;
using GerenciamentoProdutos.Application.Specifications.Pedidos;
using GerenciamentoProdutos.Domain.Entities.Read.Pedidos;
using MediatR;

namespace GerenciamentoProdutos.Application.Handlers.Pedidos;

public class PedidoQueryHandler : IRequestHandler<ConsultarPedidosQuery, IEnumerable<PedidoRead>>
{

    private readonly IReadRepository<PedidoRead> _readRepository;

    public PedidoQueryHandler(IReadRepository<PedidoRead> readRepository)
    {
        _readRepository = readRepository;
    }

    public async Task<IEnumerable<PedidoRead>> Handle(ConsultarPedidosQuery request, CancellationToken cancellationToken)
    {
        return await _readRepository.ListAsync(new ConsultarPedidosSpec(), cancellationToken);
    }
}
