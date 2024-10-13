using GerenciamentoProdutos.Domain.Entities.Pedidos;
using MediatR;

namespace GerenciamentoProdutos.Application.Requests.Pedidos;

public class CriarPedidoRequest : IRequest<Pedido>
{
    public List<NovoPedidoRequest> ItensPedido { get; set; }
}
