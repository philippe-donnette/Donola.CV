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
    }
}
