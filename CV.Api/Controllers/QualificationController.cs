using System;
using System.Threading.Tasks;
using CV.Core.Services;
using Microsoft.Extensions.Logging;
using CV.Api.Settings;
using Microsoft.AspNetCore.Mvc;

namespace CV.Api.Controllers
{
    [Route("api/[controller]")]
    public class QualificationController : Controller
    {
        private readonly IQualificationService _qualificationService;
        private readonly ILogger<QualificationController> _logger;

        public QualificationController(IQualificationService qualificationService,
            ILogger<QualificationController> logger)
        {
            _qualificationService = qualificationService;
            _logger = logger;
        }
        
        // GET: api/qualification/all
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetQualificationsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_QUALIFICATIONS, "Listing all qualifications");
            try
            {
                var qualifications = await _qualificationService.GetQualificationsAsync();
                if (qualifications != null)
                    return Ok(qualifications);
                else
                    return NotFound();
            }
            catch(Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_QUALIFICATIONS, ex.StackTrace);
                return BadRequest();
            }
        }
    }
}
