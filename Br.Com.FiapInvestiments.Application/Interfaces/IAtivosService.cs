using Br.Com.FiapInvestiments.Domain.Entidades;

namespace Br.Com.FiapInvestiments.Application.Interfaces
{
    public interface IAtivosService
    {
        Task<uint> Atualizar(Ativo ativo, CancellationToken cancellationToken);

        Task<uint> Cadastrar(Ativo ativo, CancellationToken cancellationToken);

        Task Desativar(uint id, CancellationToken cancellationToken);

        Task<IEnumerable<Ativo>> Obter(CancellationToken cancellationToken);

        Task<IEnumerable<Ativo>> ObterDisponiveis(CancellationToken cancellationToken);

        Task<Ativo> ObterPorId(uint id, CancellationToken cancellationToken);

        Task Remover(uint id, CancellationToken cancellationToken);
    }
}
