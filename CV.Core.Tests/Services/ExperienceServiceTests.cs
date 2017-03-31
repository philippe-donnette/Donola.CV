using AutoMapper;
using CV.Core.Mappings;
using CV.Core.Models;
using CV.Core.Services;
using CV.DataAccessLayer.Entities;
using CV.DataAccessLayer.Repositories;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CV.Core.Tests.Services
{
    public class ExperienceServiceTests
    {
        private readonly Mock<IExperienceRepository> _experienceRepositoryMock;
        private readonly IExperienceService _service;
        private readonly Mock<ILogger<IExperienceService>> _loggerMock;

        public ExperienceServiceTests()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new CvMapperProfile());
            });
            _experienceRepositoryMock = new Mock<IExperienceRepository>();
            _loggerMock = new Mock<ILogger<IExperienceService>>();
            _service = new ExperienceService(mapperConfig.CreateMapper(), _experienceRepositoryMock.Object, _loggerMock.Object);
        }

        #region GetExperienceAsync
        [Fact]
        public void GetExperienceAsync_ReturnExperienceModel()
        {
            int experienceId = 1;
            var experience = new Experience { Id = 1, CompanyName = "Donola.CV", StartDate = DateTime.Now };
            _experienceRepositoryMock.Setup(x => x.GetExperienceAsync(experienceId))
                .ReturnsAsync(experience);
            var result = _service.GetExperienceAsync(experienceId);
            var model = result.Result as ExperienceModel;
            model.Should().BeOfType<ExperienceModel>();
        }

        [Fact]
        public void GetExperienceAsync_ReturnNull()
        {
            int experienceId = 1;
            _experienceRepositoryMock.Setup(x => x.GetExperienceAsync(experienceId))
                .ReturnsAsync((Experience)null);
            var result = _service.GetExperienceAsync(experienceId);
            var model = result.Result as ExperienceModel;
            Assert.Equal(model, null);
        }

        [Fact]
        public void GetExperienceAsync_ReturnNullWhenExceptionThrown()
        {
            int experienceId = 1;
            _experienceRepositoryMock.Setup(x => x.GetExperienceAsync(experienceId))
                .ThrowsAsync(new Exception());
            var result = _service.GetExperienceAsync(experienceId);
            var model = result.Result as ExperienceModel;
            Assert.Equal(model, null);
        }

        [Fact]
        public void GetExperienceAsync_AssertExperienceModel()
        {
            int experienceId = 1;
            var experience = new Experience { Id = 1, CompanyName = "Some company", StartDate = DateTime.Now };
            _experienceRepositoryMock.Setup(x => x.GetExperienceAsync(experienceId))
                .ReturnsAsync(experience);
            var result = _service.GetExperienceAsync(experienceId);
            var model = result.Result as ExperienceModel;
            Assert.Equal(model.Id, experience.Id);
            Assert.Equal(model.CompanyName, experience.CompanyName);
            Assert.Equal(model.Description, experience.Description);
            Assert.Equal(model.StartDate, experience.StartDate);
        }
        #endregion

        #region GetExperiencesAsync
        [Fact]
        public void GetExperiencesAsync_ReturnListOfExperienceModel()
        {
            _experienceRepositoryMock.Setup(m => m.GetExperiencesAsync())
                .ReturnsAsync(new List<Experience>
                {
                    new Experience { Id = 1, CompanyName = "Company Number 1", Description = null, ImageUrl = null, StartDate = DateTime.Now, Skills = null },
                    new Experience { Id = 2, CompanyName = "Company Number 2", Description = null, ImageUrl = null, StartDate = DateTime.Now, Skills = null },
                    new Experience { Id = 3, CompanyName = "Company Number 3", Description = null, ImageUrl = null, StartDate = DateTime.Now, Skills = null }
                });
            var result = _service.GetExperiencesAsync();
            var experiences = result.Result as IEnumerable<ExperienceModel>;
            experiences.Should().BeOfType<List<ExperienceModel>>();
            Assert.Equal(experiences.Count(), 3);
        }

        [Fact]
        public void GetExperiencesAsync_ReturnNull()
        {
            _experienceRepositoryMock.Setup(m => m.GetExperiencesAsync())
                .ReturnsAsync((IEnumerable<Experience>)null);
            var result = _service.GetExperiencesAsync();
            var experiences = result.Result as IEnumerable<ExperienceModel>;
            Assert.Equal(experiences, null);
        }

        [Fact]
        public void GetExperiencesAsync_ReturnNullWhenExeptionThrown()
        {
            _experienceRepositoryMock.Setup(m => m.GetExperiencesAsync())
                .ThrowsAsync(new Exception());
            var result = _service.GetExperiencesAsync();
            var experiences = result.Result as IEnumerable<ExperienceModel>;
            Assert.Equal(experiences, null);
        }
        #endregion

        #region GetSkillsAsync
        [Fact]
        public void GetSkillsAsync_ReturnNull()
        {
            int experienceId = 1;
            _experienceRepositoryMock.Setup(x => x.GetSkillsAsync(experienceId))
                .ReturnsAsync((IEnumerable<ExperienceSkill>)null);
            var result = _service.GetSkillsAsync(experienceId);
            var skills = result.Result as IEnumerable<ExperienceModel>;
            Assert.Equal(skills, null);
        }

        [Fact]
        public void GetSkillsAsync_ReturnNullWhenExceptionThrown()
        {
            int experienceId = 1;
            _experienceRepositoryMock.Setup(x => x.GetSkillsAsync(experienceId))
                .ThrowsAsync(new Exception());
            var result = _service.GetSkillsAsync(experienceId);
            var skills = result.Result as IEnumerable<ExperienceModel>;
            Assert.Equal(skills, null);
        }

        [Fact]
        public void GetSkillsAsync_ReturnListOfSkillModel()
        {
            int experienceId = 1;
            var experienceSkill1 = new ExperienceSkill { ExperienceId = 1, SkillId = 1, Skill = new Skill { Id = 1, ExperienceRating = 10, InterestRating = 9, UsageRating = 8 }, UsageRating = 7 };
            var experienceSkill2 = new ExperienceSkill { ExperienceId = 1, SkillId = 2, Skill = new Skill { Id = 1, ExperienceRating = 4, InterestRating = 3, UsageRating = 2 }, UsageRating = 1 };
            var experienceSkills = new List<ExperienceSkill>
            {
                experienceSkill1,
                experienceSkill2
            };
            _experienceRepositoryMock.Setup(x => x.GetSkillsAsync(experienceId))
                .ReturnsAsync(experienceSkills);
            var result = _service.GetSkillsAsync(experienceId);
            var skills = result.Result;
            skills.Should().BeOfType<List<SkillModel>>();
            Assert.Equal(skills.Count(), 2);
        }

        [Fact]
        public void GetSkillsAsync_WeightBasedOnUsageRatingsFromExperienceSkillAndNotSkill()
        {
            int experienceId = 1;
            var experienceSkill1 = new ExperienceSkill { ExperienceId = 1, SkillId = 1, Skill = new Skill { Id = 1, ExperienceRating = 10, InterestRating = 9, UsageRating = 8 }, UsageRating = 7 };
            var experienceSkill2 = new ExperienceSkill { ExperienceId = 1, SkillId = 2, Skill = new Skill { Id = 2, ExperienceRating = 4, InterestRating = 3, UsageRating = 2 }, UsageRating = 1 };
            var experienceSkills = new List<ExperienceSkill>
            {
                experienceSkill1,
                experienceSkill2
            };
            _experienceRepositoryMock.Setup(x => x.GetSkillsAsync(experienceId))
                .ReturnsAsync(experienceSkills);
            var result = _service.GetSkillsAsync(experienceId);
            var skills = result.Result;
            var skill1 = skills.FirstOrDefault(x => x.Id == 1);
            Assert.Equal(skill1.Weight, experienceSkill1.UsageRating);
            var skill2 = skills.FirstOrDefault(x => x.Id == 2);
            Assert.Equal(skill2.Weight, experienceSkill2.UsageRating);
        }

        [Fact]
        public void GetSkillsAsync_AssertRatings()
        {
            int experienceId = 1;
            var experienceSkill1 = new ExperienceSkill { ExperienceId = 1, SkillId = 1, Skill = new Skill { Id = 1, ExperienceRating = 10, InterestRating = 9, UsageRating = 8 }, UsageRating = 7 };
            var experienceSkill2 = new ExperienceSkill { ExperienceId = 1, SkillId = 2, Skill = new Skill { Id = 2, ExperienceRating = 4, InterestRating = 3, UsageRating = 2 }, UsageRating = 1 };
            var experienceSkills = new List<ExperienceSkill>
            {
                experienceSkill1,
                experienceSkill2
            };
            _experienceRepositoryMock.Setup(x => x.GetSkillsAsync(experienceId))
                .ReturnsAsync(experienceSkills);
            var result = _service.GetSkillsAsync(experienceId);
            var skills = result.Result;
            var skill1 = skills.FirstOrDefault(x => x.Id == 1);
            Assert.Equal(skill1.ExperienceRating, experienceSkill1.Skill.ExperienceRating);
            Assert.Equal(skill1.InterestRating, experienceSkill1.Skill.InterestRating);
            Assert.Equal(skill1.UsageRating, experienceSkill1.UsageRating);
            var skill2 = skills.FirstOrDefault(x => x.Id == 2);
            Assert.Equal(skill2.ExperienceRating, experienceSkill2.Skill.ExperienceRating);
            Assert.Equal(skill2.InterestRating, experienceSkill2.Skill.InterestRating);
            Assert.Equal(skill2.UsageRating, experienceSkill2.UsageRating);
        }
        #endregion
    }
}
