using Br.Com.FiapInvestiments.Api.DTO;
using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Domain.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController(IPedidoService pedidoService) : ControllerBase
    {
        private readonly IPedidoService _pedidoService = pedidoService;

        [Authorize(Roles = "Administrador")]
        [HttpPost("OrdemCompra")]
        public async Task<IActionResult> OrdemCompra([FromBody] PedidoDTO ordemCompra)
        {
            try
            {
                var pedidoCompra = new Pedido
                {                    
                    Quantidade = ordemCompra.Quantidade,
                    Valor = ordemCompra.Valor,
                    OrdemDeCompra = true,
                    Observacao = ordemCompra.Observacao,
                    UsuarioId = ordemCompra.UsuarioInvestidorId,
                    AtivoId = ordemCompra.AtivoInvestimentoId,
                    CriadoEm = DateTime.Now
                };

                var id = await _pedidoService.EnviarOrdemCompra(pedidoCompra);
                return Ok(new { OrdemCompraCodigo = id });
            }
            catch (Exception exception)
            {

                return BadRequest($"{exception.Message}");
            }
        }


        [Authorize(Roles = "Administrador")]
        [HttpPost("OrdemVenda")]
        public async Task<IActionResult> OrdemVenda([FromBody] PedidoDTO ordemVenda)
        {
            try
            {
                var pedidoVenda = new Pedido
                {                    
                    Quantidade = ordemVenda.Quantidade,
                    Valor = ordemVenda.Valor,
                    OrdemDeCompra = false,
                    Observacao = ordemVenda.Observacao,
                    UsuarioId = ordemVenda.UsuarioInvestidorId,
                    AtivoId = ordemVenda.AtivoInvestimentoId,
                    CriadoEm = DateTime.Now
                };

                var id = await _pedidoService.EnviarOrdemVenda(pedidoVenda);
                return Ok(new { OrdemVendaCodigo = id });
            }
            catch (Exception exception)
            {

                return BadRequest($"{exception.Message}");
            }
        }
    }
}
