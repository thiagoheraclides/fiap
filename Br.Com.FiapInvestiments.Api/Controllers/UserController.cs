using Br.Com.FiapInvestiments.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;
        
        [HttpPost("Get-Users")]
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
    }
}
