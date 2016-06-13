using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CV.DataAccessLayer.Contexts;

namespace CV.Api.Migrations
{
    [DbContext(typeof(CvDbContext))]
    [Migration("20160613131242_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caption")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("CaptionIconClass")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("ImageBackUrl")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("ImageFrontUrl")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("Rotate")
                        .HasAnnotation("MaxLength", 1);

                    b.Property<string>("TextBack")
                        .HasAnnotation("MaxLength", 500);

                    b.Property<string>("TextFront")
                        .HasAnnotation("MaxLength", 500);

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

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
                        .HasAnnotation("MaxLength", 3000);

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("ImageUrl")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("RoleTitle")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("WebsiteUrl")
                        .HasAnnotation("MaxLength", 300);

                    b.HasKey("Id");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ExperienceSkill", b =>
                {
                    b.Property<int>("ExperienceId");

                    b.Property<int>("SkillId");

                    b.Property<int>("UsageRating");

                    b.HasKey("ExperienceId", "SkillId");

                    b.HasIndex("ExperienceId");

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

                    b.HasIndex("ExperienceId", "SkillId");

                    b.ToTable("ExperienceSkillVersions");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutCaption")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("AboutImage")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("AboutMotto")
                        .HasAnnotation("MaxLength", 400);

                    b.Property<string>("AboutText")
                        .HasAnnotation("MaxLength", 1000);

                    b.Property<string>("Firstname")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("GitHubUrl")
                        .HasAnnotation("MaxLength", 400);

                    b.Property<string>("HomeImage")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("Lastname")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("LinkedinUrl")
                        .HasAnnotation("MaxLength", 400);

                    b.Property<string>("Occupation")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("OccupationMotto")
                        .HasAnnotation("MaxLength", 400);

                    b.Property<string>("PrimaryImage")
                        .HasAnnotation("MaxLength", 200);

                    b.HasKey("Id");

                    b.ToTable("Persons");
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

                    b.ToTable("Projects");
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

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectImages");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectSkill", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("SkillId");

                    b.Property<int>("UsageRating");

                    b.HasKey("ProjectId", "SkillId");

                    b.HasIndex("ProjectId");

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

                    b.HasIndex("ProjectId", "SkillId");

                    b.ToTable("ProjectSkillVersions");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("Country")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("DegreeFile")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 1000);

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("ImageUrl")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("SchoolName")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Subject")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("WebsiteUrl")
                        .HasAnnotation("MaxLength", 200);

                    b.HasKey("Id");

                    b.ToTable("Qualifications");
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

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.SkillVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 50);

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
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 1000);

                    b.Property<string>("ImageUrl")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("Provider")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("Subject")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("WebsiteUrl")
                        .HasAnnotation("MaxLength", 200);

                    b.HasKey("Id");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ExperienceSkill", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CV.DataAccessLayer.Entities.Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ExperienceSkillVersion", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.SkillVersion")
                        .WithMany()
                        .HasForeignKey("SkillVersionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CV.DataAccessLayer.Entities.ExperienceSkill")
                        .WithMany()
                        .HasForeignKey("ExperienceId", "SkillId");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectImage", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectSkill", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CV.DataAccessLayer.Entities.Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.ProjectSkillVersion", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.SkillVersion")
                        .WithMany()
                        .HasForeignKey("SkillVersionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CV.DataAccessLayer.Entities.ProjectSkill")
                        .WithMany()
                        .HasForeignKey("ProjectId", "SkillId");
                });

            modelBuilder.Entity("CV.DataAccessLayer.Entities.SkillVersion", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
