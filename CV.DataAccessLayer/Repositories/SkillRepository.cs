﻿using CV.DataAccessLayer.Contexts;
using CV.DataAccessLayer.Entities;
using CV.DataAccessLayer.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly CvDbContext _context;
        private readonly ILogger<ISkillRepository> _logger;

        public SkillRepository(CvDbContext context, 
            ILogger<ISkillRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<Skill>> GetSkillsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_SKILLS, "Listing all skills");
            try
            {
                return await _context.Skills.Include(x => x.Versions)
                    .ToListAsync();
            }
            catch(Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_SKILLS, ex.StackTrace);
                return null;
            }
        }
    }
}
