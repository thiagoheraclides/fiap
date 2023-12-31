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

        public uint PerfilId { get; set; }

        public required Perfil Perfil { get; set; }

        public uint TipoUsuarioId { get; set; }

        public required TipoUsuario TipoUsuario { get; set; }

        public ICollection<Pedido>? Pedidos { get; set; }

        public ICollection<Aporte>? Aportes { get; set; }

        public ICollection<Recomendacao>? RecomendacoesUsuario { get; set; }

        public ICollection<Recomendacao>? RecomendacoesConsultor { get; set; }
    }
}
