using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Domain.Entidades;
using Br.Com.FiapInvestiments.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Br.Com.FiapInvestiments.Application.Services
{
    public class AporteService(ApiContext apiContext) : IAporteService
    {
        private readonly ApiContext _apiContext = apiContext;

        public async Task<Aporte> EfetuarAporte(Aporte aporte)
        {
            Usuario solicitante = new();

            try
            {
                solicitante = await _apiContext.Usuarios
                    .Where(p => p.Id == aporte.UsuarioId).SingleOrDefaultAsync()
                    ?? throw new Exception("Cliente não encontrado!");

                if (solicitante?.TipoUsuario?.Nome == "Administrador")
                    throw new Exception("Operação não permitida!");

                if (aporte.Valor <= default(decimal))
                    throw new Exception("Necessário informar um valor para aporte.");

                aporte.AdicionarUsuario(solicitante);

                await _apiContext.Aportes.AddAsync(aporte);
                await _apiContext.SaveChangesAsync();

                return aporte;
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
