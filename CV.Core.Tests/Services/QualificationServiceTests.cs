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
    public class QualificationServiceTests
    {
        private readonly Mock<IQualificationRepository> _qualificationRepositoryMock;
        private readonly IQualificationService _service;
        private readonly Mock<ILogger<IQualificationService>> _loggerMock;

        public QualificationServiceTests()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new CvMapperProfile());
            });
            _qualificationRepositoryMock = new Mock<IQualificationRepository>();
            _loggerMock = new Mock<ILogger<IQualificationService>>();
            _service = new QualificationService(mapperConfig.CreateMapper(), _qualificationRepositoryMock.Object, _loggerMock.Object);
        }
        
        #region GetQualificationsAsync
        [Fact]
        public void GetQualificationsAsync_ReturnListOfQualificationModel()
        {
            _qualificationRepositoryMock.Setup(m => m.GetQualificationsAsync())
                .ReturnsAsync(new List<Qualification>
                {
                    new Qualification { Id = 1, SchoolName = "Company Number 1", Description = null, ImageUrl = null, StartDate = DateTime.Now },
                    new Qualification { Id = 2, SchoolName = "Company Number 2", Description = null, ImageUrl = null, StartDate = DateTime.Now },
                    new Qualification { Id = 3, SchoolName = "Company Number 3", Description = null, ImageUrl = null, StartDate = DateTime.Now }
                });
            var result = _service.GetQualificationsAsync();
            var qualifications = result.Result as IEnumerable<QualificationModel>;
            qualifications.Should().BeOfType<List<QualificationModel>>();
            Assert.Equal(qualifications.Count(), 3);
        }

        [Fact]
        public void GetQualificationsAsync_ReturnNull()
        {
            _qualificationRepositoryMock.Setup(m => m.GetQualificationsAsync())
                .ReturnsAsync(null);
            var result = _service.GetQualificationsAsync();
            var qualifications = result.Result as IEnumerable<QualificationModel>;
            Assert.Equal(qualifications, null);
        }

        [Fact]
        public void GetQualificationsAsync_ReturnNullWhenExeptionThrown()
        {
            _qualificationRepositoryMock.Setup(m => m.GetQualificationsAsync())
                .ThrowsAsync(new Exception());
            var result = _service.GetQualificationsAsync();
            var qualifications = result.Result as IEnumerable<QualificationModel>;
            Assert.Equal(qualifications, null);
        }
        #endregion
    }
}
