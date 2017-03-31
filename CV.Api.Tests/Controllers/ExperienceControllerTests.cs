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
    public class ExperienceControllerTests
    {

        private readonly ExperienceController _controller;
        private readonly Mock<IExperienceService> _experienceServiceMock;
        private readonly Mock<ILogger<ExperienceController>> _loggerMock;

        public ExperienceControllerTests()
        {
            _experienceServiceMock = new Mock<IExperienceService>();
            _loggerMock = new Mock<ILogger<ExperienceController>>();
            _controller = new ExperienceController(_experienceServiceMock.Object, _loggerMock.Object);
        }
        
        #region GetExperienceAsync
        [Fact]
        public void GetExperienceAsync_ReturnNotFoundStatusCode()
        {
            int experienceId = 1;
            _experienceServiceMock.Setup(x => x.GetExperienceAsync(experienceId))
                .ReturnsAsync((ExperienceModel)null);
            var result = _controller.GetExperienceAsync(experienceId);
            var httpResult = result.Result as NotFoundResult;
            httpResult.Should().BeOfType<NotFoundResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public void GetExperienceAsync_ReturnOkStatusCode()
        {
            int experienceId = 1;
            var experience = new ExperienceModel { Id = 1, ImageUrl = null, Description = null, CompanyName = "Some company" };
            _experienceServiceMock.Setup(x => x.GetExperienceAsync(experienceId))
                .ReturnsAsync(experience);
            var result = _controller.GetExperienceAsync(experienceId);
            var httpResult = result.Result as OkObjectResult;
            httpResult.Should().BeOfType<OkObjectResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status200OK);
            var model = httpResult.Value as ExperienceModel;
            model.Should().BeOfType<ExperienceModel>();
            Assert.Equal(model.Description, experience.Description);
            Assert.Equal(model.Id, experience.Id);
            Assert.Equal(model.CompanyName, experience.CompanyName);
            Assert.Equal(model.ImageUrl, experience.ImageUrl);
        }

        [Fact]
        public void GetExperienceAsync_ReturnBadRequestStatusCode()
        {
            int experienceId = 1;
            _experienceServiceMock.Setup(x => x.GetExperienceAsync(experienceId))
                .ThrowsAsync(new Exception());
            var result = _controller.GetExperienceAsync(experienceId);
            var httpResult = result.Result as BadRequestResult;
            httpResult.Should().BeOfType<BadRequestResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status400BadRequest);
        }
        #endregion

        #region GetExperiencesAsync
        [Fact]
        public void GetExperiencesAsync_ReturnNotFoundStatusCode()
        {
            _experienceServiceMock.Setup(m => m.GetExperiencesAsync())
                .ReturnsAsync((IEnumerable<ExperienceModel>)null);
            var result = _controller.GetExperiencesAsync();
            var NotFoundResult = result.Result as NotFoundResult;
            NotFoundResult.Should().BeOfType<NotFoundResult>();
            Assert.Equal(NotFoundResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public void GetExperiencesAsync_ReturnOkStatusCode()
        {
            _experienceServiceMock.Setup(m => m.GetExperiencesAsync())
                .ReturnsAsync(new List<ExperienceModel>
                {
                    new ExperienceModel { Id = 1, ImageUrl = null, Description = null, CompanyName = "Some Company 1" },
                    new ExperienceModel { Id = 1, ImageUrl = null, Description = null, CompanyName = "Some Company 2" }
                });
            var result = _controller.GetExperiencesAsync();
            var httpOkResult = result.Result as OkObjectResult;
            httpOkResult.Should().BeOfType<OkObjectResult>();
            Assert.Equal(httpOkResult.StatusCode, StatusCodes.Status200OK);
            var experiences = httpOkResult.Value as List<ExperienceModel>;
            experiences.Should().BeOfType<List<ExperienceModel>>();
            Assert.Equal(experiences.Count, 2);
        }

        [Fact]
        public void GetExperiencesAsync_ReturnBadRequestStatusCode()
        {
            _experienceServiceMock.Setup(m => m.GetExperiencesAsync())
                .ThrowsAsync(new Exception());
            var result = _controller.GetExperiencesAsync();
            var httpResult = result.Result as BadRequestResult;
            httpResult.Should().BeOfType<BadRequestResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status400BadRequest);
        }
        #endregion

        #region GetSkillsAsync
        [Fact]
        public void GetSkillsAsync_ReturnNotFoundStatusCode()
        {
            int experienceId = 1;
            _experienceServiceMock.Setup(m => m.GetSkillsAsync(experienceId))
                .ReturnsAsync((IEnumerable<SkillModel>)null);
            var result = _controller.GetSkillsAsync(experienceId);
            var NotFoundResult = result.Result as NotFoundResult;
            NotFoundResult.Should().BeOfType<NotFoundResult>();
            Assert.Equal(NotFoundResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public void GetSkillsAsync_ReturnOkStatusCode()
        {
            int experienceId = 1;
            var skills = new List<SkillModel>
            {
                new SkillModel { ExperienceRating = 10, Id = 1, InterestRating = 9, Name = "ASP.NET 5", UsageRating = 8, Weight = 9 },
                new SkillModel { ExperienceRating = 4, Id = 2, InterestRating = 5, Name = "AngularJS", UsageRating = 6, Weight = 5 },
                new SkillModel { ExperienceRating = 3, Id = 3, InterestRating = 2, Name = "Angular2", UsageRating = 1, Weight = 2 }
            };
            _experienceServiceMock.Setup(m => m.GetSkillsAsync(experienceId))
                .ReturnsAsync(skills);
            var result = _controller.GetSkillsAsync(experienceId);
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
            int experienceId = 1;
            _experienceServiceMock.Setup(m => m.GetSkillsAsync(experienceId))
                .ThrowsAsync(new Exception());
            var result = _controller.GetSkillsAsync(experienceId);
            var httpResult = result.Result as BadRequestResult;
            httpResult.Should().BeOfType<BadRequestResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status400BadRequest);
        }
        #endregion
    }
}
