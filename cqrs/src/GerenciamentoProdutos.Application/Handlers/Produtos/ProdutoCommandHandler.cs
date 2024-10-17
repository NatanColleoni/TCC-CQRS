using GerenciamentoProdutos.Application.Commands.Produtos;
using GerenciamentoProdutos.Application.Services.Produtos;
using GerenciamentoProdutos.Domain.Entities.Write.Produtos;
using MediatR;

namespace GerenciamentoProdutos.Application.Handlers.Produtos;

public class ProdutoCommandHandler : IRequestHandler<CriarProdutoCommand, Produto?>
{
    private readonly IProdutoService _service;

    public ProdutoCommandHandler(IProdutoService service)
    {
        _service = service;
    }

    public async Task<Produto?> Handle(CriarProdutoCommand request, CancellationToken cancellationToken)
    {
        return await _service.CriarProduto(request, cancellationToken);
    }
}
