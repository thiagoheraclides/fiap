using Br.Com.FiapInvestiments.Api.DTO;
using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Domain.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtivoController(IAtivosService ativoService) : ControllerBase
    {
        private readonly IAtivosService _ativoService = ativoService;

        [Authorize(Roles = "Administrador")]
        [HttpPut("Atualizar/{id}")]
        public async Task<IActionResult> Atualizar(uint id, AtivoDTO ativoDTO, CancellationToken cancellationToken)
        {
            try
            {
                var ativo = new Ativo
                {
                    Id = id,
                    Sigla = ativoDTO.Sigla,
                    Nome = ativoDTO.Nome,
                    RentabilidadeEmDias = ativoDTO.RentabilidadeEmDias,
                    ValorRentabilidade = ativoDTO.ValorRentabilidade,
                    EscalaDeRisco = ativoDTO.EscalaDeRisco,
                    CriadoEm = DateTime.UtcNow
                };

                await _ativoService.Atualizar(ativo, cancellationToken);
                return Ok(new { Resultado = "Ativo atualizado com sucesso!", CodigoAtivo = id });
            }
            catch (Exception exception)
            {

                return BadRequest(exception.Message);
            }
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost("Cadastrar")]
        public async Task<IActionResult> Cadastrar(AtivoDTO ativoDTO, CancellationToken cancellationToken)
        {
            try
            {
                var ativo = new Ativo
                {
                    Sigla = ativoDTO.Sigla,
                    Nome = ativoDTO.Nome,
                    RentabilidadeEmDias = ativoDTO.RentabilidadeEmDias,
                    ValorRentabilidade = ativoDTO.ValorRentabilidade,
                    EscalaDeRisco = ativoDTO.EscalaDeRisco,
                    CriadoEm = DateTime.UtcNow
                };

                var id = await _ativoService.Cadastrar(ativo, cancellationToken);
                return Ok(new { Resultado = "Ativo cadastrado com sucesso", CodigoAtivo = id });
            }
            catch (Exception exception)
            {

                return BadRequest(exception.Message);
            }
        }

        [Authorize(Roles = "Administrador")]
        [HttpPut("Desativar/{id}")]
        public async Task<IActionResult> Desativar(uint id, CancellationToken cancellationToken)
        {
            try
            {
                await _ativoService.Desativar(id, cancellationToken);

                return Ok(new { Resultado = "Ativo desativado com sucesso!", CodigoAtivo = id });
            }
            catch (Exception exception)
            {

                return BadRequest(exception.Message);
            }
        }

        [Authorize(Roles = "Administrador")]
        [HttpGet("Obter")]
        public async Task<IActionResult> Obter(CancellationToken cancellationToken) 
        {
            try
            {
                var ativos = await _ativoService.Obter(cancellationToken);
                return Ok(ativos);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Authorize(Roles = "Administrador")]
        [HttpGet("Obter/{id}")]
        public async Task<IActionResult> ObterPorId(uint id, CancellationToken cancellationToken)
        {
            try
            {
                var ativo = await _ativoService.ObterPorId(id, cancellationToken);
                return Ok(ativo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Authorize(Roles = "Administrador")]
        [HttpGet("Obter-Disponiveis")]
        public async Task<IActionResult> ObterDisponiveis(CancellationToken cancellationToken)
        {
            try
            {
                var ativo = await _ativoService.ObterDisponiveis(cancellationToken);
                return Ok(ativo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Authorize(Roles = "Administrador")]
        [HttpDelete("Remover/{id}")]
        public async Task<IActionResult> Remover(uint id, CancellationToken cancellationToken)
        {
            try
            {
                await _ativoService.Remover(id, cancellationToken);
                return Ok(new { Resultado = "Ativo removido com sucesso!"});
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
