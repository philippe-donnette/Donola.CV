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
    public class SkillsControllerTests
    {

        private readonly SkillsController _controller;
        private readonly Mock<ISkillsService> _skillsServiceMock;
        private readonly Mock<ILogger<SkillsController>> _loggerMock;

        public SkillsControllerTests()
        {
            _skillsServiceMock = new Mock<ISkillsService>();
            _loggerMock = new Mock<ILogger<SkillsController>>();
            _controller = new SkillsController(_skillsServiceMock.Object, _loggerMock.Object);
        }

        [Fact]
        public void GetSkillsAsync_ReturnNotFoundStatusCode()
        {
            _skillsServiceMock.Setup(m => m.GetSkillsAsync())
                .ReturnsAsync(null);
            var result = _controller.GetSkillsAsync();
            var httpNotFoundResult = result.Result as HttpNotFoundResult;
            httpNotFoundResult.Should().BeOfType<HttpNotFoundResult>();
            Assert.Equal(httpNotFoundResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public void GetSkillsAsync_ReturnOkStatusCode()
        {
            _skillsServiceMock.Setup(m => m.GetSkillsAsync())
                .ReturnsAsync(new List<SkillModel>
                {
                    new SkillModel
                    {
                        Id = 1, ExperienceRating = 10, InterestRating = 9, Name = "ASP.NET 5", UsageRating = 8,
                        Description = "A description about asp.net 5",
                        Versions = new List<string> { "RC1", "RC2" }
                    },
                    new SkillModel { Id = 2, ExperienceRating = 5, InterestRating = 6, Name = "AngularJS", UsageRating = 7 }
                });
            var result = _controller.GetSkillsAsync();
            var httpOkResult = result.Result as HttpOkObjectResult;
            httpOkResult.Should().BeOfType<HttpOkObjectResult>();
            Assert.Equal(httpOkResult.StatusCode, StatusCodes.Status200OK);
            var skills = httpOkResult.Value as List<SkillModel>;
            skills.Should().BeOfType<List<SkillModel>>();
            Assert.Equal(skills.Count, 2);
            Assert.Equal(skills.FirstOrDefault(x => x.Id == 1).Versions.Count, 2);
            Assert.Equal(skills.FirstOrDefault(x => x.Id == 2).Versions, null);
        }

        [Fact]
        public void GetSkillsAsync_ReturnBadRequestStatusCode()
        {
            _skillsServiceMock.Setup(m => m.GetSkillsAsync())
                .ThrowsAsync(new Exception());
            var result = _controller.GetSkillsAsync();
            var httpResult = result.Result as BadRequestResult;
            httpResult.Should().BeOfType<BadRequestResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status400BadRequest);
        }
    }
}
