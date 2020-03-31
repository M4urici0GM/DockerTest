using System;
using Microsoft.AspNetCore.Mvc;

namespace Controllers {
    [ApiController, Route("[controller]")]
    public class HomeController : ControllerBase {

        [HttpGet]
        public IActionResult Index() {
            return Ok(new { Message = "I'm alive." });
        }
    }
}