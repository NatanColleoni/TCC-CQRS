using GerenciamentoProdutos.Application.Commands.Produtos;
using GerenciamentoProdutos.Application.Common;
using GerenciamentoProdutos.Domain.Entities.Read.Produtos;
using GerenciamentoProdutos.Domain.Entities.Write.Produtos;

namespace GerenciamentoProdutos.Application.Services.Produtos;

public interface IProdutoService : IScopedService
{
    Task<Produto?> CriarProduto(CriarProdutoCommand produto, CancellationToken cancellationToken);
    Task<ProdutoRead?> ConsultarProdutoPorId(int id, CancellationToken cancellation);
}
