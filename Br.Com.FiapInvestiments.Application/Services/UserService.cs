using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Domain.Entidades;
using Br.Com.FiapInvestiments.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Br.Com.FiapInvestiments.Application.Services
{
    public class UserService(ApiContext apiContext) : IUserService
    {
		private readonly ApiContext _apiContext = apiContext;

        public async Task<Usuario?> FindByUsernameAndPassword(string username, string password)
        {
			try
			{
                _apiContext.Database.EnsureCreated();
				return await _apiContext.Usuarios.FirstOrDefaultAsync(u => u.Login == username && u.Senha == password);
            }
			catch (Exception)
			{

				throw;
			}
        }

        public async Task<IEnumerable<Usuario>> GetUsers()
        {
			try
			{
				_apiContext.Database.EnsureCreated();
				return await _apiContext.Usuarios.ToListAsync();
			}
			catch (Exception)
			{

				throw;
			}
        }

        public Task Inserir(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
