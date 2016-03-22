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
            CreateExperiences(context);
            CreatePerson(context);

            AddProjectSkillVersions(context);
            AddProjectImages(context);
            AddExperienceSkillVersions(context);
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

        private static int CreateExperiences(CvDbContext context)
        {

            if (!context.Experiences.Any())
            {
                context.Experiences.Add(new Experience
                {
                    City = "London",
                    CompanyName = "University of London",
                    Country = "United Kingdom",
                    EndDate = new DateTime(2016, 4, 30),
                    ImageUrl = "uol-experience-icon.png",
                    RoleTitle = "Senior Developer",
                    WebsiteUrl = "http://www.london.ac.uk",
                    Description = "<p>Some description about the role goes here, do not make it too long as this is not something people might be very interested to read</p><ul><li>bazinga</li><li>kaouabounga</li><li>yata</li></ul>",
                    StartDate = new DateTime(2012, 4, 17),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill { SkillId = 1, UsageRating = 3 },
                        new ExperienceSkill { SkillId = 2, UsageRating = 9 },
                        new ExperienceSkill { SkillId = 3, UsageRating = 2 }
                    }
                });
                context.Experiences.Add(new Experience
                {
                    City = "London",
                    CompanyName = "DOCDATA",
                    Country = "United Kingdom",
                    EndDate = new DateTime(2012, 3, 30),
                    ImageUrl = "docdata-experience-icon.png",
                    RoleTitle = "Senior Developer",
                    WebsiteUrl = "http://www.docdata.ac.uk",
                    Description = "<p>Some description about the role goes here, do not make it too long as this is not something people might be very interested to read</p><ul><li>bazinga</li><li>kaouabounga</li><li>yata</li></ul>",
                    StartDate = new DateTime(2011, 4, 1),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill { SkillId = 1, UsageRating = 9 },
                        new ExperienceSkill { SkillId = 3, UsageRating = 7 }
                    }
                });
                context.Experiences.Add(new Experience
                {
                    City = "London",
                    CompanyName = "GroovyTrain",
                    Country = "United Kingdom",
                    EndDate = new DateTime(2011, 3, 20),
                    ImageUrl = "groovytrain-experience-icon.png",
                    RoleTitle = "Dotnet Developer",
                    WebsiteUrl = null,
                    Description = "<p>Some description about the role goes here, do not make it too long as this is not something people might be very interested to read</p><ul><li>bazinga</li><li>kaouabounga</li><li>yata</li></ul>",
                    StartDate = new DateTime(2010, 9, 20),
                    Skills = new List<ExperienceSkill>
                    {
                        new ExperienceSkill { SkillId = 2, UsageRating = 6 },
                        new ExperienceSkill { SkillId = 3, UsageRating = 8 }
                    }
                });
            }

            return context.SaveChanges();
        }

        private static int CreatePerson(CvDbContext context)
        {
            var deletePerson = context.Persons.SingleOrDefault();
            if (deletePerson != null)
                context.Persons.Remove(deletePerson);

            var person = new Person();
                
            person.AboutCaption = "Software & Web Developer";
            person.AboutMotto = "10 Years Experience in Software Development";
            person.AboutText = "<p>Some bla bla a bit bla bla every where</p>";
            person.AboutImage = "user.png";
            person.Firstname = "Philippe";
            person.Lastname = "Donnette";
            person.GitHubUrl = "https://github.com/philippe-donnette";
            person.HomeImage = "wordcloud-1.png";
            person.LinkedinUrl = "https://www.linkedin.com/in/philippe-donnette-2bb80b4";
            person.Occupation = "Software & Web Developer";
            person.OccupationMotto = "10 Years Experience in Software Development";
            person.PrimaryImage = "user.png";

            context.Persons.Add(person);

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

        private static int AddExperienceSkillVersions(CvDbContext context)
        {

            if (!context.ExperienceSkillVersions.Any())
            {
                context.ExperienceSkillVersions.Add(new ExperienceSkillVersion
                {
                    ExperienceId = 1,
                    SkillId = 1,
                    SkillVersionId = 2
                });

                context.ExperienceSkillVersions.Add(new ExperienceSkillVersion
                {
                    ExperienceId = 1,
                    SkillId = 2,
                    SkillVersionId = 4
                });

                context.ExperienceSkillVersions.Add(new ExperienceSkillVersion
                {
                    ExperienceId = 1,
                    SkillId = 2,
                    SkillVersionId = 5
                });

                context.ExperienceSkillVersions.Add(new ExperienceSkillVersion
                {
                    ExperienceId = 2,
                    SkillId = 1,
                    SkillVersionId = 1
                });

                context.ExperienceSkillVersions.Add(new ExperienceSkillVersion
                {
                    ExperienceId = 2,
                    SkillId = 1,
                    SkillVersionId = 2
                });

                context.ExperienceSkillVersions.Add(new ExperienceSkillVersion
                {
                    ExperienceId = 3,
                    SkillId = 2,
                    SkillVersionId = 3
                });

                context.ExperienceSkillVersions.Add(new ExperienceSkillVersion
                {
                    ExperienceId = 3,
                    SkillId = 2,
                    SkillVersionId = 4
                });

                context.ExperienceSkillVersions.Add(new ExperienceSkillVersion
                {
                    ExperienceId = 3,
                    SkillId = 2,
                    SkillVersionId = 5
                });
            }

            return context.SaveChanges();
        }
    }
}
