﻿using System;
using System.Threading.Tasks;
using CV.Core.Services;
using Microsoft.Extensions.Logging;
using CV.Api.Settings;
using Microsoft.AspNetCore.Mvc;

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

        // GET: api/project/1/images
        [HttpGet]
        [Route("{projectId}/images")]
        public async Task<IActionResult> GetImagesAsync(int projectId)
        {
            _logger.LogInformation((int)LoggingEvents.LIST_PROJECT_IMAGES, "Listing all images for a project");
            try
            {
                var images = await _projectService.GetImagesAsync(projectId);
                if (images != null)
                    return Ok(images);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_PROJECT_IMAGES, "Data:\nprojectId = " + projectId + "\n\n" + ex.StackTrace);
                return BadRequest();
            }
        }

        // GET: api/project/[projectId]
        [HttpGet]
        [Route("{projectId}")]
        public async Task<IActionResult> GetProjectAsync(int projectId)
        {
            _logger.LogInformation((int)LoggingEvents.GET_PROJECT, "Get project for projectId = " + projectId);
            try
            {
                var project = await _projectService.GetProjectAsync(projectId);
                if (project != null)
                    return Ok(project);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.GET_PROJECT, "Data:\nprojectId = " + projectId + "\n\n" + ex.StackTrace);
                return BadRequest();
            }
        }

        // GET: api/project/all
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
                    return NotFound();
            }
            catch(Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_PROJECTS, ex.StackTrace);
                return BadRequest();
            }
        }

        // GET: api/project/1/skills
        [HttpGet]
        [Route("{projectId}/skills")]
        public async Task<IActionResult> GetSkillsAsync(int projectId)
        {
            _logger.LogInformation((int)LoggingEvents.LIST_PROJECT_SKILLS, "Listing all project skills");
            try
            {
                var skills = await _projectService.GetSkillsAsync(projectId);
                if (skills != null)
                    return Ok(skills);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_PROJECT_SKILLS, "Data:\nprojectId = " + projectId + "\n\n" + ex.StackTrace);
                return BadRequest();
            }
        }
    }
}
