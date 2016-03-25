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
                    return HttpNotFound();
            }
            catch(Exception ex)
            {
                _logger.LogError((int)LoggingEvents.LIST_TRAININGS, ex.StackTrace);
                return HttpBadRequest();
            }
        }
    }
}
