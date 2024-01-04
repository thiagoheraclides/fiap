using Br.Com.FiapInvestiments.Domain.Entidades;

namespace Br.Com.FiapInvestiments.Application.Interfaces
{
    public interface IPedidoService
    {
        Task<uint> EnviarOrdemCompra(Pedido ordemCompra);

        Task<uint> EnviarOrdemVenda(Pedido ordemVenda);
    }
}
