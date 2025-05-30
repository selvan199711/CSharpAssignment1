using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment1.Controllers
{
    [ApiController]
    [Route("api/q2")]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// Greets the given name.
        /// </summary>
        /// <param name="name">Name to greet</param>
        /// <returns>Greeting message for the name</returns>
        /// <example>GET /api/q2/greeting?name=Gary → "Hi Gary!"</example>
        [HttpGet("greeting")]
        public string Greeting([FromQuery] string name)
        {
            return $"Hi {name}!";
        }
    }
}
