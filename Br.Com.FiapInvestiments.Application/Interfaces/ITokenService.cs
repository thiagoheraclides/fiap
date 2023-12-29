using Br.Com.FiapInvestiments.Domain.Entidades;

namespace Br.Com.FiapInvestiments.Application.Interfaces
{
    public interface ITokenService
    {
        string GetToken(Usuario usuario);
    }
}
