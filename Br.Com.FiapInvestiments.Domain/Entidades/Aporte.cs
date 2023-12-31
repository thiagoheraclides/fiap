using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Br.Com.FiapInvestiments.Domain.Entidades
{
    public class Aporte
    {
        public ulong Id { get; set; }

        public decimal Valor { get; set; } = default;

        public DateTime CriadoEm { get; set; } = DateTime.UtcNow;

        public string Observacao { get; set; } = null!;

        public uint? UsuarioId { get; set; }

        public virtual Usuario? Usuario { get; set; }
    }
}
