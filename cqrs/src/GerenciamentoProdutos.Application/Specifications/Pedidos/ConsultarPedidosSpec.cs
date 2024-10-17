using Ardalis.Specification;
using GerenciamentoProdutos.Domain.Entities.Read.Pedidos;

namespace GerenciamentoProdutos.Application.Specifications.Pedidos;

public class ConsultarPedidosSpec : Specification<PedidoRead>
{
    public ConsultarPedidosSpec()
    {
        Query
            .AsNoTracking()
            .Include(p => p.ItensDoPedido)
            .ThenInclude(i => i.Produto);
    }
}
