using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class MovimentoManual
    {
        [Key]
        public required int DatMes { get; set; }

        [Key]
        public required int DatAno { get; set; }

        [Key]
        public required int NumLancamento { get; set; }

        public required string CodProduto { get; set; } 

        public required string CodCosif { get; set; } 

        public required decimal ValValor { get; set; }

        public required string DesDescricao { get; set; } 

        public required DateTime DatMovimento { get; set; }

        public required string CodUsuario { get; set; } 

    }
}
