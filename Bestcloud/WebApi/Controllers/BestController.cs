using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BestController : ControllerBase
    {
        
        // GET /message
        [HttpGet("/")]
        public IActionResult GetMessage()
        {
            return Ok(new { msg = "BC4M" });
        }

        // GET /health
        [HttpGet("/health")]
        public IActionResult CheckHealthStatus()
        {
            return Ok(new { status = "Healthy" });
        }


        // POST /
        [HttpPost("/")]
        public IActionResult PostData([FromBody] object data)
        {
            return Ok(data);
        }
    }
}
