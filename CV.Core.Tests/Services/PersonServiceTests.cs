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
    public class PersonServiceTests
    {
        private readonly Mock<IPersonRepository> _personRepositoryMock;
        private readonly IPersonService _service;
        private readonly Mock<ILogger<IPersonService>> _loggerMock;

        public PersonServiceTests()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new CvMapperProfile());
            });
            _personRepositoryMock = new Mock<IPersonRepository>();
            _loggerMock = new Mock<ILogger<IPersonService>>();
            _service = new PersonService(mapperConfig.CreateMapper(), _personRepositoryMock.Object, _loggerMock.Object);
        }

        #region GetPersonAsync
        [Fact]
        public void GetPersonAsync_ReturnPersonModel()
        {
            var person = new Person
            {
                Id = 1,
                Lastname = "Donnette",
                Firstname = "Philippe"
            };
            _personRepositoryMock.Setup(x => x.GetPersonAsync())
                .ReturnsAsync(person);
            var result = _service.GetPersonAsync();
            var model = result.Result as PersonModel;
            model.Should().BeOfType<PersonModel>();
        }

        [Fact]
        public void GetPersonAsync_ReturnNull()
        {
            _personRepositoryMock.Setup(x => x.GetPersonAsync())
                .ReturnsAsync(null);
            var result = _service.GetPersonAsync();
            var model = result.Result as PersonModel;
            Assert.Equal(model, null);
        }

        [Fact]
        public void GetPersonAsync_ReturnNullWhenExceptionThrown()
        {
            _personRepositoryMock.Setup(x => x.GetPersonAsync())
                .ThrowsAsync(new Exception());
            var result = _service.GetPersonAsync();
            var model = result.Result as PersonModel;
            Assert.Equal(model, null);
        }

        [Fact]
        public void GetPersonAsync_AssertPersonModel()
        {
            var person = new Person
            {
                Id = 1,
                Lastname = "Donnette",
                Firstname = "Philippe"
            };
            _personRepositoryMock.Setup(x => x.GetPersonAsync())
                .ReturnsAsync(person);
            var result = _service.GetPersonAsync();
            var model = result.Result as PersonModel;
            Assert.Equal(model.Id, person.Id);
            Assert.Equal(model.Lastname, person.Lastname);
            Assert.Equal(model.Firstname, person.Firstname);
        }
        #endregion
    }
}
