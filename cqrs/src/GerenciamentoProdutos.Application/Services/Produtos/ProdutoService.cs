using GerenciamentoProdutos.Application.Commands.Produtos;
using GerenciamentoProdutos.Application.Persistence;
using GerenciamentoProdutos.Application.Specifications.Produtos;
using GerenciamentoProdutos.Domain.Entities.Read.Produtos;
using GerenciamentoProdutos.Domain.Entities.Write.Produtos;

namespace GerenciamentoProdutos.Application.Services.Produtos;

public class ProdutoService : IProdutoService
{
    private readonly IRepository<Produto> _repository;
    private readonly IReadRepository<ProdutoRead> _readRepository;

    public ProdutoService(IRepository<Produto> repository, IReadRepository<ProdutoRead> readRepository)
    {
        _repository = repository;
        _readRepository = readRepository;
    }

    public async Task<Produto?> CriarProduto(CriarProdutoCommand produto, CancellationToken cancellationToken)
    {
        var novoProduto = new Produto(produto.Nome, produto.Descricao, produto.Valor);
        
        var produtoSalvo = await _repository.AddAsync(novoProduto, cancellationToken);

        return produtoSalvo;
    }

    public async Task<ProdutoRead?> ConsultarProdutoPorId(int id, CancellationToken cancellationToken)
    {
        return await _readRepository.FirstOrDefaultAsync(new ConsultarProdutosPorIdSpec(id), cancellationToken);
    }
}
