using GerenciamentoProdutos.Application.Requests.Produtos;
using GerenciamentoProdutos.Application.Services.Produtos;
using GerenciamentoProdutos.Domain.Entities.Produtos;
using MediatR;

namespace GerenciamentoProdutos.Application.Handlers.Produtos;

public class ProdutoRequestHandler : IRequestHandler<CriarProdutoRequest, Produto?>,
                                     IRequestHandler<ConsultarProdutosRequest, IEnumerable<Produto>>
{
    private readonly IProdutoService _service;

    public ProdutoRequestHandler(IProdutoService service)
    {
        _service = service;
    }

    public async Task<Produto?> Handle(CriarProdutoRequest request, CancellationToken cancellationToken)
    {
        return await _service.CriarProduto(request, cancellationToken);
    }

    public async Task<IEnumerable<Produto>> Handle(ConsultarProdutosRequest request, CancellationToken cancellationToken)
    {
        return await _service.ConsultarProdutos(request, cancellationToken);
    }
}
