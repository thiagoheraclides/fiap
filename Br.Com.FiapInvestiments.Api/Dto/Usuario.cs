namespace Br.Com.FiapInvestiments.Api.Dto
{
    public partial class Usuario
    {
        public int? Codigo { get; set; }
        public string? CPF { get; set; }
        public string? Login { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public DateTime? DataUltimoAcesso { get; set; }
        public TipoUsuario? TipoUsuario { get; set; }
        public PerfilInvestidor? PerfilInvestidor { get; set; }

    }
}
