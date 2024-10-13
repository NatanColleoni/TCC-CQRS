namespace GerenciamentoProdutos.Application.Requests.Pedidos;

public class NovoPedidoRequest
{
    public int ProdutoId { get; set; }
    public int Quantidade { get; set; }
}
