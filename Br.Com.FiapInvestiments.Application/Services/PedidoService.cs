using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Domain.Entidades;
using Br.Com.FiapInvestiments.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Br.Com.FiapInvestiments.Application.Services
{
    public class PedidoService(ApiContext apiContext) : IPedidoService
    {
        private readonly ApiContext _apiContext = apiContext;

        public async Task<uint> EnviarOrdemCompra(Pedido ordemCompra)
        {
            try
            {
                var userInvestidor =
                    await _apiContext.Usuarios.Where(x => x.Id == ordemCompra.UsuarioId).FirstOrDefaultAsync()
                    ?? throw new Exception("Usuário informado não encontrado!");

                ordemCompra.AdicionarUsuario(userInvestidor);

                var ativoInvestimento =
                    await _apiContext.Ativos.Where(x => x.Id == ordemCompra.AtivoId).FirstOrDefaultAsync()
                    ?? throw new Exception("Ativo de investimento não encontrado!");

                ordemCompra.AdicionarAtivo(ativoInvestimento);

                _apiContext.Pedidos.Add(ordemCompra);

                _apiContext.SaveChanges();

                return (uint)ordemCompra.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<uint> EnviarOrdemVenda(Pedido ordemVenda)
        {
            try
            {
                var userInvestidor =
                    await _apiContext.Usuarios.Where(x => x.Id == ordemVenda.UsuarioId).FirstOrDefaultAsync()
                    ?? throw new Exception("Usuário informado não encontrado!");

                ordemVenda.AdicionarUsuario(userInvestidor);

                var ativoInvestimento =
                    await _apiContext.Ativos.Where(x => x.Id == ordemVenda.AtivoId).FirstOrDefaultAsync()
                    ?? throw new Exception("Ativo de investimento não encontrado!");

                ordemVenda.AdicionarAtivo(ativoInvestimento);

                _apiContext.Pedidos.Add(ordemVenda);

                _apiContext.SaveChanges();

                return (uint)ordemVenda.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
