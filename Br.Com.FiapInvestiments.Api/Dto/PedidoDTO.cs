using Br.Com.FiapInvestiments.Domain.Entidades;

namespace Br.Com.FiapInvestiments.Api.DTO
{
    public partial class PedidoDTO
    {
        public uint? Codigo { get; set; }

        public uint Quantidade { get; set; } = default;

        public decimal Valor { get; set; } = default;

        public string Observacao { get; set; } = null!;

        public uint? UsuarioInvestidorId { get; set; }

        public uint? AtivoInvestimentoId { get; set; }


    }
}
