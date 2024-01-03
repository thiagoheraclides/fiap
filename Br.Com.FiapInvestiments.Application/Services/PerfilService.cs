using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Domain.Entidades;
using Br.Com.FiapInvestiments.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Br.Com.FiapInvestiments.Application.Services
{
    public class PerfilService(ApiContext apiContext) : IPerfilService
    {
        private readonly ApiContext _apiContext = apiContext;
        public async Task<IEnumerable<Perfil>> Obter(CancellationToken cancellationToken)
        {
            try
            {
                cancellationToken.ThrowIfCancellationRequested();
                return await _apiContext.Perfis.ToListAsync(cancellationToken);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Perfil> ObterPorId(uint id, CancellationToken cancellationToken)
        {
            try
            {
                cancellationToken.ThrowIfCancellationRequested();
                return await _apiContext.Perfis
                    .Where(p => p.Id == id).SingleOrDefaultAsync(cancellationToken);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
