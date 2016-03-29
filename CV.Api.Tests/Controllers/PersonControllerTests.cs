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
    public class PersonControllerTests
    {

        private readonly PersonController _controller;
        private readonly Mock<IPersonService> _personServiceMock;
        private readonly Mock<ILogger<PersonController>> _loggerMock;

        public PersonControllerTests()
        {
            _personServiceMock = new Mock<IPersonService>();
            _loggerMock = new Mock<ILogger<PersonController>>();
            _controller = new PersonController(_personServiceMock.Object, _loggerMock.Object);
        }

        #region GetPersonAsync
        [Fact]
        public void GetPersonAsync_ReturnNotFoundStatusCode()
        {
            _personServiceMock.Setup(x => x.GetPersonAsync())
                .ReturnsAsync(null);
            var result = _controller.GetPersonAsync();
            var httpResult = result.Result as HttpNotFoundResult;
            httpResult.Should().BeOfType<HttpNotFoundResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public void GetPersonAsync_ReturnOkStatusCode()
        {
            var person = new PersonModel
            {
                Id = 1,
                Lastname = "Donnette",
                Firstname = "Philippe"
            };
            _personServiceMock.Setup(x => x.GetPersonAsync())
                .ReturnsAsync(person);
            var result = _controller.GetPersonAsync();
            var httpResult = result.Result as HttpOkObjectResult;
            httpResult.Should().BeOfType<HttpOkObjectResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status200OK);
            var model = httpResult.Value as PersonModel;
            model.Should().BeOfType<PersonModel>();
            Assert.Equal(model.Id, person.Id);
            Assert.Equal(model.Firstname, person.Firstname);
            Assert.Equal(model.Lastname, person.Lastname);
        }

        [Fact]
        public void GetPersonAsync_ReturnBadRequestStatusCode()
        {
            _personServiceMock.Setup(x => x.GetPersonAsync())
                .ThrowsAsync(new Exception());
            var result = _controller.GetPersonAsync();
            var httpResult = result.Result as BadRequestResult;
            httpResult.Should().BeOfType<BadRequestResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status400BadRequest);
        }
        #endregion

        #region GetProjectsAsync
        [Fact]
        public void GetProjectsAsync_ReturnNotFoundStatusCode()
        {
            _personServiceMock.Setup(m => m.GetCardsAsync())
                .ReturnsAsync(null);
            var result = _controller.GetCardsAsync();
            var httpNotFoundResult = result.Result as HttpNotFoundResult;
            httpNotFoundResult.Should().BeOfType<HttpNotFoundResult>();
            Assert.Equal(httpNotFoundResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public void GetCardsAsync_ReturnOkStatusCode()
        {
            _personServiceMock.Setup(m => m.GetCardsAsync())
                .ReturnsAsync(new List<CardModel>
                {
                    new CardModel { Id = 1, ImageBackUrl = null, TextBack = null, Caption = "Family" },
                    new CardModel { Id = 1, ImageBackUrl = null, TextBack = null, Caption = "Location" }
                });
            var result = _controller.GetCardsAsync();
            var httpOkResult = result.Result as HttpOkObjectResult;
            httpOkResult.Should().BeOfType<HttpOkObjectResult>();
            Assert.Equal(httpOkResult.StatusCode, StatusCodes.Status200OK);
            var cards = httpOkResult.Value as List<CardModel>;
            cards.Should().BeOfType<List<CardModel>>();
            Assert.Equal(cards.Count, 2);
        }

        [Fact]
        public void GetCardsAsync_ReturnBadRequestStatusCode()
        {
            _personServiceMock.Setup(m => m.GetCardsAsync())
                .ThrowsAsync(new Exception());
            var result = _controller.GetCardsAsync();
            var httpResult = result.Result as BadRequestResult;
            httpResult.Should().BeOfType<BadRequestResult>();
            Assert.Equal(httpResult.StatusCode, StatusCodes.Status400BadRequest);
        }
        #endregion
    }
}
