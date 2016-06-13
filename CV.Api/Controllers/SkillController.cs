using System;
using System.Threading.Tasks;
using CV.Core.Services;
using Microsoft.Extensions.Logging;
using CV.Api.Settings;
using Microsoft.AspNetCore.Mvc;

namespace CV.Api.Controllers
{
    [Route("api/[controller]")]
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;
        private readonly ILogger<SkillController> _logger;

        public SkillController(ISkillService skillService,
            ILogger<SkillController> logger)
        {
            _skillService = skillService;
            _logger = logger;
        }

        // GET: api/skill/all
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetSkillsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_SKILLS, "Listing all skills");
            try
            {
                var skills = await _skillService.GetSkillsAsync();
                if (skills != null)
                    return Ok(skills);
                else
                    return NotFound();
            }
            catch(Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_SKILLS, ex.StackTrace);
                return BadRequest();
            }
        }

        
    }
}
