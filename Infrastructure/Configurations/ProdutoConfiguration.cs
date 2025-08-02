using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {

        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("PRODUTO");
            builder.HasKey(p => p.CodProduto);

            builder.Property(m => m.CodProduto)
             .HasColumnName("COD_PRODUTO");

            builder.Property(m => m.DesProduto)
             .HasColumnName("DES_PRODUTO");

            builder.Property(m => m.StaStatus)
             .HasColumnName("STA_STATUS");
        }

    }
}
