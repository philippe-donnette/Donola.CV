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
                .ReturnsAsync(null);
            var result = _controller.GetTrainingsAsync();
            var httpNotFoundResult = result.Result as HttpNotFoundResult;
            httpNotFoundResult.Should().BeOfType<HttpNotFoundResult>();
            Assert.Equal(httpNotFoundResult.StatusCode, StatusCodes.Status404NotFound);
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
            var httpOkResult = result.Result as HttpOkObjectResult;
            httpOkResult.Should().BeOfType<HttpOkObjectResult>();
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
