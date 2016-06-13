using System;
using System.Threading.Tasks;
using CV.Core.Services;
using Microsoft.Extensions.Logging;
using CV.Api.Settings;
using Microsoft.AspNetCore.Mvc;

namespace CV.Api.Controllers
{
    [Route("api/[controller]")]
    public class TrainingController : Controller
    {
        private readonly ITrainingService _trainingService;
        private readonly ILogger<TrainingController> _logger;

        public TrainingController(ITrainingService trainingService,
            ILogger<TrainingController> logger)
        {
            _trainingService = trainingService;
            _logger = logger;
        }
        
        // GET: api/training/all
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetTrainingsAsync()
        {
            _logger.LogInformation((int)LoggingEvents.LIST_TRAININGS, "Listing all trainings");
            try
            {
                var trainings = await _trainingService.GetTrainingsAsync();
                if (trainings != null)
                    return Ok(trainings);
                else
                    return NotFound();
            }
            catch(Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_TRAININGS, ex.StackTrace);
                return BadRequest();
            }
        }
    }
}
