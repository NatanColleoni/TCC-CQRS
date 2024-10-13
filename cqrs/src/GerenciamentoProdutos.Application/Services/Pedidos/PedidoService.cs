using GerenciamentoProdutos.Application.Persistence;
using GerenciamentoProdutos.Application.Requests.Pedidos;
using GerenciamentoProdutos.Application.Services.Produtos;
using GerenciamentoProdutos.Application.Specifications.Pedidos;
using GerenciamentoProdutos.Domain.Entities.ItensPedidos;
using GerenciamentoProdutos.Domain.Entities.Pedidos;

namespace GerenciamentoProdutos.Application.Services.Pedidos;

public class PedidoService : IPedidoService
{
    private readonly IRepository<Pedido> _repository;
    private readonly IReadRepository<Pedido> _readRepository;
    private readonly IProdutoService _produtoService;

    public PedidoService(IRepository<Pedido> repository, IReadRepository<Pedido> readRepository, IProdutoService produtoService)
    {
        _repository = repository;
        _readRepository = readRepository;
        _produtoService = produtoService;
    }

    public async Task<Pedido?> CriarPedido(CriarPedidoRequest pedido, CancellationToken cancellationToken)
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

    public async Task<IEnumerable<Pedido>> ConsultarPedidos(ConsultarPedidosRequest request, CancellationToken cancellationToken)
    {
        return await _readRepository.ListAsync(new ConsultarPedidosSpec(), cancellationToken);
    }
}
