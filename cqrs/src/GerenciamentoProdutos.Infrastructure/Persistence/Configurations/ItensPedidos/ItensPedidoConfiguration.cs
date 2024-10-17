using GerenciamentoProdutos.Domain.Entities.Read.ItensPedidos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoProdutos.Infrastructure.Persistence.Configurations.ItensPedidos;

internal class ItensPedidoConfiguration : IEntityTypeConfiguration<ItensPedidoRead>
{
    public void Configure(EntityTypeBuilder<ItensPedidoRead> builder)
    {
        builder.ToTable("ItensPedido");
        builder.HasKey(i => i.Id);

        builder.HasOne(i => i.Pedido)
               .WithMany(p => p.ItensDoPedido)
               .HasForeignKey(i => i.PedidoId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(i => i.Produto)
               .WithMany()
               .HasForeignKey(i => i.ProdutoId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
