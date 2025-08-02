using System.ComponentModel.DataAnnotations;

namespace Contracts.Requests
{
    public class MovimentoManualRequest
    {

        [Range(1, 12)]
        public required int DatMes { get; set; }

        public required int DatAno { get; set; }

        public required string CodProduto { get; set; }

        public required string CodCosif { get; set; }

        [StringLength(50)]
        public required string DesDescricao { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal ValValor { get; set; }

        public required string CodUsuario { get; set; } = "admin";

    }
}
