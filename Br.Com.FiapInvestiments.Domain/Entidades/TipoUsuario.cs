using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Br.Com.FiapInvestiments.Domain.Entidades
{
    public class TipoUsuario
    {
        public uint Id { get; set; }

        public string Nome { get; set; } = null!;

        public string Descricao { get; set; } = null!;

        public bool Status { get; set; }

        public DateTime CriadoEm { get; set; } = DateTime.UtcNow;

        public ICollection<Usuario>? Usuarios { get; set; }
    }
}
