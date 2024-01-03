namespace Br.Com.FiapInvestiments.Api.DTO
{
    public partial class UsuarioDTO
    {
        public uint? Codigo { get; set; }

        public string CPF { get; set; } = null!;

        public string Nome { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Login { get; set; } = null!;

        public string Senha { get; set; } = null!;

        public uint TipoUsuarioCodigo { get; set; }

        public uint PerfilCodigo { get; set; }


    }
}
