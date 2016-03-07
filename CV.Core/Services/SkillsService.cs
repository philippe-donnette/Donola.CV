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
    public class SkillsService : ISkillsService
    {
        private readonly IMapper _mapper;
        private readonly ISkillsRepository _skillsRepository;
        private readonly ILogger<ISkillsService> _logger; 

        public SkillsService(IMapper mapper, 
            ISkillsRepository skillsRepository,
            ILogger<ISkillsService> logger)
        {
            _mapper = mapper;
            _skillsRepository = skillsRepository;
            _logger = logger;
        }

        public async Task<IEnumerable<SkillModel>> GetSkillsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_SKILLS, "Listing all skills");
            try
            {
                var skills = await _skillsRepository.GetSkillsAsync();
                return _mapper.Map<IEnumerable<SkillModel>>(skills);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_SKILLS, ex.StackTrace);
                return null;
            }
        }
    }
}
