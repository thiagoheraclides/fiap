namespace Br.Com.FiapInvestiments.Api.Dto
{
    public partial class PerfilInvestidor
    {
        public int? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataRegistro { get; set; }
        public bool? Ativo { get; set; }

    }
}
