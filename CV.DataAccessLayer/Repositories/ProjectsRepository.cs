﻿using CV.DataAccessLayer.Contexts;
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
    public class ProjectsRepository : IProjectsRepository
    {
        private readonly CvDbContext _context;
        private readonly ILogger<IProjectsRepository> _logger;


        public ProjectsRepository(CvDbContext context, 
            ILogger<IProjectsRepository> logger)
        {
            _context = context;
            _logger = logger;
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
                    .Where(x => x.ProjectId == projectId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_PROJECT_SKILLS, ex.StackTrace);
                return null;
            }
        }
    }
}
