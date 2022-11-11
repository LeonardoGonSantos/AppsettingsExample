using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly ILogger<TesteController> _logger;

        public TesteController(ILogger<TesteController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSettingsSingleton")]
        public IActionResult GetSettingsSingleton()
        {
            return;
        }       
        
        [HttpGet(Name = "GetSettingsIOptions")]
        public IActionResult GetSettingsSingleton()
        {
            return;
        }      
        
        [HttpGet(Name = "GetSettingsGetSection")]
        public IActionResult GetSettingsSingleton()
        {
            return;
        }
    }
}