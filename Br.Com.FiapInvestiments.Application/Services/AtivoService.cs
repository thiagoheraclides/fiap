using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Domain.Entidades;
using Br.Com.FiapInvestiments.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Br.Com.FiapInvestiments.Application.Services
{
    public class AtivoService(ApiContext apiContext) : IAtivosService
    {
        private readonly ApiContext _apiContext = apiContext;

        public async Task<uint> Atualizar(Ativo ativo, CancellationToken cancellationToken)
        {
            try
            {
                var ativoExistente = await _apiContext.Ativos
                    .Where(p => p.Id == ativo.Id)
                    .FirstOrDefaultAsync(cancellationToken);                

                if (ativoExistente is null)
                    throw new Exception("Ativo não encontrado!");

                cancellationToken.ThrowIfCancellationRequested();
                ativoExistente.Atualizar(ativo);
                _apiContext.SaveChanges();

                return ativoExistente.Id;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<uint> Cadastrar(Ativo ativo, CancellationToken cancellationToken)
        {
            try
            {                

                var ativoDataBase = await _apiContext.Ativos
                    .Where(p => p.Sigla == ativo.Sigla & p.Nome == ativo.Nome)
                    .FirstOrDefaultAsync(cancellationToken);

                cancellationToken.ThrowIfCancellationRequested();

                if (ativoDataBase is not null)
                    throw new Exception("Ativo já cadastrado!");

                await _apiContext.Ativos.AddAsync(ativo, cancellationToken);
                _apiContext.SaveChanges();

                return ativo.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task Desativar(uint id, CancellationToken cancellationToken)
        {
            try
            {
                var ativoExistente = await _apiContext.Ativos
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync(cancellationToken);

                if (ativoExistente is null)
                    throw new Exception("Ativo não encontrado!");

                cancellationToken.ThrowIfCancellationRequested();
                ativoExistente.Desativar();

                _apiContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Ativo>> Obter(CancellationToken cancellationToken)
        {
            try
            {
                return await _apiContext.Ativos.ToListAsync(cancellationToken);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Ativo>> ObterDisponiveis(CancellationToken cancellationToken)
        {
            try
            {
                return await _apiContext.Ativos
                    .Where(p => p.EncerraEm == null)
                    .ToListAsync(cancellationToken);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Ativo> ObterPorId(uint id, CancellationToken cancellationToken)
        {
            try
            {
                var ativo = await _apiContext.Ativos
                    .Where(p => p.Id == id)
                    .SingleOrDefaultAsync(cancellationToken);

                return ativo;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task Remover(uint id, CancellationToken cancellationToken)
        {
            try
            {
                var ativoExistente = await _apiContext.Ativos
                    .Where(p => p.Id == id)
                    .FirstOrDefaultAsync(cancellationToken);

                if (ativoExistente is null)
                    throw new Exception("Ativo não encontrado!");

                cancellationToken.ThrowIfCancellationRequested();
                _apiContext.Remove(ativoExistente);

                _apiContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
