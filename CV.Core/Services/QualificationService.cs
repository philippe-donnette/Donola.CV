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
    public class QualificationService : IQualificationService
    {
        private readonly IMapper _mapper;
        private readonly IQualificationRepository _qualificationRepository;
        private readonly ILogger<IQualificationService> _logger; 

        public QualificationService(IMapper mapper,
            IQualificationRepository qualificationRepository,
            ILogger<IQualificationService> logger)
        {
            _mapper = mapper;
            _qualificationRepository = qualificationRepository;
            _logger = logger;
        }
        
        public async Task<IEnumerable<QualificationModel>> GetQualificationsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_QUALIFICATIONS, "Listing all qualifications");
            try
            {
                var qualifications = await _qualificationRepository.GetQualificationsAsync();
                return _mapper.Map<IEnumerable<QualificationModel>>(qualifications);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_QUALIFICATIONS, ex.StackTrace);
                return null;
            }
        }
    }
}
