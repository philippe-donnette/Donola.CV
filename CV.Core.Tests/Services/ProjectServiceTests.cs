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
    public class ProjectServiceTests
    {
        private readonly Mock<IProjectRepository> _projectRepositoryMock;
        private readonly IProjectService _service;
        private readonly Mock<ILogger<IProjectService>> _loggerMock;

        public ProjectServiceTests()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new CvMapperProfile());
            });
            _projectRepositoryMock = new Mock<IProjectRepository>();
            _loggerMock = new Mock<ILogger<IProjectService>>();
            _service = new ProjectService(mapperConfig.CreateMapper(), _projectRepositoryMock.Object, _loggerMock.Object);
        }

        [Fact]
        public void GetProjectAsync_ReturnProjectModel()
        {
            int projectId = 1;
            var project = new Project { Id = 1, Name = "Donola.CV", StartDate = DateTime.Now };
            _projectRepositoryMock.Setup(x => x.GetProjectAsync(projectId))
                .ReturnsAsync(project);
            var result = _service.GetProjectAsync(projectId);
            var model = result.Result as ProjectModel;
            model.Should().BeOfType<ProjectModel>();
        }

        [Fact]
        public void GetProjectAsync_ReturnNull()
        {
            int projectId = 1;
            _projectRepositoryMock.Setup(x => x.GetProjectAsync(projectId))
                .ReturnsAsync(null);
            var result = _service.GetProjectAsync(projectId);
            var model = result.Result as ProjectModel;
            Assert.Equal(model, null);
        }

        [Fact]
        public void GetProjectAsync_ReturnNullWhenExceptionThrown()
        {
            int projectId = 1;
            _projectRepositoryMock.Setup(x => x.GetProjectAsync(projectId))
                .ThrowsAsync(new Exception());
            var result = _service.GetProjectAsync(projectId);
            var model = result.Result as ProjectModel;
            Assert.Equal(model, null);
        }

        [Fact]
        public void GetProjectAsync_AssertProjectModel()
        {
            int projectId = 1;
            var project = new Project { Id = 1, Name = "Donola.CV", StartDate = DateTime.Now };
            _projectRepositoryMock.Setup(x => x.GetProjectAsync(projectId))
                .ReturnsAsync(project);
            var result = _service.GetProjectAsync(projectId);
            var model = result.Result as ProjectModel;
            Assert.Equal(model.Id, project.Id);
            Assert.Equal(model.Name, project.Name);
            Assert.Equal(model.Description, project.Description);
            Assert.Equal(model.PrimaryImage, project.PrimaryImage);
        }

        [Fact]
        public void GetProjectsAsync_ReturnListOfProjectModel()
        {
            _projectRepositoryMock.Setup(m => m.GetProjectsAsync())
                .ReturnsAsync(new List<Project>
                {
                    new Project { Id = 1, Name = "Project Number 1", Description = null, PrimaryImage = null, StartDate = DateTime.Now, Skills = null },
                    new Project { Id = 2, Name = "Project Number 2", Description = null, PrimaryImage = null, StartDate = DateTime.Now, Skills = null },
                    new Project { Id = 3, Name = "Project Number 3", Description = null, PrimaryImage = null, StartDate = DateTime.Now, Skills = null }
                });
            var result = _service.GetProjectsAsync();
            var projects = result.Result as IEnumerable<ProjectModel>;
            projects.Should().BeOfType<List<ProjectModel>>();
            Assert.Equal(projects.Count(), 3);
        }

        [Fact]
        public void GetProjectsAsync_ReturnNull()
        {
            _projectRepositoryMock.Setup(m => m.GetProjectsAsync())
                .ReturnsAsync(null);
            var result = _service.GetProjectsAsync();
            var projects = result.Result as IEnumerable<ProjectModel>;
            Assert.Equal(projects, null);
        }

        [Fact]
        public void GetProjectsAsync_ReturnNullWhenExeptionThrown()
        {
            _projectRepositoryMock.Setup(m => m.GetProjectsAsync())
                .ThrowsAsync(new Exception());
            var result = _service.GetProjectsAsync();
            var projects = result.Result as IEnumerable<ProjectModel>;
            Assert.Equal(projects, null);
        }

        [Fact]
        public void GetProjectsAsync_ReturnNullWhenException()
        {
            _projectRepositoryMock.Setup(m => m.GetProjectsAsync())
                .ThrowsAsync(new System.Exception());
            var result = _service.GetProjectsAsync();
            var projects = result.Result as IEnumerable<ProjectModel>;
            Assert.Equal(projects, null);
        }

        [Fact]
        public void GetSkillsAsync_ReturnNull()
        {
            int projectId = 1;
            _projectRepositoryMock.Setup(x => x.GetSkillsAsync(projectId))
                .ReturnsAsync(null);
            var result = _service.GetSkillsAsync(projectId);
            var skills = result.Result as IEnumerable<ProjectModel>;
            Assert.Equal(skills, null);
        }

        [Fact]
        public void GetSkillsAsync_ReturnNullWhenExceptionThrown()
        {
            int projectId = 1;
            _projectRepositoryMock.Setup(x => x.GetSkillsAsync(projectId))
                .ThrowsAsync(new Exception());
            var result = _service.GetSkillsAsync(projectId);
            var skills = result.Result as IEnumerable<ProjectModel>;
            Assert.Equal(skills, null);
        }

        [Fact]
        public void GetSkillsAsync_ReturnListOfSkillModel()
        {
            int projectId = 1;
            var projectSkill1 = new ProjectSkill { ProjectId = 1, SkillId = 1, Skill = new Skill { Id = 1, ExperienceRating = 10, InterestRating = 9, UsageRating = 8 }, UsageRating = 7 };
            var projectSkill2 = new ProjectSkill { ProjectId = 1, SkillId = 2, Skill = new Skill { Id = 1, ExperienceRating = 4, InterestRating = 3, UsageRating = 2 }, UsageRating = 1 };
            var projectSkills = new List<ProjectSkill>
            {
                projectSkill1,
                projectSkill2
            };
            _projectRepositoryMock.Setup(x => x.GetSkillsAsync(projectId))
                .ReturnsAsync(projectSkills);
            var result = _service.GetSkillsAsync(projectId);
            var skills = result.Result;
            skills.Should().BeOfType<List<SkillModel>>();
            Assert.Equal(skills.Count(), 2);
        }

        [Fact]
        public void GetSkillsAsync_WeightBasedOnUsageRatingsFromProjectSkillAndNotSkill()
        {
            int projectId = 1;
            var projectSkill1 = new ProjectSkill { ProjectId = 1, SkillId = 1, Skill = new Skill { Id = 1, ExperienceRating = 10, InterestRating = 9, UsageRating = 8 }, UsageRating = 7 };
            var projectSkill2 = new ProjectSkill { ProjectId = 1, SkillId = 2, Skill = new Skill { Id = 2, ExperienceRating = 4, InterestRating = 3, UsageRating = 2 }, UsageRating = 1 };
            var projectSkills = new List<ProjectSkill>
            {
                projectSkill1,
                projectSkill2
            };
            _projectRepositoryMock.Setup(x => x.GetSkillsAsync(projectId))
                .ReturnsAsync(projectSkills);
            var result = _service.GetSkillsAsync(projectId);
            var skills = result.Result;
            var skill1 = skills.FirstOrDefault(x => x.Id == 1);
            Assert.Equal(skill1.Weight, Convert.ToDouble((skill1.ExperienceRating + skill1.InterestRating + skill1.UsageRating) / 3));
            var skill2 = skills.FirstOrDefault(x => x.Id == 2);
            Assert.Equal(skill2.Weight, Convert.ToDouble((skill2.ExperienceRating + skill2.InterestRating + skill2.UsageRating) / 3));
        }

        [Fact]
        public void GetSkillsAsync_AssertRatings()
        {
            int projectId = 1;
            var projectSkill1 = new ProjectSkill { ProjectId = 1, SkillId = 1, Skill = new Skill { Id = 1, ExperienceRating = 10, InterestRating = 9, UsageRating = 8 }, UsageRating = 7 };
            var projectSkill2 = new ProjectSkill { ProjectId = 1, SkillId = 2, Skill = new Skill { Id = 2, ExperienceRating = 4, InterestRating = 3, UsageRating = 2 }, UsageRating = 1 };
            var projectSkills = new List<ProjectSkill>
            {
                projectSkill1,
                projectSkill2
            };
            _projectRepositoryMock.Setup(x => x.GetSkillsAsync(projectId))
                .ReturnsAsync(projectSkills);
            var result = _service.GetSkillsAsync(projectId);
            var skills = result.Result;
            var skill1 = skills.FirstOrDefault(x => x.Id == 1);
            Assert.Equal(skill1.ExperienceRating, projectSkill1.Skill.ExperienceRating);
            Assert.Equal(skill1.InterestRating, projectSkill1.Skill.InterestRating);
            Assert.Equal(skill1.UsageRating, projectSkill1.UsageRating);
            var skill2 = skills.FirstOrDefault(x => x.Id == 2);
            Assert.Equal(skill2.ExperienceRating, projectSkill2.Skill.ExperienceRating);
            Assert.Equal(skill2.InterestRating, projectSkill2.Skill.InterestRating);
            Assert.Equal(skill2.UsageRating, projectSkill2.UsageRating);
        }
    }
}
