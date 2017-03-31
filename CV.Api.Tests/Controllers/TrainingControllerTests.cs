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
    public class TrainingControllerTests
    {

        private readonly TrainingController _controller;
        private readonly Mock<ITrainingService> _trainingServiceMock;
        private readonly Mock<ILogger<TrainingController>> _loggerMock;

        public TrainingControllerTests()
        {
            _trainingServiceMock = new Mock<ITrainingService>();
            _loggerMock = new Mock<ILogger<TrainingController>>();
            _controller = new TrainingController(_trainingServiceMock.Object, _loggerMock.Object);
        }
        
        #region GetTrainingsAsync
        [Fact]
        public void GetTrainingsAsync_ReturnNotFoundStatusCode()
        {
            _trainingServiceMock.Setup(m => m.GetTrainingsAsync())
                .ReturnsAsync((IEnumerable<TrainingModel>)null);
            var result = _controller.GetTrainingsAsync();
            var NotFoundResult = result.Result as NotFoundResult;
            NotFoundResult.Should().BeOfType<NotFoundResult>();
            Assert.Equal(NotFoundResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public void GetTrainingsAsync_ReturnOkStatusCode()
        {
            _trainingServiceMock.Setup(m => m.GetTrainingsAsync())
                .ReturnsAsync(new List<TrainingModel>
                {
                    new TrainingModel { Id = 1, ImageUrl = null, Description = null, Provider = "Some Provider 1" },
                    new TrainingModel { Id = 1, ImageUrl = null, Description = null, Provider = "Some Provider 2" }
                });
            var result = _controller.GetTrainingsAsync();
            var httpOkResult = result.Result as OkObjectResult;
            httpOkResult.Should().BeOfType<OkObjectResult>();
            Assert.Equal(httpOkResult.StatusCode, StatusCodes.Status200OK);
            var trainings = httpOkResult.Value as List<TrainingModel>;
            trainings.Should().BeOfType<List<TrainingModel>>();
            Assert.Equal(trainings.Count, 2);
        }

        [Fact]
        public void GetTrainingsAsync_ReturnBadRequestStatusCode()
        {
            _trainingServiceMock.Setup(m => m.GetTrainingsAsync())
                .ThrowsAsync(new Exception());
            var result = _controller.GetTrainingsAsync();
            var httpResult = result.Result as BadRequestResult;
            httpResult.Should().BeOfType<BadRequestResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status400BadRequest);
        }
        #endregion
    }
}
