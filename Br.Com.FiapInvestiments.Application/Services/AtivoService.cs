using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Domain.Entidades;
using Br.Com.FiapInvestiments.Infrastructure.Data;

namespace Br.Com.FiapInvestiments.Application.Services
{
    public class AtivoService(ApiContext apiContext) : IAtivosService
    {
        private readonly ApiContext _apiContext = apiContext;

        public Task Atualizar(Ativo ativo, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Inativar(uint uid, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(Ativo ativo, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ativo>> Obter(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Ativo> ObterPorId(uint uid, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Remover(uint uid, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
