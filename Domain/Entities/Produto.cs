using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Produto
    {
        [Key]
        public required string CodProduto { get; set; }

        public string? DesProduto { get; set; }

        public string? StaStatus { get; set; }

        public ICollection<ProdutoCosif>? ProdutosCosif { get; set; }
    }
}
