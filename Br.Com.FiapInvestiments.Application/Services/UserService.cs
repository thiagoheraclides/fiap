using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Domain.Entities;
using Br.Com.FiapInvestiments.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Br.Com.FiapInvestiments.Application.Services
{
    public class UserService(ApiContext apiContext) : IUserService
    {
		private readonly ApiContext _apiContext = apiContext;

        public async Task<User?> FindByUsernameAndPassword(string username, string password)
        {
			try
			{
                _apiContext.Database.EnsureCreated();
                return await _apiContext.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
            }
			catch (Exception)
			{

				throw;
			}
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
			try
			{
				_apiContext.Database.EnsureCreated();
				return await _apiContext.Users.ToListAsync();
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
