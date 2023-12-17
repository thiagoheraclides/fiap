using Br.Com.FiapInvestiments.Domain.Entities;

namespace Br.Com.FiapInvestiments.Application.Interfaces
{
    public interface ITokenService
    {
        string GetToken(User user);
    }
}
