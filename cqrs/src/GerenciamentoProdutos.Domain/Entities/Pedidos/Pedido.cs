using GerenciamentoProdutos.Domain.Common.Contracts;
using GerenciamentoProdutos.Domain.Entities.ItensPedidos;

namespace GerenciamentoProdutos.Domain.Entities.Pedidos;

public class Pedido : BaseEntity, IAggregateRoot
{
    public decimal ValorTotal { get; protected set; }
    public List<ItensPedido> ItensDoPedido { get; protected set; } = [];

    public Pedido()
    {

    }

    public Pedido(decimal valorTotal, List<ItensPedido> itensPedido)
    {
        ValorTotal = valorTotal;
        ItensDoPedido = itensPedido;
    }
}