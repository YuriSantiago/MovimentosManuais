using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class MovimentoManualConfiguration : IEntityTypeConfiguration<MovimentoManual>
    {

        public void Configure(EntityTypeBuilder<MovimentoManual> builder)
        {
            builder.ToTable("MOVIMENTO_MANUAL");
            builder.HasKey(m => new
            {
                m.DatAno,
                m.DatMes,
                m.NumLancamento
            });

            builder.Property(m => m.DatMes)
             .HasColumnName("DAT_MES");

            builder.Property(m => m.DatAno)
             .HasColumnName("DAT_ANO");

            builder.Property(m => m.NumLancamento)
                .HasColumnName("NUM_LANCAMENTO");

            builder.Property(m => m.CodProduto)
                .HasColumnName("COD_PRODUTO");

            builder.Property(m => m.CodCosif)
                .HasColumnName("COD_COSIF");

            builder.Property(m => m.ValValor)
                .HasColumnName("VAL_VALOR");

            builder.Property(m => m.DesDescricao)
                .HasColumnName("DES_DESCRICAO");

            builder.Property(m => m.DatMovimento)
                .HasColumnName("DAT_MOVIMENTO");

            builder.Property(m => m.CodUsuario)
                .HasColumnName("COD_USUARIO");
        }

    }
}
