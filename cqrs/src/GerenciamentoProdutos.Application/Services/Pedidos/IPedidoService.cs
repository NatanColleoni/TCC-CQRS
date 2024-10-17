using GerenciamentoProdutos.Application.Commands.Pedidos;
using GerenciamentoProdutos.Application.Common;
using GerenciamentoProdutos.Domain.Entities.Write.Pedidos;

namespace GerenciamentoProdutos.Application.Services.Pedidos;

public interface IPedidoService : IScopedService
{

    Task<Pedido?> CriarPedido(CriarPedidoCommand produto, CancellationToken cancellationToken);
}
