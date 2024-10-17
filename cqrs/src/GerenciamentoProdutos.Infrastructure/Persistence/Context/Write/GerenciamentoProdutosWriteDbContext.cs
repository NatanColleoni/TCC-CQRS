using GerenciamentoProdutos.Domain.Entities.Write.ItensPedidos;
using GerenciamentoProdutos.Domain.Entities.Write.Pedidos;
using GerenciamentoProdutos.Domain.Entities.Write.Produtos;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoProdutos.Infrastructure.Persistence.Context.Write;

public class GerenciamentoProdutosWriteDbContext(DbContextOptions<GerenciamentoProdutosWriteDbContext> options) : DbContext(options)
{
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<ItensPedido> ItensPedido { get; set; }
}
