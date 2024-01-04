namespace Br.Com.FiapInvestiments.Api.DTO
{
    public class PedidoDTO
    {
        public uint Codigo { get; set; } = default;

        public uint Quantidade { get; set; } = default;

        public decimal Valor { get; set; } = default;

        public string Observacao { get; set; } = null!;

        public uint? UsuarioInvestidorId { get; set; }

        public uint? AtivoInvestimentoId { get; set; }

    }
}
