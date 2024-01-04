using Br.Com.FiapInvestiments.Domain.Entidades;

namespace Br.Com.FiapInvestiments.Application.Interfaces
{
    public interface IAporteService
    {
        Task<Aporte> EfetuarAporte(Aporte aporte);
    }
}
