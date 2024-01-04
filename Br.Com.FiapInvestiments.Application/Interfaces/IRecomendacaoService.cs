using Br.Com.FiapInvestiments.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Br.Com.FiapInvestiments.Application.Interfaces
{
    public interface IRecomendacaoService
    {
        Task<IEnumerable<Recomendacao>> ObterTodasRecomendacoes(CancellationToken cancellationToken);

        Task<IEnumerable<Recomendacao>> ObterRecomendacoesConsultor(uint id, CancellationToken cancellationToken);

        Task<IEnumerable<Recomendacao>> ObterRecomendacoesPorPerfilInvestidor(uint id, CancellationToken cancellationToken);
    }
}
