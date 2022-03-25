using Microsoft.AspNetCore.Mvc;

namespace MathSystem.Worker.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class HealthCheckController : ControllerBase
  {
    [HttpGet]
    public IActionResult Get()
    {
      return Ok($"Service is up!");
    }
  }
}
