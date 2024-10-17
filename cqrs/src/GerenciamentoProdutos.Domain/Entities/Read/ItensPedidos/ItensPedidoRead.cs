using GerenciamentoProdutos.Domain.Common.Contracts;
using GerenciamentoProdutos.Domain.Entities.Read.Pedidos;
using GerenciamentoProdutos.Domain.Entities.Read.Produtos;
using System.Text.Json.Serialization;

namespace GerenciamentoProdutos.Domain.Entities.Read.ItensPedidos;

public class ItensPedidoRead : BaseEntity
{
    public int Quantidade { get; protected set; }
    public int ProdutoId { get; protected set; }
    public ProdutoRead? Produto { get; set; }
    [JsonIgnore]
    public int PedidoId { get; protected set; }
    [JsonIgnore]
    public PedidoRead? Pedido { get; set; }
}
