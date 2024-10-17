using GerenciamentoProdutos.Domain.Entities.Read.Produtos;
using MediatR;

namespace GerenciamentoProdutos.Application.Queries.Produtos;

public class ConsultarProdutosQuery : IRequest<IEnumerable<ProdutoRead>>
{
}
