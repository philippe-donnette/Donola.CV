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
            var projects = result.Result as List<ProjectModel>;
            projects.Should().BeOfType<List<ProjectModel>>();
            Assert.Equal(projects.Count, 3);
        }

        [Fact]
        public void GetProjectsAsync_ReturnNull()
        {
            _projectRepositoryMock.Setup(m => m.GetProjectsAsync())
                .ReturnsAsync(null);
            var result = _service.GetProjectsAsync();
            var projects = result.Result as List<ProjectModel>;
            Assert.Equal(projects, null);
        }

        [Fact]
        public void GetProjectsAsync_ReturnNullWhenException()
        {
            _projectRepositoryMock.Setup(m => m.GetProjectsAsync())
                .ThrowsAsync(new System.Exception());
            var result = _service.GetProjectsAsync();
            var projects = result.Result as List<ProjectModel>;
            Assert.Equal(projects, null);
        }
    }
}
