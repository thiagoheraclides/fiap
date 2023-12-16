using Microsoft.AspNetCore.Mvc;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        [HttpPost(Name = "Login")]
        public IActionResult Login()
        {
            return Ok();
        }
    }
}
