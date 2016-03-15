using CV.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Repositories
{
    public interface IProjectRepository
    {
        Task<Project> GetProjectAsync(int projectId);
        Task<IEnumerable<Project>> GetProjectsAsync();
        Task<IEnumerable<ProjectImage>> GetImagesAsync(int projectId);
        Task<IEnumerable<ProjectSkill>> GetSkillsAsync(int projectId);
    }
}
