using Br.Com.FiapInvestiments.Domain.Entidades;

namespace Br.Com.FiapInvestiments.Application.Interfaces
{
    public interface IPerfilService
    {
        Task<IEnumerable<Perfil>> Obter(CancellationToken cancellationToken);

        Task<Perfil> ObterPorId(uint id, CancellationToken cancellationToken);
    }
}
