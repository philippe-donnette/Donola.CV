using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using CV.Core.Services;
using CV.Core.Models;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using CV.Api.Settings;

namespace CV.Api.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        private readonly ILogger<PersonController> _logger;

        public PersonController(IPersonService personService,
            ILogger<PersonController> logger)
        {
            _personService = personService;
            _logger = logger;
        }
        
        // GET: api/person
        [HttpGet]
        //[Route("")]
        public async Task<IActionResult> GetPersonAsync()
        {
            _logger.LogInformation((int)LoggingEvents.GET_PERSON, "Get person");
            try
            {
                var person = await _personService.GetPersonAsync();
                if (person != null)
                    return Ok(person);
                else
                    return HttpNotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.GET_PERSON, ex.StackTrace);
                return HttpBadRequest();
            }
        }

        // GET: api/person/card/all
        [HttpGet]
        [Route("card/all")]
        public async Task<IActionResult> GetCardsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_CARDS, "Listing all cards");
            try
            {
                var cards = await _personService.GetCardsAsync();
                if (cards != null)
                    return Ok(cards);
                else
                    return HttpNotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_CARDS, ex.StackTrace);
                return HttpBadRequest();
            }
        }
    }
}
