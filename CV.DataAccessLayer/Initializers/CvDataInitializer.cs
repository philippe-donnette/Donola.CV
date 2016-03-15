﻿using CV.DataAccessLayer.Contexts;
using CV.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Initializers
{
    public static class CvDataInitializer
    {
        public static void EnsureSeedData(this CvDbContext context)
        {
            CreateSkills(context);
            CreateProjects(context);

            AddProjectSkillVersions(context);
            AddProjectImages(context);
        }

        private static int CreateSkills(CvDbContext context)
        {
            if (!context.Skills.Any())
            {
                context.Skills.Add(new Skill
                {
                    ExperienceRating = 3,
                    InterestRating = 10,
                    Name = "ASP.NET 5",
                    UsageRating = 6,
                    Description = "Latest Microsoft dotnet awesomnitude",
                    IconClass = "fa fa-eye",
                    IsVisible = true,
                    Versions = new List<SkillVersion>
                    {
                        new SkillVersion { Name = "RC1" },
                        new SkillVersion { Name = "RC2" }
                    }
                });
                context.Skills.Add(new Skill
                {
                    ExperienceRating = 6,
                    InterestRating = 10,
                    Name = "AngularJS",
                    UsageRating = 8,
                    Description = "Top google javascript framework",
                    IconClass = "fa fa-google",
                    IsVisible = true,
                    Versions = new List<SkillVersion>
                    {
                        new SkillVersion { Name = "1.3" },
                        new SkillVersion { Name = "1.4" },
                        new SkillVersion { Name = "1.5" }
                    }
                });
                context.Skills.Add(new Skill
                {
                    ExperienceRating = 3,
                    InterestRating = 6,
                    Name = "AutoMapper",
                    UsageRating = 4,
                    Description = "Mapping library to convert entities to dtos",
                    IconClass = "fa fa-arrow",
                    IsVisible = true
                });
            }

            return context.SaveChanges();
        }

        private static int CreateProjects(CvDbContext context)
        {
            
            if (!context.Projects.Any())
            {
                var skills = new List<Skill>
                {
                    new Skill { Id = 1 }
                };
                context.Projects.Add(new Project
                {
                    Description = "My CV website and my details",
                    Name = "MyCV",
                    PrimaryImage = "project-icon-10.png",
                    StartDate = new DateTime(2016, 3, 1),
                    Skills = new List<ProjectSkill>
                    {
                        new ProjectSkill { SkillId = 1, UsageRating = 8 },
                        new ProjectSkill { SkillId = 2, UsageRating = 7 },
                        new ProjectSkill { SkillId = 3, UsageRating = 5 }
                    }
                });
                context.Projects.Add(new Project
                {
                    Description = "Family photos driven by a tag engine",
                    Name = "Donola Photos",
                    PrimaryImage = "project-icon-7.png",
                    StartDate = new DateTime(2015, 12, 7),
                    Skills = new List<ProjectSkill>
                    {
                        new ProjectSkill { SkillId = 2, UsageRating = 7 }
                    }
                });
            }

            return context.SaveChanges();
        }

        private static int AddProjectSkillVersions(CvDbContext context)
        {

            if (!context.ProjectSkillVersions.Any())
            {
                context.ProjectSkillVersions.Add(new ProjectSkillVersion
                {
                    ProjectId = 1,
                    SkillId = 1,
                    SkillVersionId = 1
                });

                context.ProjectSkillVersions.Add(new ProjectSkillVersion
                {
                    ProjectId = 1,
                    SkillId = 2,
                    SkillVersionId = 3
                });

                context.ProjectSkillVersions.Add(new ProjectSkillVersion
                {
                    ProjectId = 2,
                    SkillId = 2,
                    SkillVersionId = 3
                });

                context.ProjectSkillVersions.Add(new ProjectSkillVersion
                {
                    ProjectId = 2,
                    SkillId = 2,
                    SkillVersionId = 4
                });
            }

            return context.SaveChanges();
        }

        private static int AddProjectImages(CvDbContext context)
        {

            if (!context.ProjectImages.Any())
            {
                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Some description image 1",
                    ImageUrl = "img1.png",
                    ProjectId = 1,
                    Title = "Title Image 1"
                });

                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Some description image 2",
                    ImageUrl = "img2.png",
                    ProjectId = 1,
                    Title = "Title Image 2"
                });

                context.ProjectImages.Add(new ProjectImage
                {
                    Description = "Some description image 3",
                    ImageUrl = "thor.jpg",
                    ProjectId = 2,
                    Title = "Title Image 3"
                });
            }

            return context.SaveChanges();
        }
    }
}
