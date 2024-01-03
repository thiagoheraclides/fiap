using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PerfilController(IPerfilService perfilService) : ControllerBase
    {
        private readonly IPerfilService _perfilService = perfilService;

        [Authorize(Roles = "Administrador")]
        [HttpGet("Obter")]
        public async Task<IActionResult> Obter(CancellationToken cancellationToken)
        {
            try
            {
                var perfis = await _perfilService.Obter(cancellationToken);
                return Ok(perfis);
            }
            catch (Exception exception)
            {

                return BadRequest(exception.Message);
            }
        }

        [Authorize(Roles = "Administrador")]
        [HttpGet("Obter/{id}")]
        public async Task<IActionResult> ObterPorId(uint id, CancellationToken cancellationToken)
        {
            try
            {
                var perfis = await _perfilService.ObterPorId(id, cancellationToken);
                return Ok(perfis);
            }
            catch (Exception exception)
            {

                return BadRequest(exception.Message);
            }
        }
    }
}
