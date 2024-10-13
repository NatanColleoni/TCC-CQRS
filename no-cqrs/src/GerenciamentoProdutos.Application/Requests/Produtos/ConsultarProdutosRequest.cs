using GerenciamentoProdutos.Domain.Entities.Produtos;
using MediatR;

namespace GerenciamentoProdutos.Application.Requests.Produtos;

public class ConsultarProdutosRequest : IRequest<IEnumerable<Produto>>
{
}
