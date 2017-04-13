using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CV.Api.Controllers
{
    [Route("api/[controller]")]
    public class HealthController : Controller
    {
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }
        
        // GET: api/health
        [HttpGet]
        [Route("")]
        public IActionResult Ping()
        {
            return Json(true);
        }
    }
}
