using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.App.GetValueGetSection;
using WebApplication1.App.GetValueSingleton;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("testeController")]
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

        [HttpGet]
        [Route("GetSettingsSingleton")]
        public IActionResult GetSettingsSingleton()
        {
            var tempo = new Stopwatch();

            tempo.Start();

            var result = _getValueSingleton.GetValue();

            tempo.Stop();

            return Ok(new { tempo = tempo.Elapsed, result = result });
        }

        [HttpGet]
        [Route("GetSettingsIOptions")]
        public IActionResult GetSettingIOptions()
        {
            var tempo = new Stopwatch();
            tempo.Start();
            var result = _getValueIOptions.GetValue();
            tempo.Stop();
            return Ok(new { tempo = tempo.Elapsed, result = result });
        }      
        
        [HttpGet]
        [Route("GetSettingsGetSection")]
        public IActionResult GetSettingsGetSection()
        {
            var tempo = new Stopwatch(); 
            tempo.Start();
            var result = _getValueGetSection.GetValue();
            tempo.Stop();
            return Ok(new { tempo = tempo.Elapsed, result = result });
        }
    }
}