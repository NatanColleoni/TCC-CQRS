using GerenciamentoProdutos.Application.Common;
using GerenciamentoProdutos.Application.Requests.Pedidos;
using GerenciamentoProdutos.Domain.Entities.Pedidos;

namespace GerenciamentoProdutos.Application.Services.Pedidos;

public interface IPedidoService : IScopedService
{

    Task<Pedido?> CriarPedido(CriarPedidoRequest produto, CancellationToken cancellationToken);
    Task<IEnumerable<Pedido>> ConsultarPedidos(ConsultarPedidosRequest request, CancellationToken cancellationToken);
}
