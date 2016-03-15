using Microsoft.Data.Entity;
using CV.DataAccessLayer.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.Entity.Metadata;

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
        public DbSet<ProjectSkill> ProjectSkills { get; set; }
        public DbSet<ProjectSkillVersion> ProjectSkillVersions { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectSkill>()
                .HasKey(x => new { x.ProjectId, x.SkillId });
            modelBuilder.Entity<ProjectSkillVersion>()
                .HasKey(x => new { x.ProjectId, x.SkillId, x.SkillVersionId });

            modelBuilder.Entity<ProjectSkillVersion>()
                .HasOne(x => x.ProjectSkill)
                .WithMany(x => x.Versions)
                .HasForeignKey(x => new { x.ProjectId, x.SkillId })
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
