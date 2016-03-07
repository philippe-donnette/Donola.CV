using Microsoft.Data.Entity;
using CV.DataAccessLayer.Entities;
using Microsoft.Extensions.Configuration;

namespace CV.DataAccessLayer.Contexts
{
    public class CvDbContext : DbContext
    {
        public CvDbContext()
        {
            //Database.EnsureCreated();
        }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<SkillVersion> SkillVersions { get; set; }
    }
}
