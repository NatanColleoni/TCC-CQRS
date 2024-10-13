using Ardalis.Specification;
using GerenciamentoProdutos.Domain.Entities.Produtos;

namespace GerenciamentoProdutos.Application.Specifications.Produtos;

public class ConsultarProdutosPorIdSpec : Specification<Produto>
{
    public ConsultarProdutosPorIdSpec(int id)
    {
        Query.Where(p => p.Id == id);
    }
}
