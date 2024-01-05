using System.Text.Json.Serialization;

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

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public uint? PerfilId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public virtual Perfil? Perfil { get; set; }

        
        public uint? TipoUsuarioId { get; set; }
        
        public virtual TipoUsuario? TipoUsuario { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public virtual ICollection<Pedido>? Pedidos { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public virtual ICollection<Aporte>? Aportes { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public virtual ICollection<Recomendacao>? RecomendacoesUsuario { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public virtual ICollection<Recomendacao>? RecomendacoesConsultor { get; set; }

        public void Atualizar (Usuario novoUsuario)
        {
            try
            {
                Cpf = novoUsuario.Cpf;
                Nome = novoUsuario.Nome;
                Email = novoUsuario.Email;
                Perfil = novoUsuario.Perfil;
                TipoUsuario = novoUsuario.TipoUsuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AdicionarTipoUsuario(TipoUsuario tipoUsuario)
        {
            TipoUsuario = tipoUsuario;
        }

        public void AdicionarPerfil(Perfil perfil)
        {
            Perfil = perfil;
        }
    }
}
