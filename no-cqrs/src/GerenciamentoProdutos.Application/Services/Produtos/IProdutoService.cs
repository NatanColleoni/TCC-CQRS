using GerenciamentoProdutos.Application.Common;
using GerenciamentoProdutos.Application.Requests.Produtos;
using GerenciamentoProdutos.Domain.Entities.Produtos;

namespace GerenciamentoProdutos.Application.Services.Produtos;

public interface IProdutoService : IScopedService
{
    Task<Produto?> CriarProduto(CriarProdutoRequest produto, CancellationToken cancellationToken);
    Task<IEnumerable<Produto>> ConsultarProdutos(ConsultarProdutosRequest request, CancellationToken cancellationToken);
    Task<Produto?> ConsultarProdutoPorId(int id, CancellationToken cancellation);
}
