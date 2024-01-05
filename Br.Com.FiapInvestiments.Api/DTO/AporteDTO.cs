namespace Br.Com.FiapInvestiments.Api.DTO
{
    public class AporteDTO
    {
        public uint SolicitanteId { get; set; }

        public decimal Valor { get; set; } = default;

        public string Observacao { get; set; } = null!;
        
    }
}
