using Br.Com.FiapInvestiments.Api.DTO;
using Br.Com.FiapInvestiments.Api.Extensions;
using Br.Com.FiapInvestiments.Application.Interfaces;
using log4net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController(IUserService userService, ITokenService tokenService) : ControllerBase
    {
        private readonly IUserService _userService = userService;
        private readonly ITokenService _tokenService = tokenService;        

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDto)
        {

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var user = await _userService.FindByUsernameAndPassword(loginDto.Username, loginDto.Password);

                if (user is null)
                    return BadRequest("Invalid credential.");

                var token = _tokenService.GetToken(user);

                var authenticatedUser = new { loginDto.Username, Token = token };

                return Ok(authenticatedUser);
            }
            catch (Exception exception)
            {
                
                return BadRequest(exception.Message);
            }            
        }
    }
}
