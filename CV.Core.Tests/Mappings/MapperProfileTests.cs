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
            Assert.Equal(skill1.Versions.Select(x => x.Name).ToList<string>(), model1.Versions);

            var model2 = model.FirstOrDefault(x => x.Id == skill2.Id);
            Assert.Equal(skill2.Description, model2.Description);
            Assert.Equal(skill2.ExperienceRating, model2.ExperienceRating);
            Assert.Equal(skill2.IconClass, model2.IconClass);
            Assert.Equal(skill2.Id, model2.Id);
            Assert.Equal(skill2.InterestRating, model2.InterestRating);
            Assert.Equal(skill2.Name, model2.Name);
            Assert.Equal(skill2.UsageRating, model2.UsageRating);
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
    }
}
