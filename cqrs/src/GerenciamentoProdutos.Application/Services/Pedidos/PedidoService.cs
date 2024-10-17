using GerenciamentoProdutos.Application.Commands.Pedidos;
using GerenciamentoProdutos.Application.Persistence;
using GerenciamentoProdutos.Application.Services.Produtos;
using GerenciamentoProdutos.Domain.Entities.Write.ItensPedidos;
using GerenciamentoProdutos.Domain.Entities.Write.Pedidos;

namespace GerenciamentoProdutos.Application.Services.Pedidos;

public class PedidoService : IPedidoService
{
    private readonly IRepository<Pedido> _repository;
    private readonly IProdutoService _produtoService;

    public PedidoService(IRepository<Pedido> repository, IProdutoService produtoService)
    {
        _repository = repository;
        _produtoService = produtoService;
    }

    public async Task<Pedido?> CriarPedido(CriarPedidoCommand pedido, CancellationToken cancellationToken)
    {
        var itensPedido = new List<ItensPedido>();
        decimal total = 0m;


        foreach (var item in pedido.ItensPedido)
        {
            var produto = await _produtoService.ConsultarProdutoPorId(item.ProdutoId, cancellationToken);
            if (produto == null)
            {
                continue;
            }

            var itemPedido = new ItensPedido(item.Quantidade, produto.Id);
            itensPedido.Add(itemPedido);
            total += produto.ValorUnitario * item.Quantidade;
        }

        var novoPedido = new Pedido(total, itensPedido);

        await _repository.AddAsync(novoPedido, cancellationToken);
        return novoPedido;
    }
}
