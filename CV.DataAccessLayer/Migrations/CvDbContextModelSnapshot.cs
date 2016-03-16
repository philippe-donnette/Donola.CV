using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using CV.DataAccessLayer.Contexts;

namespace CV.DataAccessLayer.Migrations
{
    [DbContext(typeof(CvDbContext))]
    partial class CvDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("CompanyName")
                        .HasAnnotation("MaxLength", 300);

                    b.Property<string>("Country")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 1000);

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("ImageUrl")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("RoleTitle")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("WebsiteUrl")
                        .HasAnnotation("MaxLength", 300);

                    b.HasKey("Id");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ExperienceSkill", b =>
                {
                    b.Property<int>("ExperienceId");

                    b.Property<int>("SkillId");

                    b.Property<int>("UsageRating");

                    b.HasKey("ExperienceId", "SkillId");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ExperienceSkillVersion", b =>
                {
                    b.Property<int>("ExperienceId");

                    b.Property<int>("SkillId");

                    b.Property<int>("SkillVersionId");

                    b.HasKey("ExperienceId", "SkillId", "SkillVersionId");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 1000);

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("PrimaryImage")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 500);

                    b.Property<string>("ImageUrl")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<int>("ProjectId");

                    b.Property<string>("Title")
                        .HasAnnotation("MaxLength", 200);

                    b.HasKey("Id");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectSkill", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("SkillId");

                    b.Property<int>("UsageRating");

                    b.HasKey("ProjectId", "SkillId");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectSkillVersion", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("SkillId");

                    b.Property<int>("SkillVersionId");

                    b.HasKey("ProjectId", "SkillId", "SkillVersionId");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 500);

                    b.Property<int>("ExperienceRating");

                    b.Property<string>("IconClass")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<int>("InterestRating");

                    b.Property<bool>("IsVisible");

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<int>("UsageRating");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.SkillVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<int>("SkillId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ExperienceSkill", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId");

                    b.HasOne("CV.DataAccessLayer.Entities.Skill")
                        .WithMany()
                        .HasForeignKey("SkillId");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ExperienceSkillVersion", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.SkillVersion")
                        .WithMany()
                        .HasForeignKey("SkillVersionId");

                    b.HasOne("CV.DataAccessLayer.Entities.ExperienceSkill")
                        .WithMany()
                        .HasForeignKey("ExperienceId", "SkillId");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectImage", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectSkill", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.HasOne("CV.DataAccessLayer.Entities.Skill")
                        .WithMany()
                        .HasForeignKey("SkillId");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectSkillVersion", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.SkillVersion")
                        .WithMany()
                        .HasForeignKey("SkillVersionId");

                    b.HasOne("CV.DataAccessLayer.Entities.ProjectSkill")
                        .WithMany()
                        .HasForeignKey("ProjectId", "SkillId");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.SkillVersion", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.Skill")
                        .WithMany()
                        .HasForeignKey("SkillId");
                });
        }
    }
}
