using Microsoft.AspNetCore.Mvc;

namespace micros.services.products.Controllers
{
    [Route("api/health")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public ActionResult Health()
        {
            return Ok();
        }
    }
}