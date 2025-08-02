using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ProdutoCosifConfiguration : IEntityTypeConfiguration<ProdutoCosif>
    {

        public void Configure(EntityTypeBuilder<ProdutoCosif> builder)
        {
            builder.ToTable("PRODUTO_COSIF");
            builder.HasKey(p => p.CodCosif);

            builder.Property(m => m.CodCosif)
           .HasColumnName("COD_COSIF");

            builder.Property(m => m.CodProduto)
             .HasColumnName("COD_PRODUTO");

            builder.Property(m => m.CodClassificacao)
             .HasColumnName("COD_CLASSIFICACAO");

            builder.Property(m => m.StaStatus)
             .HasColumnName("STA_STATUS");

            builder.HasOne(pc => pc.Produto)
                 .WithMany(p => p.ProdutosCosif)
                 .HasForeignKey(pc => pc.CodProduto)
                 .HasConstraintName("FK_PRODUTO_COSIF_PRODUTO_COD_PRODUTO");
        }

    }
}
