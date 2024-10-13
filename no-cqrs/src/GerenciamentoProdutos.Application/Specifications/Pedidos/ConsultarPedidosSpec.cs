using Ardalis.Specification;
using GerenciamentoProdutos.Domain.Entities.Pedidos;

namespace GerenciamentoProdutos.Application.Specifications.Pedidos;

public class ConsultarPedidosSpec : Specification<Pedido>
{
    public ConsultarPedidosSpec()
    {
        Query
            .Include(p => p.ItensDoPedido)
            .ThenInclude(i => i.Produto);
    }
}
