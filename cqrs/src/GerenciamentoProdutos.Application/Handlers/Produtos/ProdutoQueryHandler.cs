using GerenciamentoProdutos.Application.Persistence;
using GerenciamentoProdutos.Application.Queries.Produtos;
using GerenciamentoProdutos.Domain.Entities.Read.Produtos;
using MediatR;

namespace GerenciamentoProdutos.Application.Handlers.Produtos;

public class ProdutoQueryHandler : IRequestHandler<ConsultarProdutosQuery, IEnumerable<ProdutoRead>>
{
    private readonly IReadRepository<ProdutoRead> _readRepository;

    public ProdutoQueryHandler(IReadRepository<ProdutoRead> readRepository)
    {
        _readRepository = readRepository;
    }

    public async Task<IEnumerable<ProdutoRead>> Handle(ConsultarProdutosQuery request, CancellationToken cancellationToken)
    {
        return await _readRepository.ListAsync(cancellationToken);
    }
}
