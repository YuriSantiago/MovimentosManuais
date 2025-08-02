using Contracts.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class MovimentoManualDTOConfiguration : IEntityTypeConfiguration<MovimentoManualDTO>
    {

        public void Configure(EntityTypeBuilder<MovimentoManualDTO> builder)
        {
            builder.HasNoKey(); 

            builder.Property(p => p.DatMes).HasColumnName("DAT_MES");
            builder.Property(p => p.DatAno).HasColumnName("DAT_ANO");
            builder.Property(p => p.CodProduto).HasColumnName("COD_PRODUTO");
            builder.Property(p => p.DesProduto).HasColumnName("DES_PRODUTO");
            builder.Property(p => p.NumLancamento).HasColumnName("NUM_LANCAMENTO");
            builder.Property(p => p.DesDescricao).HasColumnName("DES_DESCRICAO");
            builder.Property(p => p.ValValor).HasColumnName("VAL_VALOR");
        }

    }
}
