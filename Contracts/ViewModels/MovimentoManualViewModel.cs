namespace Contracts.ViewModels
{
    public class MovimentoManualViewModel
    {
        public required int DatMes { get; set; }

        public required int DatAno { get; set; }

        public required string CodProduto { get; set; }

        public required string DesProduto { get; set; }

        public required int NumLancamento { get; set; }

        public required string DesDescricao { get; set; }

        public required decimal ValValor { get; set; }

    }
}
