using Br.Com.FiapInvestiments.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoUsuarioController(ITipoUsuarioService tipoUsuarioService) : ControllerBase
    {
        private readonly ITipoUsuarioService _tipoUsuarioService = tipoUsuarioService;

        [Authorize(Roles = "Administrador")]
        [HttpGet("Obter")]
        public async Task<IActionResult> Obter(CancellationToken cancellationToken)
        {
            try
            {
                var tiposUsuario = await _tipoUsuarioService.Obter(cancellationToken);

                // adaptação técnica para remover o objeto lazy loading da resposta;
                var resposta = JsonSerializer.Serialize(tiposUsuario);
                return Ok(resposta);
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
                var tiposUsuario = await _tipoUsuarioService.ObterPorId(id, cancellationToken);

                // adaptação técnica para remover o objeto lazy loading da resposta;
                var resposta = JsonSerializer.Serialize(tiposUsuario);
                return Ok(resposta);
            }
            catch (Exception exception)
            {

                return BadRequest(exception.Message);
            }
        }
    }
}
