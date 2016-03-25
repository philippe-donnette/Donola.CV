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
    public class TrainingServiceTests
    {
        private readonly Mock<ITrainingRepository> _trainingRepositoryMock;
        private readonly ITrainingService _service;
        private readonly Mock<ILogger<ITrainingService>> _loggerMock;

        public TrainingServiceTests()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new CvMapperProfile());
            });
            _trainingRepositoryMock = new Mock<ITrainingRepository>();
            _loggerMock = new Mock<ILogger<ITrainingService>>();
            _service = new TrainingService(mapperConfig.CreateMapper(), _trainingRepositoryMock.Object, _loggerMock.Object);
        }
        
        #region GetTrainingsAsync
        [Fact]
        public void GetTrainingsAsync_ReturnListOfTrainingModel()
        {
            _trainingRepositoryMock.Setup(m => m.GetTrainingsAsync())
                .ReturnsAsync(new List<Training>
                {
                    new Training { Id = 1, Provider = "Provider Number 1", Description = null, ImageUrl = null },
                    new Training { Id = 2, Provider = "Provider Number 2", Description = null, ImageUrl = null },
                    new Training { Id = 3, Provider = "Provider Number 3", Description = null, ImageUrl = null }
                });
            var result = _service.GetTrainingsAsync();
            var trainings = result.Result as IEnumerable<TrainingModel>;
            trainings.Should().BeOfType<List<TrainingModel>>();
            Assert.Equal(trainings.Count(), 3);
        }

        [Fact]
        public void GetTrainingsAsync_ReturnNull()
        {
            _trainingRepositoryMock.Setup(m => m.GetTrainingsAsync())
                .ReturnsAsync(null);
            var result = _service.GetTrainingsAsync();
            var trainings = result.Result as IEnumerable<TrainingModel>;
            Assert.Equal(trainings, null);
        }

        [Fact]
        public void GetTrainingsAsync_ReturnNullWhenExeptionThrown()
        {
            _trainingRepositoryMock.Setup(m => m.GetTrainingsAsync())
                .ThrowsAsync(new Exception());
            var result = _service.GetTrainingsAsync();
            var trainings = result.Result as IEnumerable<TrainingModel>;
            Assert.Equal(trainings, null);
        }
        #endregion
    }
}
