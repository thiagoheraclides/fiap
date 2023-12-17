using Br.Com.FiapInvestiments.Domain.Entities;

namespace Br.Com.FiapInvestiments.Application.Interfaces
{
    public interface IUserService
    {
        bool FindByUsernameAndPassword(string username, string password);
        IEnumerable<User> GetUsers();
    }
}
