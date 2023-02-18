using Microsoft.AspNetCore.Mvc;

namespace TeslaDash.REST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AggregatesController : ControllerBase
    {
        private readonly ILogger<AggregatesController> _logger;

        public AggregatesController(ILogger<AggregatesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Array.Empty<string>();
        }
    }
}