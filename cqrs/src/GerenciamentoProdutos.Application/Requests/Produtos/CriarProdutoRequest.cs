using GerenciamentoProdutos.Domain.Entities.Produtos;
using MediatR;

namespace GerenciamentoProdutos.Application.Requests.Produtos;

public class CriarProdutoRequest : IRequest<Produto?>
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
}
