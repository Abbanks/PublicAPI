using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using PublicAPI.Models;

namespace PublicAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Result), StatusCodes.Status200OK)]
        public IActionResult GetInfo()
        {
            var result = new Result
            {
                Email = "olubanke.eboda@gmail.com",
                CurrentDatetime = DateTime.UtcNow.ToString("o"),
                GithubUrl = "https://github.com/Abbanks/PublicAPI.git"
            };

            return Ok(result);
        }
    }
}
