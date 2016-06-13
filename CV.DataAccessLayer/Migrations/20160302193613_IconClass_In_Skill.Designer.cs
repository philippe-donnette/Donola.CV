using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using CV.DataAccessLayer.Contexts;

namespace CV.DataAccessLayer.Migrations
{
    [DbContext(typeof(CvDbContext))]
    [Migration("20160302193613_IconClass_In_Skill")]
    partial class IconClass_In_Skill
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CV.DataAccessLayer.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");
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

            modelBuilder.Entity("CV.DataAccessLayer.Entities.SkillVersion", b =>
                {
                    b.HasOne("CV.DataAccessLayer.Entities.Skill")
                        .WithMany()
                        .HasForeignKey("SkillId");
                });
        }
    }
}
