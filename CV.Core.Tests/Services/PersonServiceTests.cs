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
                .ReturnsAsync((Person)null);
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

        #region GetCardsAsync
        [Fact]
        public void GetCardsAsync_ReturnListOfCardModel()
        {
            _personRepositoryMock.Setup(m => m.GetCardsAsync())
                .ReturnsAsync(new List<Card>
                {
                    new Card { Rotate = "x", ImageFrontUrl = "card-contact.jpg", TextFront = null, Caption = "Family", CaptionIconClass = "fa fa-group", TextBack = "Happy father of two, one boy Matti and one girl Leila", ImageBackUrl = null },
                    new Card { Rotate = "y", ImageFrontUrl = "card-contact.jpg", TextFront = null, Caption = "Location", CaptionIconClass = "fa fa-map-marker", TextBack = "London SE8<br />United Kingdom", ImageBackUrl = null },
                    new Card { Rotate = "x", ImageFrontUrl = "card-contact.jpg", TextFront = null, Caption = "Contact", CaptionIconClass = "fa fa-envelope", TextBack = "LINKEDIN<br />GMAIL<br />(Phone)", ImageBackUrl = null },
                    new Card { Rotate = "x", ImageFrontUrl = "card-contact.jpg", TextFront = null, Caption = "Football", CaptionIconClass = "fa fa-soccer-ball-o", TextBack = "I love playing football and I organise games in Deptford Park most Saturdays", ImageBackUrl = null }
                });
            var result = _service.GetCardsAsync();
            var cards = result.Result as IEnumerable<CardModel>;
            cards.Should().BeOfType<List<CardModel>>();
            Assert.Equal(cards.Count(), 4);
        }

        [Fact]
        public void GetCardsAsync_ReturnNull()
        {
            _personRepositoryMock.Setup(m => m.GetCardsAsync())
                .ReturnsAsync((IEnumerable<Card>)null);
            var result = _service.GetCardsAsync();
            var cards = result.Result as IEnumerable<CardModel>;
            Assert.Equal(cards, null);
        }

        [Fact]
        public void GetCardsAsync_ReturnNullWhenExeptionThrown()
        {
            _personRepositoryMock.Setup(m => m.GetCardsAsync())
                .ThrowsAsync(new Exception());
            var result = _service.GetCardsAsync();
            var cards = result.Result as IEnumerable<CardModel>;
            Assert.Equal(cards, null);
        }
        #endregion
    }
}
