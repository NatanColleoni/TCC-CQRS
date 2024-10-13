using GerenciamentoProdutos.Domain.Entities.Pedidos;
using MediatR;

namespace GerenciamentoProdutos.Application.Requests.Pedidos;

public class ConsultarPedidosRequest : IRequest<IEnumerable<Pedido>>
{
}
