namespace Br.Com.FiapInvestiments.Domain.Entidades
{
    public class Usuario
    {
        public uint Id { get; set; }

        public string Cpf { get; set; } = null!;

        public string Nome { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Login { get; set; } = null!;

        public string Senha { get; set; } = null!;

        public DateTime UltimoAcesso { get; set; }

        public uint? PerfilId { get; set; }

        public virtual Perfil? Perfil { get; set; }

        public uint? TipoUsuarioId { get; set; }

        public virtual TipoUsuario? TipoUsuario { get; set; }

        public virtual ICollection<Pedido>? Pedidos { get; set; }

        public virtual ICollection<Aporte>? Aportes { get; set; }

        public virtual ICollection<Recomendacao>? RecomendacoesUsuario { get; set; }

        public virtual ICollection<Recomendacao>? RecomendacoesConsultor { get; set; }
    }
}
