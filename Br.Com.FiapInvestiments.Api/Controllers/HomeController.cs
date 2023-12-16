﻿using Microsoft.AspNetCore.Mvc;

namespace Br.Com.FiapInvestiments.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
