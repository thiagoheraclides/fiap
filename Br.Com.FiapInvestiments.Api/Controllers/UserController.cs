using Br.Com.FiapInvestiments.Api.DTO;
using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Domain.Entidades;
using Br.Com.FiapInvestiments.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Drawing;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(IUserService userService, ApiContext apiContext) : ControllerBase
    {
        private readonly IUserService _userService = userService;
        private readonly ApiContext _apiContext = apiContext;

        //[Authorize(Roles = "Administrador")]
        //[HttpGet("Get-Users")]
        //public async Task<IActionResult> GetUsers()
        //{
        //    try
        //    {
        //        return Ok(await _userService.GetUsers());
        //    }
        //    catch (Exception exception)
        //    {

        //        return BadRequest(exception.Message);
        //    }
        //}

        [Authorize(Roles = "Administrador")]
        [HttpPost("Cadastrar")]
        public async Task<IActionResult> Cadastrar([FromBody] UsuarioDTO usuarioDTO)
        {
            try
            {
                var usuario = new Usuario
                {
                    Cpf = usuarioDTO.CPF,
                    Nome = usuarioDTO.Nome,
                    Email = usuarioDTO.Email,
                    Login = usuarioDTO.Login,
                    Senha = usuarioDTO.Senha,
                    TipoUsuarioId = usuarioDTO.TipoUsuarioCodigo,
                    PerfilId = usuarioDTO.PerfilCodigo
                };

                var id = await _userService.Cadastrar(usuario);
                return Ok(new { UsuarioCodigo = id});
            }
            catch (Exception exception)
            {

                return BadRequest($"{exception.Message}");
            }
        }
    }
}
