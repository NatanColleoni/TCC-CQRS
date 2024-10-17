using Ardalis.Specification;
using GerenciamentoProdutos.Domain.Entities.Read.Produtos;

namespace GerenciamentoProdutos.Application.Specifications.Produtos;

public class ConsultarProdutosPorIdSpec : Specification<ProdutoRead>
{
    public ConsultarProdutosPorIdSpec(int id)
    {
        Query.Where(p => p.Id == id);
    }
}
