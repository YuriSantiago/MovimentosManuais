using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ProdutoCosif
    {
        [Key]
        public required string CodCosif { get; set; }

        public required string CodProduto { get; set; } 

        public string? CodClassificacao { get; set; }

        public string? StaStatus { get; set; }

        public required Produto Produto { get; set; }
    }
}
