using Br.Com.FiapInvestiments.Domain.Entidades;

namespace Br.Com.FiapInvestiments.Application.Interfaces
{
    public interface IUserService
    {
        Task<uint> Cadastrar(Usuario usuario);

        Task<uint> EnviarOrdemCompra(Pedido ordemCompra);

        Task<uint> EnviarOrdemVenda(Pedido ordemVenda);

        Task<Usuario?> FindByUsernameAndPassword(string username, string password);

        Task<IEnumerable<Usuario>> GetUsers();
    }
}
