using System;
using System.Threading.Tasks;
using CV.Core.Services;
using Microsoft.Extensions.Logging;
using CV.Api.Settings;
using Microsoft.AspNetCore.Mvc;

namespace CV.Api.Controllers
{
    [Route("api/[controller]")]
    public class ExperienceController : Controller
    {
        private readonly IExperienceService _experienceService;
        private readonly ILogger<ExperienceController> _logger;

        public ExperienceController(IExperienceService experienceService,
            ILogger<ExperienceController> logger)
        {
            _experienceService = experienceService;
            _logger = logger;
        }

        // GET: api/experience/[experienceId]
        [HttpGet]
        [Route("{experienceId}")]
        public async Task<IActionResult> GetExperienceAsync(int experienceId)
        {
            _logger.LogInformation((int)LoggingEvents.GET_EXPERIENCE, "Get experience for experienceId = " + experienceId);
            try
            {
                var experience = await _experienceService.GetExperienceAsync(experienceId);
                if (experience != null)
                    return Ok(experience);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.GET_EXPERIENCE, "Data:\nexperienceId = " + experienceId + "\n\n" + ex.StackTrace);
                return BadRequest();
            }
        }

        // GET: api/experience/all
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetExperiencesAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_EXPERIENCES, "Listing all experiences");
            try
            {
                var experiences = await _experienceService.GetExperiencesAsync();
                if (experiences != null)
                    return Ok(experiences);
                else
                    return NotFound();
            }
            catch(Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_EXPERIENCES, ex.StackTrace);
                return BadRequest();
            }
        }

        // GET: api/experience/1/skills
        [HttpGet]
        [Route("{experienceId}/skills")]
        public async Task<IActionResult> GetSkillsAsync(int experienceId)
        {
            _logger.LogInformation((int)LoggingEvents.LIST_EXPERIENCE_SKILLS, "Listing all experience skills");
            try
            {
                var skills = await _experienceService.GetSkillsAsync(experienceId);
                if (skills != null)
                    return Ok(skills);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_EXPERIENCE_SKILLS, "Data:\nexperienceId = " + experienceId + "\n\n" + ex.StackTrace);
                return BadRequest();
            }
        }
    }
}
