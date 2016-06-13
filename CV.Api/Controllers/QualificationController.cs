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
                    return HttpNotFound();
            }
            catch(Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_QUALIFICATIONS, ex.StackTrace);
                return HttpBadRequest();
            }
        }
    }
}
