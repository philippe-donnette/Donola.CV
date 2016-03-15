using AutoMapper;
using CV.Core.Models;
using CV.Core.Settings;
using CV.DataAccessLayer.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IMapper _mapper;
        private readonly IProjectRepository _projectRepository;
        private readonly ILogger<IProjectService> _logger; 

        public ProjectService(IMapper mapper, 
            IProjectRepository projectRepository,
            ILogger<IProjectService> logger)
        {
            _mapper = mapper;
            _projectRepository = projectRepository;
            _logger = logger;
        }

        public async Task<ProjectModel> GetProjectAsync(int projectId)
        {
            _logger.LogInformation((int)LoggingEvents.GET_PROJECT, "Get project for projectId = " + projectId);
            try
            {
                var project = await _projectRepository.GetProjectAsync(projectId);
                return _mapper.Map<ProjectModel>(project);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.GET_PROJECT, "Data:\nprojectId = " + projectId + "\n\n" + ex.StackTrace);
                return null;
            }
        }

        public async Task<IEnumerable<ProjectModel>> GetProjectsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_PROJECTS, "Listing all projects");
            try
            {
                var projects = await _projectRepository.GetProjectsAsync();
                return _mapper.Map<IEnumerable<ProjectModel>>(projects);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_PROJECTS, ex.StackTrace);
                return null;
            }
        }

        public async Task<IEnumerable<ImageModel>> GetImagesAsync(int projectId)
        {
            _logger.LogInformation((int)LoggingEvents.LIST_PROJECT_IMAGES, "Listing all images for a project");
            try
            {
                var images = await _projectRepository.GetImagesAsync(projectId);
                return _mapper.Map<IEnumerable<ImageModel>>(images);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_PROJECT_IMAGES, ex.StackTrace);
                return null;
            }
        }

        public async Task<IEnumerable<SkillModel>> GetSkillsAsync(int projectId)
        {
            _logger.LogInformation((int)LoggingEvents.LIST_PROJECT_SKILLS, "Listing all project skills");
            try
            {
                var skills = await _projectRepository.GetSkillsAsync(projectId);
                return _mapper.Map<IEnumerable<SkillModel>>(skills);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_PROJECT_SKILLS, ex.StackTrace);
                return null;
            }
        }
    }
}
