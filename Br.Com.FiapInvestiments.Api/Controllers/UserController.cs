using Br.Com.FiapInvestiments.Api.Dto;
using Br.Com.FiapInvestiments.Application.Interfaces;
using Br.Com.FiapInvestiments.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(IUserService userService, ApiContext apiContext) : ControllerBase
    {
        private readonly IUserService _userService = userService;
        private readonly ApiContext _apiContext = apiContext;

        [Authorize(Roles = "Administrador")]
        [HttpGet("Get-Users")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                return Ok(await _userService.GetUsers());
            }
            catch (Exception exception)
            {

                return BadRequest(exception.Message);
            }
        }


        public static Dto.Usuario CadatrarUsuario(ApiContext db, Dto.Usuario param)
        {
            var dbTransaction = db.Database.BeginTransaction();

            try
            {
                // Se informado Código ou Login atualizar o registro, senão criar um novo
                // Esses 2 campos são chave e tem Unique no BD
                var dataDB =
                    param.Codigo.HasValue ? db.Usuario.Find(param.Codigo) : !string.IsNullOrEmpty(param.Login) ? db.Usuario.FirstOrDefault(x => x.Login == param.Login)
                     // Fallback para criar o usuário quando nenhuma das chaves obteve sucesso
                     ?? new Domain.Entidades.Usuario();
                {
                    dataDB.Id = param.Codigo;
                    dataDB.Cpf = param.CPF ?? dataDB.Cpf;
                    dataDB.Nome = param.Nome ?? dataDB.Nome;
                    dataDB.Email = param.Email ?? dataDB.Email;
                    dataDB.Login = param.Login ?? dataDB.Login;
                    dataDB.Senha = param.Senha ?? dataDB.Senha;
                    dataDB.UltimoAcesso = param.DataUltimoAcesso ?? dataDB.UltimoAcesso;
                    dataDB.TipoUsuarioId = param.TipoUsuario.Codigo ?? dataDB.TipoUsuarioId;
                    dataDB.PerfilId = param.PerfilInvestidor.Codigo ?? dataDB.PerfilId;
                }
                if (!param.Codigo.HasValue)
                {
                    db.Usuario.Add(dataDB);
                }
               
                db.SaveChanges();
                dbTransaction.Commit();
                return new Dto.Usuario { Codigo = dataDB.Id };
            }
            catch
            {
                dbTransaction.Rollback();
                throw;
            }
        }
    }
}
