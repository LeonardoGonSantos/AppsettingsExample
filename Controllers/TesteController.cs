using Microsoft.AspNetCore.Mvc;
using WebApplication1.App.GetValueGetSection;
using WebApplication1.App.GetValueSingleton;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly ILogger<TesteController> _logger;
        private readonly IGetValueSingleton _getValueSingleton;
        private readonly IGetValueIOptions _getValueIOptions;
        private readonly IGetValueGetSection _getValueGetSection;

        public TesteController(ILogger<TesteController> logger, IGetValueSingleton getValueSingleton, IGetValueIOptions getValueIOptions, IGetValueGetSection getValueGetSection)
        {
            _logger = logger;
            _getValueSingleton = getValueSingleton;
            _getValueIOptions = getValueIOptions;
            _getValueGetSection = getValueGetSection;
        }

        [HttpGet(Name = "GetSettingsSingleton")]
        public IActionResult GetSettingsSingleton()
        {
            return Ok(_getValueSingleton.GetValue());
        }       
        
        [HttpGet(Name = "GetSettingsIOptions")]
        public IActionResult GetSettingIOptions()
        {
            return Ok(_getValueIOptions.GetValue());
        }      
        
        [HttpGet(Name = "GetSettingsGetSection")]
        public IActionResult GetSettingsGetSection()
        {
            return Ok(_getValueGetSection.GetValue());

        }
    }
}