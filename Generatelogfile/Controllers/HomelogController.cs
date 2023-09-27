using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Generatelogfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomelogController : ControllerBase
    {
        private readonly ILogger<HomelogController> _logger;
        public HomelogController(ILogger<HomelogController> logger)
        {
            _logger=logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            _logger.LogTrace("logger trace method");
            _logger.LogWarning("Logger warning");
            _logger.LogDebug("debugggg");
            _logger.LogInformation("Information");
            return Ok();
        }
    }
}
