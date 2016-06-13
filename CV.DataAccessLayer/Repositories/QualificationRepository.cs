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
    public class QualificationRepository : IQualificationRepository
    {
        private readonly CvDbContext _context;
        private readonly ILogger<IQualificationRepository> _logger;


        public QualificationRepository(CvDbContext context, 
            ILogger<IQualificationRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        
        public async Task<IEnumerable<Qualification>> GetQualificationsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_QUALIFICATIONS, "Listing all qualifications");
            try
            {
                return await _context
                    .Qualifications.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_QUALIFICATIONS, ex.StackTrace);
                return null;
            }
        }
    }
}
