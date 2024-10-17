using GerenciamentoProdutos.Domain.Common.Contracts;
using GerenciamentoProdutos.Domain.Entities.Write.Produtos;

namespace GerenciamentoProdutos.Domain.Entities.Write.ItensPedidos;

public class ItensPedido : BaseEntity, IAggregateRoot
{
    public int Quantidade { get; protected set; }
    public int ProdutoId { get; protected set; }
    public Produto? Produto { get; set; }

    public ItensPedido(int quantidade, int produtoId)
    {
        Quantidade = quantidade;
        ProdutoId = produtoId;
    }
}
