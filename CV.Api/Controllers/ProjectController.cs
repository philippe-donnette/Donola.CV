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
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;
        private readonly ILogger<ProjectController> _logger;

        public ProjectController(IProjectService projectService,
            ILogger<ProjectController> logger)
        {
            _projectService = projectService;
            _logger = logger;
        }

        // GET: api/projects/all
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetProjectsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_PROJECTS, "Listing all projects");
            try
            {
                var projects = await _projectService.GetProjectsAsync();
                if (projects != null)
                    return Ok(projects);
                else
                    return HttpNotFound();
            }
            catch(Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_PROJECTS, ex.StackTrace);
                return HttpBadRequest();
            }
        }

        
    }
}
