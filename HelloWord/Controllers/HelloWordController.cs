using Microsoft.AspNetCore.Mvc;

namespace HelloWord.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWordController : ControllerBase
    {
        [HttpGet]
        public IActionResult HelloWord(string name)
        {
            return Ok($"Minha primeira API -> Seja bem vindo {name}");
        }
    }
}
