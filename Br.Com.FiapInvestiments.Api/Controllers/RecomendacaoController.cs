using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Application.Services;
using Br.Com.FiapInvestiments.Domain.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Threading;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecomendacaoController(IRecomendacaoService recomendacaoService) : ControllerBase
    {
        private readonly IRecomendacaoService _recomendacaoService = recomendacaoService;

        [Authorize(Roles = "Consultor, Investidor")]
        [HttpGet("Obter-Todas-Recomendacoes")]
        public async Task<IActionResult> ObterTodasRecomendacoes(CancellationToken cancellationToken)
        {
            try
            {
                var ativo = await _recomendacaoService.ObterTodasRecomendacoes(cancellationToken);
                return Ok(ativo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [Authorize(Roles = "Consultor, Investidor")]
        [HttpGet("Obter-Recomendacoes-Por-Perfil-Investidor/{id}")]
        public async Task<IActionResult> ObterRecomendacoesPorPerfilInvestidor(uint id, CancellationToken cancellationToke)
        {
            try
            {
                var ativo = await _recomendacaoService.ObterRecomendacoesPorPerfilInvestidor(id, cancellationToke);
                return Ok(ativo);
            }
            catch (Exception)
            {

                throw;
            }
        }


        [Authorize(Roles = "Consultor, Investidor")]
        [HttpGet("Obter-Recomendacoes-Consultor/{id}")]
        public async Task<IActionResult> ObterRecomendacoesConsultor(uint id, CancellationToken cancellationToke)
        {
            try
            {
                var ativo = await _recomendacaoService.ObterRecomendacoesConsultor(id, cancellationToke);
                return Ok(ativo);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
