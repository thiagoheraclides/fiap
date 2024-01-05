using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Br.Com.FiapInvestiments.Domain.Entidades
{
    public class Pedido
    {
        public ulong Id { get; set; }

        public DateTime CriadoEm { get; set; } = DateTime.UtcNow;

        public uint Quantidade { get; set; } = default;

        public decimal Valor { get; set; } = default;

        public bool OrdemDeCompra { get; set; } = true;

        public string Observacao { get; set; } = null!;

        public uint UsuarioId { get; set; }

        public virtual Usuario? Usuario { get; set; }

        public uint AtivoId { get; set; }

        public virtual Ativo? Ativo { get; set; }

        public void AdicionarUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }

        public void AdicionarAtivo(Ativo ativo)
        {
            Ativo = ativo;
        }
    }
}
