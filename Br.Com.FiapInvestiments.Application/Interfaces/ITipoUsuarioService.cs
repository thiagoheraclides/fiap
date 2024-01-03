using Br.Com.FiapInvestiments.Domain.Entidades;

namespace Br.Com.FiapInvestiments.Application.Interfaces
{
    public interface ITipoUsuarioService
    {
        Task<IEnumerable<TipoUsuario>> Obter(CancellationToken cancellationToken);

        Task<TipoUsuario> ObterPorId(uint id, CancellationToken cancellationToken);
    }
}
