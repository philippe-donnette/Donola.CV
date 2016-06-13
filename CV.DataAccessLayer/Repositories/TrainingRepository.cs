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
    public class TrainingRepository : ITrainingRepository
    {
        private readonly CvDbContext _context;
        private readonly ILogger<ITrainingRepository> _logger;


        public TrainingRepository(CvDbContext context, 
            ILogger<ITrainingRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        
        public async Task<IEnumerable<Training>> GetTrainingsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_TRAININGS, "Listing all trainings");
            try
            {
                return await _context
                    .Trainings.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_TRAININGS, ex.StackTrace);
                return null;
            }
        }
    }
}
