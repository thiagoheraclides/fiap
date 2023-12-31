using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Br.Com.FiapInvestiments.Domain.Entidades
{
    public class Perfil
    {
        public uint Id { get; set; }

        public string Nome { get; set; } = null!;

        public string Descricao { get; set; } = null!;

        public bool Status { get; set; } = default;

        public DateTime CriadoEm { get; set; } = DateTime.UtcNow;

        public virtual ICollection<Usuario>? Usuarios { get; set; }
    }
}
