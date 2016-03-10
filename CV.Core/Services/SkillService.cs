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
    public class SkillService : ISkillService
    {
        private readonly IMapper _mapper;
        private readonly ISkillRepository _skillRepository;
        private readonly ILogger<ISkillService> _logger; 

        public SkillService(IMapper mapper, 
            ISkillRepository skillRepository,
            ILogger<ISkillService> logger)
        {
            _mapper = mapper;
            _skillRepository = skillRepository;
            _logger = logger;
        }

        public async Task<IEnumerable<SkillModel>> GetSkillsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_SKILLS, "Listing all skills");
            try
            {
                var skills = await _skillRepository.GetSkillsAsync();
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
