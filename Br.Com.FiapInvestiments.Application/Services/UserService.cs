using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Domain.Entities;
using Br.Com.FiapInvestiments.Infrastructure.Data;

namespace Br.Com.FiapInvestiments.Application.Services
{
    public class UserService(ApiContext apiContext) : IUserService
    {
		private readonly ApiContext _apiContext = apiContext;

        public bool FindByUsernameAndPassword(string username, string password)
        {
			try
			{
                _apiContext.Database.EnsureCreated();

                var isUserValid = _apiContext.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
				if (isUserValid == null)
					return false;

				return true;
			}
			catch (Exception)
			{

				throw;
			}
        }

        public IEnumerable<User> GetUsers()
        {
			try
			{
				_apiContext.Database.EnsureCreated();

				return _apiContext.Users.ToList();

			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
