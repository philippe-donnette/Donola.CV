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
        
    }
}
