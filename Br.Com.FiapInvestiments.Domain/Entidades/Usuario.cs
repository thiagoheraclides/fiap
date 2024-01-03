using System.Text.Json.Serialization;

namespace Br.Com.FiapInvestiments.Domain.Entidades
{
    public partial class Usuario
    {
        public int? Id { get; set; }

        public string Cpf { get; set; } = null!;

        public string Nome { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Login { get; set; } = null!;

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string Senha { get; set; } = null!;

        public DateTime UltimoAcesso { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public int? PerfilId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public virtual Perfil? Perfil { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public int? TipoUsuarioId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public virtual TipoUsuario? TipoUsuario { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public virtual ICollection<Pedido>? Pedidos { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public virtual ICollection<Aporte>? Aportes { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public virtual ICollection<Recomendacao>? RecomendacoesUsuario { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public virtual ICollection<Recomendacao>? RecomendacoesConsultor { get; set; }
    }
}
