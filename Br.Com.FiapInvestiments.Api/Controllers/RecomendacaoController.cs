using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecomendacaoController(IRecomendacaoService recomendacaoService) : ControllerBase
    {
        private readonly IRecomendacaoService _recomendacaoService = recomendacaoService;

        [Authorize(Roles = "Consultor, Investidor")]
        [HttpGet("Obter")]
        public async Task<IActionResult> Obter(CancellationToken cancellationToken)
        {
            try
            {
                
                throw new NotImplementedException();
            }
            catch (Exception exception)
            {

                return BadRequest(exception.Message);
            }
        }
    }
}
