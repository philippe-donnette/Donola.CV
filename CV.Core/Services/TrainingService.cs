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
    public class TrainingService : ITrainingService
    {
        private readonly IMapper _mapper;
        private readonly ITrainingRepository _trainingRepository;
        private readonly ILogger<ITrainingService> _logger; 

        public TrainingService(IMapper mapper,
            ITrainingRepository trainingRepository,
            ILogger<ITrainingService> logger)
        {
            _mapper = mapper;
            _trainingRepository = trainingRepository;
            _logger = logger;
        }
        
        public async Task<IEnumerable<TrainingModel>> GetTrainingsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_TRAININGS, "Listing all trainings");
            try
            {
                var trainings = await _trainingRepository.GetTrainingsAsync();
                return _mapper.Map<IEnumerable<TrainingModel>>(trainings);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_TRAININGS, ex.StackTrace);
                return null;
            }
        }
    }
}
