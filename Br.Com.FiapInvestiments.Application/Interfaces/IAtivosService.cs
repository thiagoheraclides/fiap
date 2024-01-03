using Br.Com.FiapInvestiments.Domain.Entidades;

namespace Br.Com.FiapInvestiments.Application.Interfaces
{
    public interface IAtivosService
    {
        Task Inserir(Ativo ativo, CancellationToken cancellationToken);

        Task Atualizar(Ativo ativo, CancellationToken cancellationToken);

        Task Inativar(uint uid, CancellationToken cancellationToken);

        Task<IEnumerable<Ativo>> Obter(CancellationToken cancellationToken);

        Task<Ativo> ObterPorId(uint uid, CancellationToken cancellationToken);

        Task Remover(uint uid, CancellationToken cancellationToken);
    }
}
