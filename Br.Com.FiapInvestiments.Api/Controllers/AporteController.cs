using Br.Com.FiapInvestiments.Api.DTO;
using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Application.Services;
using Br.Com.FiapInvestiments.Domain.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AporteController(IAporteService aporteService) : ControllerBase
    {
        private readonly IAporteService _aporteService = aporteService;

        [Authorize(Roles = "Consultor, Investidor")]
        [HttpPost("EfetuarAporte")]
        public async Task<IActionResult> EfetuarAporte([FromBody] AporteDTO aporteDTO)
        {
            try
            {
                var aporte = new Aporte
                {
                    Valor = aporteDTO.Valor,
                    Observacao = aporteDTO.Observacao,
                    UsuarioId = aporteDTO.SolicitanteId,
                    CriadoEm = DateTime.UtcNow
                };

                var resposta = await _aporteService.EfetuarAporte(aporte);

                return Ok(new { Resultado = "Aporte efetuado com sucesso", resposta.Valor, 
                    EmNomeDe = resposta?.Usuario?.Nome, Em = resposta?.CriadoEm.ToString("dd/MM/yyyy HH:mm:ss") });
            }
            catch (Exception exception)
            {

                return BadRequest($"{exception.Message}");
            }
        }
    }
}
