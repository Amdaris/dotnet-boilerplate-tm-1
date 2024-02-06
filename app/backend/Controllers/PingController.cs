using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet("ping")]
        public string Get()
        {
            // Don't change this
            return "pong";
        }
    }
}
