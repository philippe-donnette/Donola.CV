using AutoMapper;
using CV.Core.Mappings;
using CV.Core.Models;
using CV.Core.Services;
using CV.DataAccessLayer.Entities;
using CV.DataAccessLayer.Repositories;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CV.Core.Tests.Services
{
    public class SkillServiceTests
    {
        private readonly Mock<ISkillRepository> _skillRepositoryMock;
        private readonly ISkillService _service;
        private readonly Mock<ILogger<ISkillService>> _loggerMock;

        public SkillServiceTests()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new CvMapperProfile());
            });
            _skillRepositoryMock = new Mock<ISkillRepository>();
            _loggerMock = new Mock<ILogger<ISkillService>>();
            _service = new SkillService(mapperConfig.CreateMapper(), _skillRepositoryMock.Object, _loggerMock.Object);
        }

        [Fact]
        public void GetSkillsAsync_ReturnListOfSkillModel()
        {
            _skillRepositoryMock.Setup(m => m.GetSkillsAsync())
                .ReturnsAsync(new List<Skill>
                {
                    new Skill
                    {
                        Id = 1, ExperienceRating = 10, InterestRating = 9, Name = "ASP.NET 5", UsageRating = 8,
                        Description = "A description about asp.net 5", IconClass = "fa fa-something", IsVisible = true,
                        Versions = new List<SkillVersion>
                        {
                            new SkillVersion { Id = 1, Name = "RC1", SkillId = 1 },
                            new SkillVersion { Id = 2, Name = "RC2", SkillId = 1 }
                        }
                    },
                    new Skill {
                        Id = 2, ExperienceRating = 5, InterestRating = 6, Name = "AngularJS", UsageRating = 7,
                        Description = "A description about AngularJS", IconClass = "fa fa-something", IsVisible = true,
                        Versions = new List<SkillVersion> { }
                    }
                });
            var result = _service.GetSkillsAsync();
            var skills = result.Result as List<SkillModel>;
            skills.Should().BeOfType<List<SkillModel>>();
            Assert.Equal(skills.Count, 2);
            Assert.Equal(skills.FirstOrDefault(x => x.Id == 1).Versions.Count, 2);
            Assert.Equal(skills.FirstOrDefault(x => x.Id == 2).Versions.Count, 0);
        }

        [Fact]
        public void GetSkillsAsync_ReturnNull()
        {
            _skillRepositoryMock.Setup(m => m.GetSkillsAsync())
                .ReturnsAsync(null);
            var result = _service.GetSkillsAsync();
            var skills = result.Result as List<SkillModel>;
            Assert.Equal(skills, null);
        }

        [Fact]
        public void GetSkillsAsync_ReturnNullWhenException()
        {
            _skillRepositoryMock.Setup(m => m.GetSkillsAsync())
                .ThrowsAsync(new System.Exception());
            var result = _service.GetSkillsAsync();
            var skills = result.Result as List<SkillModel>;
            Assert.Equal(skills, null);
        }
    }
}
