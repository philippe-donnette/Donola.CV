using CV.DataAccessLayer.Contexts;
using CV.DataAccessLayer.Entities;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Repositories
{
    public class ProjectsRepository : IProjectsRepository
    {
        private CvDbContext _context;

        public ProjectsRepository(CvDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Project>> GetProjectsAsync()
        {
            return await _context.Projects.ToListAsync();
        }
    }
}
