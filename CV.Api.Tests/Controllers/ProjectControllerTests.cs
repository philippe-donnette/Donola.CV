using CV.Api.Controllers;
using CV.Core.Models;
using CV.Core.Services;
using FluentAssertions;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [Fact]
        public void GetProjectsAsync_ReturnNotFoundStatusCode()
        {
            _projectServiceMock.Setup(m => m.GetProjectsAsync())
                .ReturnsAsync(null);
            var result = _controller.GetProjectsAsync();
            var httpNotFoundResult = result.Result as HttpNotFoundResult;
            httpNotFoundResult.Should().BeOfType<HttpNotFoundResult>();
            Assert.Equal(httpNotFoundResult.StatusCode, StatusCodes.Status404NotFound);
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
            var httpOkResult = result.Result as HttpOkObjectResult;
            httpOkResult.Should().BeOfType<HttpOkObjectResult>();
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
    }
}
