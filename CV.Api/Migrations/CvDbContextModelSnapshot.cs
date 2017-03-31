using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CV.DataAccessLayer.Contexts;

namespace CV.Api.Migrations
{
    [DbContext(typeof(CvDbContext))]
    partial class CvDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caption")
                        .HasMaxLength(100);

                    b.Property<string>("CaptionIconClass")
                        .HasMaxLength(100);

                    b.Property<string>("ImageBackUrl")
                        .HasMaxLength(200);

                    b.Property<string>("ImageFrontUrl")
                        .HasMaxLength(200);

                    b.Property<string>("Rotate")
                        .HasMaxLength(1);

                    b.Property<string>("TextBack")
                        .HasMaxLength(500);

                    b.Property<string>("TextFront")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasMaxLength(100);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(300);

                    b.Property<string>("Country")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .HasMaxLength(3000);

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(200);

                    b.Property<string>("RoleTitle")
                        .HasMaxLength(200);

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("WebsiteUrl")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ExperienceSkill", b =>
                {
                    b.Property<int>("ExperienceId");

                    b.Property<int>("SkillId");

                    b.Property<int>("UsageRating");

                    b.HasKey("ExperienceId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("ExperienceSkills");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ExperienceSkillVersion", b =>
                {
                    b.Property<int>("ExperienceId");

                    b.Property<int>("SkillId");

                    b.Property<int>("SkillVersionId");

                    b.HasKey("ExperienceId", "SkillId", "SkillVersionId");

                    b.HasIndex("SkillVersionId");

                    b.ToTable("ExperienceSkillVersions");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutCaption")
                        .HasMaxLength(200);

                    b.Property<string>("AboutImage")
                        .HasMaxLength(200);

                    b.Property<string>("AboutMotto")
                        .HasMaxLength(400);

                    b.Property<string>("AboutText")
                        .HasMaxLength(1000);

                    b.Property<string>("Firstname")
                        .HasMaxLength(200);

                    b.Property<string>("GitHubUrl")
                        .HasMaxLength(400);

                    b.Property<string>("HomeImage")
                        .HasMaxLength(200);

                    b.Property<string>("Lastname")
                        .HasMaxLength(200);

                    b.Property<string>("LinkedinUrl")
                        .HasMaxLength(400);

                    b.Property<string>("Occupation")
                        .HasMaxLength(200);

                    b.Property<string>("OccupationMotto")
                        .HasMaxLength(400);

                    b.Property<string>("PrimaryImage")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("PrimaryImage")
                        .HasMaxLength(200);

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(200);

                    b.Property<int>("ProjectId");

                    b.Property<string>("Title")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectImages");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectSkill", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("SkillId");

                    b.Property<int>("UsageRating");

                    b.HasKey("ProjectId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("ProjectSkills");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectSkillVersion", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("SkillId");

                    b.Property<int>("SkillVersionId");

                    b.HasKey("ProjectId", "SkillId", "SkillVersionId");

                    b.HasIndex("SkillVersionId");

                    b.ToTable("ProjectSkillVersions");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasMaxLength(200);

                    b.Property<string>("Country")
                        .HasMaxLength(200);

                    b.Property<string>("DegreeFile")
                        .HasMaxLength(200);

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(200);

                    b.Property<string>("SchoolName")
                        .HasMaxLength(200);

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Subject")
                        .HasMaxLength(200);

                    b.Property<string>("WebsiteUrl")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<int>("ExperienceRating");

                    b.Property<string>("IconClass")
                        .HasMaxLength(200);

                    b.Property<int>("InterestRating");

                    b.Property<bool>("IsVisible");

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<int>("UsageRating");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.SkillVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int>("SkillId");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillVersions");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CertificateFile")
                        .HasMaxLength(200);

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(200);

                    b.Property<string>("Provider")
                        .HasMaxLength(200);

                    b.Property<string>("Subject")
                        .HasMaxLength(200);

                    b.Property<string>("WebsiteUrl")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ExperienceSkill", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.Experience", "Experience")
                        .WithMany("Skills")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CV.DataAccessLayer.Entities.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ExperienceSkillVersion", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.SkillVersion", "Version")
                        .WithMany()
                        .HasForeignKey("SkillVersionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CV.DataAccessLayer.Entities.ExperienceSkill", "ExperienceSkill")
                        .WithMany("Versions")
                        .HasForeignKey("ExperienceId", "SkillId");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectImage", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectSkill", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.Project", "Project")
                        .WithMany("Skills")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CV.DataAccessLayer.Entities.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectSkillVersion", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.SkillVersion", "Version")
                        .WithMany()
                        .HasForeignKey("SkillVersionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CV.DataAccessLayer.Entities.ProjectSkill", "ProjectSkill")
                        .WithMany("Versions")
                        .HasForeignKey("ProjectId", "SkillId");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.SkillVersion", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.Skill", "Skill")
                        .WithMany("Versions")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
