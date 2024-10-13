using GerenciamentoProdutos.Application.Persistence;
using GerenciamentoProdutos.Application.Requests.Produtos;
using GerenciamentoProdutos.Application.Specifications.Produtos;
using GerenciamentoProdutos.Domain.Entities.Produtos;

namespace GerenciamentoProdutos.Application.Services.Produtos;

public class ProdutoService : IProdutoService
{
    private readonly IRepository<Produto> _repository;
    private readonly IReadRepository<Produto> _readRepository;

    public ProdutoService(IRepository<Produto> repository, IReadRepository<Produto> readRepository)
    {
        _repository = repository;
        _readRepository = readRepository;
    }

    public async Task<Produto?> CriarProduto(CriarProdutoRequest produto, CancellationToken cancellationToken)
    {
        var novoProduto = new Produto(produto.Nome, produto.Descricao, produto.Valor);
        
        var produtoSalvo = await _repository.AddAsync(novoProduto, cancellationToken);

        return produtoSalvo;
    }

    public async Task<IEnumerable<Produto>> ConsultarProdutos(ConsultarProdutosRequest request, CancellationToken cancellationToken)
    {
        return await _readRepository.ListAsync(cancellationToken);
    }

    public async Task<Produto?> ConsultarProdutoPorId(int id, CancellationToken cancellationToken)
    {
        return await _readRepository.FirstOrDefaultAsync(new ConsultarProdutosPorIdSpec(id), cancellationToken);
    }
}
