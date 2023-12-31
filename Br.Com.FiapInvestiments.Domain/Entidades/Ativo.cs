using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Br.Com.FiapInvestiments.Domain.Entidades
{
    public class Ativo
    {
        public uint Id { get; set; }

        public string Sigla { get; set; } = null!;

        public string Nome { get; set; } = null!;
        
        public DateTime CriadoEm { get; set; } = DateTime.UtcNow;

        public DateTime? EncerraEm { get; set; }

        public uint RentabilidadeEmDias { get; set; } = default;

        public decimal ValorRentabilidade { get; set; } = default;

        public ushort EscalaDeRisco { get; set; } = default;

        public virtual ICollection<Pedido>? Pedidos { get; set; }

        public virtual ICollection<Recomendacao>? Recomendacoes { get; set; }

    }
}
