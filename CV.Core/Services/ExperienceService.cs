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
    public class ExperienceService : IExperienceService
    {
        private readonly IMapper _mapper;
        private readonly IExperienceRepository _experienceRepository;
        private readonly ILogger<IExperienceService> _logger; 

        public ExperienceService(IMapper mapper,
            IExperienceRepository experienceRepository,
            ILogger<IExperienceService> logger)
        {
            _mapper = mapper;
            _experienceRepository = experienceRepository;
            _logger = logger;
        }

        public async Task<ExperienceModel> GetExperienceAsync(int experienceId)
        {
            _logger.LogInformation((int)LoggingEvents.GET_EXPERIENCE, "Get experience for experienceId = " + experienceId);
            try
            {
                var experience = await _experienceRepository.GetExperienceAsync(experienceId);
                return _mapper.Map<ExperienceModel>(experience);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.GET_EXPERIENCE, "Data:\nexperienceId = " + experienceId + "\n\n" + ex.StackTrace);
                return null;
            }
        }

        public async Task<IEnumerable<ExperienceModel>> GetExperiencesAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_EXPERIENCES, "Listing all experiences");
            try
            {
                var experiences = await _experienceRepository.GetExperiencesAsync();
                return _mapper.Map<IEnumerable<ExperienceModel>>(experiences);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_EXPERIENCES, ex.StackTrace);
                return null;
            }
        }

        public async Task<IEnumerable<SkillModel>> GetSkillsAsync(int experienceId)
        {
            _logger.LogInformation((int)LoggingEvents.LIST_EXPERIENCE_SKILLS, "Listing all experience skills");
            try
            {
                var skills = await _experienceRepository.GetSkillsAsync(experienceId);
                return _mapper.Map<IEnumerable<SkillModel>>(skills);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_EXPERIENCE_SKILLS, ex.StackTrace);
                return null;
            }
        }
    }
}
