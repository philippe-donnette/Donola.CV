using AutoMapper;
using CV.Core.Models;
using CV.Core.Settings;
using CV.DataAccessLayer.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Services
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        private readonly ILogger<IPersonService> _logger; 

        public PersonService(IMapper mapper, 
            IPersonRepository personRepository,
            ILogger<IPersonService> logger)
        {
            _mapper = mapper;
            _personRepository = personRepository;
            _logger = logger;
        }

        public async Task<PersonModel> GetPersonAsync()
        {
            _logger.LogInformation((int)LoggingEvents.GET_PERSON, "Get person");
            try
            {
                var person = await _personRepository.GetPersonAsync();
                return _mapper.Map<PersonModel>(person);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.GET_PERSON, ex.StackTrace);
                return null;
            }
        }

        public async Task<IEnumerable<CardModel>> GetCardsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_CARDS, "Listing all cards");
            try
            {
                var cards = await _personRepository.GetCardsAsync();
                return _mapper.Map<IEnumerable<CardModel>>(cards);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_CARDS, ex.StackTrace);
                return null;
            }
        }
    }
}
