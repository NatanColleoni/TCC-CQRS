using GerenciamentoProdutos.Domain.Common.Contracts;
using GerenciamentoProdutos.Domain.Entities.Read.ItensPedidos;

namespace GerenciamentoProdutos.Domain.Entities.Read.Pedidos;

public class PedidoRead : BaseEntity
{
    public decimal ValorTotal { get; protected set; }
    public List<ItensPedidoRead> ItensDoPedido { get; protected set; } = [];
}
