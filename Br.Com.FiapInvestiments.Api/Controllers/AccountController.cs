using Br.Com.FiapInvestiments.Api.Dto;
using Br.Com.FiapInvestiments.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginDto loginDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var userIsValid = _userService.FindByUsernameAndPassword(loginDto.Username, loginDto.Password);

                if (!userIsValid)
                    return BadRequest("Invalid credential.");

                return Ok();
            }
            catch (Exception exception)
            {

                return BadRequest(exception.Message);
            }            
        }
    }
}
