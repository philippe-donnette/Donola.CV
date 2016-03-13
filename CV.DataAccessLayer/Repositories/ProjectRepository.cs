using CV.DataAccessLayer.Contexts;
using CV.DataAccessLayer.Entities;
using CV.DataAccessLayer.Settings;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly CvDbContext _context;
        private readonly ILogger<IProjectRepository> _logger;


        public ProjectRepository(CvDbContext context, 
            ILogger<IProjectRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Project> GetProjectAsync(int projectId)
        {
            _logger.LogInformation((int)LoggingEvents.GET_PROJECT, "Get project for projectId = " + projectId);
            try
            {
                return await _context.Projects.SingleOrDefaultAsync(x => x.Id == projectId);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.GET_PROJECT, "Data:\nprojectId = " + projectId + "\n\n" + ex.StackTrace);
                return null;
            }
        }

        public async Task<IEnumerable<Project>> GetProjectsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_PROJECTS, "Listing all projects");
            try
            {
                return await _context.Projects.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_PROJECTS, ex.StackTrace);
                return null;
            }
        }

        public async Task<IEnumerable<ProjectSkill>> GetSkillsAsync(int projectId)
        {
            _logger.LogInformation((int)LoggingEvents.LIST_PROJECT_SKILLS, "Listing all skills for projectId = " + projectId);
            try
            {
                return await _context.ProjectSkills
                    .Include(x => x.Skill)
                    .Include(x => x.Versions)
                    .ThenInclude(x => x.Version)
                    .Where(x => x.ProjectId == projectId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_PROJECT_SKILLS, "Data:\nprojectId = " + projectId + "\n\n" + ex.StackTrace);
                return null;
            }
        }
    }
}
