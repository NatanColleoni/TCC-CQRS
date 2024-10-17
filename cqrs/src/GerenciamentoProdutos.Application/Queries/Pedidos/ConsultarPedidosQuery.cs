using GerenciamentoProdutos.Domain.Entities.Read.Pedidos;
using MediatR;

namespace GerenciamentoProdutos.Application.Queries.Pedidos;

public class ConsultarPedidosQuery : IRequest<IEnumerable<PedidoRead>>
{
}
