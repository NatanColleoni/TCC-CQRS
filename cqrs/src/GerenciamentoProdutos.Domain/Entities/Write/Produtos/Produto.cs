using GerenciamentoProdutos.Domain.Common.Contracts;

namespace GerenciamentoProdutos.Domain.Entities.Write.Produtos;

public class Produto : BaseEntity, IAggregateRoot
{
    public string Nome { get; protected set; }
    public string Descricao { get; protected set; }
    public decimal ValorUnitario { get; protected set; }

    public Produto() { }

    public Produto(string nome, string descricao, decimal preco)
    {
        Nome = nome;
        Descricao = descricao;
        ValorUnitario = preco;
    }
}

