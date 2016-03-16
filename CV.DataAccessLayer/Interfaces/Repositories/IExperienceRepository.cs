using CV.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Repositories
{
    public interface IExperienceRepository
    {
        Task<Experience> GetExperienceAsync(int experienceId);
        Task<IEnumerable<Experience>> GetExperiencesAsync();
        Task<IEnumerable<ExperienceSkill>> GetSkillsAsync(int experienceId);
    }
}
