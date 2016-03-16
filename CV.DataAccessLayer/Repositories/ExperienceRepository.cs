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
    public class ExperienceRepository : IExperienceRepository
    {
        private readonly CvDbContext _context;
        private readonly ILogger<IExperienceRepository> _logger;


        public ExperienceRepository(CvDbContext context, 
            ILogger<IExperienceRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Experience> GetExperienceAsync(int experienceId)
        {
            _logger.LogInformation((int)LoggingEvents.GET_EXPERIENCE, "Get experience for experienceId = " + experienceId);
            try
            {
                return await _context.Experiences.SingleOrDefaultAsync(x => x.Id == experienceId);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.GET_EXPERIENCE, "Data:\nexperienceId = " + experienceId + "\n\n" + ex.StackTrace);
                return null;
            }
        }

        public async Task<IEnumerable<Experience>> GetExperiencesAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_EXPERIENCES, "Listing all experiences");
            try
            {
                return await _context.Experiences.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_EXPERIENCES, ex.StackTrace);
                return null;
            }
        }
        
        public async Task<IEnumerable<ExperienceSkill>> GetSkillsAsync(int experienceId)
        {
            _logger.LogInformation((int)LoggingEvents.LIST_EXPERIENCE_SKILLS, "Listing all experiences for experienceId = " + experienceId);
            try
            {
                return await _context.ExperienceSkills
                    .Include(x => x.Skill)
                    .Include(x => x.Versions)
                    .ThenInclude(x => x.Version)
                    .Where(x => x.ExperienceId == experienceId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_EXPERIENCE_SKILLS, "Data:\nexperienceId = " + experienceId + "\n\n" + ex.StackTrace);
                return null;
            }
        }
    }
}
