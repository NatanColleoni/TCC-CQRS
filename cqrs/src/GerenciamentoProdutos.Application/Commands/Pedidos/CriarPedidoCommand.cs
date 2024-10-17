using GerenciamentoProdutos.Domain.Entities.Write.Pedidos;
using MediatR;

namespace GerenciamentoProdutos.Application.Commands.Pedidos;

public class CriarPedidoCommand : IRequest<Pedido>
{
    public List<NovoPedidoCommand> ItensPedido { get; set; }
}
