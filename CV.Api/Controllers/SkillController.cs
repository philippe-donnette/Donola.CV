using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using CV.Core.Services;
using CV.Core.Models;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using CV.Api.Settings;

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

        // GET: api/skills/all
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
                    return HttpNotFound();
            }
            catch(Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_SKILLS, ex.StackTrace);
                return HttpBadRequest();
            }
        }

        
    }
}
