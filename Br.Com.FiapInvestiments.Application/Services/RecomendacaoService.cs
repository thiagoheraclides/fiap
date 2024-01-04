using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Infrastructure.Data;

namespace Br.Com.FiapInvestiments.Application.Services
{
    public class RecomendacaoService(ApiContext apiContext) : IRecomendacaoService
    {
        private readonly ApiContext _apiContext = apiContext;
    }
}
