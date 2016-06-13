using CV.DataAccessLayer.Contexts;
using CV.DataAccessLayer.Entities;
using CV.DataAccessLayer.Settings;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly CvDbContext _context;
        private readonly ILogger<IPersonRepository> _logger;


        public PersonRepository(CvDbContext context, 
            ILogger<IPersonRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Person> GetPersonAsync()
        {
            _logger.LogInformation((int)LoggingEvents.GET_PERSON, "Get person");
            try
            {
                return await _context.Persons.SingleOrDefaultAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.GET_PERSON, ex.StackTrace);
                return null;
            }
        }

        public async Task<IEnumerable<Card>> GetCardsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_CARDS, "Listing all cards");
            try
            {
                return await _context.Cards.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_CARDS, ex.StackTrace);
                return null;
            }
        }
    }
}
