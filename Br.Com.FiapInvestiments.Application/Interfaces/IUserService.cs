using Br.Com.FiapInvestiments.Domain.Entities;

namespace Br.Com.FiapInvestiments.Application.Interfaces
{
    public interface IUserService
    {
        Task<User?> FindByUsernameAndPassword(string username, string password);
        Task<IEnumerable<User>> GetUsers();
    }
}
