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
    public class QualificationControllerTests
    {

        private readonly QualificationController _controller;
        private readonly Mock<IQualificationService> _qualificationServiceMock;
        private readonly Mock<ILogger<QualificationController>> _loggerMock;

        public QualificationControllerTests()
        {
            _qualificationServiceMock = new Mock<IQualificationService>();
            _loggerMock = new Mock<ILogger<QualificationController>>();
            _controller = new QualificationController(_qualificationServiceMock.Object, _loggerMock.Object);
        }
        
        #region GetQualificationsAsync
        [Fact]
        public void GetQualificationsAsync_ReturnNotFoundStatusCode()
        {
            _qualificationServiceMock.Setup(m => m.GetQualificationsAsync())
                .ReturnsAsync(null);
            var result = _controller.GetQualificationsAsync();
            var httpNotFoundResult = result.Result as HttpNotFoundResult;
            httpNotFoundResult.Should().BeOfType<HttpNotFoundResult>();
            Assert.Equal(httpNotFoundResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public void GetQualificationsAsync_ReturnOkStatusCode()
        {
            _qualificationServiceMock.Setup(m => m.GetQualificationsAsync())
                .ReturnsAsync(new List<QualificationModel>
                {
                    new QualificationModel { Id = 1, ImageUrl = null, Description = null, SchoolName = "Some School 1" },
                    new QualificationModel { Id = 1, ImageUrl = null, Description = null, SchoolName = "Some School 2" }
                });
            var result = _controller.GetQualificationsAsync();
            var httpOkResult = result.Result as HttpOkObjectResult;
            httpOkResult.Should().BeOfType<HttpOkObjectResult>();
            Assert.Equal(httpOkResult.StatusCode, StatusCodes.Status200OK);
            var qualifications = httpOkResult.Value as List<QualificationModel>;
            qualifications.Should().BeOfType<List<QualificationModel>>();
            Assert.Equal(qualifications.Count, 2);
        }

        [Fact]
        public void GetQualificationsAsync_ReturnBadRequestStatusCode()
        {
            _qualificationServiceMock.Setup(m => m.GetQualificationsAsync())
                .ThrowsAsync(new Exception());
            var result = _controller.GetQualificationsAsync();
            var httpResult = result.Result as BadRequestResult;
            httpResult.Should().BeOfType<BadRequestResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status400BadRequest);
        }
        #endregion
    }
}
