using AutoMapper;
using CV.Core.Mappings;
using CV.Core.Models;
using CV.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CV.Core.Tests.Mappings
{
    public class MapperProfileTests
    {
        private readonly MapperConfiguration _mapperConfig;
        private readonly IMapper _mapper;

        public MapperProfileTests()
        {
            _mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new CvMapperProfile());
            });
            _mapper = _mapperConfig.CreateMapper();
        }

        [Fact]
        public void CvMapperProfile_IsValid()
        {
            _mapperConfig.AssertConfigurationIsValid();
        }

        [Fact]
        public void SkillToSkillModel()
        {
            var version1 = new SkillVersion { Id = 1, Name = "RC1", SkillId = 1 };
            var version2 = new SkillVersion { Id = 2, Name = "RC2", SkillId = 1 };
            var skill1 = new Skill
            {
                Id = 1,
                ExperienceRating = 10,
                InterestRating = 9,
                Name = "ASP.NET 5",
                UsageRating = 8,
                Description = "A description about asp.net 5",
                IconClass = "fa fa-something",
                IsVisible = true,
                Versions = new List<SkillVersion> { version1, version2 }
            };
            var skill2 = new Skill
            {
                Id = 2,
                ExperienceRating = 5,
                InterestRating = 6,
                Name = "AngularJS",
                UsageRating = 7,
                Description = "A description about AngularJS",
                IconClass = "fa fa-something",
                IsVisible = true,
                Versions = null
            };

            var skills = new List<Skill>
            {
                skill1,
                skill2
            };

            var model = _mapper.Map<IEnumerable<SkillModel>>(skills);

            var model1 = model.FirstOrDefault(x => x.Id == skill1.Id);
            Assert.Equal(skill1.Description, model1.Description);
            Assert.Equal(skill1.ExperienceRating, model1.ExperienceRating);
            Assert.Equal(skill1.IconClass, model1.IconClass);
            Assert.Equal(skill1.Id, model1.Id);
            Assert.Equal(skill1.InterestRating, model1.InterestRating);
            Assert.Equal(skill1.Name, model1.Name);
            Assert.Equal(skill1.UsageRating, model1.UsageRating);
            Assert.Equal(Convert.ToDouble((skill1.InterestRating + skill1.ExperienceRating + skill1.UsageRating) / 3), model1.Weight);
            Assert.Equal(skill1.Versions.Select(x => x.Name).ToList<string>(), model1.Versions);

            var model2 = model.FirstOrDefault(x => x.Id == skill2.Id);
            Assert.Equal(skill2.Description, model2.Description);
            Assert.Equal(skill2.ExperienceRating, model2.ExperienceRating);
            Assert.Equal(skill2.IconClass, model2.IconClass);
            Assert.Equal(skill2.Id, model2.Id);
            Assert.Equal(skill2.InterestRating, model2.InterestRating);
            Assert.Equal(skill2.Name, model2.Name);
            Assert.Equal(skill2.UsageRating, model2.UsageRating);
            Assert.Equal(Convert.ToDouble((skill2.InterestRating + skill2.ExperienceRating + skill2.UsageRating) / 3), model2.Weight);
            Assert.Equal(model2.Versions.Count, 0);
        }

        [Fact]
        public void ProjectToProjectModel()
        {
            var project1 = new Project { Id = 1, Name = "Project Number 1", Description = null, PrimaryImage = null, StartDate = DateTime.Now, Skills = null };
            var project2 = new Project { Id = 2, Name = "Project Number 2", Description = null, PrimaryImage = null, StartDate = DateTime.Now, Skills = null };
            var project3 = new Project { Id = 3, Name = "Project Number 3", Description = null, PrimaryImage = null, StartDate = DateTime.Now, Skills = null };
            var projects = new List<Project> { project1, project2, project3 };

            var model = _mapper.Map<IEnumerable<ProjectModel>>(projects);

            var model1 = model.FirstOrDefault(x => x.Id == project1.Id);
            Assert.Equal(project1.Description, model1.Description);
            Assert.Equal(project1.Id, model1.Id);
            Assert.Equal(project1.Name, model1.Name);
            Assert.Equal(project1.PrimaryImage, model1.PrimaryImage);
            Assert.Equal(project1.StartDate, model1.StartDate);

            var model2 = model.FirstOrDefault(x => x.Id == project2.Id);
            Assert.Equal(project2.Description, model2.Description);
            Assert.Equal(project2.Id, model2.Id);
            Assert.Equal(project2.Name, model2.Name);
            Assert.Equal(project2.PrimaryImage, model2.PrimaryImage);
            Assert.Equal(project2.StartDate, model2.StartDate);

            var model3 = model.FirstOrDefault(x => x.Id == project3.Id);
            Assert.Equal(project3.Description, model3.Description);
            Assert.Equal(project3.Id, model3.Id);
            Assert.Equal(project3.Name, model3.Name);
            Assert.Equal(project3.PrimaryImage, model3.PrimaryImage);
            Assert.Equal(project3.StartDate, model3.StartDate);
        }

        [Fact]
        public void ProjectSkillToSkillModel()
        {
            var projectSkill1 = new ProjectSkill { ProjectId = 1, SkillId = 1,
                Skill = new Skill { Id = 1, ExperienceRating = 10, InterestRating = 9, UsageRating = 8 },
                UsageRating = 7,
                Versions = new List<ProjectSkillVersion>
                {
                    new ProjectSkillVersion { ProjectId = 1, SkillId = 1, SkillVersionId = 1, Version = new SkillVersion { Name = "RC1", Id = 1, SkillId = 1 } },
                    new ProjectSkillVersion { ProjectId = 1, SkillId = 1, SkillVersionId = 2, Version = new SkillVersion { Name = "RC2", Id = 2, SkillId = 1 } }
                }
            };
            
            var model1 = _mapper.Map<SkillModel>(projectSkill1);

            Assert.Equal(projectSkill1.Skill.Description, model1.Description);
            Assert.Equal(projectSkill1.Skill.ExperienceRating, model1.ExperienceRating);
            Assert.Equal(projectSkill1.Skill.IconClass, model1.IconClass);
            Assert.Equal(projectSkill1.Skill.Id, model1.Id);
            Assert.Equal(projectSkill1.Skill.InterestRating, model1.InterestRating);
            Assert.Equal(projectSkill1.Skill.Name, model1.Name);
            Assert.Equal(projectSkill1.UsageRating, model1.UsageRating);
            Assert.Equal(projectSkill1.UsageRating, model1.Weight);
            Assert.Equal(projectSkill1.Versions.Select(x => x.Version.Name).ToList<string>(), model1.Versions);

            var projectSkill2 = new ProjectSkill
            {
                ProjectId = 2,
                SkillId = 2,
                Skill = new Skill { Id = 2, ExperienceRating = 4, InterestRating = 5, UsageRating = 6 },
                UsageRating = 8,
                Versions = null
            };

            var model2 = _mapper.Map<SkillModel>(projectSkill2);

            Assert.Equal(projectSkill2.Skill.Description, model2.Description);
            Assert.Equal(projectSkill2.Skill.ExperienceRating, model2.ExperienceRating);
            Assert.Equal(projectSkill2.Skill.IconClass, model2.IconClass);
            Assert.Equal(projectSkill2.Skill.Id, model2.Id);
            Assert.Equal(projectSkill2.Skill.InterestRating, model2.InterestRating);
            Assert.Equal(projectSkill2.Skill.Name, model2.Name);
            Assert.Equal(projectSkill2.UsageRating, model2.UsageRating);
            Assert.Equal(projectSkill2.UsageRating, model2.Weight);
            Assert.Equal(model2.Versions.Count, 0);
        }
    }
}
