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
using System.Linq;
using Xunit;

namespace CV.Api.Tests.Controllers
{
    public class SkillControllerTests
    {

        private readonly SkillController _controller;
        private readonly Mock<ISkillService> _skillServiceMock;
        private readonly Mock<ILogger<SkillController>> _loggerMock;

        public SkillControllerTests()
        {
            _skillServiceMock = new Mock<ISkillService>();
            _loggerMock = new Mock<ILogger<SkillController>>();
            _controller = new SkillController(_skillServiceMock.Object, _loggerMock.Object);
        }

        [Fact]
        public void GetSkillsAsync_ReturnNotFoundStatusCode()
        {
            _skillServiceMock.Setup(m => m.GetSkillsAsync())
                .ReturnsAsync(null);
            var result = _controller.GetSkillsAsync();
            var notFoundResult = result.Result as NotFoundResult;
            notFoundResult.Should().BeOfType<NotFoundResult>();
            Assert.Equal(notFoundResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public void GetSkillsAsync_ReturnOkStatusCode()
        {
            _skillServiceMock.Setup(m => m.GetSkillsAsync())
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
            var httpOkResult = result.Result as OkObjectResult;
            httpOkResult.Should().BeOfType<OkObjectResult>();
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
            _skillServiceMock.Setup(m => m.GetSkillsAsync())
                .ThrowsAsync(new Exception());
            var result = _controller.GetSkillsAsync();
            var httpResult = result.Result as BadRequestResult;
            httpResult.Should().BeOfType<BadRequestResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status400BadRequest);
        }
    }
}
