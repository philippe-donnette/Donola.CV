using CV.Api.Controllers;
using CV.Core.Models;
using CV.Core.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace CV.Api.Tests.Controllers
{
    public class ProjectControllerTests
    {

        private readonly ProjectController _controller;
        private readonly Mock<IProjectService> _projectServiceMock;
        private readonly Mock<ILogger<ProjectController>> _loggerMock;

        public ProjectControllerTests()
        {
            _projectServiceMock = new Mock<IProjectService>();
            _loggerMock = new Mock<ILogger<ProjectController>>();
            _controller = new ProjectController(_projectServiceMock.Object, _loggerMock.Object);
        }

        #region GetImagesAsync
        [Fact]
        public void GetImagesAsync_ReturnNotFoundStatusCode()
        {
            int projectId = 1;
            _projectServiceMock.Setup(m => m.GetImagesAsync(projectId))
                .ReturnsAsync(null);
            var result = _controller.GetImagesAsync(projectId);
            var NotFoundResult = result.Result as NotFoundResult;
            NotFoundResult.Should().BeOfType<NotFoundResult>();
            Assert.Equal(NotFoundResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public void GetImagesAsync_ReturnOkStatusCode()
        {
            int projectId = 1;
            var images = new List<ImageModel>
            {
                new ImageModel { Id = 1, Title = "Image number 1", Description = "Some description 1", ImageUrl = "/someimage1.png" },
                new ImageModel { Id = 2, Title = "Image number 2", Description = "Some description 2", ImageUrl = "/someimage2.gif" },
                new ImageModel { Id = 3, Title = "Image number 3", Description = "Some description 3", ImageUrl = "/someimage3.jpg" }
            };
            _projectServiceMock.Setup(m => m.GetImagesAsync(projectId))
                .ReturnsAsync(images);
            var result = _controller.GetImagesAsync(projectId);
            var httpOkResult = result.Result as OkObjectResult;
            httpOkResult.Should().BeOfType<OkObjectResult>();
            Assert.Equal(httpOkResult.StatusCode, StatusCodes.Status200OK);
            var model = httpOkResult.Value as List<ImageModel>;
            model.Should().BeOfType<List<ImageModel>>();
            Assert.Equal(model.Count, images.Count);
        }

        [Fact]
        public void GetImagesAsync_ReturnBadRequestStatusCode()
        {
            int projectId = 1;
            _projectServiceMock.Setup(m => m.GetImagesAsync(projectId))
                .ThrowsAsync(new Exception());
            var result = _controller.GetImagesAsync(projectId);
            var httpResult = result.Result as BadRequestResult;
            httpResult.Should().BeOfType<BadRequestResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status400BadRequest);
        }
        #endregion

        #region GetProjectAsync
        [Fact]
        public void GetProjectAsync_ReturnNotFoundStatusCode()
        {
            int projectId = 1;
            _projectServiceMock.Setup(x => x.GetProjectAsync(projectId))
                .ReturnsAsync(null);
            var result = _controller.GetProjectAsync(projectId);
            var httpResult = result.Result as NotFoundResult;
            httpResult.Should().BeOfType<NotFoundResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public void GetProjectAsync_ReturnOkStatusCode()
        {
            int projectId = 1;
            var project = new ProjectModel { Id = 1, PrimaryImage = null, Description = null, Name = "CV.Web" };
            _projectServiceMock.Setup(x => x.GetProjectAsync(projectId))
                .ReturnsAsync(project);
            var result = _controller.GetProjectAsync(projectId);
            var httpResult = result.Result as OkObjectResult;
            httpResult.Should().BeOfType<OkObjectResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status200OK);
            var model = httpResult.Value as ProjectModel;
            model.Should().BeOfType<ProjectModel>();
            Assert.Equal(model.Description, project.Description);
            Assert.Equal(model.Id, project.Id);
            Assert.Equal(model.Name, project.Name);
            Assert.Equal(model.PrimaryImage, project.PrimaryImage);
        }

        [Fact]
        public void GetProjectAsync_ReturnBadRequestStatusCode()
        {
            int projectId = 1;
            _projectServiceMock.Setup(x => x.GetProjectAsync(projectId))
                .ThrowsAsync(new Exception());
            var result = _controller.GetProjectAsync(projectId);
            var httpResult = result.Result as BadRequestResult;
            httpResult.Should().BeOfType<BadRequestResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status400BadRequest);
        }
        #endregion

        #region GetProjectsAsync
        [Fact]
        public void GetProjectsAsync_ReturnNotFoundStatusCode()
        {
            _projectServiceMock.Setup(m => m.GetProjectsAsync())
                .ReturnsAsync(null);
            var result = _controller.GetProjectsAsync();
            var NotFoundResult = result.Result as NotFoundResult;
            NotFoundResult.Should().BeOfType<NotFoundResult>();
            Assert.Equal(NotFoundResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public void GetProjectsAsync_ReturnOkStatusCode()
        {
            _projectServiceMock.Setup(m => m.GetProjectsAsync())
                .ReturnsAsync(new List<ProjectModel>
                {
                    new ProjectModel { Id = 1, PrimaryImage = null, Description = null, Name = "CV.Web" },
                    new ProjectModel { Id = 1, PrimaryImage = null, Description = null, Name = "CV.Web" }
                });
            var result = _controller.GetProjectsAsync();
            var httpOkResult = result.Result as OkObjectResult;
            httpOkResult.Should().BeOfType<OkObjectResult>();
            Assert.Equal(httpOkResult.StatusCode, StatusCodes.Status200OK);
            var projects = httpOkResult.Value as List<ProjectModel>;
            projects.Should().BeOfType<List<ProjectModel>>();
            Assert.Equal(projects.Count, 2);
        }

        [Fact]
        public void GetProjectsAsync_ReturnBadRequestStatusCode()
        {
            _projectServiceMock.Setup(m => m.GetProjectsAsync())
                .ThrowsAsync(new Exception());
            var result = _controller.GetProjectsAsync();
            var httpResult = result.Result as BadRequestResult;
            httpResult.Should().BeOfType<BadRequestResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status400BadRequest);
        }
        #endregion

        #region GetSkillsAsync
        [Fact]
        public void GetSkillsAsync_ReturnNotFoundStatusCode()
        {
            int projectId = 1;
            _projectServiceMock.Setup(m => m.GetSkillsAsync(projectId))
                .ReturnsAsync(null);
            var result = _controller.GetSkillsAsync(projectId);
            var NotFoundResult = result.Result as NotFoundResult;
            NotFoundResult.Should().BeOfType<NotFoundResult>();
            Assert.Equal(NotFoundResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public void GetSkillsAsync_ReturnOkStatusCode()
        {
            int projectId = 1;
            var skills = new List<SkillModel>
            {
                new SkillModel { ExperienceRating = 10, Id = 1, InterestRating = 9, Name = "ASP.NET 5", UsageRating = 8, Weight = 9 },
                new SkillModel { ExperienceRating = 4, Id = 2, InterestRating = 5, Name = "AngularJS", UsageRating = 6, Weight = 5 },
                new SkillModel { ExperienceRating = 3, Id = 3, InterestRating = 2, Name = "Angular2", UsageRating = 1, Weight = 2 }
            };
            _projectServiceMock.Setup(m => m.GetSkillsAsync(projectId))
                .ReturnsAsync(skills);
            var result = _controller.GetSkillsAsync(projectId);
            var httpOkResult = result.Result as OkObjectResult;
            httpOkResult.Should().BeOfType<OkObjectResult>();
            Assert.Equal(httpOkResult.StatusCode, StatusCodes.Status200OK);
            var model = httpOkResult.Value as List<SkillModel>;
            model.Should().BeOfType<List<SkillModel>>();
            Assert.Equal(model.Count, skills.Count);
        }

        [Fact]
        public void GetSkillsAsync_ReturnBadRequestStatusCode()
        {
            int projectId = 1;
            _projectServiceMock.Setup(m => m.GetSkillsAsync(projectId))
                .ThrowsAsync(new Exception());
            var result = _controller.GetSkillsAsync(projectId);
            var httpResult = result.Result as BadRequestResult;
            httpResult.Should().BeOfType<BadRequestResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status400BadRequest);
        }
        #endregion
    }
}
