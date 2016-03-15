using CV.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<ImageModel>> GetImagesAsync(int projectId);
        Task<ProjectModel> GetProjectAsync(int projectId);
        Task<IEnumerable<ProjectModel>> GetProjectsAsync();
        Task<IEnumerable<SkillModel>> GetSkillsAsync(int projectId);
    }
}
