using CV.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Services
{
    public interface IExperienceService
    {
        Task<ExperienceModel> GetExperienceAsync(int experienceId);
        Task<IEnumerable<ExperienceModel>> GetExperiencesAsync();
        Task<IEnumerable<SkillModel>> GetSkillsAsync(int experienceId);
    }
}
