namespace Br.Com.FiapInvestiments.Api.DTO
{
    public class AtivoDTO
    {

        public string Sigla { get; set; } = null!;

        public string Nome { get; set; } = null!;

        public uint RentabilidadeEmDias { get; set; } = default;

        public decimal ValorRentabilidade { get; set; } = default;

        public ushort EscalaDeRisco { get; set; } = default;

    }
}
